using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop9
{
    public partial class Form2 : Form
    {
        public string filepatch2;
        public Form2(string filepatch)
        {
            InitializeComponent();
            filepatch2 = filepatch;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string db = $"Data Source = {filepatch2}";
            using ( var connection = new SqliteConnection(db))
            {
                connection.Open();
                var commands = connection.CreateCommand();
                commands.CommandText = @"INSERT INTO oop9tbl (Surname, Name, FatherName, Phone) VALUES ($surname, $name, $fatherName, $phone)";
                commands.Parameters.AddWithValue("$surname",textBox1.Text);
                commands.Parameters.AddWithValue("$name", textBox2.Text);
                commands.Parameters.AddWithValue("$fatherName", textBox3.Text);
                commands.Parameters.AddWithValue("$phone", textBox4.Text);
                try
                {
                    commands.ExecuteNonQuery();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void NO_click(object sender, EventArgs e) => this.Close();
    }
}
