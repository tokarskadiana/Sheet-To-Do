namespace Sheet_To_Do.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDueDateToTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "DueDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "DueDate");
        }
    }
}
