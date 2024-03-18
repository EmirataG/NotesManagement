using System.Data;
using System.Data.SqlClient;

namespace NotesManagement
{
    public partial class HomePage : Form
    {
        private SqlConnection sqlCon = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=NotesManagement; Integrated Security=True;");
        public HomePage()
        {
            InitializeComponent();

            DataGridViewButtonColumn cancelButtonColumn = new DataGridViewButtonColumn();
            cancelButtonColumn.Name = "Open";
            cancelButtonColumn.Text = "Open";
            cancelButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(cancelButtonColumn);
            UpdateGrid();
            dataGridView.Columns["NoteID"].Visible = false;
            dataGridView.Columns["Open"].Width = 50;
            dataGridView.Columns["Content"].Width = 300;
            dataGridView.Columns["Created on:"].Width = 200;

            dataGridView.CellClick += (sender, e) =>
            {
                try
                {
                    if (e.ColumnIndex == dataGridView.Columns["Open"].Index && e.RowIndex >= 0)
                    {
                        int noteId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["NoteID"].Value);
                        NotePage note = new NotePage(noteId);
                        note.Show();
                        Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. ");
                }
            };

        }

        private void UpdateGrid()
        {
            dataGridView.DataSource = null;
            using (sqlCon)
            {
                sqlCon.Open();
                string query = "SELECT NoteID, Title, Content, Timestamp as 'Created on:' FROM Notes";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NotePage note = new NotePage();
            note.Show();
            Hide();
        }
    }
}