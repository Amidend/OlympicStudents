using NPOI.XSSF.UserModel;
using Microsoft.Data.Sqlite;
using NPOI.SS.UserModel;
using StudentInfo;

namespace OlympicStudents
{
    public partial class MainForm : Form
    {
        private void UpdateDataStudent()
        {
            listViewStudent.Clear();
            listViewStudent.View = View.Details;
            listViewStudent.GridLines = true;
            listViewStudent.FullRowSelect = true;
            listViewStudent.Columns.Add("ФИО");
            listViewStudent.Columns.Add("Дата рождения");
            listViewStudent.Columns.Add("Адрес");
            listViewStudent.Columns.Add("Номер телефона");
            listViewStudent.Columns.Add("Группа");
            listViewStudent.Columns.Add("Дата поступления");
            listViewStudent.Columns.Add("Дата выпуска");
            listViewStudent.Columns.Add("Курс");
            listViewStudent.Columns.Add("Сециализация");
            string[] arr = new string[10];
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                ListViewItem item;
                SqliteCommand command = new SqliteCommand("SELECT * FROM student", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                arr[i] = reader.GetString(i);
                            }
                            item = new ListViewItem(arr);
                            listViewStudent.Items.Add(item);
                        }
                    }
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();
            UpdateDataStudent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            addOlimp.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewOlympiad ns = new NewOlympiad(FindStudentById());
            ns.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateDataStudent();
        }
        private int FindStudentById()
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                int res = -1;
                SqliteCommand command = new SqliteCommand($"SELECT student_id FROM student WHERE fio LIKE '{listViewStudent.SelectedItems[0].Text.ToString()}%'", connection);
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
        private void addOlimpiads(int id)
        {
            listViewOlimp.Columns.Add("Дата", 100);
            listViewOlimp.Columns.Add("Уровень");
            listViewOlimp.Columns.Add("Вид");
            listViewOlimp.Columns.Add("Награда");
            listViewOlimp.Columns.Add("Поощерение");
            listViewOlimp.Columns.Add("Номинации");
            listViewOlimp.Columns.Add("продалжительность");
            listViewOlimp.Columns.Add("Название ");
            listViewOlimp.Columns.Add("место проведения");
            listViewOlimp.Columns.Add("id", 0);
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
                                    item = new ListViewItem(arr);
                                    listViewOlimp.Items.Add(item);
                                }
                            }

                        }
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listViewOlimp.Clear();
            listViewOlimp.View = View.Details;
            listViewOlimp.GridLines = true;
            listViewOlimp.FullRowSelect = true;
            /*this.listView1.Dock = DockStyle.Right;
           this.listView1.Location = new System.Drawing.Point(0, 0);
           this.listView1.Size = new System.Drawing.Size(292, 130);
           this.listView1.View = View.Details;
           this.listView1.FullRowSelect = true;*/
            addOlimpiads(FindStudentById());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet1 = workbook.CreateSheet("Отчет");
            IRow row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("Дата проведения");
            row1.CreateCell(1).SetCellValue("Уровень");
            row1.CreateCell(2).SetCellValue("Вид");
            row1.CreateCell(3).SetCellValue("Награды");
            row1.CreateCell(4).SetCellValue("Поощерение");
            row1.CreateCell(5).SetCellValue("Номинации");
            row1.CreateCell(6).SetCellValue("Продолжительность");
            row1.CreateCell(7).SetCellValue("Название Оимпиады");
            row1.CreateCell(8).SetCellValue("Местопроведения");
            List<int> size = findByids();
            for (int k = 0; k < size.Count; k++)
            {
                using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();

                    SqliteCommand command = new SqliteCommand($"SELECT * FROM olympiad WHERE olympiad_id='{size[k].ToString()}'", connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IRow row = sheet1.CreateRow(k + 1);
                                for (int i = 0; i < 9; i++)
                                {
                                    row.CreateCell(i).SetCellValue(reader.GetString(i));
                                }
                            }
                        }
                    }
                    command.Cancel(); command.Cancel();
                }
                /*using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();

                    SqliteCommand command = new SqliteCommand($"SELECT * FROM olympiad WHERE olympiad_id='{size[k].ToString()}'", connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IRow row = sheet1.CreateRow(k + 1);
                                for (int i = 0; i < 9; i++)
                                {
                                    row.CreateCell(i).SetCellValue(reader.GetString(i));
                                }
                            }
                        }
                    }
                    command.Cancel(); command.Cancel();
                }*/

            }




            FileStream sw = File.Create("test.xlsx");
            workbook.Write(sw);
            sw.Close();
        }
        private List<int> findByids()
        {
            DateTime date = dateTimePicker1.Value.AddMonths(-8);
            DateTime start, end;
            var month = date.Month;
            var year = date.Year;
            if (month <= 8)
            {
                start = new DateTime(year, 9, 1);
                end = new DateTime(year + 1, 8, 30);
            }
            else
            {
                start = new DateTime(year, 9, 1);
                end = new DateTime(year + 1, 8, 31);
            }
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                List<int> res = new List<int>();
                int k = 9;

                SqliteCommand command = new SqliteCommand($"SELECT olympiad_id FROM olympiad WHERE dates BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}'", connection);
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

        private void button2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show((listView1.SelectedItems.Count>0).ToString() + (listView2.SelectedItems.Count > 0).ToString());
            if ((listViewStudent.SelectedItems.Count > 0) && !(listViewOlimp.SelectedItems.Count > 0))
            {
                //MessageBox.Show(StudentInfo.DataBase.GetID("student", "student_id", "fio", $"{findByid().ToString()}"));


                List<int?> res = new List<int?>();
                using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();
                    int k = 9;

                    SqliteCommand command = new SqliteCommand($"SELECT olympiad_id FROM result WHERE student_id='{FindStudentById().ToString()}'", connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader.IsDBNull(0)) continue;
                                else res?.Add(reader?.GetInt32(0));
                            }
                        }
                    }
                    command.Cancel(); command.Cancel();
                }
                for (int i = 0; i < res.Count; i++)
                {
                    DataBase.Delete("olympiad", "", "olympiad_id", res[i].ToString());

                    DataBase.Delete("result", "", "student_id", FindStudentById().ToString());
                }
                DataBase.Delete("student", "", "student_id", FindStudentById().ToString());
            }
            if ((listViewStudent.SelectedItems.Count > 0) && (listViewOlimp.SelectedItems.Count > 0))
            {
                listViewStudent.SelectedItems[0].Text.ToString();

                //MessageBox.Show($"{listView2.SelectedItems[0].SubItems[9].Text.ToString()}");
                DataBase.Delete("olympiad", "", "olympiad_id", $"{listViewOlimp.SelectedItems[0].SubItems[9].Text.ToString()}");
                //MessageBox.Show(StudentInfo.DataBase.GetID("olympiad", "olympiad_id", "olympiad_id", $"{listView2.SelectedItems[0].SubItems[9].Text.ToString()}"));
                DataBase.Delete("result", "", "olympiad_id", $"{listViewOlimp.SelectedItems[0].SubItems[9].Text.ToString()}");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addOlimp.Enabled) { addOlimp.Enabled = false; }
            else { addOlimp.Enabled = true; }

        }

        private void search_Click(object sender, EventArgs e)
        {

            var res = DataBase.Search("student", "(fio || dateOfBirth || address || phone || groups || yearApplying || yearOfRelease || course || specialization )", $"{textBoxSearch.Text}");
            listViewStudent.Clear();
            ListViewItem item;
            listViewStudent.Clear();
            listViewStudent.View = View.Details;
            listViewStudent.GridLines = true;
            listViewStudent.FullRowSelect = true;
            listViewStudent.Columns.Add("ФИО", 100);
            listViewStudent.Columns.Add("Дата рождения");
            listViewStudent.Columns.Add("Адрес");
            listViewStudent.Columns.Add("Номер телефона");
            listViewStudent.Columns.Add("Группа");
            listViewStudent.Columns.Add("Дата поступления");
            listViewStudent.Columns.Add("Дата выпуска");
            listViewStudent.Columns.Add("Курс");
            listViewStudent.Columns.Add("Сециализация");
            foreach (var i in res)
            {
                item = new ListViewItem(i.ToArray());
                listViewStudent.Items.Add(item);
            }
            /*if (res != null)
            {
                listView1.Clear();
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                listView1.Columns.Add("ФИО", 100);
                listView1.Columns.Add("Дата рождения");
                listView1.Columns.Add("Адрес");
                listView1.Columns.Add("Номер телефона");
                listView1.Columns.Add("Группа");
                listView1.Columns.Add("Дата поступления");
                listView1.Columns.Add("Дата выпуска");
                listView1.Columns.Add("Курс");
                listView1.Columns.Add("Сециализация");
                string[] arr = new string[10];
                using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();
                    ListViewItem item;
                    SqliteCommand command = new SqliteCommand("SELECT * FROM student", connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    arr[i] = reader.GetString(i);
                                }
                                item = new ListViewItem(arr);
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }*/
        }
    }
}