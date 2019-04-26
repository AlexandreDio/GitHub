using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDivisaoDeInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            //int 16 = suporta os valores de −32,768 até + 32,767
            //int 32 = suporta os valores de −2,147,483,648 até + 2,147,483,647
            //int 64 = suporta os valores de −9,223,372,036,854,775,808 até + 9,223,372,036,854,775,807
            try
            {
                Console.Write("Digite o divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                Console.Write("Digite o dividendo: ");
                int dividendo = int.Parse(Console.ReadLine());

                Console.Write("Quociente: ");
                int quociente = divisor / dividendo;
                Console.WriteLine(quociente);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro de divisão por zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch(OverflowException e)
            {
                Console.WriteLine($"Estouro de pilha: {e.Message}");
            }
        }
    }
}
