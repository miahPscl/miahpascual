namespace examprac
{
    partial class frmSubject
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgrdList = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtUnits = new TextBox();
            txtDescription = new TextBox();
            txtCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgrdList).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(90, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(90, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(90, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgrdList
            // 
            dgrdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdList.Location = new Point(282, 103);
            dgrdList.Name = "dgrdList";
            dgrdList.RowHeadersWidth = 51;
            dgrdList.Size = new Size(506, 335);
            dgrdList.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(567, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(681, 57);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(33, 201);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(220, 27);
            txtUnits.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(33, 148);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 27);
            txtDescription.TabIndex = 13;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(33, 101);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(220, 27);
            txtCode.TabIndex = 12;
            // 
            // frmSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUnits);
            Controls.Add(txtDescription);
            Controls.Add(txtCode);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgrdList);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "frmSubject";
            Text = "frmSubject";
            Load += frmSubject_Load;
            ((System.ComponentModel.ISupportInitialize)dgrdList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgrdList;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtUnits;
        private TextBox txtDescription;
        private TextBox txtCode;
    }
}