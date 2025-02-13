using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Abhishek_Sah_Dot_Net_Assignment.Data;

public class Abhishek_Sah_Dot_Net_AssignmentContext : IdentityDbContext<IdentityUser>
{
    public Abhishek_Sah_Dot_Net_AssignmentContext(DbContextOptions<Abhishek_Sah_Dot_Net_AssignmentContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
