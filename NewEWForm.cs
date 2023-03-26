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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OlympicStudents
{
    public partial class NewEWForm : Form
    {
        private int id = -1;
        private int olympiadId=-1;
        public NewEWForm(int olympiadId = -1)
        {
            InitializeComponent();
            Adapter.InitializeListViewSudent(listView1);
            Adapter.FillAllListVewAsync(listView1, Constants.tableStudent);

            if (olympiadId != -1)
            {
                this.id = olympiadId;
                this.olympiadId = olympiadId;
                this.Text = "Редактирование олимпиады";
                this.button1.Text = "Сохранить изменения";

                using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();
                    SqliteCommand command = new SqliteCommand();
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM education_work WHERE id = {olympiadId}";
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DateTime date;
                                if (DateTime.TryParseExact(reader.GetString(4), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                                {
                                    this.monthCalendar1.SelectionStart = date;
                                }
                                this.richTextBox1.Text = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                this.textBox4.Text = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                                this.textBox3.Text = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            }
                        }

                    }
                }
            }
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (id == -1) { MessageBox.Show("Пожалуйста, выберите ученика."); }
            else
            {
                string date = monthCalendar1.SelectionStart.ToString("yyyy.MM.dd");
                using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();
                    SqliteCommand command = new SqliteCommand();
                    command.Connection = connection;

                    if (this.olympiadId == -1)
                    {
                        // Insert a new entry
                        command.CommandText = $"INSERT INTO education_work (event, nomination, place, date)" +
                            $" VALUES ('{textBox3.Text}', '{richTextBox1.Text}', '{textBox4.Text}', '{date}')";
                        command.ExecuteNonQuery();
                        int res = -1;
                        command = new SqliteCommand($"SELECT seq FROM sqlite_sequence WHERE name='education_work'", connection);
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
                        command.Cancel();
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO education_works (education_work_id, student_id)" + $" VALUES ('{res.ToString()}','{id}')";
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        // Update an existing entry
                        command.CommandText = $"UPDATE education_work SET date='{date}', place='{textBox4.Text}', nomination='{richTextBox1.Text}', event='{textBox3.Text}' WHERE id={this.id}";
                        command.ExecuteNonQuery();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
