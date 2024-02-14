namespace Calculadora
{
    public partial class Form1 : Form
    {
        public int subtotal = 0;
        public string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void concatNumber(string selectedNumber)
        {
            this.txtResult.Text = this.txtResult.Text + selectedNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.subtotal = Int32.Parse(this.txtResult.Text);
            this.txtResult.Text = "";
            this.op = "add";
        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            concatNumber("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            concatNumber("2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            concatNumber("1");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int y = Int32.Parse(this.txtResult.Text);
            int total = 0;

            switch (this.op)
            {
                case "add":
                    total = this.subtotal + y;
                    break;
            } 

            this.txtResult.Text = total.ToString();
        }
    }
}
