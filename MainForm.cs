using NPOI.XSSF.UserModel;
using Microsoft.Data.Sqlite;
using NPOI.SS.UserModel;
using StudentInfo;
using System.Collections;
using System.Windows.Forms;

namespace OlympicStudents
{
    public partial class MainForm : Form
    {
        private void listViewStudents_MouseOneClick(object sender, MouseEventArgs e)
        {
            int index = listViewStudent.SelectedIndices[0];
            string studentId = (listViewStudent.Items[index].SubItems[0].Text);
            int id = DataBase.FindStudentById(studentId);
            Adapter.InitializeListViewOlimpiads(listViewOlympiadsOfStudent);
            Adapter.StudentOlympiadsAsync(listViewOlympiadsOfStudent,id);
        }
        private async void UpdateDataStudentAsync()
        {
            Adapter.InitializeListViewSudent(listViewStudent);
            Adapter.FillStudentListVewAsync(listViewStudent);
        }
        public MainForm()
        {
            InitializeComponent();
            panelMenuStudents.Width = 315;
            panelMenuStudents.Dock= DockStyle.Right;

            splitContainer1.Width -= 300;
            Panel upPanel = new Panel();
            upPanel.Dock = DockStyle.Fill;
            listViewStudent.Dock = DockStyle.Fill;
            upPanel.Controls.Add(listViewStudent);
            splitContainer1.Panel1.Controls.Add(upPanel);
            Panel bottomPanel = new Panel();
            bottomPanel.Dock = DockStyle.Fill;

            listViewOlympiadsOfStudent.Dock = DockStyle.Fill;
            bottomPanel.Controls.Add(listViewOlympiadsOfStudent);

            splitContainer1.Panel2.Controls.Add(bottomPanel);

            UpdateDataStudentAsync();
            AddOlimpiads();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            using (NewStudentForm ns = new NewStudentForm())
            {
                ns.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NewOlympiadForm ns = new NewOlympiadForm())
            {
                ns.ShowDialog();
            }
        }

        private void AddOlimpiads()
        {
            Adapter.InitializeListViewOlimpiads(listViewOlimp);
            Adapter.FillOlimpiadsListVewAsync(listViewOlimp);
        }
      
        private void excel_Click(object sender, EventArgs e)
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
            UpdateDataStudentAsync();
        }


        private void search_Click_1(object sender, EventArgs e)
        {

            var res = DataBase.Search("student", "(fio || dateOfBirth || address || phone || groups || yearApplying || yearOfRelease || course || specialization )", $"{textBoxSearch.Text}");
            listViewStudent.Clear();
            ListViewItem item;
            Adapter.InitializeListViewSudent(listViewStudent);
            foreach (var i in res)
            {
                item = new ListViewItem(i.ToArray());
                listViewStudent.Items.Add(item);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = new List<List<string>>();
            foreach (var selectedItem in checkedListBox1.CheckedItems)
            {
                res.AddRange(DataBase.Search("student", "specialization", selectedItem.ToString()));
            }
            listViewStudent.Clear();
            ListViewItem item;
            Adapter.InitializeListViewSudent(listViewStudent);
            foreach (var i in res)
            {
                item = new ListViewItem(i.ToArray());
                listViewStudent.Items.Add(item);
            }

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = new List<List<string>>();
            foreach (var selectedItem in checkedListBox2.CheckedItems)
            {
                res.AddRange(DataBase.Search("student", "course", selectedItem.ToString()));
            }
            listViewStudent.Clear();
            ListViewItem item;
            Adapter.InitializeListViewSudent(listViewStudent);
            foreach (var i in res)
            {
                item = new ListViewItem(i.ToArray());
                listViewStudent.Items.Add(item);
            }
        }

       
    }
}