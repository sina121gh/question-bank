namespace QuestionBank.App
{
    partial class frmNewExam
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
            this.components = new System.ComponentModel.Container();
            this.dgvSelectedQuestions = new System.Windows.Forms.DataGridView();
            this.QuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsQuestionsDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowQuestionsDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowAllDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowType = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowDifficulty = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHideQuestionsDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHideDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHideType = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHideDifficulty = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHideLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllQuestions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFilterByType = new System.Windows.Forms.ComboBox();
            this.cboFilterByDifficulty = new System.Windows.Forms.ComboBox();
            this.cboFilterByLesson = new System.Windows.Forms.ComboBox();
            this.gbAutoSelection = new System.Windows.Forms.GroupBox();
            this.btnGenerateQuestions = new System.Windows.Forms.Button();
            this.txtQuestionsCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.stiReport = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedQuestions)).BeginInit();
            this.cmsQuestionsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuestions)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAutoSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectedQuestions
            // 
            this.dgvSelectedQuestions.AllowUserToAddRows = false;
            this.dgvSelectedQuestions.AllowUserToDeleteRows = false;
            this.dgvSelectedQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionId,
            this.Question,
            this.LessonId,
            this.TypeId,
            this.DifficultyId});
            this.dgvSelectedQuestions.ContextMenuStrip = this.cmsQuestionsDetails;
            this.dgvSelectedQuestions.Location = new System.Drawing.Point(3, 131);
            this.dgvSelectedQuestions.Name = "dgvSelectedQuestions";
            this.dgvSelectedQuestions.ReadOnly = true;
            this.dgvSelectedQuestions.Size = new System.Drawing.Size(495, 401);
            this.dgvSelectedQuestions.TabIndex = 3;
            // 
            // QuestionId
            // 
            this.QuestionId.DataPropertyName = "QuestionId";
            this.QuestionId.HeaderText = "شماره سوال";
            this.QuestionId.Name = "QuestionId";
            this.QuestionId.ReadOnly = true;
            this.QuestionId.Visible = false;
            // 
            // Question
            // 
            this.Question.DataPropertyName = "Question";
            this.Question.HeaderText = "سوال";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            // 
            // LessonId
            // 
            this.LessonId.DataPropertyName = "LessonId";
            this.LessonId.HeaderText = "درس";
            this.LessonId.Name = "LessonId";
            this.LessonId.ReadOnly = true;
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
            // cmsQuestionsDetails
            // 
            this.cmsQuestionsDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowQuestionsDetails,
            this.btnHideQuestionsDetails});
            this.cmsQuestionsDetails.Name = "cmsQuestionsDetails";
            this.cmsQuestionsDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsQuestionsDetails.Size = new System.Drawing.Size(212, 48);
            // 
            // btnShowQuestionsDetails
            // 
            this.btnShowQuestionsDetails.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowAllDetails,
            this.btnShowType,
            this.btnShowDifficulty,
            this.btnShowLesson});
            this.btnShowQuestionsDetails.Name = "btnShowQuestionsDetails";
            this.btnShowQuestionsDetails.Size = new System.Drawing.Size(211, 22);
            this.btnShowQuestionsDetails.Text = "نمایش توضیحات سوال";
            this.btnShowQuestionsDetails.Click += new System.EventHandler(this.ShowAllQuestionsDetails);
            // 
            // btnShowAllDetails
            // 
            this.btnShowAllDetails.Name = "btnShowAllDetails";
            this.btnShowAllDetails.Size = new System.Drawing.Size(135, 22);
            this.btnShowAllDetails.Text = "نمایش همه";
            this.btnShowAllDetails.Click += new System.EventHandler(this.ShowAllQuestionsDetails);
            // 
            // btnShowType
            // 
            this.btnShowType.Name = "btnShowType";
            this.btnShowType.Size = new System.Drawing.Size(135, 22);
            this.btnShowType.Text = "نوع سوال";
            this.btnShowType.Click += new System.EventHandler(this.btnShowType_Click);
            // 
            // btnShowDifficulty
            // 
            this.btnShowDifficulty.Name = "btnShowDifficulty";
            this.btnShowDifficulty.Size = new System.Drawing.Size(135, 22);
            this.btnShowDifficulty.Text = "سختی سوال";
            this.btnShowDifficulty.Click += new System.EventHandler(this.btnShowDifficulty_Click);
            // 
            // btnShowLesson
            // 
            this.btnShowLesson.Name = "btnShowLesson";
            this.btnShowLesson.Size = new System.Drawing.Size(135, 22);
            this.btnShowLesson.Text = "درس";
            this.btnShowLesson.Click += new System.EventHandler(this.btnShowLesson_Click);
            // 
            // btnHideQuestionsDetails
            // 
            this.btnHideQuestionsDetails.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHideDetails,
            this.btnHideType,
            this.btnHideDifficulty,
            this.btnHideLesson});
            this.btnHideQuestionsDetails.Name = "btnHideQuestionsDetails";
            this.btnHideQuestionsDetails.Size = new System.Drawing.Size(211, 22);
            this.btnHideQuestionsDetails.Text = "مخفی کردن توضیحات سوال";
            this.btnHideQuestionsDetails.Click += new System.EventHandler(this.HideAllQuestionsDetails);
            // 
            // btnHideDetails
            // 
            this.btnHideDetails.Name = "btnHideDetails";
            this.btnHideDetails.Size = new System.Drawing.Size(155, 22);
            this.btnHideDetails.Text = "مخفی کردن همه";
            this.btnHideDetails.Click += new System.EventHandler(this.HideAllQuestionsDetails);
            // 
            // btnHideType
            // 
            this.btnHideType.Name = "btnHideType";
            this.btnHideType.Size = new System.Drawing.Size(155, 22);
            this.btnHideType.Text = "نوع سوال";
            this.btnHideType.Click += new System.EventHandler(this.btnHideType_Click);
            // 
            // btnHideDifficulty
            // 
            this.btnHideDifficulty.Name = "btnHideDifficulty";
            this.btnHideDifficulty.Size = new System.Drawing.Size(155, 22);
            this.btnHideDifficulty.Text = "سختی سوال";
            this.btnHideDifficulty.Click += new System.EventHandler(this.btnHideDifficulty_Click);
            // 
            // btnHideLesson
            // 
            this.btnHideLesson.Name = "btnHideLesson";
            this.btnHideLesson.Size = new System.Drawing.Size(155, 22);
            this.btnHideLesson.Text = "درس";
            this.btnHideLesson.Click += new System.EventHandler(this.btnHideLesson_Click);
            // 
            // dgvAllQuestions
            // 
            this.dgvAllQuestions.AllowUserToAddRows = false;
            this.dgvAllQuestions.AllowUserToDeleteRows = false;
            this.dgvAllQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvAllQuestions.ContextMenuStrip = this.cmsQuestionsDetails;
            this.dgvAllQuestions.Location = new System.Drawing.Point(578, 131);
            this.dgvAllQuestions.Name = "dgvAllQuestions";
            this.dgvAllQuestions.ReadOnly = true;
            this.dgvAllQuestions.Size = new System.Drawing.Size(499, 401);
            this.dgvAllQuestions.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QuestionId";
            this.dataGridViewTextBoxColumn1.HeaderText = "شماره سوال";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Question";
            this.dataGridViewTextBoxColumn2.HeaderText = "سوال";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LessonId";
            this.dataGridViewTextBoxColumn3.HeaderText = "درس";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TypeId";
            this.dataGridViewTextBoxColumn4.HeaderText = "نوع سوال";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DifficultyId";
            this.dataGridViewTextBoxColumn5.HeaderText = "درجه سختی";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnSelectQuestion
            // 
            this.btnSelectQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectQuestion.Location = new System.Drawing.Point(504, 299);
            this.btnSelectQuestion.Name = "btnSelectQuestion";
            this.btnSelectQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectQuestion.Size = new System.Drawing.Size(68, 45);
            this.btnSelectQuestion.TabIndex = 1;
            this.btnSelectQuestion.Text = "<=";
            this.btnSelectQuestion.UseVisualStyleBackColor = true;
            this.btnSelectQuestion.Click += new System.EventHandler(this.btnSelectQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQuestion.Location = new System.Drawing.Point(504, 362);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteQuestion.Size = new System.Drawing.Size(68, 45);
            this.btnDeleteQuestion.TabIndex = 2;
            this.btnDeleteQuestion.Text = "=>";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1078, 112);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::QuestionBank.App.Properties.Resources.print_icon_ok;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 90);
            this.toolStripButton1.Text = "چاپ سوالات";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 112);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFilterByType);
            this.groupBox1.Controls.Add(this.cboFilterByDifficulty);
            this.groupBox1.Controls.Add(this.cboFilterByLesson);
            this.groupBox1.Location = new System.Drawing.Point(632, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر کردن سوال";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "فیلتر براساس نوع سوال :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "فیلتر براساس سختی سوال : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "فیلتر براساس درس : ";
            // 
            // cboFilterByType
            // 
            this.cboFilterByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterByType.FormattingEnabled = true;
            this.cboFilterByType.Location = new System.Drawing.Point(6, 73);
            this.cboFilterByType.Name = "cboFilterByType";
            this.cboFilterByType.Size = new System.Drawing.Size(175, 21);
            this.cboFilterByType.TabIndex = 15;
            this.cboFilterByType.SelectedValueChanged += new System.EventHandler(this.ComboBoxesSelectedValueChanged);
            // 
            // cboFilterByDifficulty
            // 
            this.cboFilterByDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterByDifficulty.FormattingEnabled = true;
            this.cboFilterByDifficulty.Location = new System.Drawing.Point(6, 45);
            this.cboFilterByDifficulty.Name = "cboFilterByDifficulty";
            this.cboFilterByDifficulty.Size = new System.Drawing.Size(175, 21);
            this.cboFilterByDifficulty.TabIndex = 16;
            this.cboFilterByDifficulty.SelectedValueChanged += new System.EventHandler(this.ComboBoxesSelectedValueChanged);
            // 
            // cboFilterByLesson
            // 
            this.cboFilterByLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterByLesson.FormattingEnabled = true;
            this.cboFilterByLesson.Location = new System.Drawing.Point(6, 19);
            this.cboFilterByLesson.Name = "cboFilterByLesson";
            this.cboFilterByLesson.Size = new System.Drawing.Size(175, 21);
            this.cboFilterByLesson.TabIndex = 17;
            this.cboFilterByLesson.SelectedValueChanged += new System.EventHandler(this.ComboBoxesSelectedValueChanged);
            // 
            // gbAutoSelection
            // 
            this.gbAutoSelection.Controls.Add(this.btnGenerateQuestions);
            this.gbAutoSelection.Controls.Add(this.txtQuestionsCount);
            this.gbAutoSelection.Controls.Add(this.label7);
            this.gbAutoSelection.Location = new System.Drawing.Point(406, 12);
            this.gbAutoSelection.Name = "gbAutoSelection";
            this.gbAutoSelection.Size = new System.Drawing.Size(207, 100);
            this.gbAutoSelection.TabIndex = 20;
            this.gbAutoSelection.TabStop = false;
            this.gbAutoSelection.Text = "انتخاب سوال به صورت خودکار";
            // 
            // btnGenerateQuestions
            // 
            this.btnGenerateQuestions.Location = new System.Drawing.Point(6, 71);
            this.btnGenerateQuestions.Name = "btnGenerateQuestions";
            this.btnGenerateQuestions.Size = new System.Drawing.Size(187, 23);
            this.btnGenerateQuestions.TabIndex = 16;
            this.btnGenerateQuestions.Text = "افزودن";
            this.btnGenerateQuestions.UseVisualStyleBackColor = true;
            this.btnGenerateQuestions.Click += new System.EventHandler(this.btnGenerateQuestions_Click);
            // 
            // txtQuestionsCount
            // 
            this.txtQuestionsCount.Location = new System.Drawing.Point(6, 26);
            this.txtQuestionsCount.Name = "txtQuestionsCount";
            this.txtQuestionsCount.Size = new System.Drawing.Size(120, 20);
            this.txtQuestionsCount.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "تعداد سوال :";
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.Location = new System.Drawing.Point(504, 236);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddAll.Size = new System.Drawing.Size(68, 45);
            this.btnAddAll.TabIndex = 0;
            this.btnAddAll.Text = "<==";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(504, 426);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemoveAll.Size = new System.Drawing.Size(68, 45);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "==>";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // stiReport
            // 
            this.stiReport.CookieContainer = null;
            this.stiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport.ReportAlias = "Report";
            this.stiReport.ReportGuid = "3f6a1cd76987408ca407199f3740017c";
            this.stiReport.ReportName = "Report";
            this.stiReport.ReportSource = null;
            this.stiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport.UseProgressInThread = false;
            // 
            // frmNewExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 535);
            this.Controls.Add(this.gbAutoSelection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnSelectQuestion);
            this.Controls.Add(this.dgvAllQuestions);
            this.Controls.Add(this.dgvSelectedQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewExam";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ایجاد آزمون";
            this.Load += new System.EventHandler(this.frmNewExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedQuestions)).EndInit();
            this.cmsQuestionsDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuestions)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAutoSelection.ResumeLayout(false);
            this.gbAutoSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectedQuestions;
        private System.Windows.Forms.ContextMenuStrip cmsQuestionsDetails;
        private System.Windows.Forms.ToolStripMenuItem btnShowQuestionsDetails;
        private System.Windows.Forms.ToolStripMenuItem btnHideQuestionsDetails;
        private System.Windows.Forms.ToolStripMenuItem btnShowType;
        private System.Windows.Forms.ToolStripMenuItem btnShowDifficulty;
        private System.Windows.Forms.ToolStripMenuItem btnShowLesson;
        private System.Windows.Forms.ToolStripMenuItem btnHideType;
        private System.Windows.Forms.ToolStripMenuItem btnHideDifficulty;
        private System.Windows.Forms.ToolStripMenuItem btnHideLesson;
        private System.Windows.Forms.ToolStripMenuItem btnShowAllDetails;
        private System.Windows.Forms.ToolStripMenuItem btnHideDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyId;
        private System.Windows.Forms.DataGridView dgvAllQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnSelectQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilterByType;
        private System.Windows.Forms.ComboBox cboFilterByDifficulty;
        private System.Windows.Forms.ComboBox cboFilterByLesson;
        private System.Windows.Forms.GroupBox gbAutoSelection;
        private System.Windows.Forms.Button btnGenerateQuestions;
        private System.Windows.Forms.NumericUpDown txtQuestionsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemoveAll;
        private Stimulsoft.Report.StiReport stiReport;
    }
}