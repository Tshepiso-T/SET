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
    public partial class managerProducts : Form
    {
        public managerProducts()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\source\repos\stockTake\stockTake\SMMSD.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        private void Loadproduct()
        {
            int i = 0;
           
            cmd = new SqlCommand("select * from Productstbl where Contact(ProdName,ProdQty,ProdPrice,ProdCat) LIKE'&", conn);
            conn.Open();
          
            while (dr != null)
            {
                i++;
                categoriesdgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());


            }
            
            conn.Close();


        }
        private void btnSellers_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellerform Seller = new sellerform();
            Seller.Show();
            
        }
        private void FillCategories()
        {
            //this bind the combobox with the Datebase
            conn.Open();
            SqlCommand cmd = new SqlCommand("select CatName from categoriestbl", conn);
            SqlDataReader dr;
            dr= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName",typeof(string));
            dt.Load(dr);
            cmbcategory.ValueMember = "CatName";
            cmbcategory.DataSource= dt;
            cmbcategory.ValueMember = "CatName";
            categoriesdgv.DataSource = dt;
            conn.Close();

        }

        private void populative()
        {
            conn.Open();
            string query = "select * from Productstbl";
            SqlDataAdapter sda =new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            categoriesdgv.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selling sellingP = new Selling();
            sellingP.Show();
            
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Log = new Login();
            Log.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            catergory cat = new catergory();    
            cat.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into Productstbl values(" + txtId.Text + ",'" + txtName.Text + "','" + txtQuantity.Text + "'," +txtPrice.Text+",'"+cmbcategory.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Products added successfully");
                conn.Close();
                populative();
                txtId.Text = "";
                txtName.Text = "";

                txtQuantity.Text = "";
                txtPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void managerProducts_Load(object sender, EventArgs e)
        { 
            FillCategories();
            populative();

        }
       

        private void categoriesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = categoriesdgv.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = categoriesdgv.SelectedRows[0].Cells[1].Value.ToString();
            txtQuantity.Text = categoriesdgv.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = categoriesdgv.SelectedRows[0].Cells[3].Value.ToString();
            cmbcategory.SelectedValue = categoriesdgv.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text==""|| txtName.Text==""|| txtPrice.Text==""||txtQuantity.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string query = "update Productstbl set ProdName='" + txtName.Text + "',ProdQty" + txtQuantity.Text + ",ProdPrice=" + txtPrice.Text + ",ProdCat=" + cmbcategory.SelectedValue.ToString() + "' where Prodid=" + txtId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated successfully");
                    conn.Close();
                    populative();
                    txtId.Text = "";
                    txtName.Text = "";
                   txtPrice.Text = "";
                    txtQuantity.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("select the product you want to delete");
                }
                else
                {
                    conn.Open();
                    string query = "delete from Productstbl where Prodid=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    conn.Close();
                    populative();
                    txtId.Text = "";
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtQuantity.Text = "";
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populative();
        }

        private void cmbsearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from Productstble where ProdCat='" ;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            categoriesdgv.DataSource = ds.Tables[0];
             conn.Close();

        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocument1;
            
                printPreview.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Bakwena IT STOCK Inventory", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + categoriesdgv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(230));
            e.Graphics.DrawString("Seller Name: " + categoriesdgv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Bill Date: " + categoriesdgv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + categoriesdgv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("STOCK Inventory", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 230));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Loadproduct();

        }
    }
}
