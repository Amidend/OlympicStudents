using Microsoft.Data.Sqlite;
namespace OlympicStudents
{
    public partial class NewStudentForm : Form
    {
        private int studentId;

        public NewStudentForm(int studentId = -1)
        {
            InitializeComponent();
            this.studentId = studentId;
            if (studentId != -1)
            {
                PopulateFormFields();
            }
        }
        private void PopulateFormFields()
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM student WHERE id = {studentId}", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox1.Text = reader["fio"] != DBNull.Value ? reader["fio"].ToString().Split(' ')[0] : "";
                        textBox10.Text = reader["fio"] != DBNull.Value ? reader["fio"].ToString().Split(' ')[1] : "";
                        textBox11.Text = reader["fio"] != DBNull.Value ? reader["fio"].ToString().Split(' ')[2] : "";
                        monthCalendar1.SelectionStart = reader["date_birth"] != DBNull.Value ? DateTime.Parse(reader["date_birth"].ToString()) : DateTime.Today;
                        richTextBox1.Text = reader["address"] != DBNull.Value ? reader["address"].ToString() : "";
                        string[] phoneNumbers = reader["phone"] != DBNull.Value ? reader["phone"].ToString().Split('|') : new string[3] { "", "", "" };
                        textBox4.Text = phoneNumbers[0];
                        textBox5.Text = phoneNumbers[1];
                        textBox6.Text = phoneNumbers[2];
                        textBox7.Text = reader["groups"] != DBNull.Value ? reader["groups"].ToString() : "";
                        textBox8.Text = reader["year_applying"] != DBNull.Value ? reader["year_applying"].ToString() : "";
                        textBox9.Text = reader["year_release"] != DBNull.Value ? reader["year_release"].ToString() : "";
                        courseBox.Text = reader["course"] != DBNull.Value ? reader["course"].ToString() : "";
                        SpecializationBox.Text = reader["specialization"] != DBNull.Value ? reader["specialization"].ToString() : "";
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
                if (studentId == 0)
                {
                    command.CommandText = $"INSERT INTO student (fio, date_birth, address, phone, groups, year_applying, year_release, course, specialization)" +
                        $" VALUES ('{textBox1.Text + " " + textBox10.Text + " " + textBox11.Text}', '{date}', '{richTextBox1.Text}', '{textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text}', '{textBox7.Text}', '{textBox8.Text}', '{textBox9.Text}', '{courseBox.Text}', '{SpecializationBox.Text}')";
                }
                else
                {
                    command.CommandText = $"UPDATE student SET fio = '{textBox1.Text + " " + textBox10.Text + " " + textBox11.Text}', date_birth = '{date}', address = '{richTextBox1.Text}', phone = '{textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text}', groups = '{textBox7.Text}', year_applying = '{textBox8.Text}', year_release = '{textBox9.Text}', course = '{courseBox.Text}', specialization = '{SpecializationBox.Text}' WHERE id = {studentId}";
                }
                command.ExecuteNonQuery();
                command.Cancel();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /*
    string date = monthCalendar1.SelectionStart.ToString("yyyy.MM.dd");
    using (var connection = new SqliteConnection("Data Source=data.db"))
    {
        connection.Open();

        SqliteCommand command = new SqliteCommand();
        command.Connection = connection;
        command.CommandText = $"INSERT INTO student (fio, dateOfBirth, address, phone, groups, yearApplying, yearOfRelease, course, specialization)" +
            $" VALUES ('{textBox1.Text + " " + textBox10.Text + " " + textBox11.Text}', '{date}', '{richTextBox1.Text}', '{textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text}', '{textBox7.Text}', '{textBox8.Text}', '{textBox9.Text}', '{courseBox.Text}', '{SpecializationBox.Text}')";
        command.ExecuteNonQuery();
        command.Cancel();
        int res = -1;
        command = new SqliteCommand($"SELECT seq FROM sqlite_sequence WHERE name='student'", connection);
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
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
    }
    */

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
