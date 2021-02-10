using System;
using System.Linq;
using System.Windows.Forms;
using Stock_App.Model;

namespace Stock_App
{
    public partial class Form1 : Form
    {
        private readonly Sales_StockDbEntities _context;

        public Form1()
        {
            InitializeComponent();
            _context = new Sales_StockDbEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberButtonClickHandler(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            string inputValue =  clickedBtn.Text;
            if (txtLoginPassword.Text.Length < 5)
            {
                txtLoginPassword.Text += inputValue;
            }

            EnableOkButton();


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtLoginPassword.Text = "";
            EnableOkButton();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string password = txtLoginPassword.Text;
            AdminSetting adminSetting = _context.AdminSettings.First();
            if (adminSetting.LoginPassword ==  password)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Parol səhvdir","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            txtLoginPassword.Text = "";

        }

        private void EnableOkButton()
        {
            if (txtLoginPassword.Text.Length < 5)
            {
                btnOk.Enabled = false;
            }
            else
            {
                btnOk.Enabled = true;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string password = txtLoginPassword.Text;
            if (password.Length > 0)
                txtLoginPassword.Text = password.Remove(password.Length - 1, 1);

            EnableOkButton();

        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
