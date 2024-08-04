using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SampleApp.Infrastructure.EFCore.Models;

public class User : IEntityTypeConfiguration<Models.User>
{
    public Guid Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public ushort YearOfBirth { get; init; }

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(b => b.Id);
    }
}
