using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FavoriteService.API.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        public string Img { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(1, 1000)]
        public decimal Price { get; set; }
    }
}
