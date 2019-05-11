using Excecoes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do Laboratório: ");
            int numLab = int.Parse(Console.ReadLine());

            Console.Write("Data do início: ");
            DateTime dataInic = DateTime.Parse(Console.ReadLine());

            Console.Write("Data do encerramento: ");
            DateTime dataFin = DateTime.Parse(Console.ReadLine());

            //Verificar data da reserva
            if (dataFin <= dataInic)
            {
                Console.WriteLine("Erro na matrícula: Data do encerramento precisa ser depois da data do início!");
            }
            else
            {
                MatriculaMuitoRuim mat = new MatriculaMuitoRuim(numLab, dataInic, dataFin);
                Console.WriteLine("Matrícula: " + mat);
                Console.WriteLine();
                Console.WriteLine("Entre com os dados para a atualização da matrícula:");
                Console.Write("Data do início (dd/MM/yyyy): ");
                dataInic = DateTime.Parse(Console.ReadLine());
                Console.Write("Data do encerramento (dd/MM/yyyy): ");
                dataFin = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (dataInic < now || dataFin < now)
                {
                    Console.WriteLine("Erro na matrícula: Datas para atualização precisa ser uma data futura!");
                }
                else if (dataFin <= dataInic)
                {
                    Console.WriteLine("Erro na matrícula: Data do encerramento precisa ser depois da data do início!");
                }
                else
                {
                    mat.AtualizaDataCurso(dataInic, dataFin);
                    Console.WriteLine($"Matrícula: {mat}");
                }

            }
        }
    }
}
