using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using System.Data.SqlClient;
using ClosedXML.Excel;

namespace stockTake
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        { 

        }
        int currentPage = 1;
        int pageSize = 40;

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMMSDDataSet.Productstbl' table. You can move, or remove it, as needed.
            this.productstblTableAdapter.Fill(this.sMMSDDataSet.Productstbl);
            cmbColum.SelectedIndex = 1;
            tempBindingSource.DataSource = new List<temp>();

            using (SMMSDEntities db = new SMMSDEntities())
               

            {
                IPagedList<Productstbl> list=db.Productstbls.OrderBy(p => p.ProdId).ToPagedList(currentPage, pageSize);
                productsBindingSource.DataSource = list.ToList();
            }
        }
        Bitmap bep;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView2.Height = dataGridView2.RowCount * dataGridView2.RowTemplate.Height * 2;
            bep = new Bitmap(dataGridView2.Width, height);
             dataGridView2.DrawToBitmap(bep, new Rectangle(0,0, dataGridView2.Width, dataGridView2.Height));
            dataGridView2.Height=height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bep,0,0);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    productsBindingSource1.Filter = string.Empty;
                else
                    productsBindingSource1.Filter = string.Format("{0}='{1}'", cmbColum.Text, txtSearch.Text);



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tshep\source\repos\stockTake\stockTake\SMMSD.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select ProdId,ProdName,ProdQty,ProdPrice,ProdCat from Productstbl where ProdId= @ProdId", conn);
            cmd.Parameters.AddWithValue("ProdId", textBox1.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader["ProdName"].ToString();
                textBox3.Text = reader["ProdQty"].ToString();
                textBox4.Text = reader["ProdPrice"].ToString();
                textBox5.Text = reader["ProdCat"].ToString();


            }
            else
            {
                MessageBox.Show("Data not found");
            }
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var objchart = chart1.ChartAreas[0];
            //axies X
            objchart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            
            objchart.AxisX.Minimum = 0;
            objchart.AxisX.Maximum = 100000;
            //axies y
            objchart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objchart.AxisY.Minimum = -100;
            objchart.AxisY.Maximum = 100000;
            chart1.Series.Clear();
            Random random = new Random();
            //loop rows
            foreach(temp t in tempBindingSource.DataSource as List<temp>) 
            {
                chart1.Series.Add(t.location);
                chart1.Series[t.location].Color = Color.FromArgb(random.Next(256));
                chart1.Series[t.location].Legend = "Legend1";
                chart1.Series[t.location].ChartArea = "ChartArea1";
                chart1.Series[t.location].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //add Data
                for (int i = 1; i <= 100000; i++)
                    chart1.Series[t.location].Points.AddXY(i, Convert.ToInt32(t[$"H{i}"]));  




            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter="Excel Workbook|*.xlsx"})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(this.sMMSDDataSet.Productstbl.CopyToDataTable(), "Products");
                            wb.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("You have Successfully exported your data to excel file.","message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                    }
                
                }
                    }
        }
    }
}
