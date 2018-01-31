using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Razor;

namespace VideoStore.Models
{
    public class Movie
    {
        // TODO: Check if needed
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public Genre? Genre { get; set; }
        public int Duration { get; set; }

        //TODO: Understand why this is included
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
