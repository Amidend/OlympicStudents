using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympicStudents
{
    public partial class NewHonorForm : Form
    {
        private int id = -1;
        private int honorId = -1;
        public NewHonorForm()
        {
            InitializeComponent();
            Adapter.InitializeListViewSudent(listView1);
            Adapter.FillAllListVewAsync(listView1, Constants.tableStudent);
        }

        public NewHonorForm(int honorId)
        {
            InitializeComponent();
            Adapter.InitializeListViewSudent(listView1);
            Adapter.FillAllListVewAsync(listView1, Constants.tableStudent);
            this.honorId = honorId;
            this.id = honorId;
            this.Text = "Редактирование награды";
            this.button1.Text = "Сохранить изменения";

            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT * FROM honor WHERE id = {id}";
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DateTime date;
                            if (DateTime.TryParseExact(reader.GetString(1), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                            {
                                this.monthCalendar1.SelectionStart = date;
                            }
                            this.textBox3.Text = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                            this.richTextBox1.Text = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            this.textBox4.Text = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = monthCalendar1.SelectionStart.ToString("yyyy.MM.dd");
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;

                if (this.honorId == -1)
                {
                    // Insert a new entry
                    command.CommandText = $"INSERT INTO honor (date, event, venue, result)" +
                        $" VALUES ('{date}', '{textBox3.Text}', '{richTextBox1.Text}', '{textBox4.Text}')";
                    command.ExecuteNonQuery();
                }
                else
                {
                    // Update an existing entry
                    command.CommandText = $"UPDATE honor SET date='{date}', event='{textBox3.Text}', venue='{richTextBox1.Text}', result='{textBox4.Text}' WHERE id={this.id}";
                    command.ExecuteNonQuery();
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text, out int id);
                this.id = id;
                if (id == -1 || id == null || listView1.SelectedItems.Count > 1)
                {
                    id = -1; throw new Exception();
                }
                MessageBox.Show("Ученик успешно выбран");
            }
            catch { MessageBox.Show("Пожалуйста, выберите только одного ученика."); }
        }
    }
}
