using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Касса
{
    public partial class CreateCashierForm : Form
    {
        public CreateCashierForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            String newLogin = newLoginTextBox.Text;
            String newPassword = newPasswordTextBox.Text;

            DB db = new DB();

            if (db.IsUserExist(newLogin, newPassword))
                MessageBox.Show("Такой аккаунт уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (newLogin == "" || newPassword == "")
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                
            }    
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
