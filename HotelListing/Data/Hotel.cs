using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class Hotel
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public double Rating { get; set; }

        [ForeignKey(nameof(Country))]

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }

}
