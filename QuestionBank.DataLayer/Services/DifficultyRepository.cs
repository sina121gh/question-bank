using QuestionBank.DataLayer.Context;
using QuestionBank.ViewModels.Difficulty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.DataLayer.Services
{
    public class DifficultyRepository
    {
        MyContext db;

        public DifficultyRepository(MyContext context)
        {
            db = context;
        }

        public string GetDifficultyNameById(int id)
        {
            return db.QuestionDifficulteis.Find(id).Difficulty;
        }

        public int GetDifficultyIdByName(string difficulty)
        {
            return db.QuestionDifficulteis.Single(d => d.Difficulty == difficulty).DifficultyId;
        }

        public List<DifficultiesListViewModel> GetDifficulties()
        {
            return db.QuestionDifficulteis.Select(d => new DifficultiesListViewModel
            {
                DifficultyId = d.DifficultyId,
                Difficulty = d.Difficulty,
            }).ToList();
        }
    }
}
