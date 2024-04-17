using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionBank.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLessonsList_Click(object sender, EventArgs e)
        {
            frmLessons frmLessons = new frmLessons();
            //frmLessons.ShowDialog();

            await Task.Run(() =>
            {
                frmLessons.ShowDialog();
            });
        }

        private async void btnQuestionsList_Click(object sender, EventArgs e)
        {
            frmQuestions frmQuestions = new frmQuestions();
            //frmQuestions.ShowDialog();

            await Task.Run(() =>
            {
                frmQuestions.ShowDialog();
            });
        }

        private async void btnNewExam_Click(object sender, EventArgs e)
        {
            frmNewExam frmNewExam = new frmNewExam();
            //frmNewExam.ShowDialog();

            await Task.Run(() =>
            {
                frmNewExam.ShowDialog();
            });
        }
    }
}
