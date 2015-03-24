using System;

namespace Bakoukala.Models
{
    public class Manager
    {
        public Gender Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return String.Format("{0}{1}{2}", FirstName, " ", LastName); }
        }

        public string DisplayName
        {
            get { return String.Format("{0}{1}", FirstName, LastName.Substring(0, 1)); }
        }

        public string OfficeNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
    }
}