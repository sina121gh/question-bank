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

namespace QuestionBank.App
{
    public partial class frmLessons : Form
    {
        public frmLessons()
        {
            InitializeComponent();
        }

        private void frmLessons_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            dgvLessons.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvLessons.DataSource = db.Lesson.Get();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewLesson_Click(object sender, EventArgs e)
        {
            frmAddOrEditLesson frmAddLesson = new frmAddOrEditLesson();
            if (frmAddLesson.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow != null)
            {
                frmAddOrEditLesson frmEditLesson = new frmAddOrEditLesson();
                frmEditLesson.lessonId = (int)dgvLessons.CurrentRow.Cells[0].Value;

                if (frmEditLesson.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک درس را از لیست انتخاب کنید.");
            }
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Lessons_Model lesson = db.Lesson.GetById(dgvLessons.CurrentRow.Cells[0].Value);
                    if (RtlMessageBox.Show($"آیا از حذف {lesson.Name} مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            db.Lesson.Delete(lesson);
                            db.Save();
                            RtlMessageBox.Show("عملیات با موفقیت انجام شد.");
                            BindGrid();
                        }
                        catch (Exception)
                        {
                            RtlMessageBox.Show("عملیات با شکست مواجه شد.");
                        }
                    }
                }
                
            }
        }
    }
}
