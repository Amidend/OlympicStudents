﻿using Microsoft.Data.Sqlite;
using System.Globalization;

namespace OlympicStudents
{
    public partial class NewOlympiadForm : Form
    {
        private int id = -1;
        private int olympiadId = -1;
        public NewOlympiadForm(int olympiadId = -1)
        {
            InitializeComponent();
            Adapter.InitializeListViewSudent(listView1);
            Adapter.FillAllListVewAsync(listView1, Constants.tableStudent);

            if (olympiadId != -1)
            {
                this.olympiadId = olympiadId;
                this.Text = "Редактирование олимпиады";
                this.button1.Text = "Сохранить изменения";

                using (var connection = new SqliteConnection("Data Source=data.db"))
                {
                    connection.Open();
                    SqliteCommand command = new SqliteCommand();
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM olympiad WHERE olympiad_id = {olympiadId}";
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

                                this.comboBox1.Text = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                                this.comboBox2.Text = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                                this.comboBox3.Text = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                                this.comboBox4.Text = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                                this.richTextBox1.Text = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                                this.textBox4.Text = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                                this.textBox3.Text = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                this.richTextBox2.Text = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                                this.richTextBox3.Text = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                                this.richTextBox4.Text = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);
                                this.richTextBox5.Text = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                            }
                        }

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                        command.CommandText = $"INSERT INTO olympiad (dates, level, type, awards, encouragement, nominations, duration, title, venue, sertificat, gramata, thank)" +
                            $" VALUES ('{date}', '{comboBox1.Text}', '{comboBox2.Text}', '{comboBox3.Text}', '{comboBox4.Text}', '{richTextBox1.Text}', '{textBox4.Text}', '{textBox3.Text}', '{richTextBox2.Text}', '{richTextBox3.Text}', '{richTextBox4.Text}', '{richTextBox5.Text}')";
                        command.ExecuteNonQuery();
                        int res = -1;
                        command = new SqliteCommand($"SELECT seq FROM sqlite_sequence WHERE name='olympiad'", connection);
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
                        command.CommandText = $"INSERT INTO result (olympiad_id, student_id)" + $" VALUES ('{res.ToString()}','{id}')";
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        // Update an existing entry
                        command.CommandText = $"UPDATE olympiad SET dates='{date}', level='{comboBox1.Text}', type='{comboBox2.Text}', awards='{comboBox3.Text}', encouragement='{comboBox4.Text}', nominations='{richTextBox1.Text}', duration='{textBox4.Text}', title='{textBox3.Text}', venue='{richTextBox2.Text}', sertificat='{richTextBox3.Text}', gramata='{richTextBox4.Text}', thank='{richTextBox5.Text}' WHERE olympiad_id={this.id}";
                        command.ExecuteNonQuery();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
