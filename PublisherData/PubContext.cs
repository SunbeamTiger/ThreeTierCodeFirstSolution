using Microsoft.EntityFrameworkCore;
using PublisherDomains;

namespace PublisherData
{
    public class PubContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }  
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=10.48.38.5;database=CodeFirstTest;UID=EFUser;PWD=Centralia;encrypt=false");
        }

    }
}
