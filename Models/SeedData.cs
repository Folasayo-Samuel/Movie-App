using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovies.Models;
using System.Linq;


namespace MovieDataApp.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
			{
				// Look for any movies.
				if(context.Movie.Any())
				{
					return;  // DB has been seeded
				}
				context.Movie.AddRange(
					new Movie
				{
					Title = "When Harry Met Sally",
					ReleaseDate = DateTime.Parse("1989-2-12"),
					Genre = "Romantic Comedy",
					Price = 7.99M,
					// Rating = "R"
				},

				new Movie
				{
					Title = "Ghostbusters 1",
					ReleaseDate = DateTime.Parse("1986-2-23"),
					Genre = "Comedy",
					Price = 8.99M,
					// Rating = "R"
				},

				new Movie
				{
					Title = "Ghostbusters 2",
					ReleaseDate = DateTime.Parse("1984-2-23"),
					Genre = "Comedy",
					Price = 9.99M,
					// Rating = "R"
				},

				new Movie
				{
					Title = "Ghostbusters 2",
					ReleaseDate = DateTime.Parse("1986-2-23"),
					Genre = "Comedy",
					Price = 19.99M,
					// Rating = "R"
				},

				new Movie
				{
					Title = "Rio Bravo",
					ReleaseDate = DateTime.Parse("1950-2-23"),
					Genre = "Western",
					Price = 3.99M,
					// Rating = "R"
				}
				);
				context.SaveChanges();
			}
		}
	}
}
