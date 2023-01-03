using MedicineApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineApp
{
    public partial class OrdersStatic : Form
    {
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder sqlCommandBuilder;
        DataTable dataTable;
        public OrdersStatic()
        {
            InitializeComponent();
            loadOrderList();
            AddColumn();
        }
        void loadOrderList()
        {
            string query = "SELECT * FROM dbo.[TestingOrder]";
            
            dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(Program.stConn);
            conn.Open();
            dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(dataTable);
            dtgvOrders.DataSource = dataTable;
            dtgvOrders.AllowUserToAddRows = false;
            conn.Close();

            //load Total Pay
            float totalPrice = 0;
            int total = 0;
            string query2 = "SELECT totalPay FROM dbo.[TestingOrder]";
            using (SqlConnection conn2 = new SqlConnection(Program.stConn))
            {
                conn2.Open();

                //Add data Detail Import Form
                SqlCommand cmd_query2 = new SqlCommand(query2, conn2);

                SqlDataReader reader;
                reader = cmd_query2.ExecuteReader();

                while (reader.Read())
                {
                    total++;
                    if (reader["totalPay"].ToString() == "")
                    {
                        continue;
                    }
                    else
                    {
                        totalPrice += float.Parse(reader["totalPay"].ToString());
                    }

                }
                conn2.Close();
            }
            label2.Text = total.ToString();
            label3.Text = totalPrice.ToString("C2", CultureInfo.CurrentCulture);


        }

        void AddColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            dtgvOrders.Columns.Insert(4, buttonColumn);
            buttonColumn.HeaderText = "Product Details";
            buttonColumn.Width = 100;
            buttonColumn.Text = "View details";
            buttonColumn.UseColumnTextForButtonValue = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Update(dataTable);
            loadOrderList();
        }

        private void dtgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == 0)
            {
                DataGridViewRow row = dtgvOrders.Rows[e.RowIndex];
                string value = row.Cells["orderID"].Value.ToString();
                OrderDetail detail = new OrderDetail(value);
                detail.ShowDialog();
                
            }
        }
        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadOrderList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete " + dtgvOrders.Rows[dtgvOrders.SelectedCells[0].RowIndex].Cells[2].Value + "? This action cannot be undone.", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                SqlConnection conn = new SqlConnection(Program.stConn);
                conn.Open();
                String sSQL = "DELETE FROM dbo.[TestingOrder] WHERE [orderID]=@OID";
                String detail_query = "DELETE FROM dbo.[TestingOrderDetail] WHERE [orderID]=@DID";
                int selectedIndex = dtgvOrders.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvOrders.Rows[selectedIndex];
                string cellValue = Convert.ToString(selectedRow.Cells[1].Value);
                MessageBox.Show(cellValue);
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlCommand cmd2 = new SqlCommand(detail_query, conn);
                cmd2.Parameters.Add(new SqlParameter("@DID", cellValue));
                cmd.Parameters.Add(new SqlParameter("@OID", cellValue));

                try
                {
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error:" + ex.Message);
                }
                MessageBox.Show("Delete successfully!");
                conn.Close();
                loadOrderList();
            }
        }
    }
}
