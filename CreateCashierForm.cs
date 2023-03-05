using MySql.Data.MySqlClient;
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
            else if (newPassword.Length > 30)
                MessageBox.Show("Длина пароля должна быть от 1 до 30 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`login`, `password`, `sum`, `shifts`) VALUES (@uL, @uP, 0, 0)", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = newLogin;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = newPassword;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ошибка ответа от базы данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();

                this.Close();
            }    
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newPasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) registerButton.PerformClick();
        }

        private void ShowHidePassButton_Click(object sender, EventArgs e)
        {
            newPasswordTextBox.UseSystemPasswordChar = !(newPasswordTextBox.UseSystemPasswordChar);
        }
    }
}
