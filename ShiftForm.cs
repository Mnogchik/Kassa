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
    public partial class ShiftForm : Form
    {
        int profit = 0, purchaces_count = 0;

        public ShiftForm()
        {
            InitializeComponent();
            CreateTable();
        }

        public void CreateTable()
        {
            int place = 0; // заглушкa

            UserInfo user = new UserInfo();
            int shifts = user.Shifts() + 1;

            dataGridView1.Rows.Add("Номер смены", shifts);
            dataGridView1.Rows.Add("Клиентов обслужено за смену", purchaces_count);
            dataGridView1.Rows.Add("Текущая прибыль за смену", profit + " ₽");
            dataGridView1.Rows.Add("Место среди других работников", place);
        }

        private void NewPurchaseButton_Click(object sender, EventArgs e)
        {
            SumTextBox.Text = "0₽";
            AddedSumLabel.Text = "(+0₽)";

            PurchaseGroupBox.Visible = true;
            NewPurchaseButton.Enabled = false;
            EndShiftLinkLabel.Enabled = false;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ArticleTextBox.Text, out int article))
            { 
                AddedSumLabel.Text = "(+" + article.ToString() + "₽)";

                var currentSum = SumTextBox.Text.ToString();
                currentSum = currentSum.Remove(currentSum.Length - 1);
                SumTextBox.Text = Convert.ToString(Convert.ToInt32(currentSum) + article) + "₽";

                ProductTextBox.Text = "Товар за " + article + "₽";
            }
        }

        private void EndPurchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseGroupBox.Visible = false;

            NewPurchaseButton.Enabled = true;
            EndShiftLinkLabel.Enabled = true;

            ArticleTextBox.Text = "";
            ProductTextBox.Text = "";

            var currentSum = SumTextBox.Text.ToString();
            currentSum = currentSum.Remove(currentSum.Length - 1);
            profit += Convert.ToInt32(currentSum);
            purchaces_count++;
        }
                                      
        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridView1[1, 1].Value = purchaces_count;
            dataGridView1[1, 2].Value = profit + " ₽";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[1].Width = 75;
        }

        private void EndShiftLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите завершить смену?", "Warning",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.OpenForms[0].Show();
                this.Close();

                UserInfo user = new UserInfo();
                int current_shifts = user.Shifts();
                int current_sum = user.Sum();

                int new_shifts = current_shifts + 1;
                int new_sum = current_sum + profit;

                user.UpdateShifts(new_shifts);
                user.UpdateSum(new_sum);
                user.UpdateRating(new_sum / new_shifts);

            }
        }

        private void ShiftForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && Application.OpenForms[0].Visible == false) Application.OpenForms[0].Close();
        }







        private void EndShiftLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // невидимая кнопка не удаляется
        {

        }
    }
}
