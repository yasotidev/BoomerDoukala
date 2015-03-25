using System.ComponentModel.DataAnnotations;

namespace Doukala.ViewModels
{
    public enum GenderViewModel
    {

        
        None = 0,
        [Display(Name = "Homme")]
        Male = 1,
        [Display(Name = "Femme")]
        Female = 2
    }
}