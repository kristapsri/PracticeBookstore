using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options)
        {
        }

        public DbSet<Author> Author { get; set; } = null!;
    }
}
