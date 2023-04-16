using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{

   

    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; } // propriedade resultado
        public decimal Valor { get; set; } // propriedade valor
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao 
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) //o click é um evento
        {
            txtResultado.Text += "6"; // txtResultado é onde vai ser mostrado o número quando clicar no botão
                    // += vai ser concatenado (vai aparecer um número atraz do outro quando clicar no botão)
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {   
            //exclamção é negar (!)
            if(!txtResultado.Text.Contains(",")) //se não conter a virgula, execute o comando( txtResultado.Text += ",";)
                txtResultado.Text += ",";        
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (OperacaoSelecionada) // para saber qual operação foi selecionada 
                {
                    case Operacao.Adicao:
                        Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                        break;
                    // vai armazenar na propriedade resultado do primeiro valor digitado + valor que vai ser digitado
                    case Operacao.Subtracao:
                        Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                        break;
                    case Operacao.Multiplicacao:
                        Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                        break;
                    case Operacao.Divisao:
                        Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO ao clicar no operador e depois no igual", "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            txtResultado.Text = Convert.ToString(Resultado); 
            //vai converter o decimal para string a propriedade resultado para mostrar na tela
            lblOperacao.Text = "=";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            try
            {
                OperacaoSelecionada = Operacao.Adicao;
                Valor = Convert.ToDecimal(txtResultado.Text);// vai converter a strings para decimal a propriedade valor para fazer o calculo
                txtResultado.Text = ""; // para sumir o número quando clicar no operador
                lblOperacao.Text = "+"; // para mostrar no label
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao clicar em dois operadores", "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                OperacaoSelecionada = Operacao.Subtracao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lblOperacao.Text = "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao clicar em dois operadores", "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            try
            {
                OperacaoSelecionada = Operacao.Multiplicacao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lblOperacao.Text = "x";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao clicar em dois operadores", "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                OperacaoSelecionada = Operacao.Divisao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lblOperacao.Text = "/";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao clicar em dois operadores", "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text = ""; //para limpar o visor
            lblOperacao.Text = "";  //para limpar o operador no label
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
