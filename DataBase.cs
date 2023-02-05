using Microsoft.Data.Sqlite;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfo
{
    internal abstract class DataBase
    {
        public static async Task<List<ListViewItem>> GetAllFromTableAsync(string table,int n)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                await connection.OpenAsync();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM {table}", connection);
                using (SqliteDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            string[] arr = new string[n];
                            for (int i = 0; i < n; i++)
                            {
                                arr[i] = reader.GetString(i);
                            }
                            items.Add(new ListViewItem(arr));
                        }
                    }
                }
            }
            return items;
        }
        public static async Task<List<ListViewItem>> GetAllOlympiadsByStudentIdAsync(int id)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            string[] arr = new string[11];
            string sqlExpressionmain = $"SELECT olympiad_id FROM result WHERE student_id='{id.ToString()}'";

            List<int> l = new List<int>();
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                ListViewItem item;
                SqliteCommand commandmain = new SqliteCommand(sqlExpressionmain, connection);
                commandmain.ExecuteNonQuery();
                using (SqliteDataReader reader = commandmain.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("olympiad_id")))
                            {
                                l.Add(reader.GetInt32(i));
                            }

                        }
                    }
                }
                commandmain.Cancel();
                commandmain.Connection = connection;
                string sqlExpression = "SELECT * FROM olympiad";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            for (int j = 0; j < l.Count; j++)
                            {
                                if (l[j] == reader.GetInt32(9))
                                {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        arr[i] = reader.GetString(i);
                                    }
                                    items.Add(new ListViewItem(arr));
                                }
                            }

                        }
                    }
                }
            }
            return items;
        }
        public static int FindStudentById(string s)
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                int res = -1;
                SqliteCommand command = new SqliteCommand($"SELECT student_id FROM student WHERE fio LIKE '{s}'", connection);
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
        public static int FindStudentByOlimpyad(string id)
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                int res = -1;
                SqliteCommand command = new SqliteCommand($"SELECT student_id FROM result WHERE olympiad_id = '{id}'", connection);
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
        public static async Task<List<string>> GetStuentInformation(string id)
        {
            List<string> list = new List<string>();
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                int res = -1;
                SqliteCommand command = new SqliteCommand($"SELECT * FROM student WHERE student_id = '{id}'", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                list.Add(reader.GetString(i));
                            }
                        }
                    }
                }
                command.Cancel(); command.Cancel();
                return list;
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
                    if (reader.HasRows) 
                    {
                        while (reader.Read())   
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
