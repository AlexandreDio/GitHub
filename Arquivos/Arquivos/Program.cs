using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\VS\teste.txt",FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string linha = sr.ReadLine();
                Console.WriteLine(linha);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Arquivo não encontrado",e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
