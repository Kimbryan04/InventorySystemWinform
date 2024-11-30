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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystemTest
{
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
        public void LoadCustomer()
        {
            int i = 0;
            dvgcustomers.Rows.Clear();
            cm = new SqlCommand("SELECT cid, cname FROM tbCustomer WHERE CONCAT(cname,cphone) LIKE '%" + txtsearchcust.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvgcustomers.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void LoadProduct()
        {
            int i = 0;
            dvgproduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname,qty,price,[desc],pcategory) LIKE '%" + txtsearchproduct.Text + "%'", con);
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

        private void txtsearchcust_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtsearchproduct_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if (Convert.ToInt16(UDQty.Value) > qty)
            {
                MessageBox.Show("Instock is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQty.Value = UDQty.Value -  1;
                return;
            }
            if (Convert.ToInt16(UDQty.Value) > 0)
            {
                int total = Convert.ToInt16(txtprice.Text) * Convert.ToInt16(UDQty.Value);
                txttotal.Text = total.ToString();
            }
        }

        private void dvgcustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustid.Text = dvgcustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcustname.Text = dvgcustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dvgproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproductid.Text = dvgproduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtproductname.Text = dvgproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtprice.Text = dvgproduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void btnorderinsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcustid.Text == "")
                {
                    MessageBox.Show("Please select a customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please select a product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to insert this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbOrder(odate,pid,cid,qty,price,total)VALUES(@odate,@pid,@cid,@qty,@price,@total)", con);
                    cm.Parameters.AddWithValue("@odate", dtpdate.Value);
                    cm.Parameters.AddWithValue("@pid", Convert.ToInt16(txtproductid.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt16(txtcustid.Text));
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(UDQty.Text));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(txtprice.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt16(txttotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order has been successfully inserted.");
                    

                    cm = new SqlCommand("UPDATE tbproduct SET qty = (qty-@qty) WHERE product_Id LIKE '"+txtproductid.Text+"' ", con);
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(UDQty.Text));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtcustid.Clear();
            txtcustname.Clear();

            txtproductid.Clear();
            txtproductname.Clear();
            txtprice.Clear();
            UDQty.Value = 0;
            dtpdate.Value = DateTime.Now;
        }

        private void btnorderclear_Click(object sender, EventArgs e)
        {
            Clear();
            
        }

        public void GetQty()
        {
            cm = new SqlCommand("SELECT qty FROM tbProduct WHERE product_id = '" + txtproductid.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
