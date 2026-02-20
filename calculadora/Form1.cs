using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        private double primeiroValor;
        private string operacao;

        public Form1()
        {
            InitializeComponent();
            textBox.Text = "0";

             this.maispae.Click += new EventHandler(this.maispae_Click);
             this.menospae.Click += new EventHandler(this.menospae_Click);
        

   
        }

        private void EscreverNumero(string numero)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += numero;
            }
            else
            {
                textBox.Text = numero;
            }
        }

        private void SelecionarOperacao(string operacao_selecionada)
        {
            try
            {
                primeiroValor = Convert.ToDouble(textBox.Text);
                textBox.Text = "0";
                operacao = operacao_selecionada;
            }
            catch
            {
                textBox.Text = "0";
            }
        }

        private double RealizarOperacao(double valor1, double valor2)
        {
            double resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    break;
            }
            return resultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                double segundoValor = Convert.ToDouble(textBox.Text);
                double resultado = RealizarOperacao(primeiroValor, segundoValor);
                textBox.Text = resultado.ToString();
                primeiroValor = 0;
            }
            catch
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains(","))
            {
                textBox.Text += ",";
            }
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            primeiroValor = 0;
            operacao = "";
        }

        private void vezespae_Click(object sender, EventArgs e)
        {
            SelecionarOperacao("*");
        }

        private void maispae_Click(object sender, EventArgs e)
        {
            SelecionarOperacao("+");
        }

        private void menospae_Click(object sender, EventArgs e)
        {
            SelecionarOperacao("-");
        }

        private void divisãopae_Click(object sender, EventArgs e)
        {
            SelecionarOperacao("/");
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            EscreverNumero("1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EscreverNumero("2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EscreverNumero("3");
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            EscreverNumero("4");
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            EscreverNumero("5");
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            EscreverNumero("6");
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            EscreverNumero("7");
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            EscreverNumero("8");
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            EscreverNumero("9");
        }

        private void numero0_Click(object sender, EventArgs e)
        {
            EscreverNumero("0");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button16_Click(object sender, EventArgs e) { }
        private void textBox_TextChanged(object sender, EventArgs e) { }
    }
}