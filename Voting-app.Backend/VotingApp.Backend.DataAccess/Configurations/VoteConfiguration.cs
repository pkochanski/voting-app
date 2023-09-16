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
        builder.Navigation(x => x.Voter);
        builder.HasOne(x => x.Candidate).WithMany(x=>x.Votes);
        builder.HasOne(x => x.Voter).WithOne(x => x.Vote);
    }
}