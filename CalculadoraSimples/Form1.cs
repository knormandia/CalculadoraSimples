using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        private Calculo.TipoOperacao operacao;
        public Form1()
        {
            InitializeComponent();
            rbSoma.CheckedChanged += rbSoma_CheckedChanged;
            rbSubtracao.CheckedChanged += rbSubtracao_CheckedChanged;
            rbMultiplicacao.CheckedChanged += rbMultiplicacao_CheckedChanged;
            rbDivisao.CheckedChanged += rbDivisao_CheckedChanged;
        }

        
        private void rbSoma_CheckedChanged(object sender, EventArgs e)
        {
            
            operacao = Calculo.TipoOperacao.Soma;

        }

        private void rbSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            operacao = Calculo.TipoOperacao.Subtracao;
        }

        private void rbMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            operacao = Calculo.TipoOperacao.Multiplicacao;
        }

        private void rbDivisao_CheckedChanged(object sender, EventArgs e)
        {
            operacao = Calculo.TipoOperacao.Divisao;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = Double.Parse(txtValor1.Text);
                double numero2 = Double.Parse(txtValor2.Text);

                double resultado = Calculo.Calcular(numero1, numero2, operacao);
                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
