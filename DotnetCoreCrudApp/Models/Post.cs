using System.ComponentModel.DataAnnotations;

namespace DotnetCoreCrudApp.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Body { get; set; }

    }
}
