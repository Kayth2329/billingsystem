using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Electricity_Billing_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=""Electricity Billing System"";Integrated Security=True");

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnComptotal_Click(object sender, EventArgs e)
        {
            double d1, d2;

            d1 = double.Parse (txtConsumption.Text);
            d2 = double.Parse (txtUprice.Text);

            txtTotal.Text = (d1*d2).ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == string.Empty || txtAdd.Text == string.Empty || txtConnum.Text == string.Empty || txtCurread.Text == string.Empty || txtPreread.Text == string.Empty ||
               txtReadmon.Text == string.Empty || txtConsumption.Text == string.Empty || txtUprice.Text == string.Empty || txtTotal.Text == string.Empty)
            {
                MessageBox.Show("Required all Fields to be signed");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=""Electricity Billing System"";Integrated Security=True");
                string InsertQuey = "insert into Transaction_Table values ('" + txtName.Text + "'," + "'" + txtAdd.Text + "'" + "," + "'" + txtConnum.Text + "'" + "," + "'" + txtCurread.Text + "'" + "," +
                    "" + "'" + txtPreread.Text + "'" + "," +"" + "'" + txtReadmon.Text + "'" + "," + "'" + txtConsumption.Text + "'" + "," + "'" + txtUprice.Text + "'" + "," + "'" + txtTotal.Text + "'" + ")";
                conn.Open();
                SqlCommand cmd = new SqlCommand(InsertQuey, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added Succesfully");
                txtName.Clear();
                txtAdd.Clear();
                txtConnum.Clear();
                txtCurread.Clear();
                txtPreread.Clear();
                txtReadmon.Clear();
                txtConsumption.Clear();
                txtUprice.Clear(); 
                txtTotal.Clear();   
            }

 
        }

        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgv1.Height;
            dgv1.Height = dgv1.RowCount * dgv1.RowTemplate.Height * 2;
            bmp = new Bitmap(dgv1.Width, dgv1.Height);
            dgv1.DrawToBitmap (bmp, new Rectangle (0,0,dgv1.Width,dgv1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgv1.Height = height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=""Electricity Billing System"";Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Transaction_Table", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv1.DataSource = dt;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        private void pbFilter_Click(object sender, EventArgs e)
        {
           
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void FilterDataGridView(string filterText)
        {

            DataView dataView = ((DataTable)dgv1.DataSource).DefaultView;
            dataView.RowFilter = $" NAME LIKE '%{filterText}%'";
            dgv1.ClearSelection();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text;
            FilterDataGridView(filterText);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
