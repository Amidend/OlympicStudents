using NPOI.XSSF.UserModel;
using Microsoft.Data.Sqlite;
using NPOI.SS.UserModel;
using StudentInfo;
using NPOI.SS.Formula.Functions;

namespace OlympicStudents
{
    public partial class MainForm : Form
    {
        private void CreateDateInListView(ListView listView) 
        {
            listView.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("���");
            listView.Columns.Add("���� ��������");
            listView.Columns.Add("�����");
            listView.Columns.Add("����� ��������");
            listView.Columns.Add("������");
            listView.Columns.Add("���� �����������");
            listView.Columns.Add("���� �������");
            listView.Columns.Add("����");
            listView.Columns.Add("������������");
        }
        public void UpdateDataStudent()
        {
            CreateDateInListView(listViewStudent);
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
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            NewStudentForm ns = new NewStudentForm();
            ns.Show();
        }

        private void addOlimp_Click(object sender, EventArgs e)
        {
            NewOlympiadForm ns = new NewOlympiadForm(DataBase.FindStudentById(listViewStudent.SelectedItems[0].Text.ToString()));
            ns.Show();
        }

        private void UpdateDataStudent_Click(object sender, EventArgs e)
        {
            UpdateDataStudent();
        }
        private void addOlimpiads(int id)
        {
            listViewOlimp.Columns.Add("����", 100);
            listViewOlimp.Columns.Add("�������");
            listViewOlimp.Columns.Add("���");
            listViewOlimp.Columns.Add("�������");
            listViewOlimp.Columns.Add("����������");
            listViewOlimp.Columns.Add("���������");
            listViewOlimp.Columns.Add("�����������������");
            listViewOlimp.Columns.Add("�������� ");
            listViewOlimp.Columns.Add("����� ����������");
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
        private void buttonDisplayOlimp_Click(object sender, EventArgs e)
        {
            listViewOlimp.Clear();
            listViewOlimp.View = View.Details;
            listViewOlimp.GridLines = true;
            listViewOlimp.FullRowSelect = true;
            addOlimpiads(DataBase.FindStudentById(listViewStudent.SelectedItems[0].Text.ToString()));
        }
        private void excel_Click(object sender, EventArgs e)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet1 = workbook.CreateSheet("�����");
            IRow row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("���� ����������");
            row1.CreateCell(1).SetCellValue("�������");
            row1.CreateCell(2).SetCellValue("���");
            row1.CreateCell(3).SetCellValue("�������");
            row1.CreateCell(4).SetCellValue("����������");
            row1.CreateCell(5).SetCellValue("���������");
            row1.CreateCell(6).SetCellValue("�����������������");
            row1.CreateCell(7).SetCellValue("�������� ��������");
            row1.CreateCell(8).SetCellValue("���������������");
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
                MessageBox.Show($"'{start.ToString("yyyy-MM-dd")}''{end.ToString("yyyy-MM-dd")}'");
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if ((listViewStudent.SelectedItems.Count > 0) && !(listViewOlimp.SelectedItems.Count > 0))
            {
                List<int?> res = new List<int?>();
                using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();
                    int k = 9;

                    SqliteCommand command = new SqliteCommand($"SELECT olympiad_id FROM result WHERE student_id='{DataBase.FindStudentById(listViewStudent.SelectedItems[0].Text.ToString()).ToString()}'", connection);
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

                    DataBase.Delete("result", "", "student_id", DataBase.FindStudentById(listViewStudent.SelectedItems[0].Text.ToString()).ToString());
                }
                DataBase.Delete("student", "", "student_id", DataBase.FindStudentById(listViewStudent.SelectedItems[0].Text.ToString()).ToString());
            }
            if ((listViewStudent.SelectedItems.Count > 0) && (listViewOlimp.SelectedItems.Count > 0))
            {
                listViewStudent.SelectedItems[0].Text.ToString();
                DataBase.Delete("olympiad", "", "olympiad_id", $"{listViewOlimp.SelectedItems[0].SubItems[9].Text.ToString()}");
                DataBase.Delete("result", "", "olympiad_id", $"{listViewOlimp.SelectedItems[0].SubItems[9].Text.ToString()}");
            }
            UpdateDataStudent();
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
            listViewStudent.Columns.Add("���", 100);
            listViewStudent.Columns.Add("���� ��������");
            listViewStudent.Columns.Add("�����");
            listViewStudent.Columns.Add("����� ��������");
            listViewStudent.Columns.Add("������");
            listViewStudent.Columns.Add("���� �����������");
            listViewStudent.Columns.Add("���� �������");
            listViewStudent.Columns.Add("����");
            listViewStudent.Columns.Add("������������");
            foreach (var i in res)
            {
                item = new ListViewItem(i.ToArray());
                listViewStudent.Items.Add(item);
            }
        }
    }
}