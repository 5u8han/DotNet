using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace MovieList.Models

{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
        { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //modelBuilder.Entity<Movie>().HasData(
        //new Movie {
        //MovieID = 1,
        //Name = "Casablanca",
        //Year = 1943,
        //Rating = 5,
        //GenreID = "D"
        //},
        //new Movie {
        //MovieID = 2,
        //Name = "Wonder Woman",
        //Year = 2017,
        //Rating = 3,
        //GenreID = "A"
        //},
        //new Movie {
        //MovieID = 3,
        //Name = "Moonstruck",
        //Year = 1988,
        //Rating = 4,
        //GenreID = "R"
        //}
        //);

        //modelBuilder.Entity<Genre>().HasData(
        //new Genre { GenreId = 'A', Name = "Action" },
        //new Genre { GenreId = 'A', Name = "Comedy" },
        //new Genre { GenreId = 'D', Name = "Drama" },
        //new Genre { GenreId = 'H', Name = "Horror" },
        //new Genre { GenreId = 'M', Name = "Musical" },
        //new Genre { GenreId = 'R', Name = "RomCom" },
        //new Genre { GenreId = 'S' , Name = "SciFi" }
        //);
        //}
    }
}