using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympicStudents
{
    public partial class NewOlympiad : Form
    {
        private int id=-1;
        public NewOlympiad(int i)
        {
            id = i;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO olympiad (dates, level, type, awards, encouragement, nominations, duration, title, venue)" +
                    $" VALUES ('{dateTimePicker1.Text}', '{comboBox1.Text}', '{comboBox2.Text}', '{comboBox3.Text}', '{comboBox4.Text}', '{textBox2.Text}', '{textBox4.Text}', '{textBox3.Text}', '{textBox5.Text}')";
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
                            MessageBox.Show(res.ToString());
                        }
                    }
                }
                command.Cancel();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO result (olympiad_id, student_id)" + $" VALUES ('{res.ToString()}','{id}')";
                command.ExecuteNonQuery();
            }

        }
    }
}
