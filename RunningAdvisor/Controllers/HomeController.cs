using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunningAdvisor.Data;
using RunningAdvisor.Models;
using RunningAdvisor.Services;
using System.Diagnostics;

namespace RunningAdvisor.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeatherService _weatherService;
        private readonly ApplicationDbContext _context;

        public HomeController(WeatherService weatherService, ApplicationDbContext context)
        {
            _weatherService = weatherService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var weather = await _weatherService.GetCurrentWeatherAsync("Sofia");
            ViewBag.Weather = weather;
            //return View();

            var comments = await _context.Comments
                .Include(c => c.User)
                .ToListAsync();
            return View(comments);
        }

        
    }
}
