using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CafeApp.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }


    }
}
