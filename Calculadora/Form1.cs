using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
                OperadorEscolhido.Text = "";
            }
            else if (operacao == "SUBTRAÇÃO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
                OperadorEscolhido.Text = "";
            }
            else if (operacao == "MULTIPLICAÇÃO")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
                OperadorEscolhido.Text = "";
            }
            else if (operacao == "DIVISÃO")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
                OperadorEscolhido.Text = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            OperadorEscolhido.Text = "";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUBTRAÇÃO";
            OperadorEscolhido.Text = "";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULTIPLICAÇÃO";
            OperadorEscolhido.Text = "";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIVISÃO";
            OperadorEscolhido.Text = "";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}