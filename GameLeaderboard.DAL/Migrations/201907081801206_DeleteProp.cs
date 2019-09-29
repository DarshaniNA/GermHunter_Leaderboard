namespace GameLeaderboard.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteProp : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Players", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "MyProperty", c => c.String());
        }
    }
}
