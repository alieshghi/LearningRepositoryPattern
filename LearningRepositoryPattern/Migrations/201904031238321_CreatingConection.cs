namespace LearningRepositoryPattern.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingConection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        AddressDescription = c.String(),
                        postalcode = c.String(),
                        Customer_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.Customer_id)
                .Index(t => t.Customer_id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        phone = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Addresses", new[] { "Customer_id" });
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
