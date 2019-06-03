namespace ResearchRecordingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BorrowModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Borrows", "BookBorrowedDate", c => c.DateTime());
            AlterColumn("dbo.Borrows", "BookReturnedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Borrows", "BookReturnedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Borrows", "BookBorrowedDate", c => c.DateTime(nullable: false));
        }
    }
}
