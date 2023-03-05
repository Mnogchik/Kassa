using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Касса
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ShiftStartButton_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm
            {
                Left = this.Left,
                Top = this.Top
            };
            loginForm.Show();
            this.Hide();
        }

        private void LoginAsAdminButton_Click(object sender, EventArgs e)
        {
            Form adminConfirmForm = new AdminConfirmForm()
            {
                Left = this.Left + 20,
                Top = this.Top + 20
            };
            adminConfirmForm.ShowDialog();
        }

    }
}
