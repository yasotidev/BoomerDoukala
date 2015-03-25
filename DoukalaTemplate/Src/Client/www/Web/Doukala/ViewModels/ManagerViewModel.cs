using System;
using System.ComponentModel.DataAnnotations;

namespace Doukala.ViewModels
{
    public class ManagerViewModel
    {

        [Display(Name = "Sex")]
        public GenderViewModel Gender { get; set; }

        [Display(Name = "Nom")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Display(Name = "Pr�nom")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Display(Name = "Nom & pr�nom")]
        [DataType(DataType.Text)]
        public string FullName
        {
            get { return String.Format("{0}{1}{2}", FirstName, " ", LastName); }
        }

        
        [Display(Name = "T�l�phone Bureau")]
        [DataType(DataType.PhoneNumber)]
        public string OfficeNumber { get; set; }

        [Display(Name = "T�l�phone portable")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}