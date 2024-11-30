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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ProductModuleForm moduleForm = new ProductModuleForm();
            moduleForm.btnsave.Enabled = true;
            moduleForm.btnupdate.Enabled = false;
            moduleForm.ShowDialog();
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            dvgproduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname,qty,price,[desc],pcategory) LIKE '%" + textBox1.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvgproduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dvgproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgproduct.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                ProductModuleForm productModule = new ProductModuleForm();
                productModule.lblPId.Text = dvgproduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.txtpname.Text = dvgproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.txtqty.Text = dvgproduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.txtprice.Text = dvgproduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.txtdesc.Text = dvgproduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.cbcat.Text = dvgproduct.Rows[e.RowIndex].Cells[6].Value.ToString();


                productModule.btnsave.Enabled = false;
                productModule.btnupdate.Enabled = true;
                productModule.ShowDialog();

            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE product_id LIKE '" + dvgproduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Successfully deleted!");
                }
            }
            LoadProduct();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txtsearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
