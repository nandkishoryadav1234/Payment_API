using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoEventApp.Models
{
    public class Seat
    {
      [Key]
        public int SeatId { get; set; }
        public string SeatNumber { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
    }
}
