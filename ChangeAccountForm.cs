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
    public partial class ChangeAccountForm : Form
    {
        public ChangeAccountForm()
        {
            InitializeComponent();
            CreateTable();
        }

        public void CreateTable()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT login FROM `user` WHERE login != 'admin'", db.getConnection());

            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);
            }
            catch { }

            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void DeleteCashierButton_Click(object sender, EventArgs e)
        {            
            string login = dataGridView1.CurrentCell.Value.ToString();
            var result = MessageBox.Show("Вы уверены, что хотите удалить аккаунт " + login + "?", "Внимание",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {

                DB db = new DB();
                db.openConnection();

                MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE login = @uL", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                command.ExecuteReader();

                db.closeConnection();

                CreateTable();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Users.currentLogin = dataGridView1.CurrentCell.Value.ToString();

            Form editInfoForm = new EditInfoForm()
            {
                Top = this.Top + 20,
                Left = this.Left + 20
            };
            editInfoForm.ShowDialog();
        }
    }
}
