namespace QuestionBank.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQuestionOptions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuestionOptions", "OptionNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.QuestionOptions", "OptionNumber");
        }
    }
}
