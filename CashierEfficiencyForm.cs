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
    public partial class CashierEfficiencyForm : Form
    {
        public CashierEfficiencyForm()
        {
            InitializeComponent();

            CreateTable();
        }

        public void CreateTable()
        {
            UserInfo user = new UserInfo();
            DataTable table = user.CreateSortedTable();

            if (table.Rows.Count != 0)
            {
                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.Columns[0].HeaderText = "Логин";
                dataGridView1.Columns[1].HeaderText = "Пароль";
                dataGridView1.Columns[2].HeaderText = "Суммарная прибыль";
                dataGridView1.Columns[3].HeaderText = "Кол-во рабочих смен";
                dataGridView1.Columns[4].HeaderText = "Рейтинг";

                dataGridView1.Enabled = false;
            }
        }
    }
}
