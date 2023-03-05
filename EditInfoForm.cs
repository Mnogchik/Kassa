using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Касса
{
    public partial class EditInfoForm : Form
    {
        public EditInfoForm()
        {
            InitializeComponent();

            FillTextBoxes();
        }

        public void FillTextBoxes()
        {
            UserInfo user = new UserInfo();

            string login = Users.currentLogin;
            string password = user.Password(login);
            int sum = user.Sum();
            int shifts = user.Shifts();

            UserTextBox.Text = login;
            PassTextBox.Text = password;
            SumTextBox.Text = sum.ToString();
            ShiftsTextBox.Text = shifts.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string login;
            string password;
            int sum;
            int shifts;
            try
            {
                login = UserTextBox.Text;
                password = PassTextBox.Text;
                sum = Convert.ToInt32(SumTextBox.Text);
                shifts = Convert.ToInt32(ShiftsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserInfo user = new UserInfo();
            user.UpdateLogin(login);
            user.UpdatePassword(password);
            user.UpdateSum(sum);
            user.UpdateShifts(shifts);


            MessageBox.Show("Данные успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
