using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.Backend.DataAccess.Entities;

namespace VotingApp.Backend.DataAccess.Configurations;

public class CandidateConfiguration:BaseEntityConfiguration, IEntityTypeConfiguration<Candidate>
{
    public void Configure(EntityTypeBuilder<Candidate> builder)
    {
        base.Configure(builder);
        builder.HasMany(x => x.Votes);
    }
}