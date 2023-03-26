using Microsoft.Data.Sqlite;

namespace OlympicStudents
{
    public partial class NewEWGroupForm : Form
    {
        private int groupId;

        public NewEWGroupForm(int groupId = -1)
        {
            InitializeComponent();
            this.groupId = groupId;
            if (groupId != -1)
            {
                PopulateFormFields();
            }
        }

        private void PopulateFormFields()
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM education_work_group WHERE id = {groupId}", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxGroup.Text = reader["groups"] != DBNull.Value ? reader["groups"].ToString() : "";
                        SpecializationBox.Text = reader["specialization"] != DBNull.Value ? reader["specialization"].ToString() : "";
                        textBoxEvent.Text = reader["event"] != DBNull.Value ? reader["event"].ToString() : "";
                        textBoxVenue.Text = reader["venue"] != DBNull.Value ? reader["venue"].ToString() : "";
                        textBoxNomination.Text = reader["nomination"] != DBNull.Value ? reader["nomination"].ToString() : "";
                        textBoxRating.Text = reader["rating"] != DBNull.Value ? reader["rating"].ToString() : "";
                        textBoxEncouragement.Text = reader["encouragement"] != DBNull.Value ? reader["encouragement"].ToString() : "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                if (groupId == -1)
                {
                    command.CommandText = $"INSERT INTO education_work_group (groups, specialization, event, venue, nomination, rating, encouragement)" +
                    $" VALUES ('{textBoxGroup.Text}', '{SpecializationBox.Text}', '{textBoxEvent.Text}', '{textBoxVenue.Text}', '{textBoxNomination.Text}', '{textBoxRating.Text}', '{textBoxEncouragement.Text}')";
                }
                else
                {
                    command.CommandText = $"UPDATE education_work_group SET groups = '{textBoxGroup.Text}', specialization = '{SpecializationBox.Text}', event = '{textBoxEvent.Text}', venue = '{textBoxVenue.Text}', nomination = '{textBoxNomination.Text}', rating = '{textBoxRating.Text}', encouragement = '{textBoxEncouragement.Text}' WHERE id = {groupId}";
                }
                command.ExecuteNonQuery();
                command.Cancel();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
