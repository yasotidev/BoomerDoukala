using System.ComponentModel.DataAnnotations;
using Doukala.Server.Core.Entities;

namespace Doukala.ViewModels
{
    public class CompagnyViewModel
    {
        

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }


        [Display(Name = "Nom de l'entreprise")]
        [DataType(DataType.Text)]
        public string Nom { get; set; }

        [Display(Name = "Déscription")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        public virtual AddressViewModel Address { get; set; }

        [Display(Name = "Activité de l'entreprise")]
        [DataType(DataType.Text)]
        public string Activity { get; set; }

        [Display(Name = "Code Naf")]
        //Todo Extension for NafCode
        public string CodeNaf { get; set; }

         [Display(Name = "Numero de SIRET")]
        //Todo Extension for SiretNumber
        public string SiretNumber { get; set; }


         [Display(Name = "Tva intracomunotaire")]
        //Todo Extension for Intra Community Vat
        public string IntraCommunityVat { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 
        
        [DataType(DataType.Url)]
        public string WebSite { get; set; }

        public virtual ManagerViewModel Manager { get; set; }
    }
}