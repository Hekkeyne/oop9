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
            выходToolStripMenuItem = new ToolStripMenuItem();
            progressBar1 = new ProgressBar();
            menuStrip1.SuspendLayout();
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
            опцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьНовуюЗапитьCtrlAToolStripMenuItem, изменитьЗаписьCtrlBToolStripMenuItem, удалитьЗаписьCtrlCToolStripMenuItem, синхронизироватьCtrlDToolStripMenuItem });
            опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            опцииToolStripMenuItem.Size = new Size(56, 20);
            опцииToolStripMenuItem.Text = "Опции";
            // 
            // добавитьНовуюЗапитьCtrlAToolStripMenuItem
            // 
            добавитьНовуюЗапитьCtrlAToolStripMenuItem.Name = "добавитьНовуюЗапитьCtrlAToolStripMenuItem";
            добавитьНовуюЗапитьCtrlAToolStripMenuItem.Size = new Size(242, 22);
            добавитьНовуюЗапитьCtrlAToolStripMenuItem.Text = "Добавить новую запить Ctrl+A";
            // 
            // изменитьЗаписьCtrlBToolStripMenuItem
            // 
            изменитьЗаписьCtrlBToolStripMenuItem.Name = "изменитьЗаписьCtrlBToolStripMenuItem";
            изменитьЗаписьCtrlBToolStripMenuItem.Size = new Size(242, 22);
            изменитьЗаписьCtrlBToolStripMenuItem.Text = "Изменить запись Ctrl+B";
            // 
            // удалитьЗаписьCtrlCToolStripMenuItem
            // 
            удалитьЗаписьCtrlCToolStripMenuItem.Name = "удалитьЗаписьCtrlCToolStripMenuItem";
            удалитьЗаписьCtrlCToolStripMenuItem.Size = new Size(242, 22);
            удалитьЗаписьCtrlCToolStripMenuItem.Text = "Удалить запись Ctrl+C";
            // 
            // синхронизироватьCtrlDToolStripMenuItem
            // 
            синхронизироватьCtrlDToolStripMenuItem.Name = "синхронизироватьCtrlDToolStripMenuItem";
            синхронизироватьCtrlDToolStripMenuItem.Size = new Size(242, 22);
            синхронизироватьCtrlDToolStripMenuItem.Text = "Синхронизировать Ctrl+D";
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
            progressBar1.Location = new Point(12, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 23);
            progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
