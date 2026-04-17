using Microsoft.Data.Sqlite;
namespace oop9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string filepatch;
        private void createsqlite()
        {
            progressBar1.Value = 50;
            string mydb = $"Data Source={filepatch}";
            using (var connection = new SqliteConnection(mydb))
            {
                connection.Open();
                var command = connection.CreateCommand();
                create(command);
                progressBar1.Value = 80;
                command.ExecuteNonQuery();
                progressBar1.Value = 100;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case (Keys.Control | Keys.A):
                    break;
                case (Keys.Control | Keys.B):
                    break;
                case (Keys.Control | Keys.C):
                    break;
                case (Keys.Control | Keys.D):
                    break;
                case (Keys.Control | Keys.E):
                    открытьБдToolStripMenuItem_Click(null, null);
                    break;
                case (Keys.Control | Keys.F):
                    создатьБдToolStripMenuItem_Click(null, null);
                    break;
            }
        }
        private void totable()
        {
            string db = $"Data Source = {filepatch}";
            using (var ccon = new SqliteConnection(db))
            {
                ccon.Open();
                var commands = ccon.CreateCommand();
                commands.CommandText = "SELECT * FROM oop9tbl";
                using (var read = commands.ExecuteReader())
                {
                    var table = new System.Data.DataTable();
                    table.Load(read);
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void добавитьНовуюЗапитьCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(filepatch);
            f2.updatedgw += updtable;
            f2.Show();

        }
        private void create(SqliteCommand command)
        {
            command.CommandText = @"CREATE TABLE IF NOT EXISTS oop9tbl(Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Фамилия TEXT NOT NULL,
                        Имя TEXT NOT NULL,
                        Отчество TEXT,
                        Номер_телефона TEXT NOT NULL
                    );";
            command.ExecuteNonQuery();
        }
        private void updtable(object sender, EventArgs e)
        {
            string datab = $"Data Source = {filepatch}";
            using (var connection = new SqliteConnection(datab))
            {
                connection.Open();
                var command = connection.CreateCommand();
                create(command);
                command.ExecuteNonQuery();
                command.CommandText = @"SELECT * FROM oop9tbl";
                using (var read = command.ExecuteReader())
                {
                    var table = new System.Data.DataTable();
                    table.Load(read);
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void создатьБдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Базы данных|*.db";
            saveFileDialog1.ShowDialog();
            filepatch = saveFileDialog1.FileName;
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            createsqlite();
            var c = new SqliteConnection($"Data Source={filepatch}");
            c.Open();
            createsqlite();
            totable();
            progressBar1.Visible = false;
        }

        private void открытьБдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Базы данных|*.db";
            openFileDialog1.ShowDialog();
            filepatch = openFileDialog1.FileName;
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            var c = new SqliteConnection($"Data Source={filepatch}");
            c.Open();
            createsqlite();
            totable();
            progressBar1.Visible = false;
        }

        private void saveedited(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
        }

        private void save_edited_button(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection($"Data Source = {filepatch}"))
            {
                connection.Open();
                var commands = connection.CreateCommand();
                commands.CommandText = @"DROP Table oop9tbl";
                commands.ExecuteNonQuery();
                create(commands);
                updtable(null,null);
            }
        }
    }
}
