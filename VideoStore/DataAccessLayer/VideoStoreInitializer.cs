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
            new List<Movie>
                {
                    new Movie{Title = "The Terminator", Director = "James Cameron", Genre = Genre.Action, Duration = 107}
                }
                .ForEach(m => context.Movies.Add(m));
            context.SaveChanges();

            new List<Actor>
                {
                    new Actor {Id = 1, Name = "Arnold Shwarzenegger", MovieId = 1},
                    new Actor {Id = 2, Name = "Linda Hamilton", MovieId = 1}
                }
                .ForEach(a => context.Actors.Add(a));
            context.SaveChanges();
        }
    }
}
