using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoEventApp.Models
{
    public class theatre
    {
       [Key]
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }
        public string ManagerName { get; set; }
        public string TheatreCity { get; set; }
        public string ManagerContact { get; set; }
        public virtual Screen Screen { get; set; }
       /* public int MovieId { get; set; }*/
    }
}
