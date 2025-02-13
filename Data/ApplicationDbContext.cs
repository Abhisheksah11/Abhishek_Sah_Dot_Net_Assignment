using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Abhishek_Sah_Dot_Net_Assignment.Models;

namespace Abhishek_Sah_Dot_Net_Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Abhishek_Sah_Dot_Net_Assignment.Models.Employee> Employee { get; set; } = default!;
        public DbSet<Abhishek_Sah_Dot_Net_Assignment.Models.RequestJob> RequestJob { get; set; } = default!;
    }
}
