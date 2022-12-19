using NPOI.XSSF.UserModel;
using Microsoft.Data.Sqlite;
using NPOI.SS.UserModel;


namespace OlympicStudents
{
    public partial class Form1 : Form
    {
        private void UpdateDatas()
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
        }
        public Form1()
        {
            InitializeComponent();
            UpdateDatas();
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
            MessageBox.Show(FindStudentById().ToString());
            NewOlympiad ns = new NewOlympiad(FindStudentById());
            ns.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateDatas();
        }
        private int FindStudentById()
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                int res = -1;
                SqliteCommand command = new SqliteCommand($"SELECT student_id FROM student WHERE fio LIKE '{listView1.SelectedItems[0].Text.ToString()}%'", connection);
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
            listView2.Columns.Add("Дата", 100);
            listView2.Columns.Add("Уровень");
            listView2.Columns.Add("Вид");
            listView2.Columns.Add("Награда");
            listView2.Columns.Add("Поощерение");
            listView2.Columns.Add("Номинации");
            listView2.Columns.Add("продалжительность");
            listView2.Columns.Add("Название ");
            listView2.Columns.Add("место проведения");
            listView2.Columns.Add("id", 0);
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
                                    listView2.Items.Add(item);
                                }
                            }

                        }
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
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
            ISheet sheet1 = workbook.CreateSheet("Sheet1");
            sheet1.CreateRow(0).CreateCell(0).SetCellValue("This is a Sample");
            List<int> size = findByids();
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                for (int k = 0; k < size.Count; k++)
                {
                    SqliteCommand command = new SqliteCommand($"SELECT * FROM olympiad WHERE olympiad_id='{size[k].ToString()}'", connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IRow row = sheet1.CreateRow(k);
                                for (int i = 0; i < 10; i++)
                                {
                                    row.CreateCell(i).SetCellValue(reader.GetString(i));
                                }
                            }
                        }
                    }
                    command.Cancel(); command.Cancel();
                }
                FileStream sw = File.Create("test.xlsx");
                workbook.Write(sw);
                sw.Close();
            }
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

                MessageBox.Show($"SELECT olympiad_id FROM olympiad WHERE dates BETWEEN '%{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}'");
                return res;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show((listView1.SelectedItems.Count>0).ToString() + (listView2.SelectedItems.Count > 0).ToString());
            if ((listView1.SelectedItems.Count > 0) && !(listView2.SelectedItems.Count > 0))
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
                    StudentInfo.DataBase.Delete("olympiad", "", "olympiad_id", res[i].ToString());

                    StudentInfo.DataBase.Delete("result", "", "student_id", FindStudentById().ToString());
                }
                StudentInfo.DataBase.Delete("student", "", "student_id", FindStudentById().ToString());
            }
            if ((listView1.SelectedItems.Count > 0) && (listView2.SelectedItems.Count > 0))
            {
                listView1.SelectedItems[0].Text.ToString();

                MessageBox.Show($"{listView2.SelectedItems[0].SubItems[9].Text.ToString()}");
                StudentInfo.DataBase.Delete("olympiad", "", "olympiad_id", $"{listView2.SelectedItems[0].SubItems[9].Text.ToString()}");
                MessageBox.Show(StudentInfo.DataBase.GetID("olympiad", "olympiad_id", "olympiad_id", $"{listView2.SelectedItems[0].SubItems[9].Text.ToString()}"));
                StudentInfo.DataBase.Delete("result", "", "olympiad_id", $"{listView2.SelectedItems[0].SubItems[9].Text.ToString()}");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addOlimp.Enabled) { addOlimp.Enabled = false; }
            else { addOlimp.Enabled = true; }
            
        }
    }
}