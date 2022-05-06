using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Data.ContextConfigurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var _ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Batman Begins",
                    Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2005, 06, 25),
                    SuperheroId = _ids[0]

                },
                 new Movie
                 {
                     Id = Guid.NewGuid(),
                     Title = "The Dark Knight",
                     Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                     Instructor = "Christopher Nolan",
                     ReleaseDate = new DateTime(2008, 07, 18),
                     SuperheroId = _ids[0]
                 },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "The Dark Knight Rises",
                    Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2012, 07, 20),
                    SuperheroId = _ids[0]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode IV – A New Hope",
                    Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                    Instructor = "George Lucas",
                    ReleaseDate = new DateTime(1977, 05, 25),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode V – The Empire Strikes Back",
                    Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                    Instructor = "Irvin Kershner",
                    ReleaseDate = new DateTime(1980, 05, 21),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode VI – Return of the Jedi",
                    Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                    Instructor = "Richard Marquand",
                    ReleaseDate = new DateTime(1983, 05, 25),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Black Widow",
                    Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                    Instructor = "Cate Shortland",
                    ReleaseDate = new DateTime(2021, 06, 29),
                    SuperheroId = _ids[2]
                }
           );
            modelBuilder.Entity<Superhero>().HasData(
                 new Superhero
                 {
                     Id = _ids[0],
                     Name = "Batman",
                     Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                     Height = "1.77"
                 },
                new Superhero
                {
                    Id = _ids[1],
                    Name = "Luke Skywalker",
                    Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                    Height = "1.77"
                },
                new Superhero
                {
                    Id = _ids[2],
                    Name = "Black Widow",
                    Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                    Height = "1.77"
                }

             );
            modelBuilder.Entity<Superpower>().HasData(
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Intellect.",
                    Description = "He's always a step ahead.",
                    SuperheroId = _ids[0]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Fighting",
                    Description = "Sublime fighting skills.",
                    SuperheroId = _ids[0]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Wealth.",
                    Description = "He got a lot of money",
                    SuperheroId = _ids[0]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Deflect blaster power.",
                    Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                    SuperheroId = _ids[1]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Espionage",
                    Description = "She's good at spying at people.",
                    SuperheroId = _ids[2]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Infiltration",
                    Description = "She knows how to infiltrate the enemy.",
                    SuperheroId = _ids[2]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Subterfuge",
                    Description = "The knowledge of how to undermine others.",
                    SuperheroId = _ids[2]
                }
                );
        }
    }
}
