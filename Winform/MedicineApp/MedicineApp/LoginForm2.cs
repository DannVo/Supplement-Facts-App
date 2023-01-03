using MedicineApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineApp
{
    public partial class LoginForm2 : Form
    {
        public LoginForm2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main mainpage = new Main();

            String check_login = "SELECT email, password FROM [TestingUser] WHERE " +
            "email='" + tbUsername.Text + "' and password='" +
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
            }
        }

        private void LoginForm2_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
