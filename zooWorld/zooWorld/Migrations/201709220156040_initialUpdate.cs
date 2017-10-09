namespace zooWorld.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        SpeciesType = c.Int(nullable: false),
                        TasteForBlood = c.Boolean(nullable: false),
                        SkinType = c.Int(nullable: false),
                        Environment_Id = c.Int(),
                        ZooKeeper_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Environments", t => t.Environment_Id)
                .ForeignKey("dbo.ZooKeepers", t => t.ZooKeeper_Id)
                .Index(t => t.Environment_Id)
                .Index(t => t.ZooKeeper_Id);
            
            CreateTable(
                "dbo.Environments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductPlacement = c.Boolean(nullable: false),
                        WaterFeature = c.Boolean(nullable: false),
                        MaxOccupancy = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ZooKeepers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FavoriteStarTrekSeries = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "ZooKeeper_Id", "dbo.ZooKeepers");
            DropForeignKey("dbo.Animals", "Environment_Id", "dbo.Environments");
            DropIndex("dbo.Animals", new[] { "ZooKeeper_Id" });
            DropIndex("dbo.Animals", new[] { "Environment_Id" });
            DropTable("dbo.ZooKeepers");
            DropTable("dbo.Environments");
            DropTable("dbo.Animals");
        }
    }
}
