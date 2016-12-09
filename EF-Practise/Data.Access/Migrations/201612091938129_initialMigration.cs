namespace Data.Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Address_AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.ContactId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .Index(t => t.Address_AddressID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "Address_AddressID", "dbo.Addresses");
            DropIndex("dbo.Contacts", new[] { "Address_AddressID" });
            DropTable("dbo.Contacts");
            DropTable("dbo.Addresses");
        }
    }
}
