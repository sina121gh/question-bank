using QuestionBank.DataLayer.Context;
using QuestionBank.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Lessons_Model lesson = new Lessons_Model()
                {
                    Name = "عربی"
                };

                
                

                //db.Lessons.Add(lesson);
                
                db.SaveChanges();
            }
        }
    }
}
