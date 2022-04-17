using System.ComponentModel.DataAnnotations;

namespace _00_WebApi.Models.Product
{
    public class ProductCreate
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }
    }
}
