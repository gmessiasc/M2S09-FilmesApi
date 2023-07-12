using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Context;

public class FilmeDbContext : DbContext
{
    public FilmeDbContext(DbContextOptions<FilmeDbContext> options) : base(options)
    {
    }

    public DbSet<Filme> Filmes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var filmes = MockFilmes.Filmes;

        foreach(var filme in filmes) modelBuilder.Entity<Filme>().HasData(filme);
    }

}
