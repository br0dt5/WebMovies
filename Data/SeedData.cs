using Microsoft.EntityFrameworkCore;
using WebMovies.Models;

namespace WebMovies.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            // Look for any movies.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }
            context.Movies.AddRange(
                new Movie
                {
                    Name = "Inception",
                    Synopsis = "Em um mundo onde é possível entrar na mente humana, um ladrão habilidoso é contratado para implantar uma ideia na mente de um CEO.",
                    Director = "Christopher Nolan",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page, Tom Hardy",
                    Keywords = "Sonhos, Realidade, Manipulação, Ação, Suspense"
                },
                new Movie
                {
                    Name = "O Poderoso Chefão",
                    Synopsis = "A saga de uma família mafiosa ítalo-americana de Nova York, liderada pelo patriarca Vito Corleone.",
                    Director = "Francis Ford Coppola",
                    ReleaseDate = DateTime.Parse("1972-3-15"),
                    Cast = "Marlon Brando, Al Pacino, James Caan, Robert Duvall",
                    Keywords = "Máfia, Família, Crime, Poder, Tragédia"
                },
                new Movie
                {
                    Name = "A Origem",
                    Synopsis = "Um grupo de exploradores corporativos usa tecnologia para entrar nos sonhos de outras pessoas e influenciar suas decisões.",
                    Director = "Christopher Nolan",
                    ReleaseDate = DateTime.Parse("2020-7-8"),
                    Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page, Tom Hardy",
                    Keywords = "Sonhos, Realidade, Manipulação, Ação, Suspense"
                },
                new Movie
                {
                    Name = "Forrest Gump",
                    Synopsis = "A história de um homem comum que viveu uma vida extraordinária, testemunhando e influenciando eventos importantes da história dos Estados Unidos.",
                    Director = "Robert Zemeckis",
                    ReleaseDate = DateTime.Parse("1994-7-6"),
                    Cast = "Tom Hanks, Robin Wright, Gary Sinise",
                    Keywords = "Vida, Amor, Superação, História, Destino"
                },
                new Movie
                {
                    Name = "Clube da Luta",
                    Synopsis = "Um homem desiludido encontra libertação na formação de um clube de luta underground, mas as coisas ficam fora de controle quando ele forma uma parceria perigosa com um colega rebelde.",
                    Director = "David Fincher",
                    ReleaseDate = DateTime.Parse("1999-10-15"),
                    Cast = "Brad Pitt, Edward Norton, Helena Bonham Carter",
                    Keywords = "Conformidade, Rebelião, Anarquia, Identidade, Luta"
                }
            );
            context.SaveChanges();
        }
    }
}