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
    public partial class AddFieldofStudent : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5E84K8C\\QOLIZADE;Initial Catalog=DBStudent;integrated security=true");
        public AddFieldofStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            handleEventTargetSaveBtn();
        }

        private void HandleSaveBtn()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [TblFindOfStudy](FindOfStudy)VALUES" + "('" + txtAddFieldofStudent.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            txtAddFieldofStudent.Text = "";
            MessageBox.Show("The data was saved correctly");
        }

        private void handleEventTargetSaveBtn()
        {
            if (txtAddFieldofStudent.TextLength == 0)
            {
                MessageBox.Show("Please enter field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleSaveBtn();
            }
        }

        private void txtAddFieldofStudent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
