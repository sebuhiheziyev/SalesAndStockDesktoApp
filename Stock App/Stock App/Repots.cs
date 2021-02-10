using System;
using System.Linq;
using System.Windows.Forms;
using Stock_App.Model;

namespace Stock_App
{
    public partial class Repots : Form
    {
        private readonly Sales_StockDbEntities _context;

        public Repots()
        {
            InitializeComponent();
            _context = new Sales_StockDbEntities();
        }

        private void Repots_Load(object sender, EventArgs e)
        {
            FillFilterCtaegoriesCombo();
            FillDataGridProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FillDataGridProducts(string category = "", string product = "")
        {
            dgwRepots.DataSource = _context.Products
           .Where
           (
                p=>
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
           .OrderBy(p=> p.Id)
           .ToList();

            dgwRepots.Columns[1].HeaderText = "Kateqoriya";
            dgwRepots.Columns[2].HeaderText = "Məhsul";
            dgwRepots.Columns[3].HeaderText = "Say m²";
        }

        private void FillFilterCtaegoriesCombo()
        {
            cmbCategoryFilter.Items.Add("Bütün");
            cmbCategoryFilter.Items.AddRange(_context.Categories.ToArray());
        }



        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategoryFilter.Text;

            
                if (category == "Bütün")
                {
                     FillDataGridProducts();
                }
                else
                {
                FillDataGridProducts(category: cmbCategoryFilter.Text, product: txtBoxName.Text); ;
                }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            FillDataGridProducts(category: cmbCategoryFilter.Text , product : txtBoxName.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
