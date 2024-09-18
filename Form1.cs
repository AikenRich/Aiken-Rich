using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
           // textBox1.Text = "September 18, 2024";
        }
    }
}