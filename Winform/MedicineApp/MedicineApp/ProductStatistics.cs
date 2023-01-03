using MedicineApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MedicineApp
{
    public partial class ProductStatistics : Form
    {
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder sqlCommandBuilder;
        DataTable dataTable;
        public ProductStatistics()
        {
            InitializeComponent();
            loadProductList();
            lbTitleTable.Text = "List Of Products";

        }

        void loadProductList()
        {
            string query = "SELECT * FROM dbo.[TestingProduct]";
            string query2 = "SELECT [quantity], [priceReceived] FROM dbo.[TestingProduct]";
            dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(Program.stConn);
            conn.Open();
            dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(dataTable);
            dtgvProducts.DataSource = dataTable;
            dtgvProducts.AllowUserToAddRows= false;

            SqlConnection conn2 = new SqlConnection(Program.stConn);
            SqlCommand cmd_query2 = new SqlCommand(query2, conn);
            float totalPrice = 0;
            int total =0;
            SqlDataReader reader;
            reader = cmd_query2.ExecuteReader();
            while (reader.Read())
            {
                total++;
                totalPrice += Int32.Parse(reader["quantity"].ToString()) * float.Parse(reader["priceReceived"].ToString());
            }

            lbTotalGoods.Text = total.ToString();
            lbTotalPrice.Text = totalPrice.ToString("C2", CultureInfo.CurrentCulture);
                /*string.Format("{0:#.000}", Convert.ToDecimal(totalPrice.ToString()) / 100);*/
            
        }

        void loadImpReceiptList()
        {
            string query = "SELECT * FROM dbo.[TestingImportReceipt]";
            dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(Program.stConn);
            dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(dataTable);
            dtgvProducts.DataSource = dataTable;
            dtgvProducts.AllowUserToAddRows = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(cbType.SelectedIndex == 0)
            {
                loadProductList();

            }
            if(cbType.SelectedIndex == 1)
            {
                loadImpReceiptList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete "+ dtgvProducts.Rows[dtgvProducts.SelectedCells[0].RowIndex].Cells[1].Value + "? This action cannot be undone.", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                
                SqlConnection conn = new SqlConnection(Program.stConn);
                conn.Open();
                String sSQL = "DELETE FROM dbo.[TestingProduct] WHERE [proID]=@PID";
                int selectedIndex = dtgvProducts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvProducts.Rows[selectedIndex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
                MessageBox.Show(cellValue);
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@PID", cellValue));
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error:" + ex.Message);
                }
                MessageBox.Show("Delete successfully!");
                conn.Close();
                loadProductList();
            }
        }

        private void dtgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cell: column
            
            DataGridViewRow selectedRow = dtgvProducts.Rows[0];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
            /*MessageBox.Show(cellValue);*/
        }

        private void dtgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (cbType.SelectedIndex == 1)
            {
                if (dtgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    label2.Text = "Manager:";
                    label3.Text = "Code:";
                    label4.Text = "Firm:";
                    label5.Text = "ID Firm:";
                    label6.Text = "Order Date:";

                    //id, name, price, quantity, daterec
                    label8.Text = dtgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label9.Text = dtgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label10.Text = dtgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                    label11.Text = dtgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label12.Text = dtgvProducts.Rows[e.RowIndex].Cells[6].Value.ToString();

                    /*MessageBox.Show(dtgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());*/
                }
            }
            else
            {
                if (dtgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //id, name, price, quantity, daterec
                    label8.Text = dtgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    label9.Text = dtgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label10.Text = float.Parse(dtgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString("C2", CultureInfo.CurrentCulture);
                    label11.Text = dtgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label12.Text = dtgvProducts.Rows[e.RowIndex].Cells[7].Value.ToString();

                    /*MessageBox.Show(dtgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());*/
                }
                else
                {
                    btnDelete_Click(sender, e);
                }
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbType.SelectedIndex == 1)
            {
                loadImpReceiptList();
                lbTitleTable.Text = "List Of Receipts";

            }
            else
            { 
                loadProductList();
                lbTitleTable.Text = "List Of Products";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO [dbo].[TestingProduct] ([proName] ,[proImg],[proDesc] ,[quantity] ,[priceDeli] ,[priceReceived] ,[dateReceive])" +
                " VALUES(@Name, @Img, @Desc, @quantity, @priceSell, @priceImp, @dateImp)";

            using (SqlConnection conn = new SqlConnection(Program.stConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);            
                cmd.Parameters.Add(new SqlParameter("@Name", rtbName.Text));
                cmd.Parameters.Add(new SqlParameter("@Img", rtbImg.Text));
                cmd.Parameters.Add(new SqlParameter("@Desc", rtbDesc.Text));
                cmd.Parameters.Add(new SqlParameter("@quantity", numQuanti.Value));
                cmd.Parameters.Add(new SqlParameter("@priceSell", float.Parse( rtbPriceSell.Text)));
                cmd.Parameters.Add(new SqlParameter("@priceImp", float.Parse(rtbPriceImp.Text)));
                cmd.Parameters.Add(new SqlParameter("@dateImp", dtpImpAt.Text));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error:" + ex.Message);
                }
                MessageBox.Show("Add Product Successfully!");
                conn.Close();

            }
        }

        private void rtbPriceImp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rtbPriceSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            
            dataAdapter.Update(dataTable);
        }

        

        
    }
}
