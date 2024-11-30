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
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }
        public void LoadCustomer()
        {
            int i = 0;
            dvgcustomers.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvgcustomers.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dvgcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgcustomers.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                CustomerModuleForm customerModule = new CustomerModuleForm();
                customerModule.lblCld.Text = dvgcustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.txtcname.Text = dvgcustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModule.txtcphone.Text = dvgcustomers.Rows[e.RowIndex].Cells[3].Value.ToString();


                customerModule.btnsave.Enabled = false;
                customerModule.btnupdate.Enabled = true;
                customerModule.ShowDialog();

            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCustomer WHERE cId LIKE '" + dvgcustomers.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Successfully deleted!");
                }
            }
            LoadCustomer();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CustomerModuleForm moduleForm = new CustomerModuleForm();
            moduleForm.btnsave.Enabled = true; 
            moduleForm.btnupdate.Enabled = false;
            moduleForm.ShowDialog();
            LoadCustomer();
        }
    }
}
