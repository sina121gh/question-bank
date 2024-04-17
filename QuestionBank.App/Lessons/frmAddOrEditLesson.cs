using QuestionBank.DataLayer.Context;
using QuestionBank.DataLayer.Models;
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
    public partial class frmAddOrEditLesson : Form
    {
        public int lessonId = 0;
        public frmAddOrEditLesson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Lessons_Model lesson = new Lessons_Model()
                    {
                        Name = txtLessonName.Text
                    };

                    try
                    {
                        if (lessonId == 0)
                            db.Lesson.Insert(lesson);
                        else
                        {
                            lesson.LessonId = lessonId;
                            db.Lesson.Update(lesson);
                        }
                        db.Save();
                        MessageBox.Show("عملیات با موفقیت انجام شد.");
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("عملیات با شکست موجه شد.");
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }
        }

        private void frmAddOrEditLesson_Load(object sender, EventArgs e)
        {
            if (lessonId != 0)
            {
                this.Text = "ویرایش درس";
                btnSave.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    txtLessonName.Text = db.Lesson.GetById(lessonId).Name;
                }
            }
        }
    }
}
