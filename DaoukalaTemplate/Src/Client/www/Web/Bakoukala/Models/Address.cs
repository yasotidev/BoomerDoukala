using System.Data.Entity.Spatial;

namespace Doukala.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string Option { get; set; }
        public string ZipCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
        public DbGeography Location { get; set; }
    }
}