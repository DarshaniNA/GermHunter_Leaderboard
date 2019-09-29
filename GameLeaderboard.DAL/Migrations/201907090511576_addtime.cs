namespace GameLeaderboard.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "TimeRun", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "TimeRun");
        }
    }
}
