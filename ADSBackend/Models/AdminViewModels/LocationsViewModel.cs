using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADSBackend.Models.AdminViewModels
{
    public class LocationsViewModel
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Latitude")]
        [Required]
        public float Latitude { get; set; }

        [Display(Name = "Longitude")]
        [Required]
        public float Longitude { get; set; }

        [Display(Name = "PhoneNumber")]
        [Required]
        public float PhoneNumber { get; set; }
    }
}
