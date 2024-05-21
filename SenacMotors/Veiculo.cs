using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacMotors
{
    public class Veiculo
    {
        //propriedades (atributos)
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        protected int MarchaAtual { get; set; }
        protected int Velocidade { get; set; }

        protected bool Ligado { get; set; }
        public bool Automatico { get; set; }

        //metodos (comportamentos)

        public void Acelerar()
        {
            Velocidade = Velocidade + 10;
        }

        public void Freiar()
        {
            if (Velocidade > 0)
            {
                Velocidade = Velocidade - 10;
            }

        }




        public void TrocarMarcha(string marcha)
        {
            if (marcha == "+")
            {
                MarchaAtual = MarchaAtual + 1;
            }

            else if (marcha == "-")
            {
                MarchaAtual = MarchaAtual - 1;
            }
            else
            {
                throw new Exception("Marcha Inválida");
            }
        }

        public void TrocarMarcha(bool automatico)
        {
            switch (Velocidade)
            {
                case 0:
                    MarchaAtual = 0;
                    break;
                case 10:
                    MarchaAtual = 1;
                    break;
                case 20:
                    MarchaAtual = 2;
                    break;
                case 30:
                    MarchaAtual = 3;
                    break;
                case 40:
                    MarchaAtual = 4;
                    break;
                case 50:
                    MarchaAtual = 5;
                    break;
                default:
                    MarchaAtual = 5;
                    break;
            }
        }

        public virtual string Direcionar(string direcao)
        {
            string volante = $"Virando o volante para {direcao}";

            return volante;

        }

        public int GetVelocidade()
        {
            return Velocidade;
        }

        public int GetMarcha()
        {
            return MarchaAtual;
        }
    }
}
