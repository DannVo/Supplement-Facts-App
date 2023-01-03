using MedicineApp.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineApp
{
    public partial class ImportedProduct : Form
    {
        public static List<TempImpReceipt> add_value = new List<TempImpReceipt>();
        
        public ImportedProduct()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //set background color panel
            




        }

        

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelImp_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*
            ImportedPro importedPro = new ImportedPro();
            importedPro.ShowDialog();
            importedPro = null;
            this.Show();*/

        }

        

        private void richTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rtbIDProduct_TextChanged(object sender, EventArgs e)
        {
            String id = rtbIDProduct.Text;
            String query = "SELECT [proID],[proName],[proImg],[proDesc],[priceReceived] FROM [TestingProduct] WHERE " +
            "proID='" + rtbIDProduct.Text + "' ";
            DataProvider dataProvider = new DataProvider();
            
            using (SqlConnection conn = new SqlConnection(Program.stConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (id != "\n" && id!="\r" && id != "\r\n" && id != null  && id != "")
                {
                    

                    if (reader.Read()) 
                    {
                        rtbNamePro.Text = reader["proName"].ToString();
                        rtbImagePro.Text = reader["proImg"].ToString();
                        rtbDescPro.Text = reader["proDesc"].ToString();
                    }

                }
                conn.Close();

            }
        }

        private void btnAddImpProd_Click(object sender, EventArgs e)
        {
            TempImpReceipt list = new TempImpReceipt();
            list.ProID = Int32.Parse(rtbIDProduct.Text);
            list.ProName = rtbNamePro.Text.ToString();
            list.ProImg = rtbImagePro.Text.ToString();
            list.ProDesc = rtbDescPro.Text.ToString();
            list.Quantity = (int)numQuanti.Value;
            list.Price = float.Parse(rtbImpPrice.Text);
            add_value.Add(list);

            //store in temporary database
            String query = "INSERT INTO [dbo].[TempImpDetail] ([proID] ,[proName],[proImg],[proDesc],[quantity] ,[priceReceive])" +
                " VALUES(@PID, @Name, @Img, @Desc, @quantity, @price)";
            
                using (SqlConnection conn = new SqlConnection(Program.stConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@PID", list.ProID));
                    cmd.Parameters.Add(new SqlParameter("@Name", list.ProName));
                    cmd.Parameters.Add(new SqlParameter("@Img", list.ProImg));
                    cmd.Parameters.Add(new SqlParameter("@Desc", list.ProDesc));
                    cmd.Parameters.Add(new SqlParameter("@quantity",list.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@price", list.Price));
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error:" + ex.Message);
                    }
                    MessageBox.Show("Add successfully!");
                conn.Close();
                    
                }
                this.Hide();





        }
    }
}
