using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoEventApp.Models
{
   
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public int NoOfSeats { get; set; }
        public virtual ICollection<Seat>  Seats { get; set; }

        
    }
}
