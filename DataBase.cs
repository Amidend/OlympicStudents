using Microsoft.Data.Sqlite;
using OlympicStudents;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using NPOI.Util.Collections;

namespace StudentInfo
{
    internal abstract class DataBase
    {
        public static async Task<List<ListViewItem>> GetAllFromTableAsync(string table, int n)
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
        public static List<string> FindOlimpyadById(string id)
        {
            List<string> list = new List<string>();
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM olympiad WHERE olympiad_id='{id.ToString()}'", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
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
        public static List<string> GetStuentInfofrmationAndSp(string id, string searchCriteria)
        {
            List<string> list = new List<string>();
            string[] searchCriterias = searchCriteria.Split("||");

            foreach (var criteria in searchCriterias)
            {
                using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();
                    SqliteCommand command = new SqliteCommand($"SELECT * FROM student WHERE student_id = '{id}' AND specialization = '{criteria}'", connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    list.Add(reader.GetString(i));
                                }
                            }
                        }
                    }
                    command.Cancel();
                }
            }
            return list;
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
        public static IEnumerable<List<string>> SearchOlimp(string table, string where, string key)
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
                            for (int i = 0; i < 10; i++)
                            {
                                results.Add(reader.GetString(i));
                            }
                            yield return results;
                        }
                    }
                }
            }
        }
        public static List<int> findByids(NumericUpDown numericUpDown1, NumericUpDown numericUpDown2)
        {
            int academicYear = (int)numericUpDown1.Value;
            int academicYear1 = (int)numericUpDown2.Value;
            DateTime start = new DateTime(academicYear, 9, 1);
            DateTime end = new DateTime(academicYear1, 8, 31);
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                List<int> res = new List<int>();

                SqliteCommand command = new SqliteCommand($"SELECT olympiad_id FROM olympiad WHERE dates BETWEEN '{start.ToString("yyyy.MM.dd")}' AND '{end.ToString("yyyy.MM.dd")}'", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            res.Add(reader.GetInt32(0));
                        }
                    }
                }
                command.Cancel(); command.Cancel();
                return res;
            }
        }
        public static List<Dictionary<string, string>> MultiSearch(string tableName, List<string> searchFields, List<string> searchValues)
        {
            List<Dictionary<string, string>> dataSource = GetData(tableName);
            System.Collections.Generic.HashSet<Dictionary<string, string>> f = new System.Collections.Generic.HashSet<Dictionary<string, string>>();
            List<Dictionary<string, string>> searchResults = new List<Dictionary<string, string>>();
            List<Dictionary<string, string>> res = new List<Dictionary<string, string>>();
            foreach (var row in dataSource)
            {
                for (int j = 0; j < searchValues.Count; j++)
                {

                    for (int i = 0; i < searchFields.Count; i++)
                    {
                        if (row[searchFields[i]].Contains(searchValues[j]))
                        {
                            searchResults.Add(row);
                            f.Add(row);
                        }
                    }
                }
            }
            if (searchFields.Count >= 2)
            {
                foreach (var i in f)
                {
                    int t = 0;
                    foreach (var j in searchResults)
                    {
                        if (i == j)
                        {
                            t += 1;
                        }
                    }
                    if (t >= searchFields.Count)
                    {
                        res.Add(i);
                    }
                }
            }
            else {
                foreach (var i in f)
                {
                    bool t = false;
                    foreach (var j in searchResults)
                    {
                        if (i == j)
                        {
                            t = true;
                        }
                    }
                    if (t)
                    {
                        res.Add(i);
                    }
                }

            }

            return res;
        }



        public static List<Dictionary<string, string>> GetData(string tableName)
        {
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();

            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $"SELECT * FROM {tableName}";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, string> row = new Dictionary<string, string>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string fieldName = reader.GetName(i);
                                string value = reader.IsDBNull(i) ? null : reader.GetString(i);
                                row.Add(fieldName, value);
                            }

                            data.Add(row);
                        }
                    }
                }
            }

            return data;
        }

    }
}

