using System;
using System.Windows.Forms;
using Stock_App.Model;

namespace Stock_App
{
    public partial class Statistics : Form
    {
        private readonly Sales_StockDbEntities _context;

        public Statistics()
        {
            InitializeComponent();
            _context = new Sales_StockDbEntities();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlCreatedProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show(allPrice.ToString());
           
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dateTimeStart.Value > dateTimeEnd.Value)
            {
                MessageBox.Show("Başlanğıc tarix bitme tarixindən böyük ola bilməz","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (dateTimeStart.Value == dateTimeEnd.Value)
            {
                MessageBox.Show("Başlanğıc tarix bitme tarixi eyni ola bilməz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            decimal allPrice = 0;
            decimal allOrderProductm2 = 0;
            decimal allStockProductm2 = 0;

            int allOrdersCount = 0;
            int allStockCount = 0;

            foreach (Order o in _context.Orders)
            {
                if (o.SalesTime >= dateTimeStart.Value && o.SalesTime <= dateTimeEnd.Value)
                {
                   allPrice += (decimal)o.Price;
                   allOrderProductm2 += (decimal)o.Count;
                   allOrdersCount += 1;
                }
            }

            foreach (Stock s in _context.Stocks)
            {
                if (s.StockTime >= dateTimeStart.Value && s.StockTime <= dateTimeEnd.Value)
                {
                    allStockCount += 1;
                    allStockProductm2 += (decimal) s.Count;
                }
            }

            dgwProducts.Rows.Add(allPrice + " AZN", allOrdersCount, allOrderProductm2 + " m²", allStockCount, allStockProductm2 + " m²");
        }
    }
}
