using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Касса
{
    public static class Users
    {
        public static string currentLogin;
        public static string currentShifts;

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
    }
}
