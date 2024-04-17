using QuestionBank.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Context
{
    public class MyContext : DbContext
    {
        public DbSet<QuestionType_Model> QuestionTypes { get; set; }
        public DbSet<QuestionDifficulty_Model> QuestionDifficulteis { get; set; }
        public DbSet<QuestionOptions> QuestionOptions { get; set; }
        public DbSet<Question_Model> Questions { get; set; }
        public DbSet<Lessons_Model> Lessons { get; set; }
        
    }
}
