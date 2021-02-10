using Stock_App.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Stock_App
{
    public partial class Products : Form
    {
        private readonly Sales_StockDbEntities _context;
        private int SelectedProductId;

        public Products()
        {
            InitializeComponent();
            _context = new Sales_StockDbEntities();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            FillDataGridProducts();
            FillCtaegoriesCombo();
        }

        private void FillCtaegoriesCombo()
        {
            cmbCategory.Items.AddRange(_context.Categories.ToArray());
        }

        private void FillDataGridProducts(string category = "", string product = "")
        {
            dgwProducts.DataSource = _context.Products
           .Where
           (
                p =>
                p.Category.Name == (category == "" ? p.Category.Name : category) &&
                p.Name.Contains(product)

            )
           .Select(p => new
           {
               p.Id,
               p.Category,
               p.Name,
               p.Count
           })
           .OrderBy(p => p.Id)
           .ToList();

            dgwProducts.Columns[1].HeaderText = "Kateqoriya";
            dgwProducts.Columns[2].HeaderText = "Məhsul";
            dgwProducts.Columns[3].HeaderText = "Say m²";
        }

        private void dgwProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnCreaated.Visible = false;
            btnDelet.Visible = btnUpdate.Visible = btnCancel.Visible = true;

            int id = (int)dgwProducts.Rows[e.RowIndex].Cells[0].Value;
            SelectedProductId = id;

            Product selectedProduct = _context.Products.Find(id);

            txtName.Text = selectedProduct.Name;
            cmbCategory.Text = selectedProduct.Category.Name;

        }

        private void btnVisable()
        {
            btnCreaated.Visible = true;
            btnDelet.Visible = btnUpdate.Visible = btnCancel.Visible = false;
            txtName.Text = "";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnVisable();
        }


        private void btnCreaated_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text.Trim() == "" || txtName.Text.Trim() == "")
            {
                MessageBox.Show("Bütün məlumatları daxil edin", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Product product = new Product
            {
                Name = txtName.Text,
                Count = 0,
                TotalOrderCount = 0,
                TotalStockCount = 0,
                CategoryId = _context.Categories.First(c => c.Name == cmbCategory.Text).Id
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            btnVisable();

            FillDataGridProducts();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text.Trim() == "" || txtName.Text.Trim() == "")
            {
                MessageBox.Show("Bütün məlumatları daxil edin", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product updatedProduct = _context.Products.Find(SelectedProductId);

            updatedProduct.Name = txtName.Text;
            updatedProduct.CategoryId = _context.Categories.First(c => c.Name == cmbCategory.Text).Id;

            _context.SaveChanges();

            btnVisable();

            FillDataGridProducts();

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bu məhsulla aid olan bütün satışlar,anbara mədaxillər silinəcək!", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                Product deletedProduct = _context.Products.Find(SelectedProductId);

                _context.Products.Remove(deletedProduct);

                _context.SaveChanges();

                btnVisable();
                FillDataGridProducts();
            }
           
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
