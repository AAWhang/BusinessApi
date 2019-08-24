using Microsoft.EntityFrameworkCore;

namespace BusinessApi.Models
{
    public class BusinessApiContext : DbContext
    {

        public DbSet<Shop> Shops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=Business_Api;");

        public BusinessApiContext(DbContextOptions options) : base(options)
        {

        }
        public BusinessApiContext()
        {

        }

    }
}
