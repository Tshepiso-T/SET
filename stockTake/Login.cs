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
using System.Diagnostics.Eventing.Reader;

namespace stockTake
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        public static string SellerName = "";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\source\repos\stockTake\stockTake\SMMSD.mdf;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("please enter user name and password");
            }
            else
            {
                if (cmbroles1.SelectedIndex > -1)
                {
                    if (cmbroles1.SelectedItem.ToString() == "Admin")
                        

                        {
                        if (txtusername.Text == "Admin" && txtPassword.Text == "Admin")
                        {
                           
                            managerProducts products = new managerProducts();
                            products.Show();
                            this.Hide();
                        }
                 
                    else
                    {
                        MessageBox.Show("If you are admin,enter the correct username and password");
                    }

                }

                

                     else
                    {
                        //MessageBox.Show("you are in the seller section")
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("select * from sellerstbl where SellerName='" + txtusername.Text + "' and SellerPassword='" + txtPassword.Text + "'", conn);
                       SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                       if (dt.Rows.Count>0)
                        {
                            SellerName = txtusername.Text;
                            Dashboard dash = new Dashboard();
                            dash.Show();
                            this.Hide();
                            conn.Close();

                        }
                        else
                        {
                            MessageBox.Show("Wrong username or Password");
                        }
                        conn.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Select the Role to Login");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
