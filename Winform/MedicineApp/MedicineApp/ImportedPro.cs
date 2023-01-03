using MedicineApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MedicineApp
{
    public partial class ImportedPro : Form
    {
        
        public ImportedPro()
        {
            InitializeComponent();
            
            loadProductList();
        }

        private void cbImpNamePartner_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbImpNamePartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbImpNamePartner.Text == "BLACKMORES")
            {
                cbIDImpPartner.SelectedIndex = 0;
                cbIDImpPartner.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            if (cbImpNamePartner.Text == "NATURE MADE")
            {
                cbIDImpPartner.SelectedIndex = 1;
                cbIDImpPartner.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            if (cbImpNamePartner.Text == "KIRKLAND SIGNATURE")
            {
                cbIDImpPartner.SelectedIndex = 2;
                cbIDImpPartner.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            

            //Hide and Show but still store the value in text input
            ImportedProduct importedProduct = new ImportedProduct();
            if(importedProduct.ShowDialog() == DialogResult.Cancel)
            {
                loadProductList();
                this.Show();
            }
            else
            {
                importedProduct.ShowDialog();

            }
            
            
            
        }
        void loadProductList()
        {
            string query = "SELECT * FROM dbo.[TempImpDetail]";
            DataProvider dataProvider = new DataProvider();
            dtgvTempImp.DataSource = dataProvider.ExecuteQuery(query);

            //load Total Pay
            float totalPrice = 0;
            string query2 = "SELECT quantity, priceReceive FROM dbo.[TempImpDetail]";
            using (SqlConnection conn = new SqlConnection(Program.stConn))
            {
                conn.Open();

                //Add data Detail Import Form
                SqlCommand cmd_query2 = new SqlCommand(query2, conn);

                SqlDataReader reader;
                reader = cmd_query2.ExecuteReader();

                while (reader.Read())
                {
                    totalPrice += Int32.Parse(reader["quantity"].ToString()) * float.Parse(reader["priceReceive"].ToString());
                }
                conn.Close();
            }
            if(totalPrice == 0)
            {
                lbTotal.Text = "0.0 $";
            }
            else
            {
                lbTotal.Text = totalPrice.ToString()+".00 $";
            }
        }

        private void dtgvTempImp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnConfirmImp_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO[dbo].[TestingImportReceipt] ([receiptCode],[nameDeli],[codeCompanyDeli],[managerName],[quantityReceipt],[paymethod],[totalPrice])" +
                " VALUES(@RCode, @NameDeli, @CompDeli, @manager, @quantity, @paymethod, @totalprice)";
            String query_detail = "INSERT INTO[dbo].[TestingImportDetailProd] ([receiptCode],[proID],[proName],[proImg],[proDesc],[quantity],[priceReceive])" +
                " VALUES(@RCode, @id, @name, @img, @desc, @quantity, @price)";
            String query_tempdetail = "SELECT * FROM [TempImpDetail] ";
            
            float total_value = 0;
            int total_quantity = 0;
            using (SqlConnection conn = new SqlConnection(Program.stConn))
            {
                conn.Open();

                //Add data Detail Import Form
                SqlCommand cmd_tempdetail = new SqlCommand(query_tempdetail, conn);
                SqlCommand cmd_detail = new SqlCommand(query_detail, conn);
                SqlDataReader reader;
                reader = cmd_tempdetail.ExecuteReader();
                
                while (reader.Read())
                {
                    total_quantity++;
                    total_value += Int32.Parse(reader["quantity"].ToString()) * float.Parse(reader["priceReceive"].ToString());
                    cmd_detail.Parameters.Add(new SqlParameter("@RCode", rtbOrderName.Text));
                    cmd_detail.Parameters.Add(new SqlParameter("@id", Int32.Parse(reader["proID"].ToString())));
                    cmd_detail.Parameters.Add(new SqlParameter("@name", reader["proName"].ToString()));
                    cmd_detail.Parameters.Add(new SqlParameter("@img", reader["proImg"].ToString()));
                    cmd_detail.Parameters.Add(new SqlParameter("@desc", reader["proDesc"].ToString()));
                    cmd_detail.Parameters.Add(new SqlParameter("@quantity", Int32.Parse(reader["quantity"].ToString())));
                    cmd_detail.Parameters.Add(new SqlParameter("@price", float.Parse(reader["priceReceive"].ToString())));


                }
                conn.Close();
                
            }
            using (SqlConnection conn = new SqlConnection(Program.stConn))
            {
                conn.Open();

                MessageBox.Show(total_value.ToString());
                // Create Final Form Import
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@RCode", rtbOrderName.Text));
                cmd.Parameters.Add(new SqlParameter("@NameDeli", cbImpNamePartner.Text));
                cmd.Parameters.Add(new SqlParameter("@CompDeli", cbIDImpPartner.Text));
                cmd.Parameters.Add(new SqlParameter("@manager", rtbManager.Text));
                cmd.Parameters.Add(new SqlParameter("@quantity", total_quantity));
                cmd.Parameters.Add(new SqlParameter("@paymethod", cbPayMethod.Text));
                cmd.Parameters.Add(new SqlParameter("@totalprice", total_value));

                String del_temp = "DELETE FROM [TempImpDetail]";
                SqlCommand cmd_del = new SqlCommand(del_temp, conn);
                cmd_del.ExecuteNonQuery();
                
                try
                {
                    
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error:" + ex.Message);
                }
                           
                MessageBox.Show("Create Import Form successfully!");
                conn.Close();
            }
            ResetForm();
            loadProductList();
        }

        private void btnRefreshImp_Click(object sender, EventArgs e)
        {
            loadProductList();
        }

        private void btnImpDel_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.stConn);
            conn.Open();
            String sSQL = "DELETE FROM dbo.TempImpDetail WHERE [proID]=@PID";
            int selectedIndex = dtgvTempImp.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvTempImp.Rows[selectedIndex];
            int cellValue = Int32.Parse( selectedRow.Cells[0].Value.ToString());
            
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
            
            loadProductList();
        }

        private void ResetForm()
        {
            rtbOrderName.Text = "";
            rtbManager.Text = "";
            dtpImpDate.Text = "";
            cbPayMethod.Text = "";
            cbImpNamePartner.Text = "";
            cbIDImpPartner.Text = "";


        }
    }
}
