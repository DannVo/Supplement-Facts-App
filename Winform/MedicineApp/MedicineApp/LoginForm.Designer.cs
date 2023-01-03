namespace MedicineApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoginx = new System.Windows.Forms.Button();
            this.tbPasswordx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.tbUsernamex = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(543, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoginx
            // 
            this.btnLoginx.Location = new System.Drawing.Point(419, 287);
            this.btnLoginx.Name = "btnLoginx";
            this.btnLoginx.Size = new System.Drawing.Size(92, 39);
            this.btnLoginx.TabIndex = 1;
            this.btnLoginx.Text = "Login";
            this.btnLoginx.UseVisualStyleBackColor = true;
            this.btnLoginx.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPasswordx
            // 
            this.tbPasswordx.Location = new System.Drawing.Point(287, 300);
            this.tbPasswordx.Name = "tbPasswordx";
            this.tbPasswordx.Size = new System.Drawing.Size(367, 26);
            this.tbPasswordx.TabIndex = 1;
            this.tbPasswordx.UseSystemPasswordChar = true;
            this.tbPasswordx.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label1.Location = new System.Drawing.Point(159, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.Username.Location = new System.Drawing.Point(471, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // tbUsernamex
            // 
            this.tbUsernamex.Location = new System.Drawing.Point(287, 255);
            this.tbUsernamex.Name = "tbUsernamex";
            this.tbUsernamex.Size = new System.Drawing.Size(367, 26);
            this.tbUsernamex.TabIndex = 1;
            this.tbUsernamex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(303, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbUsernamex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbPasswordx);
            this.Controls.Add(this.btnLoginx);
            this.Controls.Add(this.Username);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox tbPasswordx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoginx;
        private System.Windows.Forms.TextBox tbUsernamex;
        private System.Windows.Forms.Panel panel1;
    }
}

