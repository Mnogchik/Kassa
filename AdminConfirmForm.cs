using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Касса
{
    public partial class AdminConfirmForm : Form
    {
        public AdminConfirmForm()
        {
            InitializeComponent();
            incorrectPassLabel.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();

            string input_password = passwordTextBox.Text;
            string real_password = user.Password("admin");
            
            if (input_password == real_password)
            {
                this.Close();
                Application.OpenForms[0].Hide();

                Form adminForm = new AdminForm()
                {
                    Left = this.Left,
                    Top = this.Top
                };
                adminForm.Show();
            }
            else
            {
                incorrectPassLabel.Visible = true;
                passwordTextBox.Text = "";
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) loginButton.PerformClick();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowHidePassButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !(passwordTextBox.UseSystemPasswordChar);
        }
    }
}
