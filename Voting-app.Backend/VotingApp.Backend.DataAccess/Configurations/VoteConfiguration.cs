using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.Backend.DataAccess.Entities;

namespace VotingApp.Backend.DataAccess.Configurations;

public class VoteConfiguration:BaseEntityConfiguration, IEntityTypeConfiguration<Vote>
{
    public void Configure(EntityTypeBuilder<Vote> builder)
    {
        base.Configure(builder);
        builder.Navigation(x => x.Candidate);
        builder.HasOne(x => x.Candidate).WithMany(x=>x.Votes);
    }
}