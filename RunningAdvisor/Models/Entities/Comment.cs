using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunningAdvisor.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }// = DateTime.Now;
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
