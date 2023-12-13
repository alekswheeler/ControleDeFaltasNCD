namespace ControleDeFaltasNCD.Database;

using ControleDeFaltasNCD.Domain;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

class AlunosDBContext : DbContext
{
    public DbSet<Aluno> Alunos { get; init; }

    public static AlunosDBContext Create(IMongoDatabase database) =>
        new(new DbContextOptionsBuilder<AlunosDBContext>()
            .UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName)
            .Options);

    public AlunosDBContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Aluno>().ToCollection("Alunos");
    }
}