namespace ResearchRecordingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Borrow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Borrows",
                c => new
                    {
                        BorrowerId = c.Int(nullable: false, identity: true),
                        BFullaName = c.String(),
                        BContactNumber = c.String(),
                        BookBorrowedDate = c.DateTime(nullable: false),
                        BookReturnedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BorrowerId)
                .ForeignKey("dbo.ResearchBooks", t => t.BorrowerId)
                .Index(t => t.BorrowerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Borrows", "BorrowerId", "dbo.ResearchBooks");
            DropIndex("dbo.Borrows", new[] { "BorrowerId" });
            DropTable("dbo.Borrows");
        }
    }
}
