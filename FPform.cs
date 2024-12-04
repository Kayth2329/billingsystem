using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Billing_System
{
    public partial class FPform : Form
    {
        public FPform()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=""Electricity Billing System"";Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbClose, "Close");
        }
        
        private void btnVerify_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=""Electricity Billing System"";Integrated Security=True");
            try
            {
                string pass = ("SELECT PASSWORD FROM User_Table WHERE USERNAME =  '" + txtUserForgotP.Text + "' ", conn).ToString();
                MessageBox.Show("Your Password is " + pass + "." , "Information", MessageBoxButtons.OK , MessageBoxIcon.Information);


            }
            catch
            {
                MessageBox.Show("Invalid Username");
            }
        }
    }
}
