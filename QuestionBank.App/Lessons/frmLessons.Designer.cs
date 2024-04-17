namespace QuestionBank.App
{
    partial class frmLessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLessons));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.btnNewLesson = new System.Windows.Forms.ToolStripButton();
            this.btnEditLesson = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteLesson = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewLesson,
            this.btnEditLesson,
            this.btnDeleteLesson,
            this.btnRefresh,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(388, 93);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.dgvLessons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLessons.Location = new System.Drawing.Point(0, 93);
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.ReadOnly = true;
            this.dgvLessons.Size = new System.Drawing.Size(388, 468);
            this.dgvLessons.TabIndex = 1;
            // 
            // btnNewLesson
            // 
            this.btnNewLesson.AutoSize = false;
            this.btnNewLesson.Image = global::QuestionBank.App.Properties.Resources.New_lesson_icon_ok;
            this.btnNewLesson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewLesson.Name = "btnNewLesson";
            this.btnNewLesson.Size = new System.Drawing.Size(90, 90);
            this.btnNewLesson.Text = "افزودن درس";
            this.btnNewLesson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewLesson.Click += new System.EventHandler(this.btnNewLesson_Click);
            // 
            // btnEditLesson
            // 
            this.btnEditLesson.AutoSize = false;
            this.btnEditLesson.Image = global::QuestionBank.App.Properties.Resources.edit_icon_ok;
            this.btnEditLesson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditLesson.Name = "btnEditLesson";
            this.btnEditLesson.Size = new System.Drawing.Size(90, 90);
            this.btnEditLesson.Text = "ویرایش درس";
            this.btnEditLesson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditLesson.Click += new System.EventHandler(this.btnEditLesson_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.AutoSize = false;
            this.btnDeleteLesson.Image = global::QuestionBank.App.Properties.Resources.delete_icon_ok;
            this.btnDeleteLesson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(90, 90);
            this.btnDeleteLesson.Text = "حذف درس";
            this.btnDeleteLesson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "toolStripButton1";
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
            // frmLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 561);
            this.Controls.Add(this.dgvLessons);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLessons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست دروس";
            this.Load += new System.EventHandler(this.frmLessons_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnNewLesson;
        private System.Windows.Forms.ToolStripButton btnEditLesson;
        private System.Windows.Forms.ToolStripButton btnDeleteLesson;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvLessons;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
    }
}