namespace oop9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            опцииToolStripMenuItem = new ToolStripMenuItem();
            добавитьНовуюЗапитьCtrlAToolStripMenuItem = new ToolStripMenuItem();
            изменитьЗаписьCtrlBToolStripMenuItem = new ToolStripMenuItem();
            удалитьЗаписьCtrlCToolStripMenuItem = new ToolStripMenuItem();
            синхронизироватьCtrlDToolStripMenuItem = new ToolStripMenuItem();
            открытьБдToolStripMenuItem = new ToolStripMenuItem();
            создатьБдToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            progressBar1 = new ProgressBar();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { опцииToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // опцииToolStripMenuItem
            // 
            опцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьНовуюЗапитьCtrlAToolStripMenuItem, изменитьЗаписьCtrlBToolStripMenuItem, удалитьЗаписьCtrlCToolStripMenuItem, синхронизироватьCtrlDToolStripMenuItem, открытьБдToolStripMenuItem, создатьБдToolStripMenuItem });
            опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            опцииToolStripMenuItem.Size = new Size(56, 20);
            опцииToolStripMenuItem.Text = "Опции";
            // 
            // добавитьНовуюЗапитьCtrlAToolStripMenuItem
            // 
            добавитьНовуюЗапитьCtrlAToolStripMenuItem.Name = "добавитьНовуюЗапитьCtrlAToolStripMenuItem";
            добавитьНовуюЗапитьCtrlAToolStripMenuItem.Size = new Size(242, 22);
            добавитьНовуюЗапитьCtrlAToolStripMenuItem.Text = "Добавить новую запить Ctrl+A";
            добавитьНовуюЗапитьCtrlAToolStripMenuItem.Click += добавитьНовуюЗапитьCtrlAToolStripMenuItem_Click;
            // 
            // изменитьЗаписьCtrlBToolStripMenuItem
            // 
            изменитьЗаписьCtrlBToolStripMenuItem.Name = "изменитьЗаписьCtrlBToolStripMenuItem";
            изменитьЗаписьCtrlBToolStripMenuItem.Size = new Size(242, 22);
            изменитьЗаписьCtrlBToolStripMenuItem.Text = "Изменить запись Ctrl+B";
            изменитьЗаписьCtrlBToolStripMenuItem.Click += изменитьЗаписьCtrlBToolStripMenuItem_Click;
            // 
            // удалитьЗаписьCtrlCToolStripMenuItem
            // 
            удалитьЗаписьCtrlCToolStripMenuItem.Name = "удалитьЗаписьCtrlCToolStripMenuItem";
            удалитьЗаписьCtrlCToolStripMenuItem.Size = new Size(242, 22);
            удалитьЗаписьCtrlCToolStripMenuItem.Text = "Удалить запись Ctrl+C";
            удалитьЗаписьCtrlCToolStripMenuItem.Click += удалитьЗаписьCtrlCToolStripMenuItem_Click;
            // 
            // синхронизироватьCtrlDToolStripMenuItem
            // 
            синхронизироватьCtrlDToolStripMenuItem.Name = "синхронизироватьCtrlDToolStripMenuItem";
            синхронизироватьCtrlDToolStripMenuItem.Size = new Size(242, 22);
            синхронизироватьCtrlDToolStripMenuItem.Text = "Синхронизировать Ctrl+D";
            // 
            // открытьБдToolStripMenuItem
            // 
            открытьБдToolStripMenuItem.Name = "открытьБдToolStripMenuItem";
            открытьБдToolStripMenuItem.Size = new Size(242, 22);
            открытьБдToolStripMenuItem.Text = "Открыть бд Ctrl+E";
            открытьБдToolStripMenuItem.Click += открытьБдToolStripMenuItem_Click;
            // 
            // создатьБдToolStripMenuItem
            // 
            создатьБдToolStripMenuItem.Name = "создатьБдToolStripMenuItem";
            создатьБдToolStripMenuItem.Size = new Size(242, 22);
            создатьБдToolStripMenuItem.Text = "Создать бд Ctrl+F";
            создатьБдToolStripMenuItem.Click += создатьБдToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(53, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 30);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 17);
            progressBar1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(800, 426);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += saveedited;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(progressBar1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 403);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 47);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Enabled = false;
            button1.Location = new Point(515, 3);
            button1.Name = "button1";
            button1.Size = new Size(285, 25);
            button1.TabIndex = 2;
            button1.Text = "Сохранить изменения";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += save_edited_button;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Рекдатор";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem опцииToolStripMenuItem;
        private ToolStripMenuItem добавитьНовуюЗапитьCtrlAToolStripMenuItem;
        private ToolStripMenuItem изменитьЗаписьCtrlBToolStripMenuItem;
        private ToolStripMenuItem удалитьЗаписьCtrlCToolStripMenuItem;
        private ToolStripMenuItem синхронизироватьCtrlDToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ProgressBar progressBar1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem открытьБдToolStripMenuItem;
        private ToolStripMenuItem создатьБдToolStripMenuItem;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button1;
    }
}
