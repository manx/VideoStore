﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore.Models;

namespace VideoStore.DataAccessLayer
{
    public class VideoStoreInitializer : System.Data.Entity.CreateDatabaseIfNotExists<VideoStoreContext>
    {
        protected override void Seed(VideoStoreContext context)
        {
            new List<Customer>
                {
                    new Customer{FirstName = "Per", LastName = "Persson"},
                    new Customer{FirstName = "Lars", LastName = "Larsson"},
                    new Customer{FirstName = "Magnus", LastName = "Magnusson"}
                }
                .ForEach(a => context.Customers.Add(a));
        
            new List<Movie>
                {
                    new Movie{Title = "The Terminator", Genre = Genre.Action, Duration = 107},
                    new Movie{Title = "Blade Runner 2049", Genre = Genre.ScienceFiction, Duration = 164},
                    new Movie{Title = "Min pappa Toni Erdmann", Genre = Genre.Comedy, Duration = 162},
                    new Movie{Title = "The Square", Genre = Genre.Drama, Duration = 142},
                    new Movie{Title = "The Lord of the Rings", Genre = Genre.Fantasy, Duration = 200}
                }
                .ForEach(m => context.Movies.Add(m));
        
            new List<Rental>
            {
                new Rental{CustomerId = 1, MovieId = 1, RentalDate = new DateTime(2018,1,1), DueDate = new DateTime(2018,1,1).AddDays(2)},
                new Rental{CustomerId = 1, MovieId = 4, RentalDate = DateTime.Today, DueDate = DateTime.Today.AddDays(2)},
                new Rental{CustomerId = 2, MovieId = 2, RentalDate = DateTime.Today, DueDate = DateTime.Today.AddDays(2)},
                new Rental{CustomerId = 2, MovieId = 5, RentalDate = new DateTime(2018,1,1), DueDate = new DateTime(2018,1,1).AddDays(2), ReturnDate = new DateTime(2018, 1, 2)},
                new Rental{CustomerId = 3, MovieId = 3, RentalDate = DateTime.Today, DueDate = DateTime.Today.AddDays(2)}
            }
            .ForEach(r => context.Rentals.Add(r));
            context.SaveChanges();
        }
    }
}
