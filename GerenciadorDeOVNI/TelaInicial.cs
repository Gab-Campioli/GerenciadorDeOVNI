using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GerenciadorDeOVNI
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Verificar se o númro de tripulantes está vazio
            if (txbTrip.Text == "")
            {
                MessageBox.Show("Informe o número máximo de tripulantes.", 
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbAbd.Text == "")
            {
                MessageBox.Show("Informe a capacidade do compartimento de abdução.",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbPlanetas.SelectedIndex == -1)
            {
                MessageBox.Show("Você deve selecionar o planeta que deseja invadir.",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int maxTrip = int.Parse(txbTrip.Text);
                int maxAbd = int.Parse(txbAbd.Text);
                string planetaOrigem = cmbPlanetas.Text;

                BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTrip, maxAbd, planetaOrigem); //Instanciar o OVNI

                Gerenciador gerenciador = new Gerenciador(ovni); // Instanciar a janela gerenciador para conseguir chama-la

                Hide(); // Esconder a janela atual

                gerenciador.ShowDialog(); // Abrir a janela do gerenciador

                Show(); // Mostrar novamente a tela atual
            }
        }

        private void txbTrip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbAbd.Focus();
            }
        }

        private void txbAbd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbPlanetas.Focus();
            }
        }
    }
}
