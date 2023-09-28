using Microsoft.VisualBasic;
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

namespace stockTake
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        void fillChart()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\OneDrive\Documents\stock.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Target,SalesMade,GP FROM charttble",conn);
        da.Fill(dt);
            chart1.DataSource = dt;
            conn.Close(); 
            chart1.Series["Target"].XValueMember= "SalesMade";
            chart1.Series["Target"].YValueMembers= "GP(%)";
            chart1.Series["Target"].XValueMember = "Target";

            chart1.Titles.Add( "Sales");

        }
        private void Companys_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        
        fillChart();
        
        
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
           Products product = new Products();
            product.TopLevel = false;
            PanMain.Controls.Add(product);
            product.BringToFront();
            product.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            MessageBox.Show("Are you sure you want to logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            login.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
        catergory cat = new catergory();
            cat.TopLevel = false;
            PanMain.Controls.Add(cat);
            cat.BringToFront();
            cat.Show();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            RequestQ Rq = new RequestQ();
            Rq.TopLevel = false;
            PanMain.Controls.Add(Rq);
            Rq.BringToFront();
            Rq.Show();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            CompaniesForm company= new CompaniesForm();
            company.TopLevel = false;
            PanMain.Controls.Add(company);
            company.BringToFront();
            company.Show();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            Leads leeds = new Leads();
            leeds.TopLevel = false;
            PanMain.Controls.Add(leeds);
            leeds.BringToFront();
            leeds.Show();
           
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            managerProducts products = new managerProducts();
            products.TopLevel = false;
            PanMain.Controls.Add(products);
            products.BringToFront();
            products.Show();

        }

        private void BtnManagerusers_Click(object sender, EventArgs e)
        {
            sellerform user = new sellerform();
            user.TopLevel = false;
            PanMain.Controls.Add(user);
            user.BringToFront();
            user.Show();
        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            About abouts= new About();
            abouts.TopLevel = false;
            PanMain.Controls.Add(abouts);
            abouts.BringToFront();
            abouts.Show();
           

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
