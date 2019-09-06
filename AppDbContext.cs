using Microsoft.EntityFrameworkCore;

namespace RazorPagesContacts.Data 
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Users> Users { get; set; }
    }
}