using Microsoft.EntityFrameworkCore;

namespace Password_Keep.Models
{
    public class PasswordDbContext : DbContext
    {
        public PasswordDbContext(DbContextOptions<PasswordDbContext> options) : base(options)
        {

        }

        public DbSet<PasswordModel> Passwords { get; set; }
    }
}
