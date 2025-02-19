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
                    Name = "A Origem",
                    Synopsis = "Em um mundo onde é possível entrar na mente humana, um ladrão habilidoso é contratado para implantar uma ideia na mente de um CEO.",
                    Director = "Christopher Nolan",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page, Tom Hardy",
                    Genre = "Sonhos, Realidade, Manipulação, Ação, Suspense",
                    Poster = "https://image.tmdb.org/t/p/original/9e3Dz7aCANy5aRUQF745IlNloJ1.jpg"
                },
                new Movie
                {
                    Name = "O Poderoso Chefão",
                    Synopsis = "A saga de uma família mafiosa ítalo-americana de Nova York, liderada pelo patriarca Vito Corleone.",
                    Director = "Francis Ford Coppola",
                    ReleaseDate = DateTime.Parse("1972-3-15"),
                    Cast = "Marlon Brando, Al Pacino, James Caan, Robert Duvall",
                    Genre = "Máfia, Família, Crime, Poder, Tragédia",
                    Poster = "https://media.themoviedb.org/t/p/w220_and_h330_face/wOMxE93W6KcZTuCeNUByNTSaLLt.jpg"
                },
                new Movie
                {
                    Name = "Forrest Gump",
                    Synopsis = "A história de um homem comum que viveu uma vida extraordinária, testemunhando e influenciando eventos importantes da história dos Estados Unidos.",
                    Director = "Robert Zemeckis",
                    ReleaseDate = DateTime.Parse("1994-7-6"),
                    Cast = "Tom Hanks, Robin Wright, Gary Sinise",
                    Genre = "Vida, Amor, Superação, História, Destino",
                    Poster = "https://media.themoviedb.org/t/p/w220_and_h330_face/d74WpIsH8379TIL4wUxDneRCYv2.jpg"
                },
                new Movie
                {
                    Name = "Clube da Luta",
                    Synopsis = "Um homem desiludido encontra libertação na formação de um clube de luta underground, mas as coisas ficam fora de controle quando ele forma uma parceria perigosa com um colega rebelde.",
                    Director = "David Fincher",
                    ReleaseDate = DateTime.Parse("1999-10-15"),
                    Cast = "Brad Pitt, Edward Norton, Helena Bonham Carter",
                    Genre = "Conformidade, Rebelião, Anarquia, Identidade, Luta",
                    Poster = "https://media.themoviedb.org/t/p/w220_and_h330_face/ohXr0v9U0TfFu9IXbSDm5zoGV3R.jpg"
                },
                new Movie
                {
                    Name = "Matrix",
                    Synopsis = "Thomas Anderson, um jovem programador de computador que mora em um cubículo escuro, é atormentado por estranhos pesadelos nos quais encontra-se conectado por cabos e contra sua vontade, em um imenso sistema de computadores do futuro. Em todas essas ocasiões, acorda gritando no exato momento em que os eletrodos estão para penetrar em seu cérebro. À medida que o sonho se repete, Anderson começa a ter dúvidas sobre a realidade. Por meio do encontro com os misteriosos Morpheus e Trinity, Thomas descobre que é, assim como outras pessoas, vítima da Matrix, um sistema inteligente e artificial que manipula a mente das pessoas, criando a ilusão de um mundo real enquanto usa os cérebros e corpos dos indivíduos para produzir energia. Morpheus, entretanto, está convencido de que Thomas é Neo, o aguardado messias capaz de enfrentar a Matrix e conduzir as pessoas de volta à realidade e à liberdade.",
                    Director = "Lilly Wachowski",
                    ReleaseDate = DateTime.Parse("1999-05-21"),
                    Cast = "Keanu Reeves, Laurence Fishbourne, Carrie-Anne Moss, Hugo Weaving",
                    Genre = "Ação, Ficção Científica, Hacker",
                    Poster = "https://media.themoviedb.org/t/p/w220_and_h330_face/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                }
            );
            context.SaveChanges();
        }
    }
}