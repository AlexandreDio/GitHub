using Excecoes.Entidades;
using System;

namespace Excecoes
{
    class Program
    {
        //PRIMEIRA SOLUÇÃO: MUITO RUIM
        //Soluçao muito ruim, pois não delega a lógia do erro para a classe Matricula,
        //que é a reponsável por conhecer as regras que podem ocasionar o erro. Deixando
        //esta função com o programa principal (Main).
        static void Main(string[] args)
        {
            Console.Write("Número do Laboratório: ");
            int numLab = int.Parse(Console.ReadLine());

            Console.Write("Data do início: ");
            DateTime dataInic = DateTime.Parse(Console.ReadLine());

            Console.Write("Data do encerramento: ");
            DateTime dataFin = DateTime.Parse(Console.ReadLine());

            //Verificar data da matrícula
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

                DateTime agora = DateTime.Now;
                if (dataInic < agora || dataFin < agora)
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
