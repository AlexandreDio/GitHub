using ExcecoesRuim.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesRuim
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEGUNDA SOLUÇÃO: RUIM
            //Soluçao ruim, pois apesar de retirar um pouco da lógica de negócios do programa principal,
            //ainda delega bastante coisa para o programa principal, quando o correto seria delegar para
            //a classe Matricula e com isso aumentar a coesão e baixar o acoplamento.

            Console.Write("Número do laboratório: ");
            int numlab = int.Parse(Console.ReadLine());

            Console.Write("Data de início (dd/MM/yyyy): ");
            DateTime datainicial = DateTime.Parse(Console.ReadLine());

            Console.Write("Data do encerramento (dd/MM/yyyy): ");
            DateTime datafinal = DateTime.Parse(Console.ReadLine());

            //Verificar data de reserva
            if (datafinal <= datainicial)
            {
                Console.WriteLine("Erro na matrícula: Data do encerramento precisa ser maior que a data de início.");
            }
            else
            {
                MatriculaRuim matruim = new MatriculaRuim(numlab, datainicial, datafinal);
                Console.WriteLine($"Matrícula: {matruim}");

                Console.WriteLine();
                Console.Write("Entre com os dados para atualização da matrícula: ");
                Console.Write("Data de início (dd/MM/YYYY): ");
                datainicial = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de encerramento (dd/MM/YYYY): ");
                datafinal = DateTime.Parse(Console.ReadLine());

                string erro = matruim.AtualizaDataCurso(datainicial, datafinal);

                if (erro != null)
                {
                    Console.WriteLine($"Erro na atualização da matrícula: {erro}");
                }
                else
                {
                    Console.WriteLine($"Matrícula: {matruim}");
                }
            }
        }
    }
}
