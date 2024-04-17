namespace QuestionBank.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        LessonId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.LessonId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        Question = c.String(nullable: false, maxLength: 50),
                        TypeId = c.Int(nullable: false),
                        DifficultyId = c.Int(nullable: false),
                        LessonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Lessons", t => t.LessonId, cascadeDelete: true)
                .ForeignKey("dbo.Difficulties", t => t.DifficultyId, cascadeDelete: true)
                .ForeignKey("dbo.QuestionTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId)
                .Index(t => t.DifficultyId)
                .Index(t => t.LessonId);
            
            CreateTable(
                "dbo.Difficulties",
                c => new
                    {
                        DifficultyId = c.Int(nullable: false, identity: true),
                        Difficulty = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.DifficultyId);
            
            CreateTable(
                "dbo.QuestionOptions",
                c => new
                    {
                        OptionId = c.Int(nullable: false, identity: true),
                        Option = c.String(nullable: false, maxLength: 20),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OptionId)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "TypeId", "dbo.QuestionTypes");
            DropForeignKey("dbo.QuestionOptions", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "DifficultyId", "dbo.Difficulties");
            DropForeignKey("dbo.Questions", "LessonId", "dbo.Lessons");
            DropIndex("dbo.QuestionOptions", new[] { "QuestionId" });
            DropIndex("dbo.Questions", new[] { "LessonId" });
            DropIndex("dbo.Questions", new[] { "DifficultyId" });
            DropIndex("dbo.Questions", new[] { "TypeId" });
            DropTable("dbo.QuestionTypes");
            DropTable("dbo.QuestionOptions");
            DropTable("dbo.Difficulties");
            DropTable("dbo.Questions");
            DropTable("dbo.Lessons");
        }
    }
}
