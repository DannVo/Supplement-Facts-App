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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace MedicineApp
{
    public partial class TableManager : Form
    {
        private System.Windows.Forms.Panel activeForm;
        private ToolStripMenuItem currentButton;
        public TableManager()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            
            cbDMstatus.SelectedValue = "Waiting";
            loadProductList();
        }

        void loadProductList()
        {
            string query = "SELECT * FROM dbo.TestingProduct";
            DataProvider dataProvider = new DataProvider();
            dtgvProduct.DataSource = dataProvider.ExecuteQuery(query);
        }

        private void goodsDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ProductDeli productDeli = new ProductDeli();
            productDeli.ShowDialog();   */
        }

        private void productReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();       
                
            
            
        }

        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableManager_Load(object sender, EventArgs e)
        {
            /*originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(panelTMEdit.Location.X, panelTMEdit.Location.Y, panelTMEdit.Width, panelTMEdit.Height);
            buttonOriginalRectangle1 = new Rectangle(lvTMEdit.Location.X, lvTMEdit.Location.Y, lvTMEdit.Width, lvTMEdit.Height);*/
        }

        

        private void TableManager_Resize(object sender, EventArgs e)
        {
            /*resizeControl(buttonOriginalRectangle, panelTMEdit);
            resizeControl(buttonOriginalRectangle1, lvTMEdit);*/
        }

        private void lvTMEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void TableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
                LoginForm loginForm = new LoginForm();
            
            if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                
                loginForm.Show();
            }
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.stConn);
            conn.Open();
            String sSQL = "INSERT INTO dbo.DeliveryManager ([CodeDelivery],[Manager],[CustomerName],[DateDelivery], [paymethod],[StatusDelivery])" +
                " VALUES(@DID, @Manager, @Cusname, @Date, @Pay, @Status)";
            MessageBox.Show(dtpDMDate.Value.ToString("dd/MM/yyyy"));
            MessageBox.Show(cbDMPay.Text);
            MessageBox.Show(cbDMstatus.Text);
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@DID", tbDMCode.Text));
            cmd.Parameters.Add(new SqlParameter("@Manager", tbDMmag.Text));
            cmd.Parameters.Add(new SqlParameter("@Cusname", tbCusName.Text));
            cmd.Parameters.Add(new SqlParameter("@Date", dtpDMDate.Value.ToShortDateString()));
            cmd.Parameters.Add(new SqlParameter("@Pay", cbDMPay.Text));
            cmd.Parameters.Add(new SqlParameter("@Status", cbDMstatus.Text));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Save successfully!");
            loadProductList();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDMPay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.stConn);
            conn.Open();
            String sSQL = "DELETE FROM dbo.DeliveryManager WHERE [CodeDelivery]=@DID";
            int selectedIndex = dtgvProduct.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvProduct.Rows[selectedIndex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
            MessageBox.Show(cellValue);
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@DID", cellValue));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Delete successfully!");
            loadProductList();
        }

        

        
    }
}
