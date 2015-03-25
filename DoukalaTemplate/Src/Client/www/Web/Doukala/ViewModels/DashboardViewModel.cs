using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Doukala.Server.Core.Entities;

namespace Doukala.ViewModels
{
    public class DashboardViewModel
    {
        public IEnumerable<CompagnyViewModel> Compagnies { get; set; }
    }
}