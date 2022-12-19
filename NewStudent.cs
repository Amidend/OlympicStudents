using Microsoft.Data.Sqlite;
namespace OlympicStudents
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO student (fio, dateOfBirth, address, phone, groups, yearApplying, yearOfRelease, course, specialization)" +
                    $" VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text+"|"+ textBox5.Text+"|"+textBox6.Text}', '{textBox7.Text}', '{textBox8.Text}', '{textBox9.Text}', '{courseBox.Text}', '{SpecializationBox.Text}')";
                command.ExecuteNonQuery();
                command.Cancel();
                int res=-1;
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
        }
    }
}
