﻿using System;
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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itdep\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if  (checkBox1.Checked == false)
                txtpass.UseSystemPasswordChar = true;
            else
                txtpass.UseSystemPasswordChar = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpass.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", txtname.Text);
                cm.Parameters.AddWithValue("@password", txtpass.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows) 
                {
                    MessageBox.Show("Welcome " + dr["fullname"].ToString() + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main main = new main();
                    this.Hide();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid username or password!",  "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
