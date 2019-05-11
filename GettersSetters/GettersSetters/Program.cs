using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {

         // Ex.: 1
        //Cria o objeto carro e joga na memória HEAP
        Carro objCarro = new Carro();
            //Define o valor para o atributo marca
            objCarro.setMarca("GM");

            //Imprime na tela chamando o objeto objCarro e o método getMarca
            Console.WriteLine(objCarro.getMarca());
            Console.ReadKey();

            //********************************************//

            //Ex.: 2 - Utilizando os Getters and Setters
            //CarroGS objCarroGS = new CarroGS();
            //objCarroGS.modelo = "Onix";

            //Console.WriteLine(objCarroGS.modelo);
            //Console.ReadKey();
        }
    }

    class Carro
    {
        private string marca;

        public void setMarca(string marcaRecebida)
        {
            this.marca = marcaRecebida;
        }

        public string getMarca()
        {
            return this.marca;
        }
    }
}
