using NPOI.XSSF.UserModel;
using Microsoft.Data.Sqlite;
using NPOI.SS.UserModel;
using StudentInfo;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Data.SQLite;

namespace OlympicStudents
{
    public partial class MainForm : Form
    {


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

            updateDataStudentAsync();
            updateDataOlimpiadsAsync();
        }
        //��� �������
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
                searchResults = DataBase.MultiSearch("student", searchFields, searchValues)
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
                updateDataStudentAsync();
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
                updateDataOlimpiadsAsync();
            }
        }

        //����������(����� ��������)
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            using (NewStudentForm ns = new NewStudentForm())
            {
                ns.ShowDialog();
            }
            updateDataStudentAsync();
        }
        private void addOlimpiads_Click(object sender, EventArgs e)
        {
            using (NewOlympiadForm ns = new NewOlympiadForm())
            {
                ns.ShowDialog();
            }
            updateDataOlimpiadsAsync();
        }
        //����� ����� �� ��������
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
        //�����
        private void buttonSearchStudents_Click(object sender, EventArgs e)
        {
            List<string> criteriaList = new List<string>();
            foreach (var SearchItem in checkedListBoxSearch.CheckedItems)
            {
                switch (SearchItem.ToString())
                {
                    case "���":
                        criteriaList.Add("fio");
                        break;
                    case "���� ��������":
                        criteriaList.Add("dateOfBirth");
                        break;
                    case "�����":
                        criteriaList.Add("address");
                        break;
                    case "����� ��������":
                        criteriaList.Add("phone");
                        break;
                    case "������":
                        criteriaList.Add("groups");
                        break;
                    case "���� �����������":
                        criteriaList.Add("yearApplying");
                        break;
                    case "���� �������":
                        criteriaList.Add("yearOfRelease");
                        break;
                    case "����":
                        criteriaList.Add("course");
                        break;
                    case "�������������":
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
            var res = DataBase.Search("student", searchCriteria, $"{textBoxSearchStudents.Text}");
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
                    case "����":
                        criteriaList.Add("dates");
                        break;
                    case "�������":
                        criteriaList.Add("level");
                        break;
                    case "���":
                        criteriaList.Add("type");
                        break;
                    case "�������":
                        criteriaList.Add("awards");
                        break;
                    case "����������":
                        criteriaList.Add("encouragement");
                        break;
                    case "���������":
                        criteriaList.Add("nominations");
                        break;
                    case "�����������������":
                        criteriaList.Add("duration");
                        break;
                    case "��������":
                        criteriaList.Add("title");
                        break;
                    case "����� ����������":
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
            var res = DataBase.SearchOlimp("olympiad", searchCriteria, $"{textBoxSearchOlimpyad.Text}");
            listViewOlimp.Clear();
            Adapter.InitializeListViewOlimpiads(listViewOlimp);
            foreach (var i in res)
            {
                ListViewItem item = new ListViewItem(i.ToArray());
                listViewOlimp.Items.Add(item);
            }
        }
        //��������
        private void deleteStudents_Click(object sender, EventArgs e)
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
            updateDataStudentAsync();
            updateDataOlimpiadsAsync();
        }
        private void deleteOlimpyad_Click(object sender, EventArgs e)
        {
            if (listViewOlimp.SelectedItems.Count > 0)
            {
                DataBase.Delete("olympiad", "", "olympiad_id", $"{listViewOlimp.SelectedItems[0].SubItems[9].Text.ToString()}");
                DataBase.Delete("result", "", "olympiad_id", $"{listViewOlimp.SelectedItems[0].SubItems[9].Text.ToString()}");
            }
            updateDataOlimpiadsAsync();
        }
        //�����
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
            updateDataStudentAsync();
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
            updateDataOlimpiadsAsync();
        }
        //�����
        private void excelReport_ClickAsync(object sender, EventArgs e)
        {
            List<string> criteriaList = new List<string>();
            foreach (var SearchItem in checkedListBoxCriteriaExcel.CheckedItems)
            {
                switch (SearchItem.ToString())
                {
                    case "������������":
                        criteriaList.Add("������������");
                        break;
                    case "������������ ������������":
                        criteriaList.Add("������������ ������������");
                        break;
                    case "���������� ����":
                        criteriaList.Add("���������� ����");
                        break;
                    case "������������� ����, ������ � ��������":
                        criteriaList.Add("������������� ����, ������ � ��������");
                        break;
                    case "������������ ���������":
                        criteriaList.Add("������������ ���������");
                        break;
                    case "��������� � ����������� ������������":
                        criteriaList.Add("��������� � ����������� ������������");
                        break;
                    case "����������� ����������� �������������� ����������":
                        criteriaList.Add("����������� ����������� �������������� ����������");
                        break;
                }
            }
            string searchCriteria;
            if (criteriaList.Count == 0)
            {
                searchCriteria = "������������||������������ ������������||���������� ����||������������� ����, ������ � ��������||������������ ���������||��������� � ����������� ������������||����������� ����������� �������������� ����������";
            }
            else
            {
                searchCriteria = string.Join("||", criteriaList);
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
                var student_id = DataBase.FindStudentByOlimpyad(size[k].ToString());
                List<string> Olympyad = DataBase.FindOlimpyadById(size[k].ToString());
                List<string> Student = DataBase.GetStuentInfofrmationAndSp(student_id.ToString(), searchCriteria);

                if (Student.Count > 0)
                {
                    DataRow row = dt.NewRow();
                    row["fio"] = Student[0];
                    row["title"] = Olympyad[7];
                    row["dates"] = Olympyad[0];
                    row["awards"] = Olympyad[3];
                    row["encouragement"] = Olympyad[4];
                    dt.Rows.Add(row);
                }
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "OlympicStudents.ReportDefenitions.Report.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
        //��������� ��������
        private async void updateDataStudentAsync()
        {
            Adapter.InitializeListViewSudent(listViewStudent);
            Adapter.FillStudentListVewAsync(listViewStudent);
        }
        private void updateDataOlimpiadsAsync()
        {
            Adapter.InitializeListViewOlimpiads(listViewOlimp);
            Adapter.FillOlimpiadsListVewAsync(listViewOlimp);
        }
    }
}