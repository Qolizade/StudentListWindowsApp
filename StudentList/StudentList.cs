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
using System.Reflection;

namespace StudentList
{
    public partial class StudentList : Form
    {
        public static StudentList instance;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5E84K8C\\QOLIZADE;Initial Catalog=DBStudent;integrated security=true");
        public StudentList()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HanldeDataGridView();
        }

        public void HanldeDataGridView()
        {
            conn.Open();
            string query = "SELECT * FROM TblStudent";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var openAddStudentButton = new AddStudent();
            openAddStudentButton.Show();
        }

        private void btnAddFindOfStudy_Click(object sender, EventArgs e)
        {
            var OpenAddFindOfStudyButton = new AddFieldofStudent();
            OpenAddFindOfStudyButton.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want delete this row?", row.Cells["ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM TblStudent WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("ID", row.Cells["ID"].Value);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                HanldeDataGridView();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            AddStudent ads = new AddStudent();
            ads.txtID.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
            ads.txtFullName.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
            ads.txtStudentID.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
            ads.dtpBirthdate.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
            ads.txtFatherName.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
            ads.txtNationalCode.Text = this.dataGridView.CurrentRow.Cells[6].Value.ToString();
            ads.txtCityofBirth.Text = this.dataGridView.CurrentRow.Cells[7].Value.ToString();
            ads.dtpEntryDate.Text = this.dataGridView.CurrentRow.Cells[8].Value.ToString();
            ads.cboFieldOfStudy.Text = this.dataGridView.CurrentRow.Cells[9].Value.ToString();



            ads.ShowDialog();
        }

        private void GrafuatedFilter()
        {
            if (cbShowGraduated.Checked)
            {
                conn.Open();
                string query = "SELECT * FROM TblStudent where Graduated='" + cbShowGraduated.Checked + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();
            }
            else
            {
                HanldeDataGridView();
            }

        }

        private void cbShowGraduated_CheckedChanged(object sender, EventArgs e)
        {
            GrafuatedFilter();
        }
    }
}
