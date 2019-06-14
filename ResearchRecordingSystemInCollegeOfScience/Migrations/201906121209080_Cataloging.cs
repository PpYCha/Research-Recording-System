namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cataloging : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResearchBooks", "Cataloging", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResearchBooks", "Cataloging");
        }
    }
}
