using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.Backend.DataAccess.Entities;

namespace VotingApp.Backend.DataAccess.Configurations;

public abstract class BaseEntityConfiguration
{
    protected void Configure<T>(EntityTypeBuilder<T> builder) where T : BaseEntity
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .IsRequired();
    }
}