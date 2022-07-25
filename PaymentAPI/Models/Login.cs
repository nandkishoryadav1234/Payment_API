using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoEventApp.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public Boolean LoginStatus { get; set; }
        public User User { get; set; }
    }
}
