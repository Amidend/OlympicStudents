using Microsoft.Data.Sqlite;
using StudentInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympicStudents
{
    public partial class NewOlympiadForm : Form
    {
        private int id = -1;
        public NewOlympiadForm()
        {
            InitializeComponent();
            Adapter.InitializeListViewSudent(listView1);
            Adapter.FillStudentListVewAsync(listView1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                id = DataBase.FindStudentById(listView1.SelectedItems[0].Text.ToString());
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
                    command.CommandText = $"INSERT INTO olympiad (dates, level, type, awards, encouragement, nominations, duration, title, venue)" +
                        $" VALUES ('{date}', '{comboBox1.Text}', '{comboBox2.Text}', '{comboBox3.Text}', '{comboBox4.Text}', '{richTextBox1.Text}', '{textBox4.Text}', '{textBox3.Text}', '{richTextBox2.Text}')";
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
