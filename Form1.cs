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

namespace Electricity_Billing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=""Electricity Billing System"";Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUname.Text == string.Empty || txtPass.Text == string.Empty)
            {
                MessageBox.Show("Required all fields to be signed");
            }

            else
            {

                SqlConnection conn = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=""Electricity Billing System"";Integrated Security=True");
                string InsertQuey = "Insert into User_Table (USERNAME,PASSWORD) Values('" + txtUname.Text + "', '" + txtPass.Text + "')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(InsertQuey, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Dashboard dashB = new Dashboard();
                dashB.Show();
                this.Hide();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtUname.Clear();
            txtPass.Clear();
            txtUname.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=""Electricity Billing System"";Integrated Security=True");
            string InsertQuey = "Insert into User_Table (USERNAME,PASSWORD) Values('" + txtUname.Text + "', '" + txtPass.Text + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(InsertQuey, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            txtUname.Clear();
            txtPass.Clear();
            txtUname.Focus();
        }

        private void lblFP_Click(object sender, EventArgs e)
        {
            FPform fPform = new FPform();
            fPform.Show();
        }
    }
}
