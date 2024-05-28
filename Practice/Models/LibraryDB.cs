using Microsoft.EntityFrameworkCore;
namespace Practice.Models
{
    public class LibraryDBContext: DbContext
    {
        public LibraryDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<LibraryData> Librarys { get; set; }
    }
}
