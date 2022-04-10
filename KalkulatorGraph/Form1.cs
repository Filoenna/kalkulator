namespace KalkulatorGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            display.AppendText(Zero.Text);
        }
        private void One_Click(object sender, EventArgs e)
        {
            display.AppendText(One.Text);
        }
        private void Two_Click(object sender, EventArgs e)
        {
            display.AppendText(Two.Text);
        }
        private void Three_Click(object sender, EventArgs e)
        {
            display.AppendText(Three.Text);
        }
        private void Four_Click(object sender, EventArgs e)
        {
            display.AppendText(Four.Text);
        }
        private void Five_Click(object sender, EventArgs e)
        {
            display.AppendText(Five.Text);
        }
        private void Six_Click(object sender, EventArgs e)
        {
            display.AppendText(Six.Text);
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            display.AppendText(Seven.Text);
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            display.AppendText(Eight.Text);
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            display.AppendText(Nine.Text);
        }
        private void Addition_Click(object sender, EventArgs e)
        {
            display.AppendText(Addition.Text);
        }
        private void Subtraction_Click(object sender, EventArgs e)
        {
            display.AppendText(Subtraction.Text);
        }
        private void Multiplying_Click(object sender, EventArgs e)
        {
            display.AppendText(Multiplying.Text);
        }
        private void Dividing_Click(object sender, EventArgs e)
        {
            display.AppendText(Dividing.Text);
        }
        private void Modulo_Click(object sender, EventArgs e)
        {
            display.AppendText(Modulo.Text);
        }

    }
}