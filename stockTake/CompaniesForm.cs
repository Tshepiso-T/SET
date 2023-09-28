using DocumentFormat.OpenXml.Wordprocessing;
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
using System.Data.SqlClient;


namespace stockTake
{
    public partial class CompaniesForm : Form
    {
        public CompaniesForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\OneDrive\Documents\stock.mdf;Integrated Security=True;Connect Timeout=30"); 
        private void btnAdd_Click(object sender, EventArgs e)
        {  
            string Address =txtAddress.Text;
            try
            {


                conn.Open();
                string query = "insert into Productstbl values(" + txtName.Text + ",'" + txtContact.Text + "','" + txtEmail.Text + "'," + txtAddress.Text + ",'" + cmbRegion.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Products added successfully");
                conn.Close();
               

                StringBuilder queryAddress = new StringBuilder();  
                queryAddress.Append("http://maps.google.com/maps?q=");
                if (Address !=string.Empty)
                {
                    queryAddress.Append(Address+ ","+"+");
                }
                webBrowser1.Navigate(queryAddress.ToString());

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error");
                    
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
