namespace QuestionBank.App
{
    partial class frmAddOrEditQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditQuestion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLesson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboQuestionTypes = new System.Windows.Forms.ComboBox();
            this.gbQuestionOptions = new System.Windows.Forms.GroupBox();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.cboOptionsCount = new System.Windows.Forms.ComboBox();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.lblOptionsCount = new System.Windows.Forms.Label();
            this.lblOption4 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cboDifficulty = new System.Windows.Forms.ComboBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            this.gbQuestionOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLessons);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دروس";
            // 
            // dgvLessons
            // 
            this.dgvLessons.AllowUserToAddRows = false;
            this.dgvLessons.AllowUserToDeleteRows = false;
            this.dgvLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LessonId,
            this.LessonName});
            this.dgvLessons.Location = new System.Drawing.Point(6, 19);
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.ReadOnly = true;
            this.dgvLessons.Size = new System.Drawing.Size(232, 383);
            this.dgvLessons.TabIndex = 0;
            this.dgvLessons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLessons_CellClick);
            // 
            // LessonId
            // 
            this.LessonId.DataPropertyName = "LessonId";
            this.LessonId.HeaderText = "شماره درس";
            this.LessonId.Name = "LessonId";
            this.LessonId.ReadOnly = true;
            this.LessonId.Visible = false;
            // 
            // LessonName
            // 
            this.LessonName.DataPropertyName = "Name";
            this.LessonName.HeaderText = "نام درس";
            this.LessonName.Name = "LessonName";
            this.LessonName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "درس :";
            // 
            // txtLesson
            // 
            this.txtLesson.Location = new System.Drawing.Point(262, 12);
            this.txtLesson.Name = "txtLesson";
            this.txtLesson.ReadOnly = true;
            this.txtLesson.Size = new System.Drawing.Size(360, 20);
            this.txtLesson.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "متن سوال :";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(262, 44);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuestion.Size = new System.Drawing.Size(360, 58);
            this.txtQuestion.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "نوع سوال :";
            // 
            // cboQuestionTypes
            // 
            this.cboQuestionTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionTypes.FormattingEnabled = true;
            this.cboQuestionTypes.Location = new System.Drawing.Point(500, 112);
            this.cboQuestionTypes.Name = "cboQuestionTypes";
            this.cboQuestionTypes.Size = new System.Drawing.Size(121, 21);
            this.cboQuestionTypes.TabIndex = 1;
            this.cboQuestionTypes.SelectedValueChanged += new System.EventHandler(this.cboQuestionTypes_SelectedValueChanged);
            // 
            // gbQuestionOptions
            // 
            this.gbQuestionOptions.Controls.Add(this.txtOption4);
            this.gbQuestionOptions.Controls.Add(this.cboOptionsCount);
            this.gbQuestionOptions.Controls.Add(this.txtOption2);
            this.gbQuestionOptions.Controls.Add(this.lblOptionsCount);
            this.gbQuestionOptions.Controls.Add(this.lblOption4);
            this.gbQuestionOptions.Controls.Add(this.lblOption2);
            this.gbQuestionOptions.Controls.Add(this.txtOption3);
            this.gbQuestionOptions.Controls.Add(this.lblOption3);
            this.gbQuestionOptions.Controls.Add(this.txtOption1);
            this.gbQuestionOptions.Controls.Add(this.lblOption1);
            this.gbQuestionOptions.Location = new System.Drawing.Point(262, 153);
            this.gbQuestionOptions.Name = "gbQuestionOptions";
            this.gbQuestionOptions.Size = new System.Drawing.Size(418, 267);
            this.gbQuestionOptions.TabIndex = 4;
            this.gbQuestionOptions.TabStop = false;
            this.gbQuestionOptions.Text = "گزینه های سوال";
            this.gbQuestionOptions.Visible = false;
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(5, 191);
            this.txtOption4.Multiline = true;
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(353, 25);
            this.txtOption4.TabIndex = 7;
            // 
            // cboOptionsCount
            // 
            this.cboOptionsCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOptionsCount.FormattingEnabled = true;
            this.cboOptionsCount.Items.AddRange(new object[] {
            "2",
            "4"});
            this.cboOptionsCount.Location = new System.Drawing.Point(206, 32);
            this.cboOptionsCount.Name = "cboOptionsCount";
            this.cboOptionsCount.Size = new System.Drawing.Size(121, 21);
            this.cboOptionsCount.TabIndex = 3;
            this.cboOptionsCount.SelectedValueChanged += new System.EventHandler(this.cboOptionsCount_SelectedValueChanged);
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(6, 103);
            this.txtOption2.Multiline = true;
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(353, 25);
            this.txtOption2.TabIndex = 5;
            // 
            // lblOptionsCount
            // 
            this.lblOptionsCount.AutoSize = true;
            this.lblOptionsCount.Location = new System.Drawing.Point(333, 35);
            this.lblOptionsCount.Name = "lblOptionsCount";
            this.lblOptionsCount.Size = new System.Drawing.Size(78, 13);
            this.lblOptionsCount.TabIndex = 1;
            this.lblOptionsCount.Text = "تعداد گزینه ها :";
            // 
            // lblOption4
            // 
            this.lblOption4.AutoSize = true;
            this.lblOption4.Location = new System.Drawing.Point(364, 197);
            this.lblOption4.Name = "lblOption4";
            this.lblOption4.Size = new System.Drawing.Size(47, 13);
            this.lblOption4.TabIndex = 0;
            this.lblOption4.Text = "گزینه ۴ :";
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.Location = new System.Drawing.Point(365, 109);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(47, 13);
            this.lblOption2.TabIndex = 0;
            this.lblOption2.Text = "گزینه ۲ :";
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(5, 147);
            this.txtOption3.Multiline = true;
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(353, 25);
            this.txtOption3.TabIndex = 6;
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.Location = new System.Drawing.Point(364, 153);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(47, 13);
            this.lblOption3.TabIndex = 0;
            this.lblOption3.Text = "گزینه ۳ :";
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(6, 59);
            this.txtOption1.Multiline = true;
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(353, 25);
            this.txtOption1.TabIndex = 4;
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.Location = new System.Drawing.Point(365, 65);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(47, 13);
            this.lblOption1.TabIndex = 0;
            this.lblOption1.Text = "گزینه ۱ :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "افزودن";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(422, 115);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(74, 13);
            this.lblDifficulty.TabIndex = 1;
            this.lblDifficulty.Text = "سختی سوال : ";
            // 
            // cboDifficulty
            // 
            this.cboDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDifficulty.FormattingEnabled = true;
            this.cboDifficulty.Items.AddRange(new object[] {
            "آسان",
            "متوسط",
            "سخت"});
            this.cboDifficulty.Location = new System.Drawing.Point(295, 112);
            this.cboDifficulty.Name = "cboDifficulty";
            this.cboDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cboDifficulty.TabIndex = 2;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtLesson;
            this.requiredFieldValidator1.ErrorMessage = "لطفا یک درس را از لیست انتخاب کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtQuestion;
            this.requiredFieldValidator2.ErrorMessage = "لطفا متن سوال را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // frmAddOrEditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 461);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbQuestionOptions);
            this.Controls.Add(this.cboDifficulty);
            this.Controls.Add(this.cboQuestionTypes);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLesson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEditQuestion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن سوال";
            this.Load += new System.EventHandler(this.frmAddOrEditQuestion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            this.gbQuestionOptions.ResumeLayout(false);
            this.gbQuestionOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLessons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLesson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboQuestionTypes;
        private System.Windows.Forms.GroupBox gbQuestionOptions;
        private System.Windows.Forms.ComboBox cboOptionsCount;
        private System.Windows.Forms.Label lblOptionsCount;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.Label lblOption4;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cboDifficulty;
    }
}