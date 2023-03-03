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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            incorrectLoginLabel.Visible = false;
            if (loginTextBox.Text != "" || passwordTextBox.Text != "") // заглушка
            {
                incorrectLoginLabel.Visible = true;
                return;
            }

            Form shiftForm = new ShiftForm
            {
                Left = this.Left,
                Top = this.Top
            };

            shiftForm.Show();
            this.Close();
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && Application.OpenForms[0].Visible == false) Application.OpenForms[0].Close();
        }
    }
}
