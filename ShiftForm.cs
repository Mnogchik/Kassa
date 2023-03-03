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
            int shifts = 0, place = 0; // заглушки
            dataGridView1.Rows.Add("Номер смены", shifts);
            dataGridView1.Rows.Add("Клиентов обслужено за смену", purchaces_count);
            dataGridView1.Rows.Add("Текущая прибыль за смену", profit + " ₽");
            dataGridView1.Rows.Add("Рейтинг среди кассиров", place);
        }

        private void NewPurchaseButton_Click(object sender, EventArgs e)
        {
            SumTextBox.Text = "0₽";
            AddedSumLabel.Text = "(+0₽)";
            PurchaseGroupBox.Visible = true;
            NewPurchaseButton.Enabled = false;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ArticleTextBox.Text, out int article)) return;


            AddedSumLabel.Text = "(+" + article.ToString() + "₽)";

            var currentSum = SumTextBox.Text.ToString();
            currentSum = currentSum.Remove(currentSum.Length - 1);
            SumTextBox.Text = Convert.ToString(Convert.ToInt32(currentSum) + article) + "₽";
        }

        private void EndPurchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseGroupBox.Visible = false;
            NewPurchaseButton.Enabled = true;
            purchaces_count++;
        }

        private void EndShiftLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.OpenForms[0].Close();
        }
                              
        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridView1[1, 1].Value = purchaces_count;
            dataGridView1[2, 1].Value = profit + " ₽";
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
