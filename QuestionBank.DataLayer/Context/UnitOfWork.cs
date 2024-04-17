using QuestionBank.DataLayer.Models;
using QuestionBank.DataLayer.Repository;
using QuestionBank.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        MyContext db = new MyContext();

        private GenericRepository<QuestionDifficulty_Model> _questionDifficulty;
        public GenericRepository<QuestionDifficulty_Model> QuestionDifficulty
        {
            get
            {
                if (_questionDifficulty == null)
                {
                    _questionDifficulty = new GenericRepository<QuestionDifficulty_Model>(db);
                }
                return _questionDifficulty;
            }
        }

        private GenericRepository<QuestionType_Model> _questionType;
        public GenericRepository<QuestionType_Model> QuestionType
        {
            get
            {
                if (_questionType == null)
                {
                    _questionType = new GenericRepository<QuestionType_Model>(db);
                }
                return _questionType;
            }
        }

        private GenericRepository<Question_Model> _question;
        public GenericRepository<Question_Model> Question
        {
            get
            {
                if (_question == null)
                {
                    _question = new GenericRepository<Question_Model>(db);
                }
                return _question;
            }
        }

        private GenericRepository<Lessons_Model> _lesson;
        public GenericRepository<Lessons_Model> Lesson
        {
            get
            {
                if (_lesson == null)
                {
                    _lesson = new GenericRepository<Lessons_Model>(db);
                }
                return _lesson;
            }
        }

        private GenericRepository<QuestionOptions> _options;
        public GenericRepository<QuestionOptions> Options
        {
            get
            {
                if (_options == null)
                {
                    _options = new GenericRepository<QuestionOptions>(db);
                }
                return _options;
            }
        }

        private IOptionRepository _optionReposiroty;
        public IOptionRepository OptionRepository
        {
            get
            {
                if (_optionReposiroty == null)
                {
                    _optionReposiroty = new OptionRepository(db);
                }
                return _optionReposiroty;
            }
        }

        private LessonRepository _lessonRepository;
        public LessonRepository LessonRepository
        {
            get
            {
                if (_lessonRepository == null)
                {
                    _lessonRepository = new LessonRepository(db);
                }
                return _lessonRepository;
            }
        }

        private DifficultyRepository _difficultyRepository;
        public DifficultyRepository DifficultyRepository
        {
            get
            {
                if (_difficultyRepository == null)
                {
                    _difficultyRepository = new DifficultyRepository(db);
                }
                return _difficultyRepository;
            }
        }

        private TypeRepository _typeRepository;
        public TypeRepository TypeRepository
        {
            get
            {
                if (_typeRepository == null)
                {
                    _typeRepository = new TypeRepository(db);
                }
                return _typeRepository;
            }

        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
