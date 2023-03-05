using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Касса
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            Form menuForm = Application.OpenForms[0];

            menuForm.StartPosition = FormStartPosition.Manual;
            menuForm.Left = this.Left;
            menuForm.Top = this.Top;

            menuForm.Show();
            this.Close();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && Application.OpenForms[0].Visible == false) Application.OpenForms[0].Close();
        }

        private void newCashierButton_Click(object sender, EventArgs e)
        {
            Form createCashierForm = new CreateCashierForm()
            {
                Top = this.Top + 20,
                Left = this.Left + 20
            };
            createCashierForm.ShowDialog();
        }

        private void ChangeAccountButton_Click(object sender, EventArgs e)
        {
            Form changeAccountForm = new ChangeAccountForm()
            {
                Top = this.Top + 20,
                Left = this.Left + 20
            };
            changeAccountForm.ShowDialog();
        }

        private void CashierEfficiencyButton_Click(object sender, EventArgs e)
        {
            Form cashierEfficiencyForm = new CashierEfficiencyForm()
            {
                Top = this.Top + 20,
                Left = this.Left + 20
            };
            cashierEfficiencyForm.ShowDialog();
        }

        private void ChangeAdmPassButton_Click(object sender, EventArgs e)
        {
            Form changeAdmPassForm = new ChangeAdmPassForm()
            {
                Top = this.Top + 20,
                Left = this.Left + 20
            };
            changeAdmPassForm.ShowDialog();

        }
    }
}
