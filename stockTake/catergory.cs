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

namespace stockTake
{
    public partial class catergory : Form
    {
        public catergory()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\source\repos\stockTake\stockTake\SMMSD.mdf;Integrated Security=True");
        private void catergory_Load(object sender, EventArgs e)
        {

        }
        private void populative()
        {
            conn.Open();
            string query = "select * from categoriestbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            
            conn.Close();

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)

        { 

        }

        private void categoriesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            MessageBox.Show("Are you sure you want to logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            login.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerProducts products = new managerProducts();
            products.Show();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {    this.Hide();
            sellerform seller=new sellerform();
            seller.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selling sell = new Selling();
            sell.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
