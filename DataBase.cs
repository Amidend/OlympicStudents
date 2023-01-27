using Microsoft.Data.Sqlite;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfo
{
    internal class DataBase
    {
        public static int FindStudentById(string s)
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                int res = -1;
                SqliteCommand command = new SqliteCommand($"SELECT student_id FROM student WHERE fio LIKE '{s}%'", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            res = reader.GetInt32(0);
                        }
                    }
                }
                command.Cancel(); command.Cancel();
                return res;
            }
        }
        public static string? GetID(string table, string column, string where, string result)
        {
            string? id = null;
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand($"SELECT {column} FROM {table} WHERE {where} = '{result}'", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            try
                            {
                                id = reader.GetString(0);
                            }
                            catch (Exception) { }
                        }
                    }
                }
            }
            return id;
        }
        public static string Read(string table, string column, string where, string result)
        {
            string value = "1";
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                SqliteCommand comm = new SqliteCommand($"SELECT {column} FROM {table} WHERE {where}='{result}'", connection);
                using (SqliteDataReader reader = comm.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            value = reader.GetString(column);// + 1;
                        }
                    }

                }
            }
            return value;
        }
        public static void Update(string table, string colums, string value_to_update, string where, string result)
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand($"UPDATE {table} SET {colums}='{value_to_update}' WHERE {where}='{result}'", connection);

                command.ExecuteNonQuery();
            }
        }
        public static void Delete(string table, string row, string where, string result)
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand($"DELETE {row} FROM {table} WHERE {where}='{result}'", connection);
                try
                {
                    int number = command.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }
        public static IEnumerable<List<string>> Search(string table, string where, string key)
        {
            string result;

            List<string> results = new List<string>();

            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand($"SELECT * FROM {table} WHERE {where} LIKE '%{key}%'", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            results.Clear();
                            for (int i = 0; i < 9; i++)
                            {
                                results.Add(reader.GetString(i));
                            }
                            yield return results;
                        }
                    }
                }
            }
        }
    }
}
