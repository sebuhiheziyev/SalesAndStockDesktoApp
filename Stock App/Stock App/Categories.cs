using Stock_App.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Stock_App
{
    public partial class Categories : Form
    {
        private readonly Sales_StockDbEntities _context;
        private int SelectedCategoryId;

        public Categories()
        {
            InitializeComponent();
            _context = new Sales_StockDbEntities();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            FillDataGridCategory();
        }

        private void FillDataGridCategory()
        {
            dgwCategory.DataSource = _context.Categories
           .Select(c => new
           {
               c.Id,
               c.Name,
           })
           .OrderBy(c=> c.Id)
           .ToList();
            dgwCategory.Columns[1].HeaderText = "Ad";
        }

        private void btnVisable()
        {
            btnCreaated.Visible = true;
            btnDelet.Visible = btnUpdate.Visible = btnCancel.Visible = false;
            txtName.Text = "";

        }

        private void dgwCategory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnCreaated.Visible = false;
            btnDelet.Visible = btnUpdate.Visible = btnCancel.Visible = true;

            int id = (int)dgwCategory.Rows[e.RowIndex].Cells[0].Value;
            SelectedCategoryId = id;

            Category selectedCatgory = _context.Categories.Find(id);

            txtName.Text = selectedCatgory.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnVisable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Bütün məlumatları daxil edin", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category category = _context.Categories.Find(SelectedCategoryId);
            category.Name = txtName.Text;
            _context.SaveChanges();

            btnVisable();
            FillDataGridCategory();
        }

        private void btnCreaated_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Bütün məlumatları daxil edin", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category category = new Category
            {
                Name = txtName.Text
            };
            _context.Categories.Add(category);
            _context.SaveChanges();

            btnVisable();
            FillDataGridCategory(); 

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
           Category category = _context.Categories.Find(SelectedCategoryId);

            DialogResult message = MessageBox.Show("Bu kateqoriyaya aid olan bütün məhsullar həmən məhsulların satışları,anbara mədaxilləri silinəcək!", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                btnVisable();
                FillDataGridCategory();
            }

        }
    }
}
