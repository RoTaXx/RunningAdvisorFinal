using Microsoft.AspNetCore.Identity;

namespace RunningAdvisor.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Comment> Comments { get; set; }
    }
}
