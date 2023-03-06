using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Касса
{
    public partial class ChangeAdmPassForm : Form
    {
        public ChangeAdmPassForm()
        {
            InitializeComponent();
        }

        private void ShowHidePassButton_Click(object sender, EventArgs e)
        {
            newPasswordTextBox.UseSystemPasswordChar = !(newPasswordTextBox.UseSystemPasswordChar);
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите изменить пароль?", "Внимание",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Users.currentLogin = "admin";
                string password = newPasswordTextBox.Text;

                if (password.Length < 1 || password.Length > 30)
                    MessageBox.Show("Длина пароля должна быть от 1 до 30 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    UserInfo user = new UserInfo();
                    user.UpdatePassword(password);
                    this.Close();
                }
            }
        }
    }
}
