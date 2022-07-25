using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoEventApp.Models
{
    public class Customer
    {
      [Key]
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string email { get; set; }
        public string mobileNumber { get; set; }
        public string password { get; set; }
        public string address { get; set; }
    }
}