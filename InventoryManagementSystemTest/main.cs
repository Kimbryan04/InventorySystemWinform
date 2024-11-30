using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemTest
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) 
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;  
            childForm.Dock = DockStyle.Fill;   
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm());
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new dvgcategory());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm());
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderForm());
        }
    }
}
