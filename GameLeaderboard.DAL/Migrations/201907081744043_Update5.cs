namespace GameLeaderboard.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "MyProperty", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "MyProperty");
        }
    }
}
