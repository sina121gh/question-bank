using QuestionBank.DataLayer.Context;
using QuestionBank.DataLayer.Models;
using QuestionBank.ViewModels.Difficulty;
using QuestionBank.ViewModels.Lesson;
using QuestionBank.ViewModels.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionBank.App
{
    public partial class frmQuestions : Form
    {
        bool isFirst = true;
        public frmQuestions()
        {
            InitializeComponent();
        }
        private void frmQuestions_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            Filter((int)cboType.SelectedValue, (int)cboDifficulty.SelectedValue, (int)cboLesson.SelectedValue);
            isFirst = false;
        }

        private void Filter(int typeId = 0, int difficultyId = 0, int lessonId = 0)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var result = db.Question.Get();

                if (typeId > 0)
                {
                    result = result.Where(q => q.TypeId == typeId).ToList();
                }

                if (difficultyId > 0)
                {
                    result = result.Where(q => q.DifficultyId == difficultyId).ToList();
                }

                if (lessonId > 0)
                {
                    result = result.Where(q => q.LessonId == lessonId).ToList();
                }

                BindGrid(result);
            }
        }

        private void BindGrid(IEnumerable<Question_Model> res)
        {
            dgvQuestions.AutoGenerateColumns = false;
            dgvQuestions.Columns[1].Visible = false;
            dgvQuestions.Columns[2].Visible = false;
            dgvQuestions.Columns[3].Visible = false;
            dgvQuestions.DataSource = res;
        }

        private void FillComboBoxes()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<LessonsListViewModel> lessons = new List<LessonsListViewModel>();
                List<DifficultiesListViewModel> difficulties = new List<DifficultiesListViewModel>();
                List<TypesListViewModel> types = new List<TypesListViewModel>();

                lessons.Add(new LessonsListViewModel
                {
                    LessonId = 0,
                    LessonName = "فیلتر براساس درس",
                });


                difficulties.Add(new DifficultiesListViewModel
                {
                    DifficultyId = 0,
                    Difficulty = "فیلتر براساس درجه سختی",
                });

                types.Add(new TypesListViewModel
                {
                    TypeId = 0,
                    Type = "فیلتر براساس نوع سوال"
                });

                lessons.AddRange(db.LessonRepository.GetLessonsNames());
                difficulties.AddRange(db.DifficultyRepository.GetDifficulties());
                types.AddRange(db.TypeRepository.GetTypes());



                cboLesson.DataSource = lessons;
                cboDifficulty.DataSource = difficulties;
                cboType.DataSource = types;
                
                

                cboLesson.ValueMember = "LessonId";
                cboLesson.DisplayMember = "LessonName";

                cboDifficulty.ValueMember = "DifficultyId";
                cboDifficulty.DisplayMember = "Difficulty";

                cboType.ValueMember = "TypeId";
                cboType.DisplayMember = "Type";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter((int)cboType.SelectedValue, (int)cboDifficulty.SelectedValue, (int)cboLesson.SelectedValue);
        }

        private void ComboBoxesSelectedValueChanged(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Filter();
            }
            else
                Filter((int)cboType.SelectedValue, (int)cboDifficulty.SelectedValue, (int)cboLesson.SelectedValue);
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            frmAddOrEditQuestion frmAddQuestion = new frmAddOrEditQuestion();
            if (frmAddQuestion.ShowDialog() == DialogResult.OK)
            {
                Filter((int)cboType.SelectedValue, (int)cboDifficulty.SelectedValue, (int)cboLesson.SelectedValue);
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow != null)
            {
                frmAddOrEditQuestion frmEditQuestion = new frmAddOrEditQuestion();
                frmEditQuestion.questionId = (int)dgvQuestions.CurrentRow.Cells[0].Value;
                if (frmEditQuestion.ShowDialog() == DialogResult.OK)
                {
                    Filter((int)cboType.SelectedValue, (int)cboDifficulty.SelectedValue, (int)cboLesson.SelectedValue);
                }
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow != null)
            {
                if (RtlMessageBox.Show("آیا از حذف این سوال مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        try
                        {
                            int questionId = (int)dgvQuestions.CurrentRow.Cells[0].Value;
                            db.Question.Delete(questionId);

                            if (IsTestQuestion(questionId))
                            {
                                List<QuestionOptions> options = db.Options.Get(o => o.QuestionId == questionId).ToList();

                                deleteOptions(options);
                            }

                            db.Save();
                            Filter((int)cboType.SelectedValue, (int)cboDifficulty.SelectedValue, (int)cboLesson.SelectedValue);
                        }
                        catch (Exception)
                        {
                            RtlMessageBox.Show("عملیات با شکست مواجه شد.");
                        }

                    }
                }
            }
        }


        bool deleteOptions(ICollection<QuestionOptions> options)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                try
                {
                    foreach (QuestionOptions option in options)
                    {
                        db.Options.Delete(option);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        bool IsTestQuestion(int questionId)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                int typeId = db.Question.GetById(questionId).TypeId;
                if (db.TypeRepository.IsTestQuestion(typeId))
                {
                    return true;
                }
                else
                    return false;
            }
        }
        
    }
}
