namespace Calculadora
{
    public partial class Form1 : Form
    {
        public float subtotal = 0;
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
            this.subtotal = float.Parse(this.txtResult.Text);
            this.txtResult.Text = "";
            this.op = "add";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            concatNumber("8");
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
            float y = float.Parse(this.txtResult.Text);
            float total = 0;

            switch (this.op)
            {
                case "add":
                    total = this.subtotal + y;
                    break;

                case "resta":
                    total = this.subtotal - y;
                    break;

                case "multiplicacion":
                    total = this.subtotal * y;
                    break;
                case "Division":
                    total = this.subtotal / y;
                    break;
                case "Raiz":
                    total = (float)Math.Sqrt(subtotal);
                    break;
            }

            this.txtResult.Text = total.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            concatNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            concatNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            concatNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            concatNumber("7");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            concatNumber("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            concatNumber("0");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            this.subtotal = float.Parse(this.txtResult.Text);
            this.txtResult.Text = "";
            this.op = "resta";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            this.subtotal = float.Parse(this.txtResult.Text);
            this.txtResult.Text = "";
            this.op = "multiplicacion";
        }


        private void btnDividir_Click(object sender, EventArgs e)
        {
            this.subtotal = (int)float.Parse(this.txtResult.Text);
            this.txtResult.Text = "";
            this.op = "Division";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            concatNumber(".");
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            this.subtotal = float.Parse(this.txtResult.Text);
            this.txtResult.Text = "";
            this.op = "Raiz";
        }
    }
}
