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
    public partial class dvgcategory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        
        public dvgcategory()
        {
            InitializeComponent();
            LoadCat();
        }
        public void LoadCat()
        {
            int i = 0;
            dvgcat.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvgcat.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CategoryModuleForm moduleForm = new CategoryModuleForm();
            moduleForm.btnsave.Enabled = true;
            moduleForm.btnupdate.Enabled = false;
            moduleForm.ShowDialog();
            LoadCat();
        }

        private void dvgcat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgcat_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgcat.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                CategoryModuleForm customerModule = new CategoryModuleForm();
                customerModule.lblCatld.Text = dvgcat.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.txtcatname.Text = dvgcat.Rows[e.RowIndex].Cells[2].Value.ToString();
              


                customerModule.btnsave.Enabled = false;
                customerModule.btnupdate.Enabled = true;
                customerModule.ShowDialog();

            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE category_Id LIKE '" + dvgcat.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Successfully deleted!");
                }
            }
            LoadCat();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
