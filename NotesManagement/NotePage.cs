using System.Data.SqlClient;

namespace NotesManagement
{
    public partial class NotePage : Form
    {
        private SqlConnection sqlCon = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=NotesManagement; Integrated Security=True;");
        private int noteId;
        private string noteTitle;
        private string noteContent;
        private DateTime noteTimestamp;
        public NotePage(int noteID)
        {
            this.noteId = noteID;
            InitializeComponent();

            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT Title, Content, Timestamp FROM Notes WHERE NoteID = @NoteID", sqlCon);
                cmd.Parameters.AddWithValue("@NoteID", noteId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    noteTitle = reader["Title"].ToString();
                    noteContent = reader["Content"].ToString();
                    noteTimestamp = Convert.ToDateTime(reader["Timestamp"]);

                    titleBox.Text = noteTitle;
                    contentBox.Text = noteContent;
                }
                else
                {
                    MessageBox.Show("Note not found.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                sqlCon.Close();
            }

        }

        public NotePage()
        {
            InitializeComponent();
            deleteButton.Enabled = false;
            deleteButton.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.noteId != 0)
            {
                using (sqlCon)
                {
                    sqlCon.Open();
                    string update = "UPDATE Notes SET Title = @title, Content = @content WHERE NoteID = @noteID";
                    SqlCommand cmd = new SqlCommand(update, sqlCon);
                    cmd.Parameters.AddWithValue("@title", titleBox.Text);
                    cmd.Parameters.AddWithValue("@content", contentBox.Text);
                    cmd.Parameters.AddWithValue("@noteID", noteId);
                    cmd.ExecuteScalar();

                    noteTitle = titleBox.Text;
                    noteContent = contentBox.Text;

                    MessageBox.Show("Chages saved successfully!");
                }
            }
            else
            {
                if (titleBox.Text == String.Empty || contentBox.Text == String.Empty)
                {
                    MessageBox.Show("The title and the content of the note must not be empty!");
                }
                else
                {
                    using (sqlCon)
                    {
                        sqlCon.Open();
                        string add = "INSERT INTO Notes (Title, Content, Timestamp) VALUES (@title, @content, @timestamp); SELECT SCOPE_IDENTITY();";
                        SqlCommand cmd = new SqlCommand(add, sqlCon);
                        cmd.Parameters.AddWithValue("@title", titleBox.Text);
                        cmd.Parameters.AddWithValue("@content", contentBox.Text);
                        cmd.Parameters.AddWithValue("@timestamp", DateTime.Now.ToString());

                        noteId = Convert.ToInt32(cmd.ExecuteScalar());
                        noteTitle = titleBox.Text;
                        noteContent = contentBox.Text;

                        MessageBox.Show("Note added successfully!");
                        deleteButton.Enabled = true;
                        deleteButton.Visible = true;
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=NotesManagement; Integrated Security=True;"))
                    {
                        sqlCon.Open();

                        string delete = "DELETE FROM Notes WHERE NoteID = @noteId";
                        SqlCommand cmd = new SqlCommand(delete, sqlCon);
                        cmd.Parameters.AddWithValue("@NoteID", this.noteId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Note deleted successfully!");
                        Back();
                    }
                }
                else
                {
                    MessageBox.Show("Note deletion canceled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Back()
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            Hide();
            Close();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Export Note as Text File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"Note Title: {noteTitle}");
                        writer.WriteLine($"Note Content:");
                        writer.WriteLine(noteContent);
                    }

                    MessageBox.Show($"Note exported successfully to {filePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
