using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakerProject.Models
{
    public class HomeProduct
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
