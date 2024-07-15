namespace examprac
{
    partial class frmTeachers
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgrdList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtID = new TextBox();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            txtSex = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgrdList).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(682, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(568, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 1;
            // 
            // dgrdList
            // 
            dgrdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdList.Location = new Point(282, 103);
            dgrdList.Name = "dgrdList";
            dgrdList.RowHeadersWidth = 51;
            dgrdList.Size = new Size(506, 335);
            dgrdList.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(79, 293);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(79, 348);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(79, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(30, 65);
            txtID.Name = "txtID";
            txtID.Size = new Size(220, 27);
            txtID.TabIndex = 6;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(30, 112);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(220, 27);
            txtFullname.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(30, 224);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(220, 27);
            txtSex.TabIndex = 9;
            // 
            // frmTeachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSex);
            Controls.Add(txtEmail);
            Controls.Add(txtFullname);
            Controls.Add(txtID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgrdList);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "frmTeachers";
            Text = "frmTeachers";
            Load += frmTeachers_Load;
            ((System.ComponentModel.ISupportInitialize)dgrdList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgrdList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtID;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private TextBox txtSex;
    }
}