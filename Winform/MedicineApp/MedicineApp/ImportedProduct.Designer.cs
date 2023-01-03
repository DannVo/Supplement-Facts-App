namespace MedicineApp
{
    partial class ImportedProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDisplayImpPro = new System.Windows.Forms.Panel();
            this.numQuanti = new System.Windows.Forms.NumericUpDown();
            this.btnCancelImp = new System.Windows.Forms.Button();
            this.btnAddImpProd = new System.Windows.Forms.Button();
            this.rtbImpPrice = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbDescPro = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbImagePro = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbNamePro = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbIDProduct = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnDisplayImpPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuanti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imported Product";
            // 
            // pnDisplayImpPro
            // 
            this.pnDisplayImpPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.pnDisplayImpPro.Controls.Add(this.numQuanti);
            this.pnDisplayImpPro.Controls.Add(this.btnCancelImp);
            this.pnDisplayImpPro.Controls.Add(this.btnAddImpProd);
            this.pnDisplayImpPro.Controls.Add(this.rtbImpPrice);
            this.pnDisplayImpPro.Controls.Add(this.label8);
            this.pnDisplayImpPro.Controls.Add(this.label9);
            this.pnDisplayImpPro.Controls.Add(this.rtbDescPro);
            this.pnDisplayImpPro.Controls.Add(this.label5);
            this.pnDisplayImpPro.Controls.Add(this.rtbImagePro);
            this.pnDisplayImpPro.Controls.Add(this.label4);
            this.pnDisplayImpPro.Controls.Add(this.rtbNamePro);
            this.pnDisplayImpPro.Controls.Add(this.label3);
            this.pnDisplayImpPro.Controls.Add(this.rtbIDProduct);
            this.pnDisplayImpPro.Controls.Add(this.label2);
            this.pnDisplayImpPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDisplayImpPro.Location = new System.Drawing.Point(0, 63);
            this.pnDisplayImpPro.Name = "pnDisplayImpPro";
            this.pnDisplayImpPro.Size = new System.Drawing.Size(800, 387);
            this.pnDisplayImpPro.TabIndex = 1;
            // 
            // numQuanti
            // 
            this.numQuanti.Location = new System.Drawing.Point(548, 19);
            this.numQuanti.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuanti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuanti.Name = "numQuanti";
            this.numQuanti.Size = new System.Drawing.Size(120, 26);
            this.numQuanti.TabIndex = 20;
            this.numQuanti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancelImp
            // 
            this.btnCancelImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelImp.FlatAppearance.BorderSize = 0;
            this.btnCancelImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelImp.ForeColor = System.Drawing.Color.Tomato;
            this.btnCancelImp.Location = new System.Drawing.Point(637, 321);
            this.btnCancelImp.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelImp.Name = "btnCancelImp";
            this.btnCancelImp.Size = new System.Drawing.Size(92, 40);
            this.btnCancelImp.TabIndex = 19;
            this.btnCancelImp.Text = "Cancel";
            this.btnCancelImp.UseVisualStyleBackColor = false;
            this.btnCancelImp.Click += new System.EventHandler(this.btnCancelImp_Click);
            // 
            // btnAddImpProd
            // 
            this.btnAddImpProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(222)))), ((int)(((byte)(206)))));
            this.btnAddImpProd.FlatAppearance.BorderSize = 0;
            this.btnAddImpProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImpProd.ForeColor = System.Drawing.Color.White;
            this.btnAddImpProd.Location = new System.Drawing.Point(518, 321);
            this.btnAddImpProd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddImpProd.Name = "btnAddImpProd";
            this.btnAddImpProd.Size = new System.Drawing.Size(92, 40);
            this.btnAddImpProd.TabIndex = 18;
            this.btnAddImpProd.Text = "Add";
            this.btnAddImpProd.UseVisualStyleBackColor = false;
            this.btnAddImpProd.Click += new System.EventHandler(this.btnAddImpProd_Click);
            // 
            // rtbImpPrice
            // 
            this.rtbImpPrice.Location = new System.Drawing.Point(548, 69);
            this.rtbImpPrice.Name = "rtbImpPrice";
            this.rtbImpPrice.Size = new System.Drawing.Size(159, 31);
            this.rtbImpPrice.TabIndex = 11;
            this.rtbImpPrice.Text = "100.000";
            this.rtbImpPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox7_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "IMPORT PRICE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "QUANTITY";
            // 
            // rtbDescPro
            // 
            this.rtbDescPro.Location = new System.Drawing.Point(130, 171);
            this.rtbDescPro.Name = "rtbDescPro";
            this.rtbDescPro.Size = new System.Drawing.Size(239, 142);
            this.rtbDescPro.TabIndex = 7;
            this.rtbDescPro.Text = "";
            this.rtbDescPro.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "DESCRIPTION";
            // 
            // rtbImagePro
            // 
            this.rtbImagePro.Location = new System.Drawing.Point(130, 121);
            this.rtbImagePro.Name = "rtbImagePro";
            this.rtbImagePro.Size = new System.Drawing.Size(239, 31);
            this.rtbImagePro.TabIndex = 5;
            this.rtbImagePro.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "IMAGE";
            // 
            // rtbNamePro
            // 
            this.rtbNamePro.Location = new System.Drawing.Point(130, 72);
            this.rtbNamePro.Name = "rtbNamePro";
            this.rtbNamePro.Size = new System.Drawing.Size(239, 31);
            this.rtbNamePro.TabIndex = 3;
            this.rtbNamePro.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // rtbIDProduct
            // 
            this.rtbIDProduct.Location = new System.Drawing.Point(130, 21);
            this.rtbIDProduct.Name = "rtbIDProduct";
            this.rtbIDProduct.Size = new System.Drawing.Size(239, 31);
            this.rtbIDProduct.TabIndex = 1;
            this.rtbIDProduct.Text = "";
            this.rtbIDProduct.TextChanged += new System.EventHandler(this.rtbIDProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // ImportedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnDisplayImpPro);
            this.Controls.Add(this.panel1);
            this.Name = "ImportedProduct";
            this.Text = "ImportedProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnDisplayImpPro.ResumeLayout(false);
            this.pnDisplayImpPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuanti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnDisplayImpPro;
        private System.Windows.Forms.RichTextBox rtbDescPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbImagePro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbNamePro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbIDProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelImp;
        private System.Windows.Forms.Button btnAddImpProd;
        private System.Windows.Forms.RichTextBox rtbImpPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numQuanti;
    }
}