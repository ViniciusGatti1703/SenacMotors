using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacMotors
{
    public class Carro : Veiculo
    {
        public int NroPortas { get; set; }

        public string Ligar()
        { 
            Ligado = true;
            return "Liguei o carro";
        }
    }
}
