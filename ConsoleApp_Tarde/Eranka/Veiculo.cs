using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde.Eranka
{
    public class Veiculo
    {
        public string Cor;
        public int quantRodas;
        public int quantAssentos;
        public bool TemMotor;

        public string ExibirDados()
        {
            return Cor + " " + quantRodas + " " + quantAssentos + " " + TemMotor;

        }
    }
}
