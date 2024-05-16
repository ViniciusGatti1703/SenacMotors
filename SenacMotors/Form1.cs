namespace SenacMotors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Carro novoCarro;
        private void btnCriarCarro_Click(object sender, EventArgs e)
        {
            //Instanciar o carro
            novoCarro = new Carro();
            novoCarro.Marca = "Chevrolet";
            novoCarro.Modelo = "Impala";
            novoCarro.Cor = "Preto";
            novoCarro.Ano = 1967;
            novoCarro.NroPortas = 4;
            novoCarro.Automatico = false;
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            novoCarro.Acelerar();
            lblVelocimetro.Text = novoCarro.Velocidade.ToString();
        }
    }
}
