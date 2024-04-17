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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuestionBank.App
{
    public partial class frmNewExam : Form
    {
        bool isFirst = true;
        List<Question_Model> selectedQuestions = new List<Question_Model>();
        List<Question_Model> filterdQuestions = new List<Question_Model>();
        public frmNewExam()
        {
            InitializeComponent();
        }

        private void frmNewExam_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            Filter((int)cboFilterByType.SelectedValue, (int)cboFilterByDifficulty.SelectedValue, (int)cboFilterByLesson.SelectedValue);
            BindGridSelectedQuestions();
            isFirst = false;
        }


        void BindGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;
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

                BindGridAllQuestions(result);
                filterdQuestions = result.ToList();
            }
        }

        void BindGridAllQuestions(IEnumerable<Question_Model> filterdQuestions)
        {
            BindGrid(dgvAllQuestions);

            using (UnitOfWork db = new UnitOfWork())
            {
                dgvAllQuestions.Rows.Clear();

                foreach (var question in filterdQuestions)
                {
                    string type = db.TypeRepository.GetTypeById(question.TypeId);
                    string difficulty = db.DifficultyRepository.GetDifficultyNameById(question.DifficultyId);
                    string lesson = db.LessonRepository.GetLessonNameById(question.LessonId);

                    dgvAllQuestions.Rows.Add(question.QuestionId, question.Question, lesson, type, difficulty);
                }
            }
        }

        void BindGridSelectedQuestions()
        {
            BindGrid(dgvSelectedQuestions);

            using (UnitOfWork db = new UnitOfWork())
            {
                dgvSelectedQuestions.Rows.Clear();

                foreach (var question in selectedQuestions)
                {
                    string type = db.TypeRepository.GetTypeById(question.TypeId);
                    string difficulty = db.DifficultyRepository.GetDifficultyNameById(question.DifficultyId);
                    string lesson = db.LessonRepository.GetLessonNameById(question.LessonId);

                    dgvSelectedQuestions.Rows.Add(question.QuestionId, question.Question, lesson, type, difficulty);
                }
            }
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
                    LessonName = "همه دروس",
                });


                difficulties.Add(new DifficultiesListViewModel
                {
                    DifficultyId = 0,
                    Difficulty = "همه سختی ها",
                });

                types.Add(new TypesListViewModel
                {
                    TypeId = 0,
                    Type = "همه نوع ها"
                });

                lessons.AddRange(db.LessonRepository.GetLessonsNames());
                difficulties.AddRange(db.DifficultyRepository.GetDifficulties());
                types.AddRange(db.TypeRepository.GetTypes());



                cboFilterByLesson.DataSource = lessons;
                cboFilterByDifficulty.DataSource = difficulties;
                cboFilterByType.DataSource = types;



                cboFilterByLesson.ValueMember = "LessonId";
                cboFilterByLesson.DisplayMember = "LessonName";

                cboFilterByDifficulty.ValueMember = "DifficultyId";
                cboFilterByDifficulty.DisplayMember = "Difficulty";

                cboFilterByType.ValueMember = "TypeId";
                cboFilterByType.DisplayMember = "Type";
            }
        }

        private void ComboBoxesSelectedValueChanged(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Filter();
            }
            else
                Filter((int)cboFilterByType.SelectedValue, (int)cboFilterByDifficulty.SelectedValue, (int)cboFilterByLesson.SelectedValue);
        }


        void ShowQuestionsDetails()
        {
            dgvSelectedQuestions.Columns["LessonId"].Visible = true;
            dgvSelectedQuestions.Columns["TypeId"].Visible = true;
            dgvSelectedQuestions.Columns["DifficultyId"].Visible = true;
        }

        void HideQuestionsDetails()
        {
            dgvSelectedQuestions.Columns["LessonId"].Visible = false;
            dgvSelectedQuestions.Columns["TypeId"].Visible = false;
            dgvSelectedQuestions.Columns["DifficultyId"].Visible = false;
        }

        void HideColumn(string columnName)
        {
            dgvSelectedQuestions.Columns[columnName].Visible = false;
        }

        void ShowColumn(string columnName)
        {
            dgvSelectedQuestions.Columns[columnName].Visible = true;
        }
        private void btnShowType_Click(object sender, EventArgs e)
        {
            ShowColumn("TypeId");
        }

        private void btnShowDifficulty_Click(object sender, EventArgs e)
        {
            ShowColumn("DifficultyId");
        }

        private void btnShowLesson_Click(object sender, EventArgs e)
        {
            ShowColumn("LessonId");
        }

        private void ShowAllQuestionsDetails(object sender, EventArgs e)
        {
            ShowQuestionsDetails();
        }

        private void HideAllQuestionsDetails(object sender, EventArgs e)
        {
            HideQuestionsDetails();
        }

        private void btnHideType_Click(object sender, EventArgs e)
        {
            HideColumn("TypeId");
        }

        private void btnHideDifficulty_Click(object sender, EventArgs e)
        {
            HideColumn("DifficultyId");
        }

        private void btnHideLesson_Click(object sender, EventArgs e)
        {
            HideColumn("LessonId");
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (RtlMessageBox.Show("آیا از حذف همه سوالات مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectedQuestions.Clear();
                BindGridSelectedQuestions();
            }
        }

        private void btnSelectQuestion_Click(object sender, EventArgs e)
        {
            if (dgvAllQuestions.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int questionId = (int)dgvAllQuestions.CurrentRow.Cells[0].Value;
                    if (IsQuestionValid(questionId))
                    {
                        selectedQuestions.Add(db.Question.GetById(questionId));
                        BindGridSelectedQuestions();
                    }
                    else
                        RtlMessageBox.Show("سوال قبلا وارد شده");
                }
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dgvSelectedQuestions.CurrentRow != null)
            {
                int questionId = (int)dgvSelectedQuestions.CurrentRow.Cells[0].Value;
                var question = selectedQuestions.Single(q => q.QuestionId == questionId);
                selectedQuestions.Remove(question);
                BindGridSelectedQuestions();
            }
            else
                RtlMessageBox.Show("لطفا یک سوال را از لیست انتخاب کنید.");
        }

        bool IsQuestionValid(int questionId)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                if (selectedQuestions.SingleOrDefault(q => q.QuestionId == questionId) != null)
                    return false;
                else
                    return true;
            }
        }

        private void btnGenerateQuestions_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Random rand = new Random();
                for (int i = 1; i <= txtQuestionsCount.Value;)
                {
                    int index = rand.Next(0, filterdQuestions.Count);
                    int questionId = filterdQuestions[index].QuestionId;
                    if (IsQuestionValid(questionId))
                    {
                        selectedQuestions.Add(db.Question.GetById(questionId));
                        BindGridSelectedQuestions();
                        i++;

                        if (selectedQuestions.Count == filterdQuestions.Count)
                        {
                            break;
                        }
                    }

                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Number");
            dt.Columns.Add("Question");

            int questionNumber = 1;
            bool isTest;
            List<QuestionOptions> options;
            foreach (DataGridViewRow row in dgvSelectedQuestions.Rows)
            {
                dt.Rows.Add(
                    questionNumber++,
                    row.Cells[1].Value.ToString()
                    );

                using (UnitOfWork db = new UnitOfWork())
                {
                    int typeId = db.TypeRepository.GetIdByType(row.Cells["TypeId"].Value.ToString());
                    isTest = db.TypeRepository.IsTestQuestion(typeId);
                    options = db.Question.GetById((int)row.Cells[0].Value).QuestionOptions.ToList();
                }

                if (isTest)
                {
                    string optionsString = "";
                    for (int i = options.Count - 1; i >= 0; i--)
                    {
                        if (i == 0)
                        {
                            optionsString += $"{options[i].Option} ●";
                        }
                        else
                            optionsString += $"{options[i].Option} ●\t\t\t\t";
                    }
                    dt.Rows.Add(
                        "Options",
                        optionsString
                        );
                }
            }
            stiReport.Load(Application.StartupPath + "/Report.mrt");
            stiReport.RegData("DT", dt);

            if ((int)cboFilterByLesson.SelectedValue > 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    stiReport.ReportName = db.LessonRepository.GetLessonNameById((int)cboFilterByLesson.SelectedValue);
                }
            }
            else
                stiReport.ReportName = "همه دروس";

            stiReport.Show();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var question in filterdQuestions)
            {
                if (IsQuestionValid(question.QuestionId))
                {
                    selectedQuestions.Add(question);
                }
            }
            BindGridSelectedQuestions();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            selectedQuestions.Clear();
            BindGridSelectedQuestions();
        }
    }
}
