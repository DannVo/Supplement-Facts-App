using MedicineApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*Main mainpage = new Main();

            String check_login = "SELECT Name, Password FROM Users WHERE " +
            "Name='" + tbUsername.Text + "' and Password='" +
            tbPassword.Text + "'";
            DataProvider dataProvider = new DataProvider();
            DataTable data = dataProvider.ExecuteQuery(check_login);
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                mainpage.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check username or password!");
            }*/
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }*/
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
