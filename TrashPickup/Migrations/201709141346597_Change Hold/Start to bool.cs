namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeHoldStarttobool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "HoldStart", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "HoldStart", c => c.String());
        }
    }
}
