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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stockTake
{
    public partial class RequestQ : Form
    {
        public RequestQ()
        {
            InitializeComponent();
        }
        int grdtotal = 0, n = 0;

        const double GP = 0;

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\source\repos\stockTake\stockTake\SMMSD.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select ProdId,ProdName,ProdQty,ProdPrice,ProdCat from Productstbl where ProdId= @ProdId", conn);
            cmd.Parameters.AddWithValue("ProdId", txtPartNumber.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["ProdName"].ToString();
                txtQuantity.Text = reader["ProdQty"].ToString();
                txtPrice.Text = reader["ProdPrice"].ToString();
               


            }
            else
            {
                MessageBox.Show("Data not found");
            }
            conn.Close();
        }

        private void txtPartNumber_TextChanged(object sender, EventArgs e)
        {
            txtPartNumber.Enabled = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
                txtName.Enabled = false;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.Enabled = true;    
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            

            if (txtName.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                

                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(OrdersDGV);
                newrow.Cells[0].Value = n + 1;
                newrow.Cells[1].Value = txtName.Text;
                newrow.Cells[2].Value = txtQuantity.Text;
                newrow.Cells[3].Value = txtPrice.Text;
                newrow.Cells[4].Value = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                newrow.Cells[5].Value = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text)*0.25;
                OrdersDGV.Rows.Add(newrow);
                n++;
                
                grdtotal = grdtotal + total;
               
                lblAmount.Text = "" + grdtotal;

                double GP= grdtotal*grdtotal;


                lblGp.Text = "" + GP;
                


            }
        }
    }
}
