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
using DocumentFormat.OpenXml.Wordprocessing;


namespace stockTake
{
    public partial class Leads : Form
    {
        public Leads()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\OneDrive\Documents\stock.mdf;Integrated Security=True;Connect Timeout=30");
        string Status;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into Leedstbl values(" + txtIDN.Text + ",'" + txtCompanyName.Text + "','" + txtEmail.Text + "'," + txtDirectContact.Text + ",'" + txtUnit.Text + ",'"  + cmbRegion.SelectedValue.ToString()+"'" + txtPostal.Text + ",'" + Status+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company added successfully");
                conn.Close();
                txtCompanyName.Text = "";
                txtEmail.Text = "";
                txtDirectContact.Text = "";
                txtAddress.Text = "";
                txtUnit.Text = "";
                txtPostal.Text = "";
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void chkCold_CheckedChanged(object sender, EventArgs e)
        {
            Status = "Cold";
        }

        private void chkHot_CheckedChanged(object sender, EventArgs e)
        {
            Status = "Hot";
        }

        private void chkWarm_CheckedChanged(object sender, EventArgs e)
        {
            Status = "Warm"; 

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
