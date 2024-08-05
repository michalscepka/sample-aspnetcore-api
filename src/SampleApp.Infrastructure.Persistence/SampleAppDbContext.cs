using Microsoft.EntityFrameworkCore;

namespace SampleApp.Infrastructure.Persistence;

internal class SampleAppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Models.User> Users { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleAppDbContext).Assembly);
    }
}
