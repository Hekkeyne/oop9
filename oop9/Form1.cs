namespace oop9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            createsqlite();
        }
        private void createsqlite()
        {

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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)=>Close();
    }
}
