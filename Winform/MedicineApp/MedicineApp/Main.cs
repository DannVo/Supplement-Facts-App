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
    public partial class Main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm,activeSubForm;
        private static Color temp = new Color();
        public Main()
        {
            InitializeComponent();
            
            random = new Random();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            customizeDesing();
            btnCloseChild.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void customizeDesing()
        {
            pnSubProManage.Visible = false;
            pnSubOrderManage.Visible = false;

        }

        private void hideSubMenu()
        {
            if(pnSubProManage.Visible == true) 
            {
                pnSubProManage.Visible = false;
            }
            if(pnSubOrderManage.Visible == true) 
            {
                pnSubOrderManage.Visible = false;
            }
        }

        private void ShowSubMenu(Panel sub) 
        {
            if(sub.Visible == false)
            {
                hideSubMenu();
                sub.Visible = true;
            }
            else
            {
                sub.Visible = false;
            }
        }

        public Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count); 
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();

            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDisplayContent.Controls.Add(childForm);
            this.pnDisplayContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(); 
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    temp = color;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnTitle.BackColor = color;
                    pnBrand.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChild.Visible = true;
                }
            }
        }

            private void DisableButton()
            {
                foreach(Control prevBtn in pnMenu.Controls)
                {
                    if(prevBtn.GetType() == typeof(Button))
                    {
                        prevBtn.BackColor = Color.FromArgb(33, 42, 57);
                        prevBtn.ForeColor = Color.Gainsboro;
                        prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }

        
        
        private void openSubForm(Form childForm, object btnSender, Panel panel)
        {
            if(activeSubForm != null)
            {
                activeSubForm.Close();
            }
            ActivateSubButton(btnSender,panel);
            activeSubForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDisplayContent.Controls.Add(childForm);
            this.pnDisplayContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void ActivateSubButton(object btnSender, Panel panel)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableSubButton(panel);
                    /*Color color = SelectThemeColor();*/
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = temp;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnTitle.BackColor = temp;
                    pnBrand.BackColor = ThemeColor.ChangeColorBrightness(temp, -0.3);
                    btnCloseChild.Visible = true;
                }
            }
        }

        private void DisableSubButton(Panel panel)
        {
            foreach (Control prevBtn in panel.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(33, 42, 57);
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenu(pnSubOrderManage);

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenu(pnSubProManage);
            /*OpenChildForm(new TableManager(), sender);*/
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(activeSubForm != null)
            {
                activeSubForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lbTitle.Text = "HOME";
            pnTitle.BackColor = Color.FromArgb(58, 136, 145);
            pnBrand.BackColor = Color.FromArgb(87, 167, 176);
            currentButton = null;
            btnCloseChild.Visible = false;   
        }

        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm2 loginForm = new LoginForm2();          
            loginForm.ShowDialog();
            
        }

        private void btnMaximumSize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubStatistic_Click(object sender, EventArgs e)
        {
            openSubForm(new ProductStatistics(), sender, pnSubProManage);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            openSubForm(new OrdersStatic(), sender, pnSubOrderManage);
        }

        private void btnSubImported_Click(object sender, EventArgs e)
        {
            
            openSubForm(new ImportedPro(), sender, pnSubProManage);
            


        }

        
    }
}
