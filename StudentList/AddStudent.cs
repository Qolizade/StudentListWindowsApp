using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentList
{
    public partial class AddStudent : Form
    {
        public static AddStudent instance;
        string Graduated;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5E84K8C\\QOLIZADE;Initial Catalog=DBStudent;integrated security=true");
        public AddStudent()
        {
            InitializeComponent();
            instance = this;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

            HandleFieldOfStudyData();

        }



        private void HandleFieldOfStudyData()
        {
            try
            {
                using (DBStudentEntities db = new DBStudentEntities())
                {
                    cboFieldOfStudy.DataSource = db.TblFindOfStudies.ToList();
                    cboFieldOfStudy.ValueMember = "FindOfStudy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentID.TextLength > 12 || txtStudentID.TextLength < 12)
            {
                lblMessageStudentID.Text = "The entered number must be 12 digits";
                Color Red = Color.Red;
                lblMessageStudentID.ForeColor = Red;
            }
            else
            {
                lblMessageStudentID.Text = "Success";
                Color Green = Color.Green;
                lblMessageStudentID.ForeColor = Green;
            }
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalCode.TextLength > 10 || txtNationalCode.TextLength < 10)
            {
                lblMessageNationalCode.Text = "The entered number must be 10 digits";
                Color Red = Color.Red;
                lblMessageNationalCode.ForeColor = Red;
            }
            else
            {
                lblMessageNationalCode.Text = "Success";
                Color Green = Color.Green;
                lblMessageNationalCode.ForeColor = Green;
            }
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            HandleEventTargetSaveBtn();
            StudentList.instance.HanldeDataGridView();
        }

        private void HandleSaveButton()
        {

            SqlCommand cmdCheckStudentID = new SqlCommand("SELECT (StudentID) FROM TblStudent where StudentID= '" + txtStudentID.Text + "'", conn);
            SqlCommand cmdCheckNationalCode = new SqlCommand("SELECT (NasionalCode) FROM TblStudent where NasionalCode= '" + txtNationalCode.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmdCheckStudentID);
            SqlDataAdapter sdnc = new SqlDataAdapter(cmdCheckNationalCode);
            DataTable dt = new DataTable();
            DataTable dtnc = new DataTable();
            sd.Fill(dt);
            sdnc.Fill(dtnc);
            if (dt.Rows.Count >= 1 || dtnc.Rows.Count >= 1)
            {
                MessageBox.Show("The entered number is repeated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [TblStudent](FullName,StudentID,Birthday,FatherName,NasionalCode,CityofBirth,EntryDate,FK_FieldOfStudy,Graduated)VALUES" + "('" + txtFullName.Text + "','" + txtStudentID.Text + "','" + dtpBirthdate.Value + "','" + txtFatherName.Text + "','" + txtNationalCode.Text + "','" + txtCityofBirth.Text + "','" + dtpEntryDate.Value + "','" + cboFieldOfStudy.Text + "','" + cbGraduated.Checked + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtFullName.Text = "";
                txtStudentID.Text = "";
                txtFatherName.Text = "";
                txtNationalCode.Text = "";
                txtCityofBirth.Text = "";
                cbGraduated.Checked = false;
                MessageBox.Show("The data was saved correctly");
            }





        }

        private void HandleEventTargetSaveBtn()
        {
            if (txtStudentID.TextLength > 12 || txtStudentID.Text.Length < 12 || txtStudentID.TextLength == 0)
            {
                MessageBox.Show("Please enter the number correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNationalCode.TextLength > 10 || txtNationalCode.TextLength < 10 || txtNationalCode.TextLength == 0)
            {
                MessageBox.Show("Please enter the number correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFullName.TextLength == 0 || txtFatherName.TextLength == 0 || txtCityofBirth.TextLength == 0 || cboFieldOfStudy.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpBirthdate.Value > dtpEntryDate.Value)
            {
                MessageBox.Show("The date of birth entered is greater than the date of graduation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleSaveButton();
            }
        }


        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HandleEventTargetUpdateBtn();
            StudentList.instance.HanldeDataGridView();
        }

        private void HandleUpdateButton()
        {
            SqlCommand cmdCheckStudentID = new SqlCommand("SELECT (StudentID) FROM TblStudent where StudentID= '" + txtStudentID.Text + "'", conn);
            SqlCommand cmdCheckNationalCode = new SqlCommand("SELECT (NasionalCode) FROM TblStudent where NasionalCode= '" + txtNationalCode.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmdCheckStudentID);
            SqlDataAdapter sdnc = new SqlDataAdapter(cmdCheckNationalCode);
            DataTable dt = new DataTable();
            DataTable dtnc = new DataTable();
            sd.Fill(dt);
            sdnc.Fill(dtnc);
            if (dt.Rows.Count >= 1 || dtnc.Rows.Count >= 1)
            {
                MessageBox.Show("The entered number is repeated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TblStudent SET FullName='" + txtFullName.Text + "',StudentID='" + txtStudentID.Text + "',Birthday='" + dtpBirthdate.Value + "',FatherName='" + txtFatherName.Text + "',NasionalCode='" + txtNationalCode.Text + "',CityofBirth='" + txtCityofBirth.Text + "',EntryDate='" + dtpEntryDate.Value + "',FK_FieldOfStudy='" + cboFieldOfStudy.Text + "',Graduated='" + cbGraduated.Checked + "'WHERE ID='" + txtID.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txtFullName.Text = "";
                txtStudentID.Text = "";
                txtFatherName.Text = "";
                txtNationalCode.Text = "";
                txtCityofBirth.Text = "";
                cbGraduated.Checked = false;
                MessageBox.Show("The data was Update correctly");
            }


        }

        private void HandleEventTargetUpdateBtn()
        {
            if (txtStudentID.TextLength > 12 || txtStudentID.Text.Length < 12 || txtStudentID.TextLength == 0)
            {
                MessageBox.Show("Please enter the number correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNationalCode.TextLength > 10 || txtNationalCode.TextLength < 10 || txtNationalCode.TextLength == 0)
            {
                MessageBox.Show("Please enter the number correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFullName.TextLength == 0 || txtFatherName.TextLength == 0 || txtCityofBirth.TextLength == 0 || cboFieldOfStudy.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpBirthdate.Value > dtpEntryDate.Value)
            {
                MessageBox.Show("The date of birth entered is greater than the date of graduation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleUpdateButton();
            }
        }



        private void cbGraduated_CheckedChanged(object sender, EventArgs e)
        {
            Graduated = "Yes";
        }
    }
}
