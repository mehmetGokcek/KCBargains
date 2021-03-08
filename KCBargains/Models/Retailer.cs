using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCBargains.Models
{
    public class Retailer
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Store name is required")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = " must be between 3 and 12 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zipcode is required")]
        public string Zipcode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        private const double homeLatitude = 39.0942823;
        private const double homeLongitude = -94.5906067;

        public Retailer(string name, string street, string city, string state, string zipcode, double latitude, double longitude ) {

            Name = name;
            Street = street;
            City = city;
            State = state;
            Zipcode = zipcode;
            Latitude = latitude;
            Longitude = longitude;
        }

        public Retailer() { }

        public double HomeLatitude { get { return homeLatitude; } }
        public double HomeLongitude { get { return homeLongitude; } }

    }
}
