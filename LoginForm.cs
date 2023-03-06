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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            incorrectLoginLabel.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String inputLogin = loginTextBox.Text;
            String inputPassword = passwordTextBox.Text;

            DB db = new DB();

            if (db.IsInfoCorrect(inputLogin, inputPassword) && inputLogin != "admin")
            {
                Users.currentLogin = inputLogin;

                Form shiftForm = new ShiftForm
                {
                    Left = this.Left,
                    Top = this.Top
                };

                shiftForm.Show();
                this.Close();
            }
            else
            {
                incorrectLoginLabel.Visible = true;
            }

            loginTextBox.Text = "";
            passwordTextBox.Text = "";

        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            Form menuForm = Application.OpenForms[0];

            menuForm.StartPosition = FormStartPosition.Manual;
            menuForm.Left = this.Left;
            menuForm.Top = this.Top;

            menuForm.Show();
            this.Close();
        }

        private void ShowHidePassButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !(passwordTextBox.UseSystemPasswordChar);
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) loginButton.PerformClick();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && Application.OpenForms[0].Visible == false) Application.OpenForms[0].Close();
        }
    }
}
