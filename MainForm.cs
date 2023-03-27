using Microsoft.Data.Sqlite;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Globalization;

namespace OlympicStudents
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            updateDataStudent();
            updateDataOlimpiads();
            UpdateDAta();
        }

        private Dictionary<TabPage, int> tabPageIndexes = new Dictionary<TabPage, int>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            // save the indexes of each TabPage in a dictionary
            for (int i = 0; i < tabMain.TabPages.Count; i++)
            {
                tabPageIndexes.Add(tabMain.TabPages[i], i);
            }
        }

        //Чек боксики
        private void checkBoxesStudents_CheckedChanged(object sender, EventArgs e)
        {
            var selectedSpecializations = checkedListBoxSpecialization.CheckedItems.Cast<string>().ToList();
            var selectedCourses = checkedListBoxCourse.CheckedItems.Cast<string>().ToList();

            var searchFields = new List<string>();
            var searchValues = new List<string>();
            var searchResults = new List<List<string>>();

            if (selectedSpecializations.Any())
            {
                searchFields.Add("specialization");
                searchValues.AddRange(selectedSpecializations);
            }

            if (selectedCourses.Any())
            {
                searchFields.Add("course");
                searchValues.AddRange(selectedCourses);
            }
            if (searchFields.Any())
            {
                searchResults = DataBase.MultiSearch(Constants.tableStudent, searchFields, searchValues)
               .Select(dict => dict.Values.ToList())
               .ToList();
            }


            ListViewItem item;
            Adapter.InitializeListViewSudent(listViewStudent);
            foreach (var i in searchResults)
            {
                item = new ListViewItem(i.ToArray());
                listViewStudent.Items.Add(item);
            }
            if (selectedCourses.Count == 0 && selectedSpecializations.Count == 0)
            {
                updateDataStudent();
            }
        }
        private void checkBoxesOlimp_CheckedChanged(object sender, EventArgs e)
        {

            var selectedAvards = checkedListBoxAvards.CheckedItems.Cast<string>().ToList();
            var selectedEnco = checkedListBoxEnco.CheckedItems.Cast<string>().ToList();
            var selectedLevel = checkedListBoxLevel.CheckedItems.Cast<string>().ToList();
            var selectedType = checkedListBoxType.CheckedItems.Cast<string>().ToList();

            var searchFields = new List<string>();
            var searchValues = new List<string>();
            var searchResults = new List<List<string>>();

            if (selectedAvards.Any())
            {
                searchFields.Add("awards");
                searchValues.AddRange(selectedAvards);
            }

            if (selectedEnco.Any())
            {
                searchFields.Add("encouragement");
                searchValues.AddRange(selectedEnco);
            }

            if (selectedLevel.Any())
            {
                searchFields.Add("level");
                searchValues.AddRange(selectedLevel);
            }

            if (selectedType.Any())
            {
                searchFields.Add("type");
                searchValues.AddRange(selectedType);
            }

            if (searchFields.Any())
            {
                searchResults = DataBase.MultiSearch("olympiad", searchFields, searchValues)
                .Select(dict => dict.Values.ToList())
                .ToList();
            }

            ListViewItem item;
            Adapter.InitializeListViewOlimpiads(listViewOlimp);
            foreach (var i in searchResults)
            {
                item = new ListViewItem(i.ToArray());
                listViewOlimp.Items.Add(item);
            }

            if (selectedAvards.Count == 0 && selectedEnco.Count == 0 && selectedLevel.Count == 0 && selectedType.Count == 0)
            {
                updateDataOlimpiads();
            }
        }

        //Добавление(новые формочки)
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            using (NewStudentForm ns = new NewStudentForm())
            {
                ns.ShowDialog();
            }
            UpdateDAta();
        }
        private void addOlimpiads_Click(object sender, EventArgs e)
        {
            using (NewOlympiadForm ns = new NewOlympiadForm())
            {
                ns.ShowDialog();
            }
            UpdateDAta();
        }
        //Когда нажал на табличку
        private void listViewStudents_MouseOneClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listViewStudent.SelectedIndices[0];
                int id = int.Parse(listViewStudent.Items[index].SubItems[0].Text);
                Adapter.InitializeListViewOlimpiads(listViewOlympiadsOfStudent);
                Adapter.FillStudentOlympiadsAsync(listViewOlympiadsOfStudent, id, "olympiad_id", "result", "student_id", "olympiad");
            }
            catch (ArgumentOutOfRangeException ex) { }
        }
        private void listViewOlimp_MouseOneClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listViewOlimp.SelectedIndices[0];
                string studentId = (listViewOlimp.Items[index].SubItems[0].Text);
                int id = DataBase.FindStudentByOlimpyad(studentId, "student_id", "result", "olympiad_id");
                List<Label> labels = new List<Label>() { labelfio, labeldob, labeladd, labelph1, labelph2, labelph3, labelgro, labelyap, labelyor, labelcou, labelspe };
                Adapter.FillStudentInformationAsync(id, labels);
            }
            catch (Exception ex) { }
        }
        //Поиск
        private void buttonSearchStudents_Click(object sender, EventArgs e)
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
            var res = DataBase.Search(Constants.tableStudent, searchCriteria, $"{textBoxSearchStudents.Text}");
            listViewStudent.Clear();
            Adapter.InitializeListViewSudent(listViewStudent);
            foreach (var i in res)
            {
                ListViewItem item = new ListViewItem(i.ToArray());
                listViewStudent.Items.Add(item);
            }
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
        //Удаление
        private void deleteStudents_Click(object sender, EventArgs e)
        {

            if ((listViewStudent.SelectedItems.Count > 0) && !(listViewOlympiadsOfStudent.SelectedItems.Count > 0))
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {


                    List<int?> res = new List<int?>();
                    using (var connection = new SqliteConnection("Data Source=data.db"))
                    {
                        connection.Open();
                        int k = 9;

                        SqliteCommand command = new SqliteCommand($"SELECT olympiad_id FROM result WHERE student_id='{listViewStudent.Items[listViewStudent.SelectedIndices[0]].SubItems[0].Text.ToString()}'", connection);
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

                        DataBase.Delete("result", "", "student_id", listViewStudent.Items[listViewStudent.SelectedIndices[0]].SubItems[0].Text.ToString());
                    }
                    DataBase.Delete("student", "", "id", listViewStudent.Items[listViewStudent.SelectedIndices[0]].SubItems[0].Text.ToString());
                }
            }
            if ((listViewStudent.SelectedItems.Count > 0) && (listViewOlympiadsOfStudent.SelectedItems.Count > 0))
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    DataBase.Delete("olympiad", "", "olympiad_id", $"{listViewOlympiadsOfStudent.Items[listViewOlympiadsOfStudent.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                    DataBase.Delete("result", "", "olympiad_id", $"{listViewOlympiadsOfStudent.Items[listViewOlympiadsOfStudent.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                }
            }
            listViewStudents_MouseOneClick(sender, (MouseEventArgs)e);
            updateDataStudent();
            updateDataOlimpiads();
        }
        private void deleteOlimpyad_Click(object sender, EventArgs e)
        {
            if (listViewOlimp.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataBase.Delete("olympiad", "", "olympiad_id", $"{listViewOlimp.Items[listViewOlimp.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                    DataBase.Delete("result", "", "olympiad_id", $"{listViewOlimp.Items[listViewOlimp.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                }
            }
            updateDataOlimpiads();
        }
        //Сброс
        private void buttonDumpingStudents_Click(object sender, EventArgs e)
        {
            foreach (CheckedListBox clb in new List<CheckedListBox> { checkedListBoxSpecialization, checkedListBoxCourse, checkedListBoxSearch })
            {
                foreach (int i in clb.CheckedIndices)
                {
                    clb.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            textBoxSearchStudents.Text = string.Empty;
            updateDataStudent();
        }
        private void buttonDumpingOlimpyad_Click(object sender, EventArgs e)
        {
            foreach (CheckedListBox clb in new List<CheckedListBox> { checkedListBoxLevel, checkedListBoxType, checkedListBoxAvards, checkedListBoxEnco, checkedListBoxSearchOlipyad })
            {
                foreach (int i in clb.CheckedIndices)
                {
                    clb.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            textBoxSearchOlimpyad.Text = string.Empty;
            updateDataOlimpiads();
        }
        //Отчёт
        private void excelReport_ClickAsync(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            List<string> criteriaList = new List<string>();
            foreach (var SearchItem in checkedListBoxCriteriaExcel.CheckedItems)
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
                        strings.Add("Экономике и организации производства");
                        break;
                    case "Программное обеспечение информационных технологий":
                        criteriaList.Add("Программное обеспечение информационных технологий");
                        strings.Add("Программному обеспечению информационных технологий");
                        break;
                }
            }
            string searchCriteria;
            string categories;
            string report;
            if (criteriaList.Count == 0 || criteriaList.Count == 7)
            {
                searchCriteria = "Правоведение||Коммерческая деятельность||Банковское дело||Бухгалтерский учет, анализ и контроль||Операционная логистика||Экономика и организация производства||Программное обеспечение информационных технологий";
                categories = "Правоведение, Коммерческая деятельность, Банковское дело, Бухгалтерский учет, анализ и контроль, Операционная логистика, Экономика и организация производства, Программное обеспечение информационных технологий";
                report = $"Отчет об участии учащихся колледжа в олимпиадах \nза {numericUpDown1.Value}-{numericUpDown2.Value} учебный год ";
            }
            else if (criteriaList.Count == 1)
            {
                searchCriteria = string.Join("||", criteriaList);
                categories = string.Join(", ", criteriaList);

                report = $"Отчет об участии учащихся специальности \"{categories}\" в олимпиадах \nза {numericUpDown1.Value}-{numericUpDown2.Value} учебный год ";
            }
            else
            {
                List<string> criteriaList1 = new List<string>();
                for (int i = 0; i < criteriaList.Count; i++)
                {
                    criteriaList1.Add("\"" + criteriaList[i].ToString() + "\"");
                }
                searchCriteria = string.Join("||", criteriaList);
                categories = string.Join(", ", criteriaList1);
                report = $"Отчет об участии учащихся специальностей {categories} в олимпиадах \nза {numericUpDown1.Value}-{numericUpDown2.Value} учебный год ";
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("fio");
            dt.Columns.Add("title");
            dt.Columns.Add("dates");
            dt.Columns.Add("awards");
            dt.Columns.Add("encouragement");

            List<int> size = DataBase.findByids(numericUpDown1, numericUpDown2);
            for (int k = 0; k < size.Count; k++)
            {
                var student_id = DataBase.FindStudentByOlimpyad(size[k].ToString(), "student_id", "result", "olympiad_id");
                List<string> Olympyad = DataBase.FindOlimpyadById(size[k].ToString());
                List<string> Student = DataBase.GetStuentInfofrmationAndSp(student_id.ToString(), searchCriteria);

                if (Student.Count > 0)
                {
                    DataRow row = dt.NewRow();
                    row["fio"] = Student[1];
                    row["title"] = Olympyad[2];
                    DateTime dateTime;
                    if (DateTime.TryParseExact(Olympyad[1], "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                    {
                        row["dates"] = dateTime.ToString("dd.MM.yyyy");
                    }
                    else
                    {
                        // Handle the case where the date string is empty or invalid
                        row["dates"] = string.Empty; // or set to some default value
                    }
                    row["awards"] = Olympyad[5];
                    row["encouragement"] = Olympyad[6];
                    dt.Rows.Add(row);
                }
            }
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "OlympicStudents.ReportDefenitions.Report.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ReportParameter1", report));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
        //Обнуление таблички
        private void UpdateDAta()
        {
            updateDataStudent();
            updateDataOlimpiads();
            UpdateDataEWG();
            UpdateDataHonor();
            UpdateDataEW();
            UpdateDataEducationWorkStudent();
            UpdateDataHonorStudent();
        }
        private void updateDataStudent()
        {
            Adapter.InitializeListViewSudent(listViewStudent);
            Adapter.FillListVewAsync(listViewStudent, Constants.tableStudent, "student_id", "result");
        }
        private void updateDataOlimpiads()
        {
            Adapter.InitializeListViewOlimpiads(listViewOlimp);
            Adapter.FillListVewAsync(listViewOlimp, Constants.tableOlimpiad, "olympiad_id", "result");
        }
        private void UpdateDataEWG()
        {
            Adapter.InitializeEducationWorkGroup(listViewEducationWorkGroup);
            Adapter.FillListVewAsync(listViewEducationWorkGroup, Constants.tableEWG);
        }
        private void UpdateDataHonor()
        {
            Adapter.InitializeHonor(listViewHonor);
            Adapter.FillListVewAsync(listViewHonor, Constants.tableHonor);
        }
        private void UpdateDataEW()
        {
            Adapter.InitializeEW(listViewEducationWork);
            Adapter.FillListVewAsync(listViewEducationWork, Constants.tableEW);

        }
        private void UpdateDataEducationWorkStudent()
        {
            Adapter.InitializeListViewSudent(listViewEWStudent);
            Adapter.FillListVewAsync(listViewEWStudent, Constants.tableStudent, "student_id", "education_works");
        }
        private void UpdateDataHonorStudent()
        {
            Adapter.InitializeListViewSudent(listViewStudentsH);
            Adapter.FillListVewAsync(listViewStudentsH, Constants.tableStudent, "student_id", "honors");
        }
        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            if ((listViewStudent.SelectedItems.Count > 0) && !(listViewOlympiadsOfStudent.SelectedItems.Count > 0))
            {
                int.TryParse(listViewStudent.Items[listViewStudent.SelectedIndices[0]].SubItems[0].Text, out int studentId);
                using (NewStudentForm ns = new NewStudentForm(studentId))
                {
                    ns.ShowDialog();
                }

                updateDataStudent();
                updateDataOlimpiads();
            }
            if ((listViewOlympiadsOfStudent.SelectedItems.Count > 0))
            {
                int.TryParse(listViewOlympiadsOfStudent.Items[listViewOlympiadsOfStudent.SelectedIndices[0]].SubItems[0].Text, out int olimpiadId);
                using (NewOlympiadForm ns = new NewOlympiadForm(olimpiadId))
                {
                    ns.ShowDialog();
                }
                updateDataStudent();
                updateDataOlimpiads();
            }

        }
        private void buttonUpdateOlimpiad_Click(object sender, EventArgs e)
        {
            if ((listViewOlimp.SelectedItems.Count > 0) && (listViewOlimp.SelectedItems.Count == 1))
            {
                int.TryParse(listViewOlimp.Items[listViewOlimp.SelectedIndices[0]].SubItems[0].Text, out int olimpiadId);
                using (NewOlympiadForm ns = new NewOlympiadForm(olimpiadId))
                {
                    ns.ShowDialog();
                }
                updateDataStudent();
                updateDataOlimpiads();
            }
        }

        private void buttonAddEW_Click(object sender, EventArgs e)
        {
            using (NewEWForm ns = new NewEWForm())
            {
                ns.ShowDialog();
            }
            UpdateDataEW();
        }

        private void buttonUpdateEW_Click(object sender, EventArgs e)
        {
            if ((listViewEducationWork.SelectedItems.Count > 0) && (listViewEducationWork.SelectedItems.Count == 1))
            {
                int.TryParse(listViewEducationWork.Items[listViewEducationWork.SelectedIndices[0]].SubItems[0].Text, out int Id);
                using (NewEWForm ns = new NewEWForm(Id))
                {
                    ns.ShowDialog();
                }
                UpdateDataEW();
            }
        }

        private void buttonDeleteEW_Click(object sender, EventArgs e)
        {
            if (listViewEducationWork.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataBase.Delete("education_work", "", "id", $"{listViewEducationWork.Items[listViewEducationWork.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                    DataBase.Delete("education_works", "", "education_work_id", $"{listViewEducationWork.Items[listViewEducationWork.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                }
            }
            UpdateDAta();
        }
        private void buttonDeleteHonor_Click(object sender, EventArgs e)
        {
            if (listViewHonor.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataBase.Delete("honor", "", "id", $"{listViewHonor.Items[listViewHonor.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                    DataBase.Delete("honors", "", "honor_id", $"{listViewHonor.Items[listViewHonor.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                }
            }
            UpdateDAta();
        }

        private void buttonAddHonor_Click(object sender, EventArgs e)
        {
            using (NewHonorForm ns = new NewHonorForm())
            {
                ns.ShowDialog();
            }
            UpdateDAta();
        }

        private void buttonUpdateHonor_Click(object sender, EventArgs e)
        {
            if ((listViewHonor.SelectedItems.Count > 0) && (listViewHonor.SelectedItems.Count == 1))
            {
                int.TryParse(listViewHonor.Items[listViewHonor.SelectedIndices[0]].SubItems[0].Text, out int Id);
                using (NewHonorForm ns = new NewHonorForm(Id))
                {
                    ns.ShowDialog();
                }
                UpdateDAta();
            }
        }



        private void buttonAddEWG_Click(object sender, EventArgs e)
        {
            using (NewEWGroupForm ns = new NewEWGroupForm())
            {
                ns.ShowDialog();
            }
            UpdateDAta();
        }

        private void buttonUpdateEWG_Click(object sender, EventArgs e)
        {

            if ((listViewEducationWorkGroup.SelectedItems.Count > 0) && (listViewEducationWorkGroup.SelectedItems.Count == 1))
            {
                int.TryParse(listViewEducationWorkGroup.Items[listViewEducationWorkGroup.SelectedIndices[0]].SubItems[0].Text, out int Id);
                using (NewEWGroupForm ns = new NewEWGroupForm(Id))
                {
                    ns.ShowDialog();
                }
                UpdateDAta();
            }
        }

        private void buttonDeleteEWG_Click(object sender, EventArgs e)
        {
            if (listViewEducationWorkGroup.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataBase.Delete("education_work_group", "", "id", $"{listViewEducationWorkGroup.Items[listViewEducationWorkGroup.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                }
            }
            UpdateDAta();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 0)
            {
                tabMain.SelectedIndex = 1;
                tabMain.TabPages[0].Hide();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 1)
            {
                tabMain.SelectedIndex = 0;
                tabMain.TabPages[1].Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 3)
            {
                tabMain.SelectedIndex = 4;
                tabMain.TabPages[3].Hide();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 4)
            {
                tabMain.SelectedIndex = 3;
                tabMain.TabPages[4].Hide();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 5)
            {
                tabMain.SelectedIndex = 6;
                tabMain.TabPages[5].Hide();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 6)
            {
                tabMain.SelectedIndex = 5;
                tabMain.TabPages[6].Hide();
            }
        }

        private void listViewEducationWorkGroup_MouseClick(object sender, MouseEventArgs e)
        {

        }



        private void listViewEducationWork_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listViewEducationWork.SelectedIndices[0];
                string studentId = (listViewEducationWork.Items[index].SubItems[0].Text);
                int id = DataBase.FindStudentByOlimpyad(studentId, "student_id", "education_works", "education_work_id");
                List<Label> labels = new List<Label>() { labelfioEW, labelDoBEW, labeladressEW, labellabelph1EW, labellabelph2EW, labellabelph3Ew, labelGroupEW, labelDoAEW, labelDoEEW, labelCourseEW, labelspEW };
                Adapter.FillStudentInformationAsync(id, labels);
            }
            catch (Exception ex) { }
        }



        private void listViewHonor_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listViewHonor.SelectedIndices[0];
                string studentId = (listViewHonor.Items[index].SubItems[0].Text);
                int id = DataBase.FindStudentByOlimpyad(studentId, "student_id", "honors", "honor_id");
                List<Label> labels = new List<Label>() { labelfioH, labelDoBH, labeladressH, labelph1H, labelph2H, labelph3H, labelGroupH, labelDoAH, labelDoEH, labelCourseH, labelspH };
                Adapter.FillStudentInformationAsync(id, labels);
            }
            catch (Exception ex) { }
        }

        private void listViewEWStudent_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listViewEWStudent.SelectedIndices[0];
                int id = int.Parse(listViewEWStudent.Items[index].SubItems[0].Text);
                Adapter.InitializeEW(listViewEWByStudent);
                Adapter.FillStudentOlympiadsAsync(listViewEWByStudent, id, "education_work_id", "education_works", "student_id", "education_work");
            }
            catch (ArgumentOutOfRangeException ex) { }
        }
        private void listViewStudentsH_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listViewStudentsH.SelectedIndices[0];
                int id = int.Parse(listViewStudentsH.Items[index].SubItems[0].Text);
                Adapter.InitializeHonor(listViewHonorByS);
                Adapter.FillStudentOlympiadsAsync(listViewHonorByS, id, "honor_id", "honors", "student_id", "honor");
            }
            catch (ArgumentOutOfRangeException ex) { }
        }

        private void buttonUpdateEWS_Click(object sender, EventArgs e)
        {

            if ((listViewStudent.SelectedItems.Count > 0) && !(listViewOlympiadsOfStudent.SelectedItems.Count > 0))
            {
                int.TryParse(listViewStudent.Items[listViewStudent.SelectedIndices[0]].SubItems[0].Text, out int studentId);
                using (NewStudentForm ns = new NewStudentForm(studentId))
                {
                    ns.ShowDialog();
                }

                updateDataStudent();
                updateDataOlimpiads();
            }
            if ((listViewOlympiadsOfStudent.SelectedItems.Count > 0))
            {
                int.TryParse(listViewOlympiadsOfStudent.Items[listViewOlympiadsOfStudent.SelectedIndices[0]].SubItems[0].Text, out int olimpiadId);
                using (NewOlympiadForm ns = new NewOlympiadForm(olimpiadId))
                {
                    ns.ShowDialog();
                }
                updateDataStudent();
                updateDataOlimpiads();
            }
           
        }

        private void buttonAddEWS_Click(object sender, EventArgs e)
        {
            buttonAddStudent_Click(sender, e);
        }

        private void buttonDeleteEWS_Click(object sender, EventArgs e)
        {
            if ((listViewEWStudent.SelectedItems.Count > 0) && !(listViewEWByStudent.SelectedItems.Count > 0))
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {


                    List<int?> res = new List<int?>();
                    using (var connection = new SqliteConnection("Data Source=data.db"))
                    {
                        connection.Open();
                        int k = 9;

                        SqliteCommand command = new SqliteCommand($"SELECT education_work_id FROM education_works WHERE student_id='{listViewEWStudent.Items[listViewEWStudent.SelectedIndices[0]].SubItems[0].Text.ToString()}'", connection);
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
                        DataBase.Delete("education_work", "", "id", res[i].ToString());

                        DataBase.Delete("education_works", "", "student_id", listViewEWStudent.Items[listViewEWStudent.SelectedIndices[0]].SubItems[0].Text.ToString());
                    }
                    DataBase.Delete("student", "", "id", listViewEWStudent.Items[listViewEWStudent.SelectedIndices[0]].SubItems[0].Text.ToString());
                }
            }
            if ((listViewEWStudent.SelectedItems.Count > 0) && (listViewEWByStudent.SelectedItems.Count > 0))
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    DataBase.Delete("education_work", "", "id", $"{listViewEWByStudent.Items[listViewEWByStudent.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                    DataBase.Delete("education_works", "", "education_work_id", $"{listViewEWByStudent.Items[listViewEWByStudent.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                }
            }
            listViewStudents_MouseOneClick(sender, (MouseEventArgs)e);
            UpdateDAta();
        }

        private void buttonAddHS_Click(object sender, EventArgs e)
        {
            buttonAddStudent_Click(sender, e);
        }

        private void buttonUpdateHS_Click(object sender, EventArgs e)
        {
            if ((listViewStudentsH.SelectedItems.Count > 0) && !(listViewHonorByS.SelectedItems.Count > 0))
            {
                int.TryParse(listViewStudentsH.Items[listViewStudentsH.SelectedIndices[0]].SubItems[0].Text, out int studentId);
                using (NewStudentForm ns = new NewStudentForm(studentId))
                {
                    ns.ShowDialog();
                }

                UpdateDAta();
            }
            if ((listViewHonorByS.SelectedItems.Count > 0))
            {
                int.TryParse(listViewHonorByS.Items[listViewHonorByS.SelectedIndices[0]].SubItems[0].Text, out int olimpiadId);
                using (NewOlympiadForm ns = new NewOlympiadForm(olimpiadId))
                {
                    ns.ShowDialog();
                }
                UpdateDAta();
            }
        }

        private void buttonDeleteHS_Click(object sender, EventArgs e)
        {
            if ((listViewStudentsH.SelectedItems.Count > 0) && !(listViewHonorByS.SelectedItems.Count > 0))
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {


                    List<int?> res = new List<int?>();
                    using (var connection = new SqliteConnection("Data Source=data.db"))
                    {
                        connection.Open();
                        int k = 9;

                        SqliteCommand command = new SqliteCommand($"SELECT honor_id FROM honors WHERE student_id='{listViewStudentsH.Items[listViewStudentsH.SelectedIndices[0]].SubItems[0].Text.ToString()}'", connection);
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
                        DataBase.Delete("honor", "", "id", res[i].ToString());

                        DataBase.Delete("honors", "", "student_id", listViewStudentsH.Items[listViewStudentsH.SelectedIndices[0]].SubItems[0].Text.ToString());
                    }
                    DataBase.Delete("student", "", "id", listViewStudentsH.Items[listViewStudentsH.SelectedIndices[0]].SubItems[0].Text.ToString());
                }
            }
            if ((listViewStudentsH.SelectedItems.Count > 0) && (listViewHonorByS.SelectedItems.Count > 0))
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    DataBase.Delete("honor", "", "id", $"{listViewHonorByS.Items[listViewHonorByS.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                    DataBase.Delete("honors", "", "honor_id", $"{listViewHonorByS.Items[listViewHonorByS.SelectedIndices[0]].SubItems[0].Text.ToString()}");
                }
            }
            listViewStudents_MouseOneClick(sender, (MouseEventArgs)e);
            UpdateDAta();
        }
    }
}