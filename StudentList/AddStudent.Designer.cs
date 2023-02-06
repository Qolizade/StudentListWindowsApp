using System;

namespace StudentList
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblBirtdate = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblCityofBirth = new System.Windows.Forms.Label();
            this.lblFieldofStudy = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtCityofBirth = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbGraduated = new System.Windows.Forms.CheckBox();
            this.cboFieldOfStudy = new System.Windows.Forms.ComboBox();
            this.lblMessageStudentID = new System.Windows.Forms.Label();
            this.lblMessageNationalCode = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 121);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(150, 34);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(223, 118);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(468, 41);
            this.txtFullName.TabIndex = 0;
            // 
            // lblBirtdate
            // 
            this.lblBirtdate.AutoSize = true;
            this.lblBirtdate.Location = new System.Drawing.Point(12, 235);
            this.lblBirtdate.Name = "lblBirtdate";
            this.lblBirtdate.Size = new System.Drawing.Size(137, 34);
            this.lblBirtdate.TabIndex = 1;
            this.lblBirtdate.Text = "Birthdate:";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(12, 349);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(197, 34);
            this.lblNationalCode.TabIndex = 1;
            this.lblNationalCode.Text = "National Code:";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(223, 350);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(468, 41);
            this.txtNationalCode.TabIndex = 4;
            this.txtNationalCode.TextChanged += new System.EventHandler(this.txtNationalCode_TextChanged);
            this.txtNationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalCode_KeyPress);
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(12, 463);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(157, 34);
            this.lblEntryDate.TabIndex = 1;
            this.lblEntryDate.Text = "Entry Date:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(697, 121);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(159, 34);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(697, 238);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(187, 34);
            this.lblFatherName.TabIndex = 1;
            this.lblFatherName.Text = "Father Name:";
            // 
            // lblCityofBirth
            // 
            this.lblCityofBirth.AutoSize = true;
            this.lblCityofBirth.Location = new System.Drawing.Point(697, 355);
            this.lblCityofBirth.Name = "lblCityofBirth";
            this.lblCityofBirth.Size = new System.Drawing.Size(171, 34);
            this.lblCityofBirth.TabIndex = 1;
            this.lblCityofBirth.Text = "City of Birth:";
            // 
            // lblFieldofStudy
            // 
            this.lblFieldofStudy.AutoSize = true;
            this.lblFieldofStudy.Location = new System.Drawing.Point(697, 472);
            this.lblFieldofStudy.Name = "lblFieldofStudy";
            this.lblFieldofStudy.Size = new System.Drawing.Size(194, 34);
            this.lblFieldofStudy.TabIndex = 1;
            this.lblFieldofStudy.Text = "Field of Study:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(908, 118);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(455, 41);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_KeyPress);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(908, 235);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(455, 41);
            this.txtFatherName.TabIndex = 3;
            // 
            // txtCityofBirth
            // 
            this.txtCityofBirth.Location = new System.Drawing.Point(908, 352);
            this.txtCityofBirth.Name = "txtCityofBirth";
            this.txtCityofBirth.Size = new System.Drawing.Size(455, 41);
            this.txtCityofBirth.TabIndex = 5;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(223, 234);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(468, 41);
            this.dtpBirthdate.TabIndex = 2;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(223, 466);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(468, 41);
            this.dtpEntryDate.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Location = new System.Drawing.Point(1165, 648);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 119);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbGraduated
            // 
            this.cbGraduated.AutoSize = true;
            this.cbGraduated.Location = new System.Drawing.Point(18, 577);
            this.cbGraduated.Name = "cbGraduated";
            this.cbGraduated.Size = new System.Drawing.Size(170, 38);
            this.cbGraduated.TabIndex = 8;
            this.cbGraduated.Text = "Graduated";
            this.cbGraduated.UseVisualStyleBackColor = true;
            this.cbGraduated.CheckedChanged += new System.EventHandler(this.cbGraduated_CheckedChanged);
            // 
            // cboFieldOfStudy
            // 
            this.cboFieldOfStudy.FormattingEnabled = true;
            this.cboFieldOfStudy.Location = new System.Drawing.Point(908, 469);
            this.cboFieldOfStudy.Name = "cboFieldOfStudy";
            this.cboFieldOfStudy.Size = new System.Drawing.Size(455, 42);
            this.cboFieldOfStudy.TabIndex = 7;
            this.cboFieldOfStudy.SelectedIndexChanged += new System.EventHandler(this.cboFieldOfStudy_SelectedIndexChanged);
            // 
            // lblMessageStudentID
            // 
            this.lblMessageStudentID.AutoSize = true;
            this.lblMessageStudentID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMessageStudentID.Location = new System.Drawing.Point(908, 166);
            this.lblMessageStudentID.Name = "lblMessageStudentID";
            this.lblMessageStudentID.Size = new System.Drawing.Size(0, 29);
            this.lblMessageStudentID.TabIndex = 11;
            // 
            // lblMessageNationalCode
            // 
            this.lblMessageNationalCode.AutoSize = true;
            this.lblMessageNationalCode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMessageNationalCode.Location = new System.Drawing.Point(223, 398);
            this.lblMessageNationalCode.Name = "lblMessageNationalCode";
            this.lblMessageNationalCode.Size = new System.Drawing.Size(0, 29);
            this.lblMessageNationalCode.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(961, 648);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 119);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(223, 44);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 41);
            this.txtID.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(54, 34);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID:";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 779);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMessageNationalCode);
            this.Controls.Add(this.lblMessageStudentID);
            this.Controls.Add(this.cboFieldOfStudy);
            this.Controls.Add(this.cbGraduated);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txtCityofBirth);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFieldofStudy);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.lblCityofBirth);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lblBirtdate);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cboFieldOfStudy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBirtdate;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblCityofBirth;
        private System.Windows.Forms.Label lblFieldofStudy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbGraduated;
        private System.Windows.Forms.Label lblMessageStudentID;
        private System.Windows.Forms.Label lblMessageNationalCode;
        public System.Windows.Forms.TextBox txtFullName;
        public System.Windows.Forms.TextBox txtNationalCode;
        public System.Windows.Forms.TextBox txtStudentID;
        public System.Windows.Forms.TextBox txtFatherName;
        public System.Windows.Forms.TextBox txtCityofBirth;
        public System.Windows.Forms.DateTimePicker dtpBirthdate;
        public System.Windows.Forms.DateTimePicker dtpEntryDate;
        public System.Windows.Forms.ComboBox cboFieldOfStudy;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}