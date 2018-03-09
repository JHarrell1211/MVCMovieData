using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieDiectorApp.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }

        public string Title { get; set; }

        [Display(Name = "Date Released")] //change display name
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")] //sets to display date only
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="Rotten Tomatoes Score")]
        public int RTScore { get; set; }

        public string Rating { get; set; }

        [Display(Name = "Award Winner")]
        public bool WonAward { get; set; }

        //Foreign Keys and Navigation properties
        [ForeignKey("Director"), Display(Name = "Director")]
        public int DirectorID { get; set; }
        public virtual Director Director { get; set; }

        [ForeignKey("Genre"), Display(Name = "Genre")]
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}