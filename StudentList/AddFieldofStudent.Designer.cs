namespace StudentList
{
    partial class AddFieldofStudent
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
            this.lblAddFieldofStudent = new System.Windows.Forms.Label();
            this.txtAddFieldofStudent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Field of Student";
            // 
            // lblAddFieldofStudent
            // 
            this.lblAddFieldofStudent.AutoSize = true;
            this.lblAddFieldofStudent.Location = new System.Drawing.Point(12, 127);
            this.lblAddFieldofStudent.Name = "lblAddFieldofStudent";
            this.lblAddFieldofStudent.Size = new System.Drawing.Size(220, 34);
            this.lblAddFieldofStudent.TabIndex = 1;
            this.lblAddFieldofStudent.Text = "Field of Student:";
            // 
            // txtAddFieldofStudent
            // 
            this.txtAddFieldofStudent.Location = new System.Drawing.Point(238, 124);
            this.txtAddFieldofStudent.Name = "txtAddFieldofStudent";
            this.txtAddFieldofStudent.Size = new System.Drawing.Size(465, 41);
            this.txtAddFieldofStudent.TabIndex = 2;
            this.txtAddFieldofStudent.TextChanged += new System.EventHandler(this.txtAddFieldofStudent_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Location = new System.Drawing.Point(709, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddFieldofStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 201);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddFieldofStudent);
            this.Controls.Add(this.lblAddFieldofStudent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddFieldofStudent";
            this.Text = "AddFieldofStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddFieldofStudent;
        private System.Windows.Forms.TextBox txtAddFieldofStudent;
        private System.Windows.Forms.Button btnSave;
    }
}