using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace oop9
{
    public partial class Form4 : Form
    {
        public string filepatch2;
        public event EventHandler updatedgw;
        public string name;
        public string surname;
        public string fathername;
        public string number;
        public string id;
        public Form4(string file,string s, string nam, string fn, string n, string i)
        {
            InitializeComponent();
            filepatch2= file;
            name = nam;
            surname = s;
            fathername = fn;
            number = n;
            textBox1.Text = surname;
            textBox2.Text = name;
            textBox3.Text = fathername;
            textBox4.Text = number;
            id = i;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox4.Text)))
            {
                string db = $"Data Source = {filepatch2}";
                using (var connection = new SqliteConnection(db))
                {
                    connection.Open();
                    var commands = connection.CreateCommand();
                    commands.CommandText = @"UPDATE oop9tbl SET Фамилия = $surname, Имя = $name, Отчество = $fatherName, Номер_телефона = $phone WHERE id=$id";
                    commands.Parameters.AddWithValue("$surname", textBox1.Text);
                    commands.Parameters.AddWithValue("$name", textBox2.Text);
                    commands.Parameters.AddWithValue("$fatherName", textBox3.Text);
                    commands.Parameters.AddWithValue("$phone", textBox4.Text);
                    commands.Parameters.AddWithValue("$id", id);
                    try
                    {
                        commands.ExecuteNonQuery();
                        updatedgw?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else { MessageBox.Show("Введите имя, фамилию и номер телефона"); }
        }

        private void NO_click(object sender, EventArgs e) => this.Close();
    }
}
