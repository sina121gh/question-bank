namespace QuestionBank.DataLayer.Migrations
{
    using QuestionBank.DataLayer.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuestionBank.DataLayer.Context.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuestionBank.DataLayer.Context.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            #region Seed Data
            List<Lessons_Model> lessons = new List<Lessons_Model>()
            {
                new Lessons_Model()
                {
                    LessonId = 1,
                    Name = "ریاضی",
                },

                new Lessons_Model()
                {
                    LessonId = 2,
                    Name = "فارسی",
                },

                new Lessons_Model()
                {
                    LessonId = 3,
                    Name = "انگلیسی",
                },

                new Lessons_Model()
                {
                    LessonId = 4,
                    Name = "دانش فنی",
                },

                new Lessons_Model()
                {
                    LessonId = 5,
                    Name = "توسعه پایگاه داده",
                },

                new Lessons_Model()
                {
                    LessonId = 6,
                    Name = "طراحی وب",
                },
            };
            List<QuestionDifficulty_Model> difficulties = new List<QuestionDifficulty_Model>()
            {
                new QuestionDifficulty_Model()
                {
                    DifficultyId = 1,
                    Difficulty = "آسان",
                },

                new QuestionDifficulty_Model()
                {
                    DifficultyId = 2,
                    Difficulty = "متوسط",
                },

                new QuestionDifficulty_Model()
                {
                    DifficultyId = 3,
                    Difficulty = "سخت",
                },
            };
            List<QuestionType_Model> types = new List<QuestionType_Model>()
            {
                new QuestionType_Model()
                {
                    TypeId = 1,
                    Type = "تشریحی",
                },

                new QuestionType_Model()
                {
                    TypeId = 2,
                    Type = "تستی",
                },

                new QuestionType_Model()
                {
                    TypeId = 3,
                    Type = "جاخالی",
                },
            };
            List<Question_Model> questions = new List<Question_Model>()
            {
                new Question_Model()
                {
                    QuestionId = 1,
                    LessonId = 1,
                    DifficultyId = 1,
                    TypeId = 1,
                    Question = "تابع را تعریف کنید."
                },

                new Question_Model()
                {
                    QuestionId = 2,
                    LessonId = 2,
                    DifficultyId = 1,
                    TypeId = 1,
                    Question = "کنایه را تعریف کنید."
                },

                new Question_Model()
                {
                    QuestionId = 3,
                    LessonId = 3,
                    DifficultyId = 1,
                    TypeId = 1,
                    Question = "انواع فعل هارا در انگلیسی توضیح دهید"
                },

                new Question_Model()
                {
                    QuestionId = 4,
                    LessonId = 4,
                    DifficultyId = 2,
                    TypeId = 1,
                    Question = "آدرس آیپی را توضیح دهید"
                },

                new Question_Model()
                {
                    QuestionId = 5,
                    LessonId = 5,
                    DifficultyId = 3,
                    TypeId = 1,
                    Question = "در ویندوز فرم یک ماشین حساب طراحی کنید"
                },

                new Question_Model()
                {
                    QuestionId = 6,
                    LessonId = 6,
                    DifficultyId = 3,
                    TypeId = 1,
                    Question = "دیجیکالا را طراحی کنید."
                },

                new Question_Model()
                {
                    QuestionId = 7,
                    LessonId = 1,
                    DifficultyId = 2,
                    TypeId = 2,
                    Question = "جواب درست را انتخاب کنید."
                },
            };
            List<QuestionOptions> questionOptions = new List<QuestionOptions>()
            {
                new QuestionOptions()
                {
                    OptionId = 1,
                    Option = "گزینه 1",
                    OptionNumber = 1,
                    QuestionId = 7,
                },

                new QuestionOptions()
                {
                    OptionId = 2,
                    Option = "گزینه 2",
                    OptionNumber = 2,
                    QuestionId = 7,
                },

                new QuestionOptions()
                {
                    OptionId = 3,
                    Option = "گزینه 3",
                    OptionNumber = 3,
                    QuestionId = 7,
                },

                new QuestionOptions()
                {
                    OptionId = 4,
                    Option = "گزینه 4",
                    OptionNumber = 4,
                    QuestionId = 7,
                },
            };

            context.Lessons.AddOrUpdate(lessons.ToArray());
            context.SaveChanges();
            context.QuestionDifficulteis.AddOrUpdate(difficulties.ToArray());
            context.SaveChanges();
            context.QuestionTypes.AddOrUpdate(types.ToArray());
            context.SaveChanges();
            context.Questions.AddOrUpdate(questions.ToArray());
            context.SaveChanges();
            context.QuestionOptions.AddOrUpdate(questionOptions.ToArray());
            context.SaveChanges();
            #endregion

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
