using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poe_progs_3.Areas.Identity.Data;

namespace poe_progs_3.Data;

public class poe_progs_3Context : IdentityDbContext<poe_progs_3User>
{
    public poe_progs_3Context(DbContextOptions<poe_progs_3Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<poe_progs_3User>
{
    public void Configure(EntityTypeBuilder<poe_progs_3User> builder)
    {
       
    }
}