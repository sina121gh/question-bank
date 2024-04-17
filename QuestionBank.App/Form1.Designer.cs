namespace QuestionBank.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLessonsList = new System.Windows.Forms.ToolStripButton();
            this.btnQuestionsList = new System.Windows.Forms.ToolStripButton();
            this.btnNewExam = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLessonsList,
            this.btnQuestionsList,
            this.btnNewExam});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(300, 93);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLessonsList
            // 
            this.btnLessonsList.AutoSize = false;
            this.btnLessonsList.Image = global::QuestionBank.App.Properties.Resources.lessons_icon;
            this.btnLessonsList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLessonsList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLessonsList.Name = "btnLessonsList";
            this.btnLessonsList.Size = new System.Drawing.Size(90, 90);
            this.btnLessonsList.Text = "لیست دروس";
            this.btnLessonsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLessonsList.Click += new System.EventHandler(this.btnLessonsList_Click);
            // 
            // btnQuestionsList
            // 
            this.btnQuestionsList.AutoSize = false;
            this.btnQuestionsList.Image = global::QuestionBank.App.Properties.Resources.new_question_icon_ok;
            this.btnQuestionsList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQuestionsList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuestionsList.Name = "btnQuestionsList";
            this.btnQuestionsList.Size = new System.Drawing.Size(90, 90);
            this.btnQuestionsList.Text = "لیست سوالات";
            this.btnQuestionsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuestionsList.Click += new System.EventHandler(this.btnQuestionsList_Click);
            // 
            // btnNewExam
            // 
            this.btnNewExam.AutoSize = false;
            this.btnNewExam.Image = global::QuestionBank.App.Properties.Resources.new_exam_icon_ok;
            this.btnNewExam.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewExam.Name = "btnNewExam";
            this.btnNewExam.Size = new System.Drawing.Size(90, 90);
            this.btnNewExam.Text = "ایجاد آزمون";
            this.btnNewExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewExam.Click += new System.EventHandler(this.btnNewExam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 97);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم اصلی";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnQuestionsList;
        private System.Windows.Forms.ToolStripButton btnLessonsList;
        private System.Windows.Forms.ToolStripButton btnNewExam;
    }
}

