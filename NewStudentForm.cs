using Microsoft.Data.Sqlite;
namespace OlympicStudents
{
    public partial class NewStudentForm : Form
    {
        private int studentId; // add a private field to store the student ID

        // modify the constructor to accept the student ID as a parameter
        public NewStudentForm(int studentId = -1)
        {
            InitializeComponent();
            this.studentId = studentId;
            if (studentId != -1)
            {
                LoadStudentData(studentId); // if a student ID is passed, load the student data into the form
            }
        }
        private void LoadStudentData(int studentId)
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT * FROM student WHERE id = {studentId}";

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string fio = reader.GetString(1);
                            string[] fioParts = fio.Split(' ');
                            if (fioParts.Length >= 1)
                            {
                                textBox1.Text = fioParts[0];
                            }
                            if (fioParts.Length >= 2)
                            {
                                textBox10.Text = fioParts[1];
                            }
                            if (fioParts.Length >= 3)
                            {
                                textBox11.Text = fioParts[2];
                            }
                            MessageBox.Show(reader.GetString(2));
                            DateTime dateOfBirth = reader.GetDateTime(2);
                            monthCalendar1.SetDate(dateOfBirth);
                            string address = reader.GetString(3);
                            richTextBox1.Text = address;
                            string[] phoneParts = reader.GetString(4).Split('|');
                            if (phoneParts.Length >= 1)
                            {
                                textBox4.Text = phoneParts[0];
                            }
                            if (phoneParts.Length >= 2)
                            {
                                textBox5.Text = phoneParts[1];
                            }
                            if (phoneParts.Length >= 3)
                            {
                                textBox6.Text = phoneParts[2];
                            }
                            textBox7.Text = reader.GetString(5);
                            textBox8.Text = reader.GetString(6);
                            textBox9.Text = reader.GetString(7);
                            courseBox.Text = reader.GetString(8);
                            SpecializationBox.Text = reader.GetString(9);
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
                if (studentId == -1) // if no student ID is passed, insert a new record
                {
                    command.CommandText = $"INSERT INTO student (fio, dateOfBirth, address, phone, groups, yearApplying, yearOfRelease, course, specialization)" +
                    $" VALUES ('{textBox1.Text + " " + textBox10.Text + " " + textBox11.Text}', '{date}', '{richTextBox1.Text}', '{textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text}', '{textBox7.Text}', '{textBox8.Text}', '{textBox9.Text}', '{courseBox.Text}', '{SpecializationBox.Text}')";
                }
                else // if a student ID is passed, update the existing record
                {
                    command.CommandText = $"UPDATE student SET fio = '{textBox1.Text + " " + textBox10.Text + " " + textBox11.Text}', dateOfBirth = '{date}', address = '{richTextBox1.Text}', phone = '{textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text}', groups = '{textBox7.Text}', yearApplying = '{textBox8.Text}', yearOfRelease = '{textBox9.Text}', course = '{courseBox.Text}', specialization = '{SpecializationBox.Text}' WHERE id = {studentId}";
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
