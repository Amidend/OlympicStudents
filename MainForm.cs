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

        private async void UpdateDataStudentAsync()
        {
            Adapter.InitializeListViewSudent(listViewStudent);
            Adapter.FillStudentListVewAsync(listViewStudent);
        }
        public MainForm()
        {
            InitializeComponent();
            panelMenuStudents.Width = 315;
            panelMenuStudents.Dock = DockStyle.Right;

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
            UpdateDataOlimpiadsAsync();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            using (NewStudentForm ns = new NewStudentForm())
            {
                ns.ShowDialog();
            }
            UpdateDataStudentAsync();
        }

        private void AddOlimpiads_Click(object sender, EventArgs e)
        {
            using (NewOlympiadForm ns = new NewOlympiadForm())
            {
                ns.ShowDialog();
            }
            UpdateDataOlimpiadsAsync();
        }

        private void UpdateDataOlimpiadsAsync()
        {
            Adapter.InitializeListViewOlimpiads(listViewOlimp);
            Adapter.FillOlimpiadsListVewAsync(listViewOlimp);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if ((listViewStudent.SelectedItems.Count > 0) && !(listViewOlympiadsOfStudent.SelectedItems.Count > 0))
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
            if ((listViewStudent.SelectedItems.Count > 0) && (listViewOlympiadsOfStudent.SelectedItems.Count > 0))
            {
                DataBase.Delete("olympiad", "", "olympiad_id", $"{listViewOlympiadsOfStudent.SelectedItems[0].SubItems[9].Text.ToString()}");
                DataBase.Delete("result", "", "olympiad_id", $"{listViewOlympiadsOfStudent.SelectedItems[0].SubItems[9].Text.ToString()}");
            }
            listViewStudents_MouseOneClick(sender, (MouseEventArgs)e);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<string> criteriaList = new List<string>();
            foreach (var SearchItem in checkedListBoxSearch.CheckedItems)
            {
                switch (SearchItem.ToString())
                {
                    case "ФИО":
                        criteriaList.Add("fio");
                        break;
                    case "Дата рождения":
                        criteriaList.Add("dateOfBirth");
                        break;
                    case "Адрес":
                        criteriaList.Add("address");
                        break;
                    case "Номер телефона":
                        criteriaList.Add("phone");
                        break;
                    case "Группа":
                        criteriaList.Add("groups");
                        break;
                    case "Дата поступления":
                        criteriaList.Add("yearApplying");
                        break;
                    case "Дата выпуска":
                        criteriaList.Add("yearOfRelease");
                        break;
                    case "Курс":
                        criteriaList.Add("course");
                        break;
                    case "Специализация":
                        criteriaList.Add("specialization");
                        break;
                }
            }
            string searchCriteria;
            if (criteriaList.Count == 0)
            {
                searchCriteria = "(fio || dateOfBirth || address || phone || groups || yearApplying || yearOfRelease || course || specialization)";
            }
            else
            {
                searchCriteria = string.Join(" || ", criteriaList);
            }
            var res = DataBase.Search("student", searchCriteria, $"{textBoxSearch.Text}");
            listViewStudent.Clear();
            Adapter.InitializeListViewSudent(listViewStudent);
            foreach (var i in res)
            {
                ListViewItem item = new ListViewItem(i.ToArray());
                listViewStudent.Items.Add(item);
            }
        }

        private void checkedListBoxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = new List<List<string>>();
            foreach (var selectedItem in checkedListBoxSpecialization.CheckedItems)
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

        private void checkedListBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = new List<List<string>>();
            foreach (var selectedItem in checkedListBoxCourse.CheckedItems)
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

        private void buttonDumping_Click(object sender, EventArgs e)
        {
            foreach (CheckedListBox clb in new List<CheckedListBox> { checkedListBoxSpecialization, checkedListBoxCourse, checkedListBoxSearch })
            {
                foreach (int i in clb.CheckedIndices)
                {
                    clb.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            UpdateDataStudentAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewOlimp.SelectedItems.Count > 0)
            {
                DataBase.Delete("olympiad", "", "olympiad_id", $"{listViewOlimp.SelectedItems[0].SubItems[9].Text.ToString()}");
                DataBase.Delete("result", "", "olympiad_id", $"{listViewOlimp.SelectedItems[0].SubItems[9].Text.ToString()}");
            }
            UpdateDataOlimpiadsAsync();
        }
        private void listViewStudents_MouseOneClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listViewStudent.SelectedIndices[0];
                string studentId = (listViewStudent.Items[index].SubItems[0].Text);
                int id = DataBase.FindStudentById(studentId);
                Adapter.InitializeListViewOlimpiads(listViewOlympiadsOfStudent);
                Adapter.FillStudentOlympiadsAsync(listViewOlympiadsOfStudent, id);
            }
            catch (Exception ex) { }
        }

        private void listViewOlimp_MouseOneClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listViewOlimp.SelectedIndices[0];
                string studentId = (listViewOlimp.Items[index].SubItems[9].Text);
                int id = DataBase.FindStudentByOlimpyad(studentId);
                List<Label> labels = new List<Label>() { labelfio, labeldob, labeladd, labelph1, labelph2, labelph3, labelgro, labelyap, labelyor, labelcou, labelspe };
                Adapter.FillStudentInformationAsync(id, labels);


            }
            catch (Exception ex) { }
        }

        private void buttonSearchOlympyad_Click(object sender, EventArgs e)
        {
            List<string> criteriaList = new List<string>();
            foreach (var SearchItem in checkedListBoxSearchOlipyad.CheckedItems)
            {
                switch (SearchItem.ToString())
                {
                    case "Дата":
                        criteriaList.Add("dates");
                        break;
                    case "Уровень":
                        criteriaList.Add("level");
                        break;
                    case "Вид":
                        criteriaList.Add("type");
                        break;
                    case "Награда":
                        criteriaList.Add("awards");
                        break;
                    case "Поощерение":
                        criteriaList.Add("encouragement");
                        break;
                    case "Номинации":
                        criteriaList.Add("nominations");
                        break;
                    case "Продалжительность":
                        criteriaList.Add("duration");
                        break;
                    case "Название":
                        criteriaList.Add("title");
                        break;
                    case "Место проведения":
                        criteriaList.Add("venue");
                        break;
                }
            }
            string searchCriteria;
            if (criteriaList.Count == 0)
            {
                searchCriteria = "(dates || level || type || awards || encouragement || nominations || duration || title || venue)";
            }
            else
            {
                searchCriteria = string.Join(" || ", criteriaList);
            }
            var res = DataBase.Search("olympiad", searchCriteria, $"{textBoxSearchOlimpyad.Text}");
            listViewOlimp.Clear();
            Adapter.InitializeListViewOlimpiads(listViewOlimp);
            foreach (var i in res)
            {
                ListViewItem item = new ListViewItem(i.ToArray());
                listViewOlimp.Items.Add(item);
            }
        }

        private void buttonDumpingOlimpyad_Click(object sender, EventArgs e)
        {
            foreach (CheckedListBox clb in new List<CheckedListBox> { checkedListBoxLevel, checkedListBoxType, checkedListBoxAvards, checkedListBoxEnco })
            {
                foreach (int i in clb.CheckedIndices)
                {
                    clb.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            UpdateDataOlimpiadsAsync();
        }
        private void excel_ClickAsync(object sender, EventArgs e)
        {
            List<string> criteriaList = new List<string>();
            foreach (var SearchItem in checkedListBoxSearch.CheckedItems)
            {
                switch (SearchItem.ToString())
                {
                    case "Правоведение":
                        criteriaList.Add("Правоведение");
                        break;
                    case "Коммерческая деятельность":
                        criteriaList.Add("Коммерческая деятельность");
                        break;
                    case "Банковское дело":
                        criteriaList.Add("Банковское дело");
                        break;
                    case "Бухгалтерский учет, анализ и контроль":
                        criteriaList.Add("Бухгалтерский учет, анализ и контроль");
                        break;
                    case "Операционная логистика":
                        criteriaList.Add("Операционная логистика");
                        break;
                    case "Экономика и организация производства":
                        criteriaList.Add("Экономика и организация производства");
                        break;
                    case "Программное обеспечение информационных технологий":
                        criteriaList.Add("Программное обеспечение информационных технологий");
                        break;
                }
            }
            string searchCriteria;
            if (criteriaList.Count == 0)
            {
                searchCriteria = "Правоведение||Коммерческая деятельность||Банковское дело||Бухгалтерский учет, анализ и контроль||Операционная логистика||Экономика и организация производства||Программное обеспечение информационных технологий";
            }
            else
            {
                searchCriteria = string.Join(" || ", criteriaList);
            }
          

            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet1 = workbook.CreateSheet("Отчет");
            IRow row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("ФИО");
            row1.CreateCell(1).SetCellValue("Название Оимпиады");
            row1.CreateCell(2).SetCellValue("Дата проведения");
            row1.CreateCell(3).SetCellValue("Награды");
            row1.CreateCell(4).SetCellValue("Поощерение");
            List<int> size = DataBase.findByids(numericUpDown1);

            for (int k = 0; k < size.Count; k++)
            {
                var student_id = DataBase.FindStudentByOlimpyad(size[k].ToString());
                List<string> Olympyad =  DataBase.FindOlimpyadById(size[k].ToString());
                List<string> Student =  DataBase.GetStuentInfofrmationAndSp(student_id.ToString(), searchCriteria);
                
                if (Student.Count > 0)
                {
                    IRow row = sheet1.CreateRow(k + 1);
                    row.CreateCell(0).SetCellValue(Student[0]);
                    row.CreateCell(1).SetCellValue(Olympyad[7]);
                    row.CreateCell(2).SetCellValue(Olympyad[0]);
                    row.CreateCell(3).SetCellValue(Olympyad[3]);
                    row.CreateCell(4).SetCellValue(Olympyad[4]);
                }
            }
            FileStream sw = File.Create("test.xlsx");
            workbook.Write(sw);
            sw.Close();
        }

    }
}