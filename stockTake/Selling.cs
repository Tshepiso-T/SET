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
using System.Drawing.Printing;

namespace stockTake
{
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\source\repos\stockTake\stockTake\SMMSD.mdf;Integrated Security=True");
       
        
        private void populative()
        {

            conn.Open();
            string query = "select ProdName,ProdQty from Productstbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void populativebill()
        { 

            conn.Open();
            string query = "select * from billtbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void fillcategory()
        {//this bind the combobox with the Datebase
            conn.Open();
            SqlCommand cmd = new SqlCommand("select CatName from categoriestbl", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(dr);
            cmbCategory.ValueMember = "CatName";
            cmbCategory.DataSource = dt;
            cmbCategory.ValueMember = "CatName";
            cmbCategory.DataSource = dt;
            conn.Close();

        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            managerProducts products = new managerProducts();
            products.Show();
            this.Hide();
        }

        private void Selling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMMSDDataSet1.categoriestbl' table. You can move, or remove it, as needed.
            this.categoriestblTableAdapter.Fill(this.sMMSDDataSet1.categoriestbl);
            populative();
            populativebill();
            fillcategory();
            lblSellername.Text = Login.SellerName;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Today.Day.ToString()+"/"+DateTime.Today.Year.ToString();
        }
       
        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtQuantity.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
        }
        int grdtotal = 0, n = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            try
            {
                conn.Open();
                string query = "insert into billtbl values(" + txtId.Text + ",'" + lblSellername.Text + "','" + lblDate.Text + "'," + lblAmount.Text + ")";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Orders added successfully");
                conn.Close();
                populativebill();
                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Bakwena IT STOCK Inventory", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(230));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Bill Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("STOCK Inventory", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 230));



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreview.Document = PrintDocument;

            PrintPreview.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populative();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            catergory cat = new catergory();
            cat.Show();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {

            this.Hide();
            sellerform Seller = new sellerform();
            Seller.Show();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select ProdName,ProdQty from Productstble where ProdCat='" + cmbCategory.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void OrdersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            if (txtName.Text ==""|| txtQuantity.Text =="")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                int total= Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(OrdersDGV);
                newrow.Cells[0].Value = n +1;
                newrow.Cells[1].Value = txtName.Text;
                newrow.Cells[2].Value = txtQuantity.Text;
                newrow.Cells[3].Value = txtPrice.Text;
                newrow.Cells[4].Value = Convert.ToInt32(txtPrice.Text)*Convert.ToInt32(txtQuantity.Text);
                OrdersDGV.Rows.Add(newrow);
                n++;
                grdtotal = grdtotal + total;
                lblAmount.Text = "" + grdtotal;
            }
        }
    }
}
