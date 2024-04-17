using QuestionBank.DataLayer.Context;
using QuestionBank.DataLayer.Models;
using QuestionBank.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Services
{
    public class OptionRepository : IOptionRepository
    {
        MyContext db;

        public OptionRepository(MyContext context)
        {
            db = context;
        }

        public bool Delete(QuestionOptions option)
        {
            try
            {
                db.QuestionOptions.Remove(option);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int optionId)
        {
            try
            {
                Delete(GetById(optionId));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ICollection<QuestionOptions> GetAll()
        {
            return db.QuestionOptions.ToList();
        }

        public QuestionOptions GetById(int optionId)
        {
            return db.QuestionOptions.Find(optionId);
        }

        public bool Insert(QuestionOptions option)
        {
            try
            {
                db.QuestionOptions.Add(option);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(QuestionOptions option)
        {
            try
            {
                var local = db.Set<QuestionOptions>()
                         .Local
                         .FirstOrDefault(f => f.OptionId == option.OptionId);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(option).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
