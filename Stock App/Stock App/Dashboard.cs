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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void kateqoriyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayalara girdiz");
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kateqoriylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.ShowDialog();
            this.Close();

        }

        private void anbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close();
            //Repots repots = new Repots();
            //repots.ShowDialog();

        }

        private void məhsullarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
            //this.Close();
        }

        private void anabaraBaxışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Repots repots = new Repots();
            repots.ShowDialog();
            //this.Close();

        }

        private void anbaraMedaxilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockAdd stockAdd = new StockAdd();
            stockAdd.ShowDialog();
            //this.Close();
        }

        private void məhsulSatışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
          
        }
    }
}
