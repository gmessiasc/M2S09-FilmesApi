using FilmesApi.Models;

namespace FilmesApi
{
    public static class MockFilmes
    {
        public static IList<Filme> Filmes = new List<Filme>()
        {
                                  new Filme {
                                      Id = 1,
                                      Name= "Blade Runner",
                                      Director = "Jane Campion",
                                      Duration = 60,
                                      Genre =  "Suspense"},
                                   new Filme
                                   {
                                       Id = 2,
                                       Name = "Trainspotting - Sem Limites",
                                       Director = "Quentin Tarantino",
                                       Duration = 90,
                                       Genre = "Documentário"
                                   },
                                   new Filme
                                   {
                                       Id = 3,
                                       Name = "Gênio Indomável",
                                       Director = "Sofia Coppola",
                                       Duration = 90,
                                       Genre = "Romance"
                                   },
                                   new Filme
                                   {
                                       Id = 4,
                                       Name = "Titanic",
                                       Director = "Petra Costa",
                                       Duration = 120,
                                       Genre = "Romance"
                                   },
                                   new Filme
                                   {
                                       Id = 5,
                                       Name = "Aliens, O Resgate",
                                       Director = "Sofia Coppola",
                                       Duration = 120,
                                       Genre = "Desenho"
                                   },
                                   new Filme
                                   {
                                       Id = 6,
                                       Name = "Um Sonho de Liberdade",
                                       Director = "Kathryn Bigelow",
                                       Duration = 60,
                                       Genre = "Ficção"
                                   },
                                   new Filme
                                   {
                                       Id = 7,
                                       Name = "Blade Runner",
                                       Director = "Jean-Luc Godard",
                                       Duration = 120,
                                       Genre = "Policial"
                                   },
                                   new Filme
                                   {
                                       Id = 8,
                                       Name = "Noivo Neurótico, Noiva Nervosa",
                                       Director = "Alfred Hitchcock",
                                       Duration = 60,
                                       Genre = "Romance"
                                   },
                                   new Filme
                                   {
                                       Id = 9,
                                       Name = "Uma Vida sem Limites",
                                       Director = "Steven Spielberg",
                                       Duration = 90,
                                       Genre = "Aventura"
                                   },
                                   new Filme
                                   {
                                       Id = 10,
                                       Name = "Donnie Darko",
                                       Director = "Stanley Kubrick",
                                       Duration = 90,
                                       Genre = "Ficção"
                                   }

        };
    }
}