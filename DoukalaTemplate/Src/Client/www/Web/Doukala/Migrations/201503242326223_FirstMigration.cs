namespace Doukala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compagny",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LogoAvatar = c.Binary(),
                        Logo = c.String(),
                        Nom = c.String(),
                        Description = c.String(),
                        Address_Street = c.String(),
                        Address_Option = c.String(),
                        Address_ZipCode = c.String(),
                        Address_City = c.String(),
                        Address_State = c.String(),
                        Address_Country = c.String(),
                        Address_Location = c.Geography(),
                        Activity = c.String(),
                        CodeNaf = c.String(),
                        SiretNumber = c.String(),
                        IntraCommunityVat = c.String(),
                        Email = c.String(),
                        WebSite = c.String(),
                        Manager_Gender = c.Int(nullable: false),
                        Manager_FirstName = c.String(),
                        Manager_LastName = c.String(),
                        Manager_OfficeNumber = c.String(),
                        Manager_MobileNumber = c.String(),
                        Manager_Email = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Compagny");
        }
    }
}
