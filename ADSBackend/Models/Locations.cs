using System.ComponentModel.DataAnnotations;

namespace ADSBackend.Models
{
    public class Locations
    {
        public int Id { get; set; }

        
        [DataType(DataType.EmailAddress)]
        [Required]
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

        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }
    }
}
