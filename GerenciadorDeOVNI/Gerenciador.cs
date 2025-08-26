using BibliotecaOVNI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class Gerenciador : Form
    {
        // Objetos globais
        BibliotecaOVNI.OVNI ovni;
        public Gerenciador(BibliotecaOVNI.OVNI ovni) // Obrigatoriamente deve-se iniciar passando um ovni
        {
            InitializeComponent();
            this.ovni = ovni; // Copiando o ovni vindo da outra janela para um obj global

            AtualizarInformacoes(); // Atualizar as informações

            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos); //Popular o combobox comos planeta validos
        }

        public void AtualizarInformacoes()
        {
            lblSituacao.Text = $"Situação: {(ovni.Situacao ? "Ligado" : "Desligado")}";
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";

            btnDesligar.Enabled = ovni.Situacao;
            btnLigar.Enabled = !ovni.Situacao;  // Atualizar botões de ligar e desligar

            txbPlaneta.Text = ovni.PlanetaAtual;

            grbAbduzidos.Enabled = ovni.Situacao; // Ativar/Desativar os grb de acordo com o status da nave.
            grbPlaneta.Enabled = ovni.Situacao;
            grbTripulantes.Enabled = ovni.Situacao;

            if (ovni.PlanetaAtual == "Terra")
            {
                pbTerra.Visible = true;
            }
            else
            {
                pbTerra.Visible = false;    
            }

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("O OVNI foi ligado!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está ligado!", "ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInformacoes(); // Chamar novamente a atualização
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("O OVNI foi desligado!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está desligado!", "ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInformacoes(); // Chamar novamente a atualização
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulante adiconado!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não há limites para embarque!", "ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInformacoes();
        }

        private void btnRemoverTrip_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante())
            {
                MessageBox.Show("Tripulante removido!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possível deixar a nave sem operadores!", "ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInformacoes();
        }

        private void btnAbduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir())
            {
                MessageBox.Show("Forma de vida capturada!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possível abduzir mais pessoas!", "ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInformacoes();
        }

        private void btnDesabduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir())
            {
                MessageBox.Show("Forma de vida devolvida ao planeta natal!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não há mais formas de vida a bordo!", "ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInformacoes();
        }

        private void btnMudarPlaneta_Click(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlanetas.Text))
            {
                MessageBox.Show("Salto realizado, pouso completo!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possível saltar, selecione um planeta válido!", "ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            AtualizarInformacoes();

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem())
            {
                MessageBox.Show("Salto realizado, retorno realizado com sucesso!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possível saltar, verifique as condições atual de retorno!", "ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            AtualizarInformacoes();
        }
    }
}
