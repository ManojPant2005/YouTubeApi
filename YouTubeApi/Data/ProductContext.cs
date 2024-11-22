using Microsoft.EntityFrameworkCore;
using YouTubeApi.Data.Entities;

namespace YouTubeApi.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }        

    }
}
