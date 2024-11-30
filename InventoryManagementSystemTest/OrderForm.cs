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
using static System.Windows.Forms.AxHost;

namespace InventoryManagementSystemTest
{
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public OrderForm()
        {
            InitializeComponent();
            LoadOrder();
        }
        public void LoadOrder()
        {
            double total = 0;
            int i = 0;
            dvgorder.Rows.Clear(); 
            cm = new SqlCommand("SELECT orderid, odate, o.pid, p.pname, o.cid, c.cname, o.qty, o.price, o.total FROM tbOrder AS o JOIN tbCustomer as c ON o.cid = c.cid JOIN tbProduct AS p ON o.pid = p.product_Id WHERE CONCAT(orderid, odate, o.pid, p.pname, o.cid, c.cname, o.qty, o.price) LIKE '%"+txtsearchorder.Text+"%' ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvgorder.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                total += Convert.ToInt32(dr[8].ToString());
            }
            dr.Close();
            con.Close();

            lblqty.Text = i.ToString();
            lbltotal.Text = total.ToString();
        }
        private void pictureBox3_Click(object sender, EventArgs e)  
        {
            OrderModuleForm moduleForm = new OrderModuleForm();
            moduleForm.btnorderinsert.Enabled = true;
            moduleForm.ShowDialog();
            LoadOrder();
        }

        private void dvgorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgorder.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this order", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbOrder WHERE orderid LIKE '" + dvgorder.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order Successfully deleted!");

                    cm = new SqlCommand("UPDATE tbproduct SET qty = (qty+@qty) WHERE product_Id LIKE '" + dvgorder.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", con);
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(dvgorder.Rows[e.RowIndex].Cells[5].Value.ToString()));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                }
            }
            LoadOrder();
        }

        private void txtsearchorder_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void lblqty_Click(object sender, EventArgs e)
        {

        }
    }
}
