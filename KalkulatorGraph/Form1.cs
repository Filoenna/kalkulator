namespace KalkulatorGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddText(object sender, EventArgs e)
        {
            display.AppendText(((ButtonBase)sender).Text);
        }
        
        private void Clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void Result_Click(object sender, EventArgs e)
        {
            string equation = display.Text;
            char[] operators;
            string temp;
            int[] numbers;
            int equationLength = equation.Length;

            for (int i = 0; i < equationLength; i++)
            {
                if (equation[i] == char.Parse("+"))
                {
                    operators = new char[char.Parse("+")]; 
                }
            }
        }

    }
}