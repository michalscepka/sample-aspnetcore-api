using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SampleApp.Infrastructure.Persistence.Models;

internal class User : IEntityTypeConfiguration<Models.User>
{
    public Guid Id { get; init; }
    public string FirstName { get; init; } = null!;
    public string LastName { get; init; } = null!;
    public ushort YearOfBirth { get; init; }

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(b => b.Id);
        
        builder.Property(b => b.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(b => b.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(b => b.YearOfBirth)
            .IsRequired();
    }
}
