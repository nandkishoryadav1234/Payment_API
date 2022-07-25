using ContosoEventApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

       
        public string MovieName { get; set; }

        
        public string MovieGenre { get; set; }

      
        public string MovieLanguage { get; set; }
        public string MovieDescription { get; set; }
        public int MovieRating { get; set; }
        public DateTime MovieDate { get; set; }




    }
}
