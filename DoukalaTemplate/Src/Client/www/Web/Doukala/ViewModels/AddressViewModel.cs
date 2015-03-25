using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;

namespace Doukala.ViewModels
{
    public class AddressViewModel
    {
        [Display(Name = "Rue")]
        [DataType(DataType.Text)]
        public string Street { get; set; }


        [Display(Name = "Complement")]
        [DataType(DataType.Text)]
        public string Option { get; set; }


        [Display(Name = "Code postal")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }



        [Display(Name = "Ville")]
        public string City { get; set; }

        [Display(Name = "Région")]
        [DataType(DataType.Text)]
        public string State { get; set; }

        [Display(Name = "Pays")]
        [DataType(DataType.Text)]
        public string Country { get; set; }


        [Display(Name = "Geo localisation")]
        [DataType(DataType.Html)]
        public DbGeography Location { get; set; }
    }
}