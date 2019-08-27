//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieTicketBooking.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class Movie
    {
        public Movie()
        {
            this.MovieShows = new HashSet<MovieShow>();
            this.Bookings = new HashSet<Booking>();
        }
    
        public int MovieId { get; set; }

        [Required]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Ticket Price")]
        public int TicketPrice { get; set; }

        [Required(ErrorMessage = "Select a poster")]
        [Display(Name = "Poster")]
        public string MovieImage { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
    
        public virtual ICollection<MovieShow> MovieShows { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
