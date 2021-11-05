namespace UtilitiesLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerRounds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        playerName = c.String(),
                        score = c.Int(nullable: false),
                        gameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rounds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        gameID = c.Int(nullable: false),
                        amountOfPlayers = c.Int(nullable: false),
                        highestScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rounds");
            DropTable("dbo.PlayerRounds");
        }
    }
}
