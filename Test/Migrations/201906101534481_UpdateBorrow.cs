namespace ResearchRecordingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBorrow : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Borrows", "BorrowerId", "dbo.ResearchBooks");
            DropIndex("dbo.Borrows", new[] { "BorrowerId" });
            AddColumn("dbo.Borrows", "ThesisTitleId", c => c.Int());
            CreateIndex("dbo.Borrows", "ThesisTitleId");
            AddForeignKey("dbo.Borrows", "ThesisTitleId", "dbo.ResearchBooks", "ThesisTitleId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Borrows", "ThesisTitleId", "dbo.ResearchBooks");
            DropIndex("dbo.Borrows", new[] { "ThesisTitleId" });
            DropColumn("dbo.Borrows", "ThesisTitleId");
            CreateIndex("dbo.Borrows", "BorrowerId");
            AddForeignKey("dbo.Borrows", "BorrowerId", "dbo.ResearchBooks", "ThesisTitleId");
        }
    }
}
