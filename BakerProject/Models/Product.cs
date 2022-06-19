using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakerProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Raiting { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
