using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Palio p = new Palio();
            p.Marca = "Fait";
            p.Modelo = "Palio";
            p.AroRodas = 14;
            p.Potencia = 90;
            p.VersaoPalio = "Palio EDX";

            Mustang m = new Mustang();
            m.Marca = "Ford";
            m.Modelo = "Mustang";
            m.VersaoMustang = "Shelby GT 500 Cobra";

            Console.WriteLine("Meu carro é um: " + m.Marca + " " + m.Modelo + " " + m.VersaoMustang);
            Console.WriteLine("Digite qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
