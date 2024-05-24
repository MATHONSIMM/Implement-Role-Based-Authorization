using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Implement_Role_Based_Authorization.Models;

namespace Implement_Role_Based_Authorization.Data;

public class Implement_Role_Based_AuthorizationContext : IdentityDbContext<IdentityUser>
{
    public Implement_Role_Based_AuthorizationContext(DbContextOptions<Implement_Role_Based_AuthorizationContext> options)
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

    public DbSet<Implement_Role_Based_Authorization.Models.PerformanceCellsUpdated> PerformanceCellsUpdated { get; set; } = default!;
}
