using QuestionBank.DataLayer.Context;
using QuestionBank.ViewModels.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Services
{
    public class TypeRepository
    {
        private MyContext db;

        public TypeRepository(MyContext context)
        {
            db = context;
        }

        public bool IsTestQuestion(int typeId)
        {
            if (typeId == db.QuestionTypes.Single(t => t.Type == "تستی").TypeId)
                return true;
            else
                return false;
        }

        public string GetTypeById(int id)
        {
            return db.QuestionTypes.Find(id).Type;
        }

        public int GetIdByType(string  type)
        {
            return db.QuestionTypes.Single(t => t.Type == type).TypeId;
        }

        public List<TypesListViewModel> GetTypes()
        {
            return db.QuestionTypes.Select(t => new TypesListViewModel
            {
               TypeId = t.TypeId,
               Type = t.Type,
            }).ToList();
        }
    }
}
