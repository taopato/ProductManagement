using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
