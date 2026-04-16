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
                command.CommandText =
                @"
                    CREATE TABLE IF NOT EXISTS oop9tbl (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Surname TEXT NOT NULL,
                        Name TEXT NOT NULL,
                        FatherName TEXT,
                        Phone TEXT NOT NULL
                    );
                ";
                progressBar1.Value = 80;
                command.ExecuteNonQuery();
                progressBar1.Value = 100;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Control | Keys.A):
                    break;
                case (Keys.Control | Keys.B):
                    break;
                case (Keys.Control | Keys.C):
                    break;
                case (Keys.Control | Keys.D):
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
            new Form2(filepatch).Show();
            updtable();
        }
        private void updtable()
        {
            string datab = $"Data Source = {filepatch}";
            using (var connection = new SqliteConnection(datab))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM oop9tbl";
                using(var read = command.ExecuteReader())
                {
                    var table = new System.Data.DataTable();
                    table.Load(read);
                    dataGridView1.DataSource= table;
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
            totable();
            //var com = c.CreateCommand();
            //com.CommandText = @"
            //    INSERT INTO oop9tbl (Surname, Name, FatherName, Phone) VALUES
            //    ('Smith', 'John', 'Doe', '123-456-7890'),
            //    ('Johnson', 'Jane', 'Doe', '234-567-8901'),
            //    ('Brown', 'Charlie', 'Doe', '345-678-9012');";
            //com.ExecuteNonQuery();
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
            totable();
            progressBar1.Visible = false;
        }

    }
}
