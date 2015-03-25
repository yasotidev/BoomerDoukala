using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Doukala.Server.Core.Entities;

namespace Doukala.ViewModels
{
    public class ManageCompagnyViewModel
    {

        public virtual ICollection<CompagnyViewModel> ListOfCompagnies { get; set; } 
    }
}