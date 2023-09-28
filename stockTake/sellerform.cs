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
using System.IO;

namespace stockTake
{
    public partial class sellerform : Form
    {
        public sellerform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\source\repos\stockTake\stockTake\SMMSD.mdf;Integrated Security=True");
       
        private void populative()
        {
            conn.Open();
            string query = "select * from sellerstbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Sellersdgv.DataSource = ds.Tables[0];
            conn.Close();

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string query = "insert into sellerstbl values(" + txtId.Text + ",'" + txtName.Text + "','" + txtsellerage.Text + "'," + txtPhone.Text + ",'" + txtsellerPassword + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added successfully");
                conn.Close();
                populative();
                txtId.Text = "";
                txtName.Text = "";
                txtsellerage.Text = "";
                txtPhone.Text = "";
                txtsellerPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtName.Text == "" || txtsellerage.Text == "" || txtPhone.Text == "" || txtsellerPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string query = "update sellerstbl set SellerName='" + txtName.Text + "',SellerAge=" + txtsellerage.Text + ",SellerPhone=" + txtPhone.Text + ",SellerPassword=" + txtsellerPassword + "' where Sellerid=" + txtId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated successfully");
                    conn.Close();
                    populative();
                    txtId.Text = "";
                    txtName.Text = "";
                    txtsellerage.Text = "";
                    txtPhone.Text = "";
                    txtsellerPassword.Text = "";
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
                    string query = "delete from sellerstbl where Sellerid=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    conn.Close();
                    populative();
                    txtId.Text = "";
                    txtName.Text = "";
                    txtsellerage.Text = "";
                    txtPhone.Text = "";
                    txtsellerPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sellerform_Load(object sender, EventArgs e)
        {
            populative();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            catergory cate = new catergory();
             cate.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {

            this.Hide();
            Selling sell= new Selling();
            sell.Show();
        }

        private void txtsellerPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Log = new Login();
            Log.Show();

        }

        private void Sellersdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Sellersdgv.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = Sellersdgv.SelectedRows[0].Cells[1].Value.ToString();
            txtsellerage.Text = Sellersdgv.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = Sellersdgv.SelectedRows[0].Cells[3].Value.ToString();
            txtsellerPassword.Text = Sellersdgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog tfd = new OpenFileDialog();
            tfd.Filter = "Choose image |*.png;*.bmp;*.jpg";
            if(tfd.ShowDialog() == DialogResult.OK)
            { 
                PIC.Image=Image.FromFile(tfd.FileName); 
            
            }
        }
    }
}
