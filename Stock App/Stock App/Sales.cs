using Stock_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_App
{
    public partial class Sales : Form
    {
        private readonly Sales_StockDbEntities _context;
        private int duId;

        public Sales()
        {
            InitializeComponent();
            _context = new Sales_StockDbEntities();

        }

        private void pnlCreatedProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            FillDataSales();
            CmbLoad();
            nmrCount.TextChanged += new EventHandler(nmrCount_TextChanged);
            nmrOnePrice.TextChanged += new EventHandler(nmrOnePrice_TextChanged);
        }

        private void FillDataSales()
        {
            dgwSales.DataSource = _context.Orders
            .Select(o => new
            {
                o.Id,
                o.Product.Category.Name,
                o.Product,
                o.Count,
                o.Price,
                o.CustomerName,
                o.CustomerPhone,
                o.CustomerAddress,
                o.SalesTime
            }).OrderByDescending(o=> o.SalesTime).ToList();

            dgwSales.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";

            dgwSales.Columns[1].HeaderText = "Kateqoriya";
            dgwSales.Columns[2].HeaderText = "Məhsul";
            dgwSales.Columns[3].HeaderText = "Say m²";
            dgwSales.Columns[4].HeaderText = "Qiymət AZN";
            dgwSales.Columns[5].HeaderText = "Müştəri adı";
            dgwSales.Columns[6].HeaderText = "Əlaqə nömrəsi";
            dgwSales.Columns[7].HeaderText = "Ünvan";
            dgwSales.Columns[8].HeaderText = "Tarix";

            nmrAllPrice.Enabled = false;
            txtAdress.Text = txtName.Text = txtPhone.Text = "";
            nmrCount.Value = nmrOnePrice.Value = nmrAllPrice.Value = 0;
         
        }

        private void CmbLoad()
        {
            cmbCategory.Items.AddRange(_context.Categories.ToArray());
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal maxCount =(decimal) _context.Products.Where(p => p.Name == cmbProduct.Text).First().Count;
            nmrCount.Maximum = maxCount;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.AddRange(_context.Products.Where(p => p.Category.Name == cmbCategory.Text).ToArray());
        }

        private void nmrCount_ValueChanged(object sender, EventArgs e)
        {
            nmrAllPrice.Value = nmrCount.Value * nmrOnePrice.Value;
        }

        private void nmrOnePrice_ValueChanged(object sender, EventArgs e)
        {
            nmrAllPrice.Value = nmrCount.Value * nmrOnePrice.Value;
        }

        private void nmrCount_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        void nmrCount_TextChanged(object sender, EventArgs e)
        {
            nmrAllPrice.Value = nmrCount.Value * nmrOnePrice.Value;
        }

        void nmrOnePrice_TextChanged(object sender, EventArgs e)
        {
            nmrAllPrice.Value = nmrCount.Value * nmrOnePrice.Value;
        }

        private void btnCreaated_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "")
            {
                MessageBox.Show("Kateqoiya seçin");
                return;
            }

            if (cmbProduct.Text == "")
            {
                MessageBox.Show("Mehsul seçin");
                return;
            }

            if (nmrCount.Value == 0)
            {
                MessageBox.Show("Mehsul sayın daxil edin");
                return;
            }

            if (nmrOnePrice.Value == 0)
            {
                MessageBox.Show("Mehsul 1 ed ucun qiymetini daxil edin");
                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("m a daxil edin");
                return;
            }

            int selectedProduct = _context.Products.First(c => c.Name == cmbProduct.Text).Id;

            Order order = new Order
            {
                ProductId = selectedProduct,
                Count = nmrCount.Value,
                Price = nmrAllPrice.Value,
                CustomerName = txtName.Text.Trim(),
                CustomerAddress = txtAdress.Text.Trim(),
                CustomerPhone = txtPhone.Text.Trim(),
                SalesTime = DateTime.Now
            };

            _context.Orders.Add(order);
            _context.Products.Find(selectedProduct).Count -= nmrCount.Value;
            _context.Products.Find(selectedProduct).TotalOrderCount += 1;
            _context.SaveChanges();
            FillDataSales();

            cmbCategory.Items.Clear();
            cmbProduct.Items.Clear();

            CmbLoad();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwSales_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnCancel.Enabled = btnDelet.Enabled = btnUpdate.Enabled = true;
            btnCreaated.Enabled = false;

            int id = (int)dgwSales.Rows[e.RowIndex].Cells[0].Value;
            duId = id;
            Order order = _context.Orders.Find(id);
            txtAdress.Text = order.CustomerAddress;
            txtName.Text = order.CustomerName;
            txtPhone.Text = order.CustomerPhone;
            cmbCategory.Text = order.Product.Category.Name;
            cmbProduct.Text = order.Product.Name;
            nmrCount.Value = (decimal) order.Count;
            nmrAllPrice.Value = (decimal) order.Price;
            nmrOnePrice.Value = (decimal)order.Price / (decimal)order.Count;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = btnDelet.Enabled = btnUpdate.Enabled = false;
            btnCreaated.Enabled = true;
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            Order order = _context.Orders.Find(duId);
            decimal orderCount = (decimal) order.Count;
            order.Product.Count += orderCount;
            order.Product.TotalOrderCount -= 1;
            _context.Orders.Remove(order);
            _context.SaveChanges();
            FillDataSales();
        }

        private  void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "")
            {
                MessageBox.Show("Kateqoiya seçin");
                return;
            }

            if (cmbProduct.Text == "")
            {
                MessageBox.Show("Mehsul seçin");
                return;
            }

            if (nmrCount.Value == 0)
            {
                MessageBox.Show("Mehsul sayın daxil edin");
                return;
            }

            if (nmrOnePrice.Value == 0)
            {
                MessageBox.Show("Mehsul 1 ed ucun qiymetini daxil edin");
                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("m a daxil edin");
                return;
            }

            Order order = _context.Orders.Find(duId);
            if (order.Product.Name == cmbProduct.Text)
            {
                if (nmrCount.Value > order.Count)
                {
                    decimal artanCount = nmrCount.Value - (decimal)order.Count;
                    order.Count = nmrCount.Value;
                    order.Product.Count -= artanCount;
                }
                else if (nmrCount.Value < order.Count)
                {
                    decimal azalanCount =  (decimal)order.Count - nmrCount.Value;
                    order.Count = nmrCount.Value;
                    order.Product.Count += azalanCount;
                }
                
            }
            else
            {
                order.Product.Count += order.Count;
                order.Product.TotalOrderCount -= 1;
                order.Count = nmrCount.Value;
                int newPro = _context.Products.First(p => p.Name == cmbProduct.Text).Id;
                order.ProductId = newPro;

                Product product = _context.Products.Find(newPro);
                product.Count -= order.Count;
                product.TotalOrderCount += 1;
            }
            order.CustomerName = txtName.Text.Trim();
            order.CustomerAddress = txtAdress.Text.Trim();
            order.CustomerPhone = txtPhone.Text.Trim();
            order.Price = nmrAllPrice.Value;

            _context.SaveChanges();
            FillDataSales();
        }
    }
}
