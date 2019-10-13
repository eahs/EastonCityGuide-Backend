using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADSBackend.Models
{
    public class Events
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "date")]
        [Required]
        public string Date { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Description")]
        public string Descripition { get; set; }
    }
}
