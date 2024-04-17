using QuestionBank.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Repository
{
    public interface IOptionRepository
    {
        ICollection<QuestionOptions> GetAll();
        QuestionOptions GetById(int optionId);
        bool Insert(QuestionOptions option);
        bool Update(QuestionOptions option);
        bool Delete(QuestionOptions option);
        bool Delete(int optionId);
    }
}
