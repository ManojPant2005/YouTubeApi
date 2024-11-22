using System.ComponentModel.DataAnnotations;

namespace YouTubeApi.Data.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }  
        public decimal PriceTotal { get; set; }
        public string Address { get; set; }
    }
}
