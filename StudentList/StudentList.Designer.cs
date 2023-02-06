using System;

namespace StudentList
{
    partial class StudentList
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
            this.lblStudentList = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddFindOfStudy = new System.Windows.Forms.Button();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbShowGraduated = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentList.Location = new System.Drawing.Point(564, 9);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(394, 72);
            this.lblStudentList.TabIndex = 0;
            this.lblStudentList.Text = "Student List";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete});
            this.dataGridView.Location = new System.Drawing.Point(12, 280);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1478, 488);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddStudent.Location = new System.Drawing.Point(12, 155);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(198, 119);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddFindOfStudy
            // 
            this.btnAddFindOfStudy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddFindOfStudy.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAddFindOfStudy.Location = new System.Drawing.Point(216, 155);
            this.btnAddFindOfStudy.Name = "btnAddFindOfStudy";
            this.btnAddFindOfStudy.Size = new System.Drawing.Size(198, 119);
            this.btnAddFindOfStudy.TabIndex = 2;
            this.btnAddFindOfStudy.Text = "Add Find of Study";
            this.btnAddFindOfStudy.UseVisualStyleBackColor = false;
            this.btnAddFindOfStudy.Click += new System.EventHandler(this.btnAddFindOfStudy_Click);
            // 
            // cbShowGraduated
            // 
            this.cbShowGraduated.AutoSize = true;
            this.cbShowGraduated.Location = new System.Drawing.Point(1243, 236);
            this.cbShowGraduated.Name = "cbShowGraduated";
            this.cbShowGraduated.Size = new System.Drawing.Size(247, 38);
            this.cbShowGraduated.TabIndex = 3;
            this.cbShowGraduated.Text = "Show Graduated";
            this.cbShowGraduated.UseVisualStyleBackColor = true;
            this.cbShowGraduated.CheckedChanged += new System.EventHandler(this.cbShowGraduated_CheckedChanged);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 780);
            this.Controls.Add(this.cbShowGraduated);
            this.Controls.Add(this.btnAddFindOfStudy);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblStudentList);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddFindOfStudy;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.CheckBox cbShowGraduated;
    }
}

