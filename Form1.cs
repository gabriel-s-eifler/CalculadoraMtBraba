namespace CalculadoraMtBraba
{
    public partial class Form1 : Form
    {
        calculadora nova = new calculadora();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text +button1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button9.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button8.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + button0.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = null;
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + buttonVirgula.Text;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            nova.SetVariavel1(double.Parse(TxtResultado.Text));
            nova.SetOperacao("+");
            TxtResultado.Text = null;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            nova.SetVariavel1(double.Parse(TxtResultado.Text));
            nova.SetOperacao("-");
            TxtResultado.Text = null;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            nova.SetVariavel1(double.Parse(TxtResultado.Text));
            nova.SetOperacao("/");
            TxtResultado.Text = null;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            nova.SetVariavel1(double.Parse(TxtResultado.Text));
            nova.SetOperacao("*");
            TxtResultado.Text = null;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            nova.SetVariavel2(double.Parse(TxtResultado.Text));
            TxtResultado.Text = nova.executarOperacao().ToString();
        }
    }
}