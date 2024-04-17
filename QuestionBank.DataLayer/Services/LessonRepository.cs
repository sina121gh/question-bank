using QuestionBank.DataLayer.Context;
using QuestionBank.ViewModels.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Services
{
    public class LessonRepository
    {
        MyContext db;
        public LessonRepository(MyContext context)
        {
            db = context;
        }

        public string GetLessonNameById(int id)
        {
            return db.Lessons.Find(id).Name;
        }

        public int GetLessonIdByName(string name)
        {
            return db.Lessons.Single(l => l.Name == name).LessonId;
        }

        public List<LessonsListViewModel> GetLessonsNames()
        {
            return db.Lessons.Select(l => new LessonsListViewModel
            {
                LessonId = l.LessonId,
                LessonName = l.Name
            }).ToList();
        }
    }
}
