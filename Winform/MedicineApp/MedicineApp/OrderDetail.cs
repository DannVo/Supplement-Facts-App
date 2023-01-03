using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineApp
{
    public partial class OrderDetail : Form
    {
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder sqlCommandBuilder;
        DataTable dataTable;
        public OrderDetail(string orderID)
        {
            InitializeComponent();
            loadDTOrderList(orderID);
        }
        

        public void loadDTOrderList(string id)
        {
            label2.Text= string.Empty;
            label9.Text= string.Empty;
            label10.Text= string.Empty;
            string query = "SELECT * FROM dbo.[TestingOrderDetail] WHERE [orderID]='"+
                id+"'";

            dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(Program.stConn);
            conn.Open();
            dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(dataTable);
            dtgvDtOrder.DataSource = dataTable;
            dtgvDtOrder.AllowUserToAddRows = false;

            dtgvDtOrder.Columns[0].HeaderText= "Order Identity";
            dtgvDtOrder.Columns[1].HeaderText= "ID Product";
            dtgvDtOrder.Columns[2].HeaderText= "Quantity";
            dtgvDtOrder.Columns[3].HeaderText = "Total Price";




        }

        private void dtgvDtOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvDtOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDtOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                

                //id, name, price, quantity, daterec
                label2.Text = dtgvDtOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                label9.Text = dtgvDtOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                label10.Text = dtgvDtOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                label11.Text = dtgvDtOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                

                /*MessageBox.Show(dtgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());*/
            }
        }
    }
}
