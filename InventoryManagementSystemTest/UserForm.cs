using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemTest
{
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr; 
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dvguser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvguser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.btnsave.Enabled = true;
            userModule.btnupdate.Enabled = false;
            userModule.btndelete.Enabled = true;
            userModule.ShowDialog();
            LoadUser();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dvguser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvguser.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtusername.Text = dvguser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtfname.Text = dvguser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtpass.Text = dvguser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtphone.Text = dvguser.Rows[e.RowIndex].Cells[4].Value.ToString();

                
                userModule.btnupdate.Enabled = true;
                userModule.btndelete.Enabled = false;
                userModule.btnsave.Enabled = false; 
                userModule.txtusername.Enabled = false;
                userModule.ShowDialog();

            }else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbUser WHERE username LIKE '" + dvguser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Successfully deleted!");
                }
            }
            LoadUser();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
