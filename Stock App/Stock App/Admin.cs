using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_App.Model;

namespace Stock_App
{
    public partial class Admin : Form
    {
        private readonly Sales_StockDbEntities _context;
        public Admin()
        {
            InitializeComponent();
            _context = new Sales_StockDbEntities();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOldPassword.Text, "[^0-9]"))
            {
                MessageBox.Show("Xaiş olunur yalnız rəqəmlərdən istifadə edin.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtOldPassword.Text = "";
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "" || txtNewPassword1.Text == "" || txtNewPassword2.Text == "")
            {
                MessageBox.Show("Bütün xanaları doldurun!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (txtOldPassword.Text.Length != 5 || txtNewPassword1.Text.Length != 5 || txtNewPassword2.Text.Length != 5)
            {
                MessageBox.Show("Xanalarda minumum ve maksimum 5 simvoldan istifadə edin istifadə edin.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string oldPasswordMain = _context.AdminSettings.First().LoginPassword;
            if (txtOldPassword.Text != oldPasswordMain)
            {
                MessageBox.Show("İndiki parolu düzgün daxil edin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewPassword1.Text != txtNewPassword2.Text)
            {
                MessageBox.Show("Yeni parollar fərqlidir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.AdminSettings.First().LoginPassword = txtNewPassword1.Text;
            _context.SaveChanges();
            MessageBox.Show("Parol uğurla dəyişildi", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNewPassword1.Text = txtNewPassword2.Text = txtOldPassword.Text = "";
        }

        private void txtNewPassword1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNewPassword1.Text, "[^0-9]"))
            {
                MessageBox.Show("Xaiş olunur yalnız rəqəmlərdən istifadə edin.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword1.Text = "";
            }
        }

        private void txtNewPassword2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNewPassword2.Text, "[^0-9]"))
            {
                MessageBox.Show("Xaiş olunur yalnız rəqəmlərdən istifadə edin.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword2.Text = "";
            }
        }
    }
}
