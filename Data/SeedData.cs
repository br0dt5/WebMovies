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
                    Name = "Gladiator",
                    Synopsis = "Um ex-general romano busca vingança contra o corrupto imperador que matou sua família e o condenou à escravidão.",
                    Genre = "Ação, Drama, História",
                    Director = "Ridley Scott",
                    ReleaseDate = new DateTime(2000, 5, 5),
                    Cast = "Russell Crowe, Joaquin Phoenix, Connie Nielsen",
                    Duration = 155,
                    Keywords = "roma, vingança, arena",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Grand Budapest Hotel",
                    Synopsis = "As aventuras de um concierge lendário de um famoso hotel europeu e seu aprendiz, que se envolvem no roubo de uma valiosa pintura renascentista.",
                    Genre = "Comédia, Drama",
                    Director = "Wes Anderson",
                    ReleaseDate = new DateTime(2014, 3, 28),
                    Cast = "Ralph Fiennes, Tony Revolori, Adrien Brody",
                    Duration = 99,
                    Keywords = "hotel, mistério, amizade",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Parasite",
                    Synopsis = "Uma família pobre arquiteta um plano para se infiltrar na casa de uma família rica, levando a consequências inesperadas.",
                    Genre = "Drama, Thriller",
                    Director = "Bong Joon-ho",
                    ReleaseDate = new DateTime(2019, 5, 30),
                    Cast = "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong",
                    Duration = 132,
                    Keywords = "diferença social, enganação, suspense",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Blade Runner 2049",
                    Synopsis = "Um jovem replicante descobre um segredo enterrado há muito tempo que pode mudar o futuro da humanidade e dos androides.",
                    Genre = "Ficção Científica, Ação",
                    Director = "Denis Villeneuve",
                    ReleaseDate = new DateTime(2017, 10, 6),
                    Cast = "Ryan Gosling, Harrison Ford, Ana de Armas",
                    Duration = 164,
                    Keywords = "cyberpunk, inteligência artificial, futuro distópico",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Revenant",
                    Synopsis = "Após ser atacado por um urso e deixado para morrer, um caçador de peles luta para sobreviver e buscar vingança.",
                    Genre = "Aventura, Drama, Faroeste",
                    Director = "Alejandro González Iñárritu",
                    ReleaseDate = new DateTime(2015, 12, 25),
                    Cast = "Leonardo DiCaprio, Tom Hardy, Domhnall Gleeson",
                    Duration = 156,
                    Keywords = "sobrevivência, vingança, natureza selvagem",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Whiplash",
                    Synopsis = "Um jovem baterista talentoso entra para um conservatório de música e enfrenta um instrutor implacável que o empurra além de seus limites.",
                    Genre = "Drama, Música",
                    Director = "Damien Chazelle",
                    ReleaseDate = new DateTime(2014, 10, 10),
                    Cast = "Miles Teller, J.K. Simmons, Paul Reiser",
                    Duration = 107,
                    Keywords = "música, disciplina, obsessão",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Mad Max: Fury Road",
                    Synopsis = "Em um mundo pós-apocalíptico, um guerreiro e uma mulher rebelde lutam contra um tirano cruel para libertar um grupo de prisioneiras.",
                    Genre = "Ação, Aventura, Ficção Científica",
                    Director = "George Miller",
                    ReleaseDate = new DateTime(2015, 5, 15),
                    Cast = "Tom Hardy, Charlize Theron, Nicholas Hoult",
                    Duration = 120,
                    Keywords = "deserto, perseguição, sobrevivência",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Inception",
                    Synopsis = "Um ladrão que rouba segredos corporativos através do uso da tecnologia de compartilhamento de sonhos é encarregado de plantar uma ideia na mente de um CEO.",
                    Genre = "Ficção Científica",
                    Director = "Christopher Nolan",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Elliot Page",
                    Duration = 148,
                    Keywords = "sonho, subconsciente, espionagem",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Matrix",
                    Synopsis = "Um hacker descobre a verdade sobre sua realidade e seu papel na guerra contra seus controladores.",
                    Genre = "Ação, Ficção Científica",
                    Director = "Lana Wachowski, Lilly Wachowski",
                    ReleaseDate = new DateTime(1999, 3, 31),
                    Cast = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                    Duration = 136,
                    Keywords = "realidade virtual, IA, distopia",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Interstellar",
                    Synopsis = "Um grupo de exploradores viaja através de um buraco de minhoca no espaço em uma tentativa de garantir o futuro da humanidade.",
                    Genre = "Aventura, Drama, Ficção Científica",
                    Director = "Christopher Nolan",
                    ReleaseDate = new DateTime(2014, 11, 7),
                    Cast = "Matthew McConaughey, Anne Hathaway, Jessica Chastain",
                    Duration = 169,
                    Keywords = "espaço, viagem no tempo, buraco negro",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Dark Knight",
                    Synopsis = "Batman enfrenta o Coringa, um criminoso psicótico que espalha o caos por Gotham.",
                    Genre = "Ação, Crime, Drama",
                    Director = "Christopher Nolan",
                    ReleaseDate = new DateTime(2008, 7, 18),
                    Cast = "Christian Bale, Heath Ledger, Aaron Eckhart",
                    Duration = 152,
                    Keywords = "super-herói, vingança, caos",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Pulp Fiction",
                    Synopsis = "As vidas de dois assassinos de aluguel, um boxeador, um gangster e sua esposa se entrelaçam em histórias de violência e redenção.",
                    Genre = "Crime, Drama",
                    Director = "Quentin Tarantino",
                    ReleaseDate = new DateTime(1994, 10, 14),
                    Cast = "John Travolta, Uma Thurman, Samuel L. Jackson",
                    Duration = 154,
                    Keywords = "violência, crime, narrativa não linear",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Fight Club",
                    Synopsis = "Um homem deprimido e um vendedor de sabão formam um clube de luta clandestino que evolui para algo muito maior.",
                    Genre = "Drama",
                    Director = "David Fincher",
                    ReleaseDate = new DateTime(1999, 10, 15),
                    Cast = "Brad Pitt, Edward Norton, Helena Bonham Carter",
                    Duration = 139,
                    Keywords = "rebeldia, capitalismo, identidade",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Shawshank Redemption",
                    Synopsis = "Dois homens presos formam um vínculo ao longo dos anos, encontrando consolo e redenção por meio de atos de bondade.",
                    Genre = "Drama",
                    Director = "Frank Darabont",
                    ReleaseDate = new DateTime(1994, 9, 23),
                    Cast = "Tim Robbins, Morgan Freeman, Bob Gunton",
                    Duration = 142,
                    Keywords = "prisão, amizade, esperança",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Godfather",
                    Synopsis = "O patriarca de uma família mafiosa transfere o controle de seu império clandestino para seu filho relutante.",
                    Genre = "Crime, Drama",
                    Director = "Francis Ford Coppola",
                    ReleaseDate = new DateTime(1972, 3, 24),
                    Cast = "Marlon Brando, Al Pacino, James Caan",
                    Duration = 175,
                    Keywords = "máfia, família, crime organizado",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Lord of the Rings: The Return of the King",
                    Synopsis = "A Sociedade do Anel se prepara para a batalha final enquanto Frodo e Sam se aproximam de Mordor com o anel.",
                    Genre = "Aventura, Drama, Fantasia",
                    Director = "Peter Jackson",
                    ReleaseDate = new DateTime(2003, 12, 17),
                    Cast = "Elijah Wood, Viggo Mortensen, Ian McKellen",
                    Duration = 201,
                    Keywords = "fantasia, batalha, amizade",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "Forrest Gump",
                    Synopsis = "Um homem simples encontra-se no meio de eventos históricos, influenciando a cultura popular ao longo do caminho.",
                    Genre = "Drama, Romance",
                    Director = "Robert Zemeckis",
                    ReleaseDate = new DateTime(1994, 7, 6),
                    Cast = "Tom Hanks, Robin Wright, Gary Sinise",
                    Duration = 142,
                    Keywords = "história, amizade, superação",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Dark Knight Rises",
                    Synopsis = "Batman retorna para enfrentar o terrorista Bane, que planeja destruir Gotham City.",
                    Genre = "Ação, Crime, Drama",
                    Director = "Christopher Nolan",
                    ReleaseDate = new DateTime(2012, 7, 20),
                    Cast = "Christian Bale, Tom Hardy, Anne Hathaway",
                    Duration = 165,
                    Keywords = "super-herói, terrorismo, redenção",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Lord of the Rings: The Fellowship of the Ring",
                    Synopsis = "Um hobbit relutante começa uma jornada épica para destruir um anel mágico e salvar a Terra-média da escuridão.",
                    Genre = "Aventura, Drama, Fantasia",
                    Director = "Peter Jackson",
                    ReleaseDate = new DateTime(2001, 12, 19),
                    Cast = "Elijah Wood, Ian McKellen, Orlando Bloom",
                    Duration = 178,
                    Keywords = "fantasia, jornada, amizade",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Lord of the Rings: The Two Towers",
                    Synopsis = "A Sociedade do Anel se divide para enfrentar inimigos e aliados enquanto Frodo e Sam continuam sua jornada para Mordor.",
                    Genre = "Aventura, Drama, Fantasia",
                    Director = "Peter Jackson",
                    ReleaseDate = new DateTime(2002, 12, 18),
                    Cast = "Elijah Wood, Ian McKellen, Viggo Mortensen",
                    Duration = 179,
                    Keywords = "fantasia, batalha, amizade",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Godfather: Part II",
                    Synopsis = "A história da ascensão de Vito Corleone ao poder e a vida de seu filho Michael como o novo chefe da família.",
                    Genre = "Crime, Drama",
                    Director = "Francis Ford Coppola",
                    ReleaseDate = new DateTime(1974, 12, 20),
                    Cast = "Al Pacino, Robert De Niro, Robert Duvall",
                    Duration = 202,
                    Keywords = "máfia, família, crime organizado",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Matrix Reloaded",
                    Synopsis = "Neo luta contra o tempo para salvar Zion da invasão das máquinas enquanto descobre a verdade sobre sua existência.",
                    Genre = "Ação, Ficção Científica",
                    Director = "Lana Wachowski, Lilly Wachowski",
                    ReleaseDate = new DateTime(2003, 5, 15),
                    Cast = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                    Duration = 138,
                    Keywords = "realidade virtual, IA, distopia",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Matrix Revolutions",
                    Synopsis = "Neo enfrenta o Agente Smith em uma batalha final para salvar a humanidade e a Matrix da destruição.",
                    Genre = "Ação, Ficção Científica",
                    Director = "Lana Wachowski, Lilly Wachowski",
                    ReleaseDate = new DateTime(2003, 11, 5),
                    Cast = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                    Duration = 129,
                    Keywords = "realidade virtual, IA, distopia",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Social Network",
                    Synopsis = "A história da criação do Facebook e a batalha judicial que se seguiu entre seus fundadores.",
                    Genre = "Biografia, Drama",
                    Director = "David Fincher",
                    ReleaseDate = new DateTime(2010, 10, 1),
                    Cast = "Jesse Eisenberg, Andrew Garfield, Justin Timberlake",
                    Duration = 120,
                    Keywords = "internet, empreendedorismo, traição",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Departed",
                    Synopsis = "Um policial disfarçado e um espião criminoso tentam descobrir a identidade um do outro enquanto infiltram organizações rivais.",
                    Genre = "Crime, Drama, Thriller",
                    Director = "Martin Scorsese",
                    ReleaseDate = new DateTime(2006, 10, 6),
                    Cast = "Leonardo DiCaprio, Matt Damon, Jack Nicholson",
                    Duration = 151,
                    Keywords = "máfia, polícia, traição",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Prestige",
                    Synopsis = "Dois mágicos rivais se envolvem em uma competição de truques cada vez mais perigosos e mortais.",
                    Genre = "Drama, Mistério, Ficção Científica",
                    Director = "Christopher Nolan",
                    ReleaseDate = new DateTime(2006, 10, 20),
                    Cast = "Christian Bale, Hugh Jackman, Scarlett Johansson",
                    Duration = 130,
                    Keywords = "magia, rivalidade, segredo",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Green Mile",
                    Synopsis = "Um guarda de prisão descobre que um prisioneiro condenado à morte possui poderes sobrenaturais.",
                    Genre = "Crime, Drama, Fantasia",
                    Director = "Frank Darabont",
                    ReleaseDate = new DateTime(1999, 12, 10),
                    Cast = "Tom Hanks, Michael Clarke Duncan, David Morse",
                    Duration = 189,
                    Keywords = "prisão, sobrenatural, redenção",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Wolf of Wall Street",
                    Synopsis = "A história de um corretor de ações corrupto e sua ascensão ao poder e queda para a prisão.",
                    Genre = "Biografia, Comédia, Crime",
                    Director = "Martin Scorsese",
                    ReleaseDate = new DateTime(2013, 12, 25),
                    Cast = "Leonardo DiCaprio, Jonah Hill, Margot Robbie",
                    Duration = 180,
                    Keywords = "corrupção, ganância, Wall Street",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Silence of the Lambs",
                    Synopsis = "Uma agente do FBI recorre a um psicopata canibal para ajudá-la a capturar um assassino em série.",
                    Genre = "Crime, Drama, Suspense",
                    Director = "Jonathan Demme",
                    ReleaseDate = new DateTime(1991, 2, 14),
                    Cast = "Jodie Foster, Anthony Hopkins, Scott Glenn",
                    Duration = 118,
                    Keywords = "serial killer, psicopata, investigação",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                },
                new Movie
                {
                    Name = "The Shining",
                    Synopsis = "Uma família se muda para um hotel isolado durante o inverno, onde o pai começa a enlouquecer e aterrorizar sua esposa e filho.",
                    Genre = "Drama, Terror",
                    Director = "Stanley Kubrick",
                    ReleaseDate = new DateTime(1980, 5, 23),
                    Cast = "Jack Nicholson, Shelley Duvall, Danny Lloyd",
                    Duration = 146,
                    Keywords = "isolamento, loucura, terror psicológico",
                    Poster = "https://image.tmdb.org/t/p/original/qFHE09iQDbpHUBXJ8cFZu9v2ViO.jpg"
                }
            );
            context.SaveChanges();
        }
    }
}