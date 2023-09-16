using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.Backend.DataAccess.Entities;

namespace VotingApp.Backend.DataAccess.Configurations;

public class VoterConfiguration:BaseEntityConfiguration, IEntityTypeConfiguration<Voter>
{
    public void Configure(EntityTypeBuilder<Voter> builder)
    {
        base.Configure(builder);
        builder.Navigation(x => x.Vote);
        builder.HasOne(x => x.Vote).WithOne(x=>x.Voter);
        
        
    }
}