using ExcecoesBoasPraticas.Entidades;
using ExcecoesBoasPraticas.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesBoasPraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //TERCEIRA SOLUÇÃO: BOA
            //Utiliza boas práticas da programação delegando a regra de negócio para a classe Matrícula e 
            //criando exceções para tratar os possíveis erros. Foi criada também uma classe de exceção
            //personalizada para tratar possíveis erros da aplicação.
            try
            {
                Console.Write("Laboratório: ");
                int numsala = int.Parse(Console.ReadLine());

                Console.Write("Data de início: ");
                DateTime datainicio = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de encerramento: ");
                DateTime datafim = DateTime.Parse(Console.ReadLine());

                MatriculaBoasPraticas mbp = new MatriculaBoasPraticas(numsala, datainicio, datafim);
                Console.WriteLine($"Matrícula: {mbp}");

                Console.WriteLine();
                Console.Write("Entre com os dados para atualização da matrícula: ");
                Console.Write("Data de início (dd/MM/yyyy): ");
                DateTime dataInicio = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de encerramento: (dd/MM/yyyy): ");
                DateTime dataFim = DateTime.Parse(Console.ReadLine());

                mbp.AtualizaDataCurso(dataInicio, dataFim);
                Console.WriteLine($"Matrícula: {mbp}");
            }
            catch (DataInicioMatriculaException e)
            {
                Console.WriteLine($"Erro na matrícula: {e.Message} ");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro na formatação: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Estourou o tamanho do tipo de dados {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
