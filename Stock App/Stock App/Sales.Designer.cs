
namespace Stock_App
{
    partial class Sales
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
            this.dgwSales = new System.Windows.Forms.DataGridView();
            this.pnlCreatedProduct = new System.Windows.Forms.Panel();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrAllPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrOnePrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrCount = new System.Windows.Forms.NumericUpDown();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreaated = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.J = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSales)).BeginInit();
            this.pnlCreatedProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAllPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOnePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSales
            // 
            this.dgwSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSales.BackgroundColor = System.Drawing.Color.White;
            this.dgwSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwSales.Location = new System.Drawing.Point(0, 278);
            this.dgwSales.Name = "dgwSales";
            this.dgwSales.Size = new System.Drawing.Size(1161, 296);
            this.dgwSales.TabIndex = 4;
            this.dgwSales.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwSales_RowHeaderMouseDoubleClick);
            // 
            // pnlCreatedProduct
            // 
            this.pnlCreatedProduct.Controls.Add(this.txtAdress);
            this.pnlCreatedProduct.Controls.Add(this.label7);
            this.pnlCreatedProduct.Controls.Add(this.txtPhone);
            this.pnlCreatedProduct.Controls.Add(this.label6);
            this.pnlCreatedProduct.Controls.Add(this.txtName);
            this.pnlCreatedProduct.Controls.Add(this.label5);
            this.pnlCreatedProduct.Controls.Add(this.label4);
            this.pnlCreatedProduct.Controls.Add(this.nmrAllPrice);
            this.pnlCreatedProduct.Controls.Add(this.label3);
            this.pnlCreatedProduct.Controls.Add(this.nmrOnePrice);
            this.pnlCreatedProduct.Controls.Add(this.label2);
            this.pnlCreatedProduct.Controls.Add(this.nmrCount);
            this.pnlCreatedProduct.Controls.Add(this.cmbProduct);
            this.pnlCreatedProduct.Controls.Add(this.btnCancel);
            this.pnlCreatedProduct.Controls.Add(this.btnDelet);
            this.pnlCreatedProduct.Controls.Add(this.btnUpdate);
            this.pnlCreatedProduct.Controls.Add(this.btnCreaated);
            this.pnlCreatedProduct.Controls.Add(this.label1);
            this.pnlCreatedProduct.Controls.Add(this.J);
            this.pnlCreatedProduct.Controls.Add(this.cmbCategory);
            this.pnlCreatedProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreatedProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlCreatedProduct.Name = "pnlCreatedProduct";
            this.pnlCreatedProduct.Size = new System.Drawing.Size(1161, 272);
            this.pnlCreatedProduct.TabIndex = 5;
            this.pnlCreatedProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCreatedProduct_Paint);
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAdress.Location = new System.Drawing.Point(668, 124);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(190, 26);
            this.txtAdress.TabIndex = 20;
            this.txtAdress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(665, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Müştərinin ünavnı:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(426, 124);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(190, 26);
            this.txtPhone.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(423, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Müştərinin nömrəsi:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(176, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 26);
            this.txtName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(173, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Müştərinin adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(906, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Toplam qiymət";
            // 
            // nmrAllPrice
            // 
            this.nmrAllPrice.DecimalPlaces = 2;
            this.nmrAllPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrAllPrice.Location = new System.Drawing.Point(909, 125);
            this.nmrAllPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrAllPrice.Name = "nmrAllPrice";
            this.nmrAllPrice.Size = new System.Drawing.Size(190, 26);
            this.nmrAllPrice.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(906, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bir m² qiymət";
            // 
            // nmrOnePrice
            // 
            this.nmrOnePrice.DecimalPlaces = 2;
            this.nmrOnePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrOnePrice.Location = new System.Drawing.Point(909, 62);
            this.nmrOnePrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrOnePrice.Name = "nmrOnePrice";
            this.nmrOnePrice.Size = new System.Drawing.Size(190, 26);
            this.nmrOnePrice.TabIndex = 11;
            this.nmrOnePrice.ValueChanged += new System.EventHandler(this.nmrOnePrice_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(665, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Neçə m²";
            // 
            // nmrCount
            // 
            this.nmrCount.DecimalPlaces = 2;
            this.nmrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrCount.Location = new System.Drawing.Point(668, 62);
            this.nmrCount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Size = new System.Drawing.Size(190, 26);
            this.nmrCount.TabIndex = 9;
            this.nmrCount.ThousandsSeparator = true;
            this.nmrCount.ValueChanged += new System.EventHandler(this.nmrCount_ValueChanged);
            this.nmrCount.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.nmrCount_ControlAdded);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(426, 62);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(190, 28);
            this.cmbProduct.TabIndex = 8;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(909, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Geri Qayit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.Brown;
            this.btnDelet.Enabled = false;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelet.ForeColor = System.Drawing.Color.White;
            this.btnDelet.Location = new System.Drawing.Point(668, 203);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(190, 46);
            this.btnDelet.TabIndex = 6;
            this.btnDelet.Text = "Sil";
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(426, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 46);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Yadda Saxla";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreaated
            // 
            this.btnCreaated.BackColor = System.Drawing.Color.Green;
            this.btnCreaated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreaated.ForeColor = System.Drawing.Color.White;
            this.btnCreaated.Location = new System.Drawing.Point(173, 203);
            this.btnCreaated.Name = "btnCreaated";
            this.btnCreaated.Size = new System.Drawing.Size(190, 46);
            this.btnCreaated.TabIndex = 4;
            this.btnCreaated.Text = "Əlavə Et";
            this.btnCreaated.UseVisualStyleBackColor = false;
            this.btnCreaated.Click += new System.EventHandler(this.btnCreaated_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(423, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Məhsul seçin";
            // 
            // J
            // 
            this.J.AutoSize = true;
            this.J.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.J.Location = new System.Drawing.Point(173, 43);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(123, 16);
            this.J.TabIndex = 1;
            this.J.Text = "Kateqoriyaya seçin";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(173, 62);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(190, 28);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 574);
            this.Controls.Add(this.pnlCreatedProduct);
            this.Controls.Add(this.dgwSales);
            this.Name = "Sales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSales)).EndInit();
            this.pnlCreatedProduct.ResumeLayout(false);
            this.pnlCreatedProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAllPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOnePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSales;
        private System.Windows.Forms.Panel pnlCreatedProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrCount;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreaated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label J;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrAllPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrOnePrice;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
    }
}