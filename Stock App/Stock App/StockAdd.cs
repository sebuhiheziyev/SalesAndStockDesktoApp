using Stock_App.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Stock_App
{
    public partial class StockAdd : Form
    {
        private readonly Sales_StockDbEntities _context;
        private int SelectedStockAddId;


        public StockAdd()
        {
            InitializeComponent();
            _context = new Sales_StockDbEntities();

        }

        private void StockAdd_Load(object sender, EventArgs e)
        {
            FillCtaegoriesCombo();
            FillDataGridProducts();
        }

        private void FillCtaegoriesCombo()
        {
            cmbCategory.Items.AddRange(_context.Categories.ToArray());
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.AddRange(_context.Products.Where(p=>p.Category.Name == cmbCategory.Text).ToArray());
        }

        private void FillDataGridProducts()
        {

            dgwStockAdd.DataSource = _context.Stocks
            .Select(s => new
            {
              s.Id,
              s.Product.Category,
              s.Product,
              s.Count,
              s.StockTime
            }).OrderByDescending(s=> s.StockTime).ToList();

            dgwStockAdd.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";
            dgwStockAdd.Columns[1].HeaderText = "Kateqoriya";
            dgwStockAdd.Columns[2].HeaderText = "Məhsul";
            dgwStockAdd.Columns[3].HeaderText = "Say m²";
            dgwStockAdd.Columns[4].HeaderText = "Tarix";

            nmrCount.Value = 0;

            btnCreaated.Visible = true;
            btnDelet.Visible = btnUpdate.Visible = btnCancel.Visible = false;



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

            int selectedProduct = _context.Products.First(c => c.Name == cmbProduct.Text).Id;

            Stock stock = new Stock
            {
                ProductId = selectedProduct,
                Count = nmrCount.Value,
                StockTime = DateTime.Now,
            };

            Product updatProduct =   _context.Products.Find(selectedProduct);
            updatProduct.Count += nmrCount.Value;
            updatProduct.TotalStockCount += 1;

            _context.Stocks.Add(stock);
            _context.SaveChanges();
            FillDataGridProducts();

        }

        private void dgwStockAdd_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnCreaated.Visible = false;
            btnDelet.Visible = btnUpdate.Visible = btnCancel.Visible = true;

            SelectedStockAddId = (int)dgwStockAdd.Rows[e.RowIndex].Cells[0].Value;

            Stock stockAdd = _context.Stocks.Find(SelectedStockAddId);

            cmbCategory.Text = stockAdd.Product.Category.Name;
            cmbProduct.Text = stockAdd.Product.Name;
            nmrCount.Value = stockAdd.Count.Value;

            cmbCategory.Enabled = false;
            cmbProduct.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCreaated.Visible = true;
            btnDelet.Visible = btnUpdate.Visible = btnCancel.Visible = false;

            cmbCategory.Enabled = cmbProduct.Enabled = true;

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bunu silmək istədiynizdən əminsiz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Stock stockAdd = _context.Stocks.Find(SelectedStockAddId);
                Product product = _context.Products.Find(stockAdd.ProductId);
                product.Count -= stockAdd.Count;
                product.TotalStockCount -= 1;
                _context.Stocks.Remove(stockAdd);
                _context.SaveChanges();
            }

            FillDataGridProducts();
            cmbCategory.Enabled = cmbProduct.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Stock stockAdd = _context.Stocks.Find(SelectedStockAddId);
            Product product = _context.Products.Find(stockAdd.ProductId);
            
            if (stockAdd.Count > nmrCount.Value)
            {
                decimal azalanCount = (decimal)stockAdd.Count - nmrCount.Value;
                stockAdd.Count = nmrCount.Value;
                product.Count -= azalanCount;

            }
            else if(stockAdd.Count < nmrCount.Value) 
            {
                decimal artanCount = nmrCount.Value - (decimal)stockAdd.Count;
                stockAdd.Count = nmrCount.Value;
                product.Count += artanCount;
            }
            else
            {
                MessageBox.Show("Tekrar reqem");
            }
            _context.SaveChanges();
            FillDataGridProducts();
        }
    }
}
