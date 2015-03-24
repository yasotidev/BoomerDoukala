namespace Bakoukala.Models
{
    public class Compagny
    {
        public byte[] LogoAvatar { get; set; }
        public string Logo { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public virtual Address Address { get; set; }
        public string Activity { get; set; }
        public string CodeNaf { get; set; }
        public string SiretNumber { get; set; }
        public string IntraCommunityVat { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public virtual Manager Manager { get; set; }
    }
}