namespace examprac
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboSchool = new ComboBox();
            btnSearch = new Button();
            btnTeacher = new Button();
            btnSubject = new Button();
            txtSearch = new TextBox();
            dgrdData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgrdData).BeginInit();
            SuspendLayout();
            // 
            // cboSchool
            // 
            cboSchool.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSchool.FormattingEnabled = true;
            cboSchool.Location = new Point(88, 29);
            cboSchool.Name = "cboSchool";
            cboSchool.Size = new Size(314, 28);
            cboSchool.TabIndex = 0;
            cboSchool.SelectedIndexChanged += cboSchool_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(615, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Location = new Point(615, 209);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(94, 29);
            btnTeacher.TabIndex = 2;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnSubject
            // 
            btnSubject.Location = new Point(615, 285);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(94, 29);
            btnSubject.TabIndex = 3;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += btnSubject_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(457, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 27);
            txtSearch.TabIndex = 4;
            // 
            // dgrdData
            // 
            dgrdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdData.Location = new Point(54, 113);
            dgrdData.Name = "dgrdData";
            dgrdData.RowHeadersWidth = 51;
            dgrdData.Size = new Size(477, 292);
            dgrdData.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgrdData);
            Controls.Add(txtSearch);
            Controls.Add(btnSubject);
            Controls.Add(btnTeacher);
            Controls.Add(btnSearch);
            Controls.Add(cboSchool);
            Name = "frmMain";
            Text = "MainForm";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgrdData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSchool;
        private Button btnSearch;
        private Button btnTeacher;
        private Button btnSubject;
        private TextBox txtSearch;
        private DataGridView dgrdData;
    }
}
