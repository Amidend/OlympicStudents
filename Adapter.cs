using System.Collections;

namespace OlympicStudents
{

    public static class Adapter
    {
        public static void InitializeListViewSudent(ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;

            listView.Columns.AddRange(new[] {
                new ColumnHeader { Text = "id" },
                new ColumnHeader { Text = "ФИО" },
                new ColumnHeader { Text = "Курс" },
                new ColumnHeader { Text = "Группа" },
                new ColumnHeader { Text = "Специальность" },
                new ColumnHeader { Text = "Дата рождения" },
                new ColumnHeader { Text = "Адресс" },
                new ColumnHeader { Text = "Телефон" },
                new ColumnHeader { Text = "Дата поступления" },
                new ColumnHeader { Text = "Дата выпуска" }
            });

            int columnWidth = listView.ClientSize.Width / (listView.Columns.Count-1);
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width  = columnWidth; 
            }
            listView.Columns[0].Width = 0;

            listView.ListViewItemSorter = new ListViewItemComparer(0, true);
            listView.ColumnClick += (sender, e) =>
            {
                var list = (ListView)sender;
                bool reverse = (list.ListViewItemSorter as ListViewItemComparer)?.Reverse ?? false;
                list.ListViewItemSorter = new ListViewItemComparer(e.Column, !reverse);
            };
        }
        public static void InitializeListViewOlimpiads(ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;

            listView.Columns.AddRange(new[] {
                new ColumnHeader { Text = "id" },
                new ColumnHeader { Text = "Дата" },
                new ColumnHeader { Text = "Название" },
                new ColumnHeader { Text = "Уровень" },
                new ColumnHeader { Text = "Вид" },
                new ColumnHeader { Text = "Результат" },
                new ColumnHeader { Text = "Поощерение" },
                new ColumnHeader { Text = "Номинации" },
                new ColumnHeader { Text = "Место проведения" },
                new ColumnHeader { Text = "Продолжительность" }
            });

            int columnWidth = listView.ClientSize.Width / (listView.Columns.Count - 1);
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width = columnWidth;
            }

            listView.Columns[0].Width = 0;
            listView.ListViewItemSorter = new ListViewItemComparer(0, true);
            listView.ColumnClick += (sender, e) =>
            {
                var list = (ListView)sender;
                bool reverse = (list.ListViewItemSorter as ListViewItemComparer)?.Reverse ?? false;
                list.ListViewItemSorter = new ListViewItemComparer(e.Column, !reverse);
            };
        }
        public static async Task FillListVewAsync(ListView listViewStudent,string table,int n)
        {
            var items = await DataBase.GetAllFromTableAsync(table, n);
            foreach (var item in items)
            {
                listViewStudent.Items.Add(item);
            }
        }
        public static async Task FillStudentOlympiadsAsync(ListView listViewStudent, int id)
        {
            var items = await DataBase.GetAllOlympiadsByStudentIdAsync(id);
            foreach (var item in items)
            {
                listViewStudent.Items.Add(item);
            }
        }
        public static async Task FillStudentInformationAsync(int id, List<Label> labels)
        {
            var items = await DataBase.GetStuentInformation(id.ToString());
            if (items.Count == 10)
            {
                labels[0].Text = items[1];
                labels[1].Text = items[5];
                labels[2].Text = items[6];
                if  (items[7]!=null)
                {
                    string[] phoneNumbers = items[7].Split('|');
                    labels[3].Text = phoneNumbers.Length >= 1 ? phoneNumbers[0] : "";
                    labels[4].Text = phoneNumbers.Length >= 2 ? phoneNumbers[1] : "";
                    labels[5].Text = phoneNumbers.Length >= 3 ? phoneNumbers[2] : "";
                }
                labels[6].Text = items[3];
                labels[7].Text = items[8];
                labels[8].Text = items[9];
                labels[9].Text = items[2];
                labels[10].Text = items[4];
            }
        }

    }
    public class ListViewItemComparer : IComparer
    {
        private int col;
        private bool reverse;

        public ListViewItemComparer(int column, bool reverse)
        {
            col = column;
            this.reverse = reverse;
        }

        public bool Reverse { get => reverse; }

        public int Compare(object x, object y)
        {
            int result = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            if (Reverse)
            {
                result *= -1;
            }
            return result;
        }
    }
}
