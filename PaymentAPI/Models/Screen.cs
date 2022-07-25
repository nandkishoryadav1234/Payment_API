using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoEventApp.Models
{
    public class Screen
    {
        [Key]
        public int ScreenId { get; set; }
        public string ScreenName { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
    }
}
