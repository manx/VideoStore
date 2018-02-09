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
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public Genre? Genre { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
