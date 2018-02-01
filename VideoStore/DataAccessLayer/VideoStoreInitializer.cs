using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore.Models;

namespace VideoStore.DataAccessLayer
{
    // Inheriting from System.Data.Entity.DropCreateDatabaseIfModelChanges<VideoStoreContext> causes an existing Database to be dropped when the model changes.
    // TODO: Not suitable for production.
    public class VideoStoreInitializer : System.Data.Entity.DropCreateDatabaseAlways<VideoStoreContext> //DropCreateDatabaseIfModelChanges<VideoStoreContext>
    {
        protected override void Seed(VideoStoreContext context)
        {
            // TODO: Not needed in production
            // context.SaveChanges() after every Table
            new List<Customer>
                {
                    new Customer{FirstName = "Per", LastName = "Persson"},
                    new Customer{FirstName = "Lars", LastName = "Larsson"},
                    new Customer{FirstName = "Magnus", LastName = "Magnusson"}
                }
                .ForEach(a => context.Customers.Add(a));
            context.SaveChanges();

            new List<Movie>
                {
                    new Movie{Title = "The Terminator", Genre = Genre.Action, Duration = 107},
                    new Movie{Title = "Blade Runner 2049", Genre = Genre.ScienceFiction, Duration = 164},
                    new Movie{Title = "Min pappa Toni Erdmann", Genre = Genre.Comedy, Duration = 162},
                    new Movie{Title = "The Square", Genre = Genre.Drama, Duration = 142}
                }
                .ForEach(m => context.Movies.Add(m));
            context.SaveChanges();

            new List<Rental>
            {
                //TODO: Add constructor in Rental class? 
                new Rental{CustomerId = 1, MovieId = 1, RentalDate = new DateTime(2018,1,1,16,0,0), DueDate = new DateTime(2018,1,1,16,0,0).AddDays(2), ReturnDate = DateTime.Now},
                new Rental{CustomerId = 1, MovieId = 4, RentalDate = DateTime.Today, DueDate = DateTime.Today.AddDays(2)},
                new Rental{CustomerId = 2, MovieId = 2, RentalDate = DateTime.Today, DueDate = DateTime.Today.AddDays(2)},
                new Rental{CustomerId = 3, MovieId = 3, RentalDate = DateTime.Today, DueDate = DateTime.Today.AddDays(2)}
            }
            .ForEach(r => context.Rentals.Add(r));
            context.SaveChanges();
        }
    }
}
