namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUpDateDayandeditedAddressModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "HoldStart", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addresses", "HoldStart");
        }
    }
}
