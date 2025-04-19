using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            string resultado = null;
        
            
        private void Form1_Load(object sender, EventArgs e)
        {
            txtresultado.Text = resultado;
        }
            

        private void button8_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string texto = txtresultado.Text;
            double resultado = 0;
            double numeroAtual = 0;
            char operador = '+';
            string numero = "";

            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];

                if (char.IsDigit(c) || c == '.')
                {
                    numero += c;
                }
                else if ("+-*/".Contains(c))
                {
                    if (numero != "")
                    {
                        numeroAtual = double.Parse(numero);
                        resultado = Calcular(resultado, numeroAtual, operador);
                        numero = "";
                    }
                    operador = c;
                }
                else if (c == '^')
                {
                    if (numero != "")
                    {
                        numeroAtual = double.Parse(numero);
                        numeroAtual = Math.Pow(numeroAtual, 3); 
                        resultado = Calcular(resultado, numeroAtual, operador);
                        numero = "";

                        if (i + 1 < texto.Length && texto[i + 1] == '3')
                        {
                            i++;
                        }
                    }
                }
                else if (c == '√')
                {
                    operador = '√';
                }
            }

            if (numero != "")
            {
                numeroAtual = double.Parse(numero);
                resultado = Calcular(resultado, numeroAtual, operador);
            }

            txtresultado.Text = resultado.ToString();
        }

        private double Calcular(double a, double b, char operador)
        {
            switch (operador)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b != 0 ? a / b : 0;
                case '√': return Math.Sqrt(b);
                default: return b;
            }
        }

        private void btncube_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "^3";

        }

        private void btnroot_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "√";
           
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "/";

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "-";

        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "*";

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "+";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }
    }
}
