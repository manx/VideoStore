using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using VideoStore.Models;

namespace VideoStore.DataAccessLayer
{
    public class VideoStoreContext : DbContext
    {
        // The DbContext constructor is called with the name of the new database as parameter
        public VideoStoreContext() : base("VideoStoreContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Movie> Movies { get; set; }
        

        // Since I´m calling modelBuilder.Conventions.Remove<PluralizingTableNames>(), 
        // the tables in the generated database wont have pluralized names. 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
