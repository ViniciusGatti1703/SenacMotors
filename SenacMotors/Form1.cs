using Microsoft.VisualBasic;

namespace SenacMotors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        dynamic veiculo;
        private void btnCriarCarro_Click(object sender, EventArgs e)
        {
            //Instanciar o carro
            veiculo = new Carro();
            veiculo.Marca = Interaction.InputBox("Digite a Marca");
            veiculo.Modelo = Interaction.InputBox("Digite o Modelo");
            veiculo.Cor = Interaction.InputBox("Digite a Cor");
            veiculo.Ano = Convert.ToInt32(Interaction.InputBox("Digite o Ano"));
            veiculo.NroPortas = Convert.ToInt32(Interaction.InputBox("Digite o número de portas"));
            veiculo.Automatico = Convert.ToBoolean(Interaction.InputBox("Digite true para automático, false para não"));
            lblAviso.Text = $"Carro {veiculo.Marca} {veiculo.Modelo} criado com sucesso!!!";
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            veiculo.Acelerar();
            lblVelocimetro.Text = veiculo.GetVelocidade().ToString();

            if (veiculo.Automatico)
            {
                veiculo.TrocarMarcha(true);
                lblMarcha.Text = veiculo.GetMarcha().ToString();
            }
        }

        private void btnFreiar_Click(object sender, EventArgs e)
        {
            veiculo.Freiar();

            lblVelocimetro.Text = veiculo.GetVelocidade().ToString();

            if (veiculo.Automatico)
            {
                veiculo.TrocarMarcha(true);
                lblMarcha.Text = veiculo.GetMarcha().ToString();
            }
        }

        private void btnSobeMarcha_Click(object sender, EventArgs e)
        {
            veiculo.TrocarMarcha("+");
            lblMarcha.Text = veiculo.GetMarcha().ToString();
        }

        private void btnDesceMarcha_Click(object sender, EventArgs e)
        {
            veiculo.TrocarMarcha("-");
            lblMarcha.Text = veiculo.GetMarcha().ToString();
        }

        private void btnVirarEsquerda_Click(object sender, EventArgs e)
        {
            lblAviso.Text = veiculo.Direcionar("Esquerda");

        }

        private void btnVirarDireita_Click(object sender, EventArgs e)
        {
            lblAviso.Text = veiculo.Direcionar("Direta");
        }

        private void btnCriarMoto_Click(object sender, EventArgs e)
        {
            veiculo = new Moto();
            veiculo.Marca = Interaction.InputBox("Digite a Marca");
            veiculo.Modelo = Interaction.InputBox("Digite o Modelo");
            veiculo.Cor = Interaction.InputBox("Digite a Cor");
            veiculo.Ano = Convert.ToInt32(Interaction.InputBox("Digite o Ano"));
            veiculo.Automatico = Convert.ToBoolean(Interaction.InputBox("Digite true para automático, false para não"));
            lblAviso.Text = $"Moto {veiculo.Marca} {veiculo.Modelo} criado com sucesso!!!";

        }
    }
}
