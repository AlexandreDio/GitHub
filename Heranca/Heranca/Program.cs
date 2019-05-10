using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Camaro c = new Camaro();
            c.AroRodas = 22;
            c.Combustivel = "Gasolina";
            c.Potencia = 650;
            c.Modelo = "SS V8";
            Console.WriteLine($"Meu camaro é {c.Modelo} a {c.Combustivel}");
        }
    }
}
