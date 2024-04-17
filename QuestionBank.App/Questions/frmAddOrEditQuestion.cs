using QuestionBank.DataLayer.Context;
using QuestionBank.DataLayer.Models;
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
using ValidationComponents;

namespace QuestionBank.App
{
    public partial class frmAddOrEditQuestion : Form
    {
        public int questionId = 0;
        bool isFirst = true;
        public frmAddOrEditQuestion()
        {
            InitializeComponent();
        }

        private void frmAddOrEditQuestion_Load(object sender, EventArgs e)
        {
            FillTypes();
            BindGrid();
            isFirst = false;
            if (questionId > 0)
            {
                FillInputsToEdit(questionId);
                this.Text = "ویرایش سوال";
                btnSave.Text = "ویرایش";
            }
        }

        public void FillInputsToEdit(int questionId)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Question_Model question = db.Question.GetById(questionId);
                txtLesson.Text = db.LessonRepository.GetLessonNameById(question.LessonId);
                txtQuestion.Text = question.Question;
                cboQuestionTypes.SelectedValue = question.TypeId;
                cboDifficulty.SelectedItem = db.DifficultyRepository.GetDifficultyNameById(question.DifficultyId);
                int optionsCount = question.QuestionOptions.Count;

                if (optionsCount != 0)
                {
                    cboOptionsCount.SelectedItem = optionsCount.ToString();
                    List<QuestionOptions> options = question.QuestionOptions.ToList();

                    txtOption1.Text = options.Single(o => o.OptionNumber == 1).Option;
                    txtOption2.Text = options.Single(o => o.OptionNumber == 2).Option;
                    if (optionsCount == 4)
                    {
                        txtOption3.Text = options.Single(o => o.OptionNumber == 3).Option;
                        txtOption4.Text = options.Single(o => o.OptionNumber == 4).Option;
                    }
                }
            }
        }

        private void dgvLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLessons.CurrentRow != null)
            {
                txtLesson.Text = dgvLessons.CurrentRow.Cells[1].Value.ToString();
            }
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvLessons.AutoGenerateColumns = false;
                dgvLessons.DataSource = db.Lesson.Get();
            }
        }

        void FillTypes()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<TypesListViewModel> types = new List<TypesListViewModel>();

                types.Add(new TypesListViewModel
                {
                    TypeId = 0,
                    Type = "انتخاب کنید"
                });

                types.AddRange(db.TypeRepository.GetTypes());

                cboQuestionTypes.DataSource = types;

                cboQuestionTypes.ValueMember = "TypeId";
                cboQuestionTypes.DisplayMember = "Type";
            }
        }

        private void cboQuestionTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                if (cboQuestionTypes.SelectedIndex > 0)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (IsTestQuestion())
                        {
                            ShowControls(gbQuestionOptions);
                            cboOptionsCount.SelectedIndex = 1;
                        }
                        else
                            HideControls(gbQuestionOptions);
                    }
                }
            }
        }

        private void cboOptionsCount_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboOptionsCount.SelectedItem.ToString() == "2")
            {
                HideControls(lblOption3, lblOption4, txtOption3, txtOption4);
            }
            else
            {
                ShowControls(lblOption3, lblOption4, txtOption3, txtOption4);
            }
        }

        void HideControls(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Visible = false;
            }
        }

        void ShowControls(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (ValidateComboBoxes())
                {
                    bool IsValidate = true;

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        List<QuestionOptions> options = new List<QuestionOptions>();

                        Question_Model question = new Question_Model()
                        {
                            Question = txtQuestion.Text,
                            LessonId = db.LessonRepository.GetLessonIdByName(txtLesson.Text),
                            DifficultyId = db.DifficultyRepository.GetDifficultyIdByName(cboDifficulty.SelectedItem.ToString()),
                            TypeId = db.QuestionType.GetById(cboQuestionTypes.SelectedValue).TypeId,
                        };

                        if (IsTestQuestion())
                        {
                            if (cboOptionsCount.SelectedItem.ToString() == "2")
                            {
                                if (!OptionsValidator(txtOption1, txtOption2))
                                {
                                    RtlMessageBox.Show("لطفا تمامی گزینه ها را وارد کنید.");
                                    IsValidate = false;
                                }
                                else
                                    CreateOptions(options, txtOption1.Text, txtOption2.Text);
                            }
                            else
                            {
                                if (!OptionsValidator(txtOption1, txtOption2, txtOption3, txtOption4))
                                {
                                    RtlMessageBox.Show("لطفا تمامی گزینه ها را وارد کنید.");
                                    IsValidate = false;
                                }
                                else
                                    CreateOptions(options, txtOption1.Text, txtOption2.Text, txtOption3.Text, txtOption4.Text);
                            }

                            if (IsValidate)
                            {
                                AddOptionsToQuestion(questionId, options);
                                question.QuestionOptions = options;
                            }


                        }
                        if (IsValidate)
                        {
                            try
                            {
                                if (questionId == 0)
                                {
                                    InsertOptionsToDataBase(options);
                                    db.Question.Insert(question);
                                }
                                else
                                {
                                    #region Deletes Previous question and creates it again
                                    db.Question.Delete(questionId);

                                    using (UnitOfWork db2 = new UnitOfWork())
                                    {
                                        var oldOptions = db2.Question.GetById(questionId).QuestionOptions.ToList();

                                        foreach (var oldOption in oldOptions)
                                        {
                                            db2.Options.Delete(oldOption);
                                            db2.Save();
                                        }
                                    }

                                    if (IsTestQuestion())
                                    {
                                        InsertOptionsToDataBase(options);
                                    }

                                    db.Question.Insert(question);
                                    #endregion

                                    #region Updates Question And Options
                                    //question.QuestionId = questionId;

                                    //if (IsTestQuestion())
                                    //{
                                    //    using (UnitOfWork db2 = new UnitOfWork())
                                    //    {
                                    //        var oldOptions = db2.Question.GetById(questionId).QuestionOptions.ToList();
                                    //        List<int> ids = new List<int>();

                                    //        foreach (var oldOption in oldOptions)
                                    //            ids.Add(oldOption.OptionId);

                                    //        UpdateOptions(options, ids, questionId);
                                    //    }
                                    //}

                                    //db.Question.Update(question);
                                    #endregion
                                    #region Try to delete previous options and create new ones
                                    //if (IsTestQuestion())
                                    //{

                                    //    InsertOptionsToDataBase(options);
                                    //    db.Question.Update(question);

                                    //    using (UnitOfWork db2 = new UnitOfWork())
                                    //    {
                                    //        var oldOptions = db2.Question.GetById(questionId).QuestionOptions.ToList();

                                    //        foreach (var oldOption in oldOptions)
                                    //        {
                                    //            db2.Options.Delete(oldOption);
                                    //            db2.Save();
                                    //        }
                                    //    }

                                    //}
                                    #endregion
                                }
                                db.Save();
                                MessageBox.Show("عملیات با موفقیت انجام شد");
                                DialogResult = DialogResult.OK;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("عملیات با شکست مواجه شد");
                                DialogResult = DialogResult.Cancel;
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("لطفا یکی از گزینه های لیست هارا انتخاب کنید");
                }
            }
        }

        bool OptionsValidator(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        void CreateOptions(List<QuestionOptions> optionslist, params string[] options)
        {
            int optionNumber = 1;
            foreach (var option in options)
            {
                optionslist.Add(new QuestionOptions
                {
                    Option = option,
                    OptionNumber = optionNumber,
                });
                optionNumber++;
            }
        }

        void AddOptionsToQuestion(int questionId, List<QuestionOptions> options)
        {
            foreach (var option in options)
            {
                option.QuestionId = questionId;
            }
        }

        bool InsertOptionsToDataBase(List<QuestionOptions> optionslist)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                try
                {
                    foreach (var option in optionslist)
                    {
                        db.OptionRepository.Insert(option);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        bool UpdateOptions(List<QuestionOptions> optionslist, List<int> optionsId, int questionId)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                try
                {
                    int i = 0;
                    foreach (var option in optionslist)
                    {
                        option.QuestionId = questionId;
                        option.OptionId = optionsId[i++];
                        db.Options.Update(option);
                        db.Save();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        bool IsTestQuestion()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (db.TypeRepository.IsTestQuestion((int)cboQuestionTypes.SelectedValue))
                    return true;
                else
                    return false;
            }
        }

        bool ValidateComboBoxes()
        {
            if (cboQuestionTypes.SelectedIndex > 0 && cboDifficulty.SelectedIndex >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
