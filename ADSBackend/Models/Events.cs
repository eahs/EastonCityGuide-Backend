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


        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        [Required]
        public string Date { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
