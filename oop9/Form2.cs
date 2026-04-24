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
        public event EventHandler updatedgw;
        public Form2(string filepatch)
        {
            InitializeComponent();
            filepatch2 = filepatch;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox1.Text)&&string.IsNullOrWhiteSpace(textBox2.Text)&&string.IsNullOrWhiteSpace(textBox4.Text)))
            {
                string db = $"Data Source = {filepatch2}";
                using (var connection = new SqliteConnection(db))
                {
                    connection.Open();
                    var commands = connection.CreateCommand();
                    commands.CommandText = @"INSERT INTO oop9tbl (Фамилия, Имя, Отчество, Номер_телефона) VALUES ($surname, $name, $fatherName, $phone)";
                    commands.Parameters.AddWithValue("$surname", textBox1.Text);
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
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else { MessageBox.Show("Введите имя, фамилию и номер телефона"); }
        }

        private void NO_click(object sender, EventArgs e) => this.Close();
    }
}
