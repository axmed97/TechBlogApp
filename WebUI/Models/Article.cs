using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string SeoUrl { get; set; }
    }
}
