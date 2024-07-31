using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunningAdvisor.Data;
using RunningAdvisor.Models.Entities;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RunningAdvisor.Controllers
{
    
    [Authorize]
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommentsController(ApplicationDbContext context)
        {
            _context = context;
        }
        /*public IActionResult SortComments(string sortOrder)
        {
            var comments = _context.Comments.Include(c => c.User).AsQueryable();

            switch (sortOrder)
            {
                case "oldest":
                    comments = comments.OrderBy(c => c.CreatedAt);
                    break;
                case "newest":
                default:
                    comments = comments.OrderByDescending(c => c.CreatedAt);
                    break;
            }

            return PartialView("_CommentsPartial", comments.ToList());
        }*/

        [HttpPost]
        public async Task<IActionResult> Create(string text)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var comment = new Comment
            {
                Text = text,
                CreatedAt = DateTime.UtcNow,
                UserId = userId
            };
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, string text)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == id && c.UserId == userId);
            if (comment != null)
            {
                comment.Text = text;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == id && c.UserId == userId);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
