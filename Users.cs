using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Касса
{
    public static class Users
    {
        public static string currentLogin;
        public static string currentShifts;
        public static DataTable table;
    }

    class UserInfo
    {
        public int Shifts()
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT `shifts` FROM `user` WHERE login = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Users.currentLogin;

            MySqlDataReader reader = command.ExecuteReader();

            String current_shifts_str = "";
            while (reader.Read())
            {
                current_shifts_str = reader.GetString(0);
            }
            db.closeConnection();

            var current_shifts = Convert.ToInt32(current_shifts_str);
            return current_shifts;
        }

        public int Sum()
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT `sum` FROM `user` WHERE login = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Users.currentLogin;

            MySqlDataReader reader = command.ExecuteReader();

            String current_sum_str = "";
            while (reader.Read())
            {
                current_sum_str = reader.GetString(0);
            }
            db.closeConnection();

            var current_sum = Convert.ToInt32(current_sum_str);
            return current_sum;
        }

        public string Password(string _login)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT `password` FROM `user` WHERE login = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = _login;

            MySqlDataReader reader = command.ExecuteReader();

            string password = "";
            while (reader.Read())
            {
                password = reader.GetString(0);
            }
            db.closeConnection();

            return password;
        }

        public void UpdateLogin(string value)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `login`= @uS WHERE login = @uL", db.getConnection());

            command.Parameters.Add("@uS", MySqlDbType.Int32).Value = value;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Users.currentLogin;
            command.ExecuteReader();

            db.closeConnection();
        }

        public void UpdatePassword(string value)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `password`= @uS WHERE login = @uL", db.getConnection());

            command.Parameters.Add("@uS", MySqlDbType.Int32).Value = value;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Users.currentLogin;
            command.ExecuteReader();

            db.closeConnection();
        }

        public void UpdateShifts(int value)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `shifts`= @uS WHERE login = @uL", db.getConnection());

            command.Parameters.Add("@uS", MySqlDbType.Int32).Value = value;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Users.currentLogin;
            command.ExecuteReader();

            db.closeConnection();
        }

        public void UpdateSum(int value)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `sum`= @uS WHERE login = @uL", db.getConnection());

            command.Parameters.Add("@uS", MySqlDbType.Int32).Value = value;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Users.currentLogin;
            command.ExecuteReader();

            db.closeConnection();
        }

        public void UpdateRating(double value)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `rating`= @uS WHERE login = @uL", db.getConnection());

            command.Parameters.Add("@uS", MySqlDbType.Float).Value = value;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Users.currentLogin;
            command.ExecuteReader();

            db.closeConnection();
        }

        public DataTable CreateSortedTable()
        {
            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE login != 'admin' ORDER BY `user`.`rating` DESC", db.getConnection());

            adapter.SelectCommand = command;

            Users.table = new DataTable();
            try
            {
                adapter.Fill(Users.table);
            } 
            catch { }

            return Users.table;
        }

        public int Place()
        {
            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `login` FROM `user` WHERE login != 'admin' ORDER BY `user`.`rating` DESC", db.getConnection());

            adapter.SelectCommand = command;

            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);
            }
            catch { }

            int index = -1;
            foreach (DataRow row in table.Rows)
                if (row[0].ToString() == Users.currentLogin)
                    index = table.Rows.IndexOf(row) + 1;

            return index;
        }
    }

    class ProductsInfo
    {
        public string Name(int article)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT `name` FROM `product` WHERE article = @art", db.getConnection());
            command.Parameters.Add("@art", MySqlDbType.VarChar).Value = article;

            MySqlDataReader reader = command.ExecuteReader();

            String name = "";
            while (reader.Read())
            {
                name = reader.GetString(0);
            }
            db.closeConnection();

            return name;
        }

        public int Value(int article)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT `value` FROM `product` WHERE article = @art", db.getConnection());
            command.Parameters.Add("@art", MySqlDbType.VarChar).Value = article;

            MySqlDataReader reader = command.ExecuteReader();

            String value = "";
            while (reader.Read())
            {
                value = reader.GetString(0);
            }
            db.closeConnection();

            return Convert.ToInt32(value);
        }
    }
}
