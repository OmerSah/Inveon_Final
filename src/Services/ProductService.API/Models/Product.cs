using ProductService.API.Utilities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.API.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public ProductLabel Labels { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public ProductCategory Category { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string Hover_Img { get; set; }
        public Rating Rating { get; set; }
        public ICollection<ColorOption> Colors { get; set; }

    }
}