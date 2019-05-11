using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciei a classe PecaLego
            PecaLego pl = new PecaLego();
            pl.Cor = "Azul";

            //pl.altura = 0.7f;
            //pl.numPinosX = 8;
            //pl.numPinosY = 2;

            PecaLego pl2 = new PecaLego();
            pl2.Cor = "Vermelha";

            //Chamar o método Mover()
            pl.Mover(1, 2, 3);

            //Chamar o método Encaixar()
            pl.Encaixar();

            Console.WriteLine($"Minha peça de lego possui a cor {pl.Cor}");
            Console.WriteLine($"Minha outra peça de lego possui a cor {pl2.Cor}");
            Console.ReadKey();
        }
    }

    class PecaLego
    {
        //public string cor;
        //public float altura;
        //public int numPinosX;
        //public int numPinosY;

        //private string cor;

        //public string getCor()
        //{
        //    return this.cor;
        //}

        //public void setCor(string corRecebida)
        //{
        //    this.cor = corRecebida;
        //}

        private string cor;

        #region Construtor padrão
        public PecaLego()
        {
        }
        #endregion


        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }


        public void Encaixar()
        {
            //Ações que o método irá executar
        }

        public int Mover(int posX, int PosY, int PosZ)
        {
            int i = 10;
            //Ações que o método irá executar
            return i;
        }
    }
}
