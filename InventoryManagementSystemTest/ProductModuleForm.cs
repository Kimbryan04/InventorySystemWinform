using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemTest
{
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            cbcat.Items.Clear();
            cm = new SqlCommand("SELECT name FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbcat.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbproduct(pname,qty,price,[desc],pcategory)VALUES(@pname,@qty,@price,@desc,@pcategory)", con);
                    cm.Parameters.AddWithValue("@pname",txtpname.Text);
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(txtqty.Text));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(txtprice.Text));
                    cm.Parameters.AddWithValue("@desc", txtdesc.Text);
                    cm.Parameters.AddWithValue("@pcategory", cbcat.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been successfully saved.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtpname.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtdesc.Clear();
            cbcat.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET pname = @pname,qty = @qty,price = @price, [desc] = @desc, pcategory = @pcategory WHERE product_id LIKE '" + lblPId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@pname", txtpname.Text);
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(txtqty.Text));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(txtprice.Text));
                    cm.Parameters.AddWithValue("@desc", txtdesc.Text);
                    cm.Parameters.AddWithValue("@pcategory", cbcat.Text);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
