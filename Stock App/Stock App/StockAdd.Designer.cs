
namespace Stock_App
{
    partial class StockAdd
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
            this.dgwStockAdd = new System.Windows.Forms.DataGridView();
            this.pnlCreatedProduct = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwStockAdd)).BeginInit();
            this.pnlCreatedProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStockAdd
            // 
            this.dgwStockAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStockAdd.BackgroundColor = System.Drawing.Color.White;
            this.dgwStockAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStockAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwStockAdd.Location = new System.Drawing.Point(0, 190);
            this.dgwStockAdd.Name = "dgwStockAdd";
            this.dgwStockAdd.Size = new System.Drawing.Size(1107, 312);
            this.dgwStockAdd.TabIndex = 3;
            this.dgwStockAdd.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwStockAdd_RowHeaderMouseDoubleClick);
            // 
            // pnlCreatedProduct
            // 
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
            this.pnlCreatedProduct.Size = new System.Drawing.Size(1107, 172);
            this.pnlCreatedProduct.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(504, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Necə m²";
            // 
            // nmrCount
            // 
            this.nmrCount.DecimalPlaces = 2;
            this.nmrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrCount.Location = new System.Drawing.Point(507, 50);
            this.nmrCount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Size = new System.Drawing.Size(190, 26);
            this.nmrCount.TabIndex = 9;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(265, 50);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(190, 28);
            this.cmbProduct.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(709, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Geri Qayit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.Brown;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelet.ForeColor = System.Drawing.Color.White;
            this.btnDelet.Location = new System.Drawing.Point(507, 96);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(190, 46);
            this.btnDelet.TabIndex = 6;
            this.btnDelet.Text = "Sil";
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Visible = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(265, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 46);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Yadda Saxla";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreaated
            // 
            this.btnCreaated.BackColor = System.Drawing.Color.Green;
            this.btnCreaated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreaated.ForeColor = System.Drawing.Color.White;
            this.btnCreaated.Location = new System.Drawing.Point(12, 96);
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
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Məhsul seçin";
            // 
            // J
            // 
            this.J.AutoSize = true;
            this.J.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.J.Location = new System.Drawing.Point(12, 31);
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
            this.cmbCategory.Location = new System.Drawing.Point(12, 50);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(190, 28);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // StockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 502);
            this.Controls.Add(this.pnlCreatedProduct);
            this.Controls.Add(this.dgwStockAdd);
            this.Name = "StockAdd";
            this.Text = "Anbara Mədaxil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStockAdd)).EndInit();
            this.pnlCreatedProduct.ResumeLayout(false);
            this.pnlCreatedProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStockAdd;
        private System.Windows.Forms.Panel pnlCreatedProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreaated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label J;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrCount;
    }
}