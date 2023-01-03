namespace MedicineApp
{
    partial class TableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolSMIStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.importGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnDisplayStatistic = new System.Windows.Forms.Panel();
            this.panelTMEdit = new System.Windows.Forms.Panel();
            this.cbDMstatus = new System.Windows.Forms.ComboBox();
            this.cbDMPay = new System.Windows.Forms.ComboBox();
            this.dtpDMDate = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDMmag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDMCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvTMEdit = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnDisplayStatistic.SuspendLayout();
            this.panelTMEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSMIStatistic,
            this.importGoodsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolSMIStatistic
            // 
            this.toolSMIStatistic.CheckOnClick = true;
            this.toolSMIStatistic.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.toolSMIStatistic.Name = "toolSMIStatistic";
            this.toolSMIStatistic.Size = new System.Drawing.Size(126, 34);
            this.toolSMIStatistic.Text = "STATISTICS";
            // 
            // importGoodsToolStripMenuItem
            // 
            this.importGoodsToolStripMenuItem.CheckOnClick = true;
            this.importGoodsToolStripMenuItem.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importGoodsToolStripMenuItem.Name = "importGoodsToolStripMenuItem";
            this.importGoodsToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.importGoodsToolStripMenuItem.Text = "IMPORT GOODS";
            // 
            // pnDisplayStatistic
            // 
            this.pnDisplayStatistic.Controls.Add(this.panelTMEdit);
            this.pnDisplayStatistic.Controls.Add(this.panel2);
            this.pnDisplayStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDisplayStatistic.Location = new System.Drawing.Point(0, 38);
            this.pnDisplayStatistic.Name = "pnDisplayStatistic";
            this.pnDisplayStatistic.Size = new System.Drawing.Size(1444, 548);
            this.pnDisplayStatistic.TabIndex = 7;
            // 
            // panelTMEdit
            // 
            this.panelTMEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTMEdit.Controls.Add(this.cbDMstatus);
            this.panelTMEdit.Controls.Add(this.cbDMPay);
            this.panelTMEdit.Controls.Add(this.dtpDMDate);
            this.panelTMEdit.Controls.Add(this.textBox7);
            this.panelTMEdit.Controls.Add(this.label7);
            this.panelTMEdit.Controls.Add(this.label6);
            this.panelTMEdit.Controls.Add(this.label5);
            this.panelTMEdit.Controls.Add(this.label4);
            this.panelTMEdit.Controls.Add(this.tbCusName);
            this.panelTMEdit.Controls.Add(this.label3);
            this.panelTMEdit.Controls.Add(this.tbDMmag);
            this.panelTMEdit.Controls.Add(this.label2);
            this.panelTMEdit.Controls.Add(this.tbDMCode);
            this.panelTMEdit.Controls.Add(this.label1);
            this.panelTMEdit.Controls.Add(this.btnSave);
            this.panelTMEdit.Controls.Add(this.btnDelete);
            this.panelTMEdit.Controls.Add(this.lvTMEdit);
            this.panelTMEdit.Location = new System.Drawing.Point(34, 40);
            this.panelTMEdit.Name = "panelTMEdit";
            this.panelTMEdit.Size = new System.Drawing.Size(343, 468);
            this.panelTMEdit.TabIndex = 7;
            // 
            // cbDMstatus
            // 
            this.cbDMstatus.FormattingEnabled = true;
            this.cbDMstatus.Items.AddRange(new object[] {
            "Waiting",
            "Cancelled",
            "Completed"});
            this.cbDMstatus.Location = new System.Drawing.Point(170, 251);
            this.cbDMstatus.Name = "cbDMstatus";
            this.cbDMstatus.Size = new System.Drawing.Size(153, 28);
            this.cbDMstatus.TabIndex = 4;
            this.cbDMstatus.Text = "Waiting";
            // 
            // cbDMPay
            // 
            this.cbDMPay.FormattingEnabled = true;
            this.cbDMPay.Items.AddRange(new object[] {
            "Master Card",
            "Visa",
            "Momo"});
            this.cbDMPay.Location = new System.Drawing.Point(170, 219);
            this.cbDMPay.Name = "cbDMPay";
            this.cbDMPay.Size = new System.Drawing.Size(153, 28);
            this.cbDMPay.TabIndex = 3;
            // 
            // dtpDMDate
            // 
            this.dtpDMDate.Location = new System.Drawing.Point(170, 188);
            this.dtpDMDate.Name = "dtpDMDate";
            this.dtpDMDate.Size = new System.Drawing.Size(153, 26);
            this.dtpDMDate.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(170, 283);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(153, 26);
            this.textBox7.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Other";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Payment Method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Delivery:";
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(170, 155);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(153, 26);
            this.tbCusName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Name:";
            // 
            // tbDMmag
            // 
            this.tbDMmag.Location = new System.Drawing.Point(170, 123);
            this.tbDMmag.Name = "tbDMmag";
            this.tbDMmag.Size = new System.Drawing.Size(153, 26);
            this.tbDMmag.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manager:";
            // 
            // tbDMCode
            // 
            this.tbDMCode.Location = new System.Drawing.Point(170, 91);
            this.tbDMCode.Name = "tbDMCode";
            this.tbDMCode.Size = new System.Drawing.Size(153, 26);
            this.tbDMCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(193)))), ((int)(((byte)(189)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(170, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(65, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lvTMEdit
            // 
            this.lvTMEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTMEdit.HideSelection = false;
            this.lvTMEdit.Location = new System.Drawing.Point(3, 3);
            this.lvTMEdit.Name = "lvTMEdit";
            this.lvTMEdit.Size = new System.Drawing.Size(337, 462);
            this.lvTMEdit.TabIndex = 0;
            this.lvTMEdit.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.dtgvProduct);
            this.panel2.Location = new System.Drawing.Point(401, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 468);
            this.panel2.TabIndex = 6;
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(3, 3);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersWidth = 62;
            this.dtgvProduct.RowTemplate.Height = 28;
            this.dtgvProduct.Size = new System.Drawing.Size(1003, 459);
            this.dtgvProduct.TabIndex = 0;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 586);
            this.Controls.Add(this.pnDisplayStatistic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.TableManager_Load);
            this.Resize += new System.EventHandler(this.TableManager_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnDisplayStatistic.ResumeLayout(false);
            this.panelTMEdit.ResumeLayout(false);
            this.panelTMEdit.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolSMIStatistic;
        private System.Windows.Forms.ToolStripMenuItem importGoodsToolStripMenuItem;
        private System.Windows.Forms.Panel pnDisplayStatistic;
        private System.Windows.Forms.Panel panelTMEdit;
        private System.Windows.Forms.ComboBox cbDMstatus;
        private System.Windows.Forms.ComboBox cbDMPay;
        private System.Windows.Forms.DateTimePicker dtpDMDate;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDMmag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDMCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvTMEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvProduct;
    }
}