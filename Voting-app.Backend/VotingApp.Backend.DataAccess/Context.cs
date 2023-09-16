using Microsoft.EntityFrameworkCore;
using VotingApp.Backend.DataAccess.Entities;

namespace VotingApp.Backend.DataAccess;

public class Context:DbContext
{
    public DbSet<Voter> Voters { get; set; }
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Vote> Votes { get; set; }

    public Context(DbContextOptions<Context> options):base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
    }
}