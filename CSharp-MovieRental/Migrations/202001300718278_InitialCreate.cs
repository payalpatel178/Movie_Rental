namespace CSharp_MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BorrowHistories",
                c => new
                    {
                        BorrowHistoryId = c.Int(nullable: false, identity: true),
                        BorrowDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BorrowHistoryId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Director = c.String(),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Year = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        Synopsis = c.String(),
                        ImageURL = c.String(),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BorrowHistories", "UserId", "dbo.Users");
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.BorrowHistories", "MovieId", "dbo.Movies");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropIndex("dbo.BorrowHistories", new[] { "MovieId" });
            DropIndex("dbo.BorrowHistories", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
            DropTable("dbo.BorrowHistories");
        }
    }
}
