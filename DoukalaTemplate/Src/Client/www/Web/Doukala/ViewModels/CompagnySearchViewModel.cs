using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doukala.ViewModels
{
    public class CompagnySearchViewModel
    {
        public int CompagnyId { get; set; }
        public string Name { get; set; }
        public string Activity { get; set; }
        public string CodeNaf { get; set; }
        public string SiretNumber { get; set; }
    }
}