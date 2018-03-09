using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieDiectorApp.Models
{
    public class Director
    {
        [Key]
        public int DirectorID { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public virtual ICollection<Movie> Movies { get; set; }
    }
}