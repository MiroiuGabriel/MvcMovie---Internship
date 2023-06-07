using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var movieContext = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>());
            using var videoGameContext = new MvcVideoGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcVideoGamesContext>>());
            // Look for any movies.
            if (movieContext.Movie.Any() || videoGameContext.VideoGame.Any())
            {
                return;   // DB has been seeded
            }

            movieContext.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },

                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                }
            );

            videoGameContext.VideoGame.AddRange(
                new VideoGame
                {
                    Title = "Game 1",
                    Genre = "Action",
                    Publisher = "Publisher 1",
                    ReleaseDate = new DateTime(2022, 1, 1),
                    Price = 59.99m
                },
                new VideoGame
                {
                    Title = "Game 2",
                    Genre = "RPG",
                    Publisher = "Publisher 2",
                    ReleaseDate = new DateTime(2022, 2, 1),
                    Price = 49.99m
                });


            movieContext.SaveChanges();
            videoGameContext.SaveChanges();
        }
    }
}