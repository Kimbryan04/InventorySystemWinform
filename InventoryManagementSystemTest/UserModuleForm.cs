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
using System.Security.Cryptography.X509Certificates;



namespace InventoryManagementSystemTest
{
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtpass != Repass)
                {
                    MessageBox.Show("Password did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbUser(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
                    cm.Parameters.AddWithValue("@username", txtusername.Text);
                    cm.Parameters.AddWithValue("@fullname", txtfname.Text);
                    cm.Parameters.AddWithValue("@password", txtpass.Text);
                    cm.Parameters.AddWithValue("@phone", txtphone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();  
                    con.Close();
                    MessageBox.Show("User has been successfully saved.");
                    Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           Clear();
           btnsave.Enabled = true;
           btnupdate.Enabled = false;
        }

        public void Clear()
        {
            txtusername.Clear();
            txtfname.Clear();
            txtpass.Clear();
            Repass.Clear();
            txtphone.Clear();  
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpass != Repass)
                {
                    MessageBox.Show("Password did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbUser SET fullname = @fullname,password = @password,phone = @phone WHERE username LIKE '"+txtusername.Text+ "' ",  con);
                    cm.Parameters.AddWithValue("@fullname", txtfname.Text);
                    cm.Parameters.AddWithValue("@password", txtpass.Text);
                    cm.Parameters.AddWithValue("@phone", txtphone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully updated!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
