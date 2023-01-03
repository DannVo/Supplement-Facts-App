namespace MedicineApp
{
    partial class ImportedPro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnImport = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTitleTotal = new System.Windows.Forms.Label();
            this.btnConfirmImp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefreshImp = new System.Windows.Forms.Button();
            this.btnImpDel = new System.Windows.Forms.Button();
            this.dtgvTempImp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIDImpPartner = new System.Windows.Forms.ComboBox();
            this.cbImpNamePartner = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPayMethod = new System.Windows.Forms.ComboBox();
            this.dtpImpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbManager = new System.Windows.Forms.RichTextBox();
            this.rtbOrderName = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnImport.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTempImp)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnImport
            // 
            this.pnImport.AutoScroll = true;
            this.pnImport.Controls.Add(this.panel3);
            this.pnImport.Controls.Add(this.panel1);
            this.pnImport.Controls.Add(this.panel2);
            this.pnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnImport.Location = new System.Drawing.Point(0, 0);
            this.pnImport.Name = "pnImport";
            this.pnImport.Size = new System.Drawing.Size(1258, 1050);
            this.pnImport.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.lbTotal);
            this.panel3.Controls.Add(this.lbTitleTotal);
            this.panel3.Controls.Add(this.btnConfirmImp);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(0, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1258, 557);
            this.panel3.TabIndex = 6;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Leelawadee UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbTotal.Location = new System.Drawing.Point(261, 448);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(74, 36);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "0.0 $";
            // 
            // lbTitleTotal
            // 
            this.lbTitleTotal.AutoSize = true;
            this.lbTitleTotal.Font = new System.Drawing.Font("Leelawadee UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleTotal.ForeColor = System.Drawing.Color.SlateGray;
            this.lbTitleTotal.Location = new System.Drawing.Point(67, 448);
            this.lbTitleTotal.Name = "lbTitleTotal";
            this.lbTitleTotal.Size = new System.Drawing.Size(188, 36);
            this.lbTitleTotal.TabIndex = 11;
            this.lbTitleTotal.Text = "TOTAL PRICE :";
            // 
            // btnConfirmImp
            // 
            this.btnConfirmImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(151)))));
            this.btnConfirmImp.FlatAppearance.BorderSize = 0;
            this.btnConfirmImp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmImp.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmImp.ForeColor = System.Drawing.Color.White;
            this.btnConfirmImp.Location = new System.Drawing.Point(986, 432);
            this.btnConfirmImp.Name = "btnConfirmImp";
            this.btnConfirmImp.Size = new System.Drawing.Size(239, 49);
            this.btnConfirmImp.TabIndex = 3;
            this.btnConfirmImp.Text = "Confirm Slips";
            this.btnConfirmImp.UseVisualStyleBackColor = false;
            this.btnConfirmImp.Click += new System.EventHandler(this.btnConfirmImp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.btnRefreshImp);
            this.groupBox3.Controls.Add(this.btnImpDel);
            this.groupBox3.Controls.Add(this.dtgvTempImp);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(108, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1127, 423);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Required Products";
            // 
            // btnRefreshImp
            // 
            this.btnRefreshImp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefreshImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnRefreshImp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshImp.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshImp.ForeColor = System.Drawing.Color.White;
            this.btnRefreshImp.Location = new System.Drawing.Point(931, 25);
            this.btnRefreshImp.Name = "btnRefreshImp";
            this.btnRefreshImp.Size = new System.Drawing.Size(104, 41);
            this.btnRefreshImp.TabIndex = 2;
            this.btnRefreshImp.Text = "Refresh";
            this.btnRefreshImp.UseVisualStyleBackColor = false;
            this.btnRefreshImp.Click += new System.EventHandler(this.btnRefreshImp_Click);
            // 
            // btnImpDel
            // 
            this.btnImpDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImpDel.BackColor = System.Drawing.Color.Red;
            this.btnImpDel.FlatAppearance.BorderSize = 0;
            this.btnImpDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpDel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpDel.ForeColor = System.Drawing.Color.White;
            this.btnImpDel.Location = new System.Drawing.Point(804, 25);
            this.btnImpDel.Name = "btnImpDel";
            this.btnImpDel.Size = new System.Drawing.Size(104, 41);
            this.btnImpDel.TabIndex = 1;
            this.btnImpDel.Text = "Delete";
            this.btnImpDel.UseVisualStyleBackColor = false;
            this.btnImpDel.Click += new System.EventHandler(this.btnImpDel_Click);
            // 
            // dtgvTempImp
            // 
            this.dtgvTempImp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTempImp.BackgroundColor = System.Drawing.Color.Teal;
            this.dtgvTempImp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTempImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTempImp.Location = new System.Drawing.Point(77, 74);
            this.dtgvTempImp.Name = "dtgvTempImp";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTempImp.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTempImp.RowHeadersWidth = 62;
            this.dtgvTempImp.RowTemplate.Height = 28;
            this.dtgvTempImp.Size = new System.Drawing.Size(958, 332);
            this.dtgvTempImp.TabIndex = 0;
            this.dtgvTempImp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTempImp_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 416);
            this.panel1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(686, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(524, 151);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Product";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MedicineApp.Properties.Resources.icons8_import_20;
            this.button1.Location = new System.Drawing.Point(138, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Import..";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Product";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.cbIDImpPartner);
            this.groupBox2.Controls.Add(this.cbImpNamePartner);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(686, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 123);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import Partner";
            // 
            // cbIDImpPartner
            // 
            this.cbIDImpPartner.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIDImpPartner.FormattingEnabled = true;
            this.cbIDImpPartner.Items.AddRange(new object[] {
            "BLM001",
            "NM002",
            "KLS003"});
            this.cbIDImpPartner.Location = new System.Drawing.Point(138, 80);
            this.cbIDImpPartner.Name = "cbIDImpPartner";
            this.cbIDImpPartner.Size = new System.Drawing.Size(150, 29);
            this.cbIDImpPartner.TabIndex = 5;
            // 
            // cbImpNamePartner
            // 
            this.cbImpNamePartner.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImpNamePartner.FormattingEnabled = true;
            this.cbImpNamePartner.Items.AddRange(new object[] {
            "BLACKMORES",
            "NATURE MADE",
            "KIRKLAND SIGNATURE"});
            this.cbImpNamePartner.Location = new System.Drawing.Point(138, 38);
            this.cbImpNamePartner.Name = "cbImpNamePartner";
            this.cbImpNamePartner.Size = new System.Drawing.Size(231, 29);
            this.cbImpNamePartner.TabIndex = 4;
            this.cbImpNamePartner.SelectedIndexChanged += new System.EventHandler(this.cbImpNamePartner_SelectedIndexChanged);
            this.cbImpNamePartner.DisplayMemberChanged += new System.EventHandler(this.cbImpNamePartner_DisplayMemberChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID Company";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbPayMethod);
            this.groupBox1.Controls.Add(this.dtpImpDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rtbManager);
            this.groupBox1.Controls.Add(this.rtbOrderName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 290);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail of Suppliment Order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Payment Method";
            // 
            // cbPayMethod
            // 
            this.cbPayMethod.FormattingEnabled = true;
            this.cbPayMethod.Items.AddRange(new object[] {
            "Cash",
            "Debit"});
            this.cbPayMethod.Location = new System.Drawing.Point(201, 222);
            this.cbPayMethod.Name = "cbPayMethod";
            this.cbPayMethod.Size = new System.Drawing.Size(118, 28);
            this.cbPayMethod.TabIndex = 7;
            this.cbPayMethod.Text = "Cash";
            // 
            // dtpImpDate
            // 
            this.dtpImpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpImpDate.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpImpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpImpDate.Location = new System.Drawing.Point(201, 170);
            this.dtpImpDate.Name = "dtpImpDate";
            this.dtpImpDate.Size = new System.Drawing.Size(197, 31);
            this.dtpImpDate.TabIndex = 6;
            this.dtpImpDate.Value = new System.DateTime(2022, 12, 9, 23, 5, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Imported Date";
            // 
            // rtbManager
            // 
            this.rtbManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbManager.Location = new System.Drawing.Point(201, 113);
            this.rtbManager.Name = "rtbManager";
            this.rtbManager.Size = new System.Drawing.Size(293, 32);
            this.rtbManager.TabIndex = 4;
            this.rtbManager.Text = "";
            // 
            // rtbOrderName
            // 
            this.rtbOrderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOrderName.Location = new System.Drawing.Point(201, 60);
            this.rtbOrderName.Name = "rtbOrderName";
            this.rtbOrderName.Size = new System.Drawing.Size(293, 32);
            this.rtbOrderName.TabIndex = 2;
            this.rtbOrderName.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Import Slips";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 71);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(396, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "WAREHOUSE IMPORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportedPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 1050);
            this.Controls.Add(this.pnImport);
            this.Name = "ImportedPro";
            this.Text = "Import Product";
            this.pnImport.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTempImp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvTempImp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPayMethod;
        private System.Windows.Forms.DateTimePicker dtpImpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbManager;
        private System.Windows.Forms.RichTextBox rtbOrderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIDImpPartner;
        private System.Windows.Forms.ComboBox cbImpNamePartner;
        private System.Windows.Forms.Button btnRefreshImp;
        private System.Windows.Forms.Button btnImpDel;
        private System.Windows.Forms.Button btnConfirmImp;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTitleTotal;
    }
}