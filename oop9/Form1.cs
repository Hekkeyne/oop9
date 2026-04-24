using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SQLite;
namespace oop9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            offlight();
        }
        public string filepatch;
        public int choose_index = -1;
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
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void добавитьНовуюЗапитьCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filepatch != null)
            {
                Form2 f2 = new Form2(filepatch);
                if (f2.ShowDialog() == DialogResult.OK) updtable();
            }
            else MessageBox.Show("Создайте базу данных");

        }
        private void удалитьЗаписьCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filepatch != null)
            {
                if (int.IsPositive(choose_index))
                {
                    Form3 f3 = new Form3();
                    if (f3.ShowDialog() == DialogResult.OK) deleterow();
                }
                else MessageBox.Show("Выберите строку для удаления");
            }
            else MessageBox.Show("Создайте базу данных");
            offlight();
        }
        private void изменитьЗаписьCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filepatch != null)
            {
                if (int.IsPositive(choose_index))
                {
                    Form4 f4 = new Form4
                        (
                        filepatch,//путь
                        dataGridView1[1, choose_index].Value.ToString(),//фамилия
                        dataGridView1[2, choose_index].Value.ToString(),//имя
                        dataGridView1[3, choose_index].Value.ToString(),//отчество
                        dataGridView1[4, choose_index].Value.ToString(),//номер
                        dataGridView1[0, choose_index].Value.ToString()//ид
                        );
                    if (f4.ShowDialog() == DialogResult.OK) updtable();
                }
                else MessageBox.Show("Выберите строку для редактирования");
            }
            else MessageBox.Show("Создайте базу данных");
            offlight();
        }
        private void создатьБдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Базы данных|*.db";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepatch = saveFileDialog1.FileName;
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                createsqlite();
                var c = new SqliteConnection($"Data Source={filepatch}");
                c.Open();
                createsqlite();
                totable();
                progressBar1.Visible = false;
                dataGridView1.Columns[0].Visible = false;
            }
        }
        private void открытьБдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Базы данных|*.db";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepatch = openFileDialog1.FileName;
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                var c = new SqliteConnection($"Data Source={filepatch}");
                c.Open();
                createsqlite();
                totable();
                progressBar1.Visible = false;
                dataGridView1.Columns[0].Visible = false;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                choose_index = e.RowIndex;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.White;
                        dataGridView1[i, j].Style.ForeColor = Color.Black;
                    }
                }
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1[i, e.RowIndex].Style.BackColor = Color.Green;
                    dataGridView1[i, e.RowIndex].Style.ForeColor = Color.White;
                }
            }
            offlight();
        }
        private void saveedited(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
        }
        private void save_edited_button(object sender, EventArgs e)
        {
            var db = $"DataSource = {filepatch}";
            using (var connection = new SQLiteConnection(db))
            {
                var adap = new SQLiteDataAdapter("SELECT * FROM oop9tbl", connection);
                var bld = new SQLiteCommandBuilder(adap);
                var table = (DataTable)dataGridView1.DataSource;
                adap.Update(table);
            }
        }
        private void deleterow()
        {
            using (SqliteConnection con = new SqliteConnection($"Data Source = {filepatch}"))
            {
                con.Open();
                var command = con.CreateCommand();
                command.CommandText = @"DELETE FROM oop9tbl WHERE ID = @id";
                command.Parameters.AddWithValue("@id", dataGridView1[0, choose_index].Value);
                command.ExecuteNonQuery();
                updtable();
                choose_index = -1;
            }
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
        private void updtable()
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
            choose_index = -1;
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
                progressBar1.Value = 100;
            }
        }
        private void offlight()
        {
            if (choose_index == -1)
            {
                удалитьЗаписьCtrlCToolStripMenuItem.Enabled = false;
                изменитьЗаписьCtrlBToolStripMenuItem.Enabled = false;
            }
            else
            {
                удалитьЗаписьCtrlCToolStripMenuItem.Enabled = true;
                изменитьЗаписьCtrlBToolStripMenuItem.Enabled = true;
            }
        }
    }
}