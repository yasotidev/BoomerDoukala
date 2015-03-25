using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Doukala.Models;

namespace Doukala.Migrations
{
    public class AppDataSeeder
    {
        public static void Seed(DefaultContext context)
        {
            CompagnyDataSeed(context);
        }

        

        private static void CompagnyDataSeed(DefaultContext context)
        {
            new List<Compagny>
            {
                new Compagny
                {
                    Id = 1,
                    //   Logo =
                    Nom = "COMPAGNY DESIGN",
                    Description = "Société de batiment et refection",
                    Activity = "Batiment",
                    CodeNaf = "A4521",
                    SiretNumber = "999999999",
                    IntraCommunityVat = "999999999",
                    Manager = new Manager
                    {
                        FirstName = "BROKE",
                        LastName = "Mikael",
                        OfficeNumber = null,
                        MobileNumber = "06 66 45 50 96",
                        Email = "mbroke@compagny-design.com"
                    },
                    Address = new Address()
                    {
                        Street = "20 rue de la Grande Ile",
                        Option = null,
                        ZipCode = "77 100",
                        City = "Meaux",
                        State = "Seine et Marne",
                        Country = "France",
                        //Location = GeographyHelpers.CreatePoint(48.955592, 2.876217)
                    },
                    Email = "contact@boomerdesign.fr",
                    WebSite = "http://www.compagny-design.fr"

                }   ,
                 new Compagny
                {
                    Id = 2,
                    //   Logo =
                    Nom = "COMPAGNY FIX",
                    Description = "Société de Dépannage informatique",
                    Activity = "Informatique",
                    CodeNaf = "4521",
                    SiretNumber = "999999999",
                    IntraCommunityVat = "999999999",
                    Manager = new Manager
                    {
                        FirstName = "BRAKE",
                        LastName = "Stéphane",
                        OfficeNumber = null,
                        MobileNumber = "06 66 45 50 96",
                        Email = "mbrake@fix.com"
                    },
                    Address = new Address()
                    {
                        Street = "120 rue de la Gloire",
                        Option = null,
                        ZipCode = "94 200",
                        City = "Ivry Sur Seine",
                        State = "Val de Marne",
                        Country = "France",
                        //Location = GeographyHelpers.CreatePoint(48.955592, 2.876217)
                    },
                    Email = "contact@boomerdesign.fr",
                    WebSite = "http://www.fix.fr"

                }  ,
                new Compagny
                {
                    Id = 3,
                    //   Logo =
                    Nom = "COMPAGNY FAX",
                    Description = "Commerce de détail de produits pharmaceutiques",
                    Activity = "Service",
                    CodeNaf = "4773Z",
                    SiretNumber = "999999999",
                    IntraCommunityVat = "999999999",
                    Manager = new Manager
                    {
                        FirstName = "LAPURGE",
                        LastName = "Stéphane",
                        OfficeNumber = null,
                        MobileNumber = "06 66 45 50 96",
                        Email = "slapurgebrake@fax.com"
                    },
                    Address = new Address()
                    {
                        Street = "30 rue de la fortune",
                        Option = null,
                        ZipCode = "75 016",
                        City = "Paris",
                        State = "Ile de France",
                        Country = "France",
                        //Location = GeographyHelpers.CreatePoint(48.955592, 2.876217)
                    },
                    Email = "contact@boomerdesign.fr",
                    WebSite = "http://www.fax.fr"

                } ,
                 new Compagny
                {
                    Id = 4,
                    //   Logo =
                    Nom = "COMPAGNY AFOUS",
                    Description = "Commerce de détail de produits Alimentaires",
                    Activity = "Service",
                    CodeNaf = "A4521",
                    SiretNumber = "999999999",
                    IntraCommunityVat = "999999999",
                    Manager = new Manager
                    {
                        FirstName = "BRIKE",
                        LastName = "Moulay",
                        OfficeNumber = null,
                        MobileNumber = "06 66 45 50 96",
                        Email = "mbrike@afous.com"
                    },
                    Address = new Address()
                    {
                        Street = "20 rue du petit arabe",
                        Option = null,
                        ZipCode = "92 200",
                        City = "Montrouge",
                        State = "La Haute Seine",
                        Country = "France",
                        //Location = GeographyHelpers.CreatePoint(48.955592, 2.876217)
                    },
                    Email = "contact@boomerdesign.fr",
                    WebSite = "http://www.compagny-design.fr"

                }   ,
                 new Compagny
                {
                    Id = 5,
                    //   Logo =
                    Nom = "COMPAGNY GRIGRI",
                    Description = "Commerce de restauration traditionnels sénégalais",
                    Activity = "Restauration",
                    CodeNaf = "345",
                    SiretNumber = "999999999",
                    IntraCommunityVat = "999999999",
                    Manager = new Manager
                    {
                        FirstName = "DIAKITE",
                        LastName = "Mamadou",
                        OfficeNumber = null,
                        MobileNumber = "06 66 45 50 96",
                        Email = "mdiakite@grgri.com"
                    },
                    Address = new Address()
                    {
                        Street = "120 rue e nagadef",
                        Option = null,
                        ZipCode = "78 280",
                        City = "Saint Germain en Laye",
                        State = "Yvelines",
                        Country = "France",
                        //Location = GeographyHelpers.CreatePoint(48.955592, 2.876217)
                    },
                    Email = "contact@grigri.fr",
                    WebSite = "http://www.fix.fr"

                }  ,
                new Compagny
                {
                    Id = 6,
                    //   Logo =
                    Nom = "COMPAGNY FAIL",
                    Description = "Société de téléphonie portable",
                    Activity = "Service",
                    CodeNaf = "4521",
                    SiretNumber = "999999999",
                    IntraCommunityVat = "999999999",
                    Manager = new Manager
                    {
                        FirstName = "GALERIEN",
                        LastName = "Cyril",
                        OfficeNumber = null,
                        MobileNumber = "06 66 45 50 96",
                        Email = "cgalairien@fail.fr"
                    },
                    Address = new Address()
                    {
                        Street = "30 rue de la fortune",
                        Option = null,
                        ZipCode = "75 011",
                        City = "Paris",
                        State = "Ile de France",
                        Country = "France",
                        //Location = GeographyHelpers.CreatePoint(48.955592, 2.876217)
                    },
                    Email = "contact@fail.fr",
                    WebSite = "http://www.fail.fr"

                }


            }.ForEach(o => context.Compagnies.AddOrUpdate(o));
        }
    }
}