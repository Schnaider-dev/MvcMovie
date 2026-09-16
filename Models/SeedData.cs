using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Prison Break",
                    ReleaseDate = DateTime.Parse("2005-08-29"),
                    Genre = "Drama/Thriller",
                    Rating = "TV-14",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Grimm",
                    ReleaseDate = DateTime.Parse("2011-10-28"),
                    Genre = "Fantasy/Drama",
                    Rating = "TV-14",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Gotham",
                    ReleaseDate = DateTime.Parse("2014-09-22"),
                    Genre = "Crime/Drama",
                    Rating = "TV-14",
                    Price = 10.99M
                }
            );
            context.SaveChanges();
        }
    }
}