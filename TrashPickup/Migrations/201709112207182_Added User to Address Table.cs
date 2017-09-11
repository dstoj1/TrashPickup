namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUsertoAddressTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Addresses", "User_Id");
            AddForeignKey("dbo.Addresses", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropColumn("dbo.Addresses", "User_Id");
        }
    }
}
