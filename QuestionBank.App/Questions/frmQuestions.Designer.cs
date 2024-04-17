namespace QuestionBank.App
{
    partial class frmQuestions
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
            this.btnNewQuestion = new System.Windows.Forms.ToolStripButton();
            this.btnEditQuestion = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteQuestion = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.QuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboLesson = new System.Windows.Forms.ComboBox();
            this.cboDifficulty = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewQuestion,
            this.btnEditQuestion,
            this.btnDeleteQuestion,
            this.btnRefresh,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(190, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(393, 93);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.AutoSize = false;
            this.btnNewQuestion.Image = global::QuestionBank.App.Properties.Resources.plus_icon_ok;
            this.btnNewQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(90, 90);
            this.btnNewQuestion.Text = "افزودن سوال";
            this.btnNewQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.AutoSize = false;
            this.btnEditQuestion.Image = global::QuestionBank.App.Properties.Resources.edit_icon_ok;
            this.btnEditQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(90, 90);
            this.btnEditQuestion.Text = "ویرایش سوال";
            this.btnEditQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.AutoSize = false;
            this.btnDeleteQuestion.Image = global::QuestionBank.App.Properties.Resources.delete_icon_ok;
            this.btnDeleteQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(90, 90);
            this.btnDeleteQuestion.Text = "حذف سوال";
            this.btnDeleteQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.Image = global::QuestionBank.App.Properties.Resources.refresh_icon_ok;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 90);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionId,
            this.TypeId,
            this.DifficultyId,
            this.LessonId,
            this.Question});
            this.dgvQuestions.Location = new System.Drawing.Point(0, 96);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.Size = new System.Drawing.Size(583, 266);
            this.dgvQuestions.TabIndex = 2;
            // 
            // QuestionId
            // 
            this.QuestionId.DataPropertyName = "QuestionId";
            this.QuestionId.HeaderText = "شماره سوال";
            this.QuestionId.Name = "QuestionId";
            this.QuestionId.ReadOnly = true;
            this.QuestionId.Visible = false;
            // 
            // TypeId
            // 
            this.TypeId.DataPropertyName = "TypeId";
            this.TypeId.HeaderText = "نوع سوال";
            this.TypeId.Name = "TypeId";
            this.TypeId.ReadOnly = true;
            // 
            // DifficultyId
            // 
            this.DifficultyId.DataPropertyName = "DifficultyId";
            this.DifficultyId.HeaderText = "درجه سختی";
            this.DifficultyId.Name = "DifficultyId";
            this.DifficultyId.ReadOnly = true;
            // 
            // LessonId
            // 
            this.LessonId.DataPropertyName = "LessonId";
            this.LessonId.HeaderText = "درس";
            this.LessonId.Name = "LessonId";
            this.LessonId.ReadOnly = true;
            // 
            // Question
            // 
            this.Question.DataPropertyName = "Question";
            this.Question.HeaderText = "سوال";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            // 
            // cboLesson
            // 
            this.cboLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLesson.FormattingEnabled = true;
            this.cboLesson.Location = new System.Drawing.Point(12, 12);
            this.cboLesson.Name = "cboLesson";
            this.cboLesson.Size = new System.Drawing.Size(175, 21);
            this.cboLesson.TabIndex = 3;
            this.cboLesson.SelectedValueChanged += new System.EventHandler(this.ComboBoxesSelectedValueChanged);
            // 
            // cboDifficulty
            // 
            this.cboDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDifficulty.FormattingEnabled = true;
            this.cboDifficulty.Location = new System.Drawing.Point(12, 39);
            this.cboDifficulty.Name = "cboDifficulty";
            this.cboDifficulty.Size = new System.Drawing.Size(175, 21);
            this.cboDifficulty.TabIndex = 3;
            this.cboDifficulty.SelectedValueChanged += new System.EventHandler(this.ComboBoxesSelectedValueChanged);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(12, 66);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(175, 21);
            this.cboType.TabIndex = 3;
            this.cboType.SelectedValueChanged += new System.EventHandler(this.ComboBoxesSelectedValueChanged);
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboDifficulty);
            this.Controls.Add(this.cboLesson);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuestions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست سوالات";
            this.Load += new System.EventHandler(this.frmQuestions_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewQuestion;
        private System.Windows.Forms.ToolStripButton btnEditQuestion;
        private System.Windows.Forms.ToolStripButton btnDeleteQuestion;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cboLesson;
        private System.Windows.Forms.ComboBox cboDifficulty;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
    }
}