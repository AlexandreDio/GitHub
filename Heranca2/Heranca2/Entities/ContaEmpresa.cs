namespace Heranca2.Entities
{
    class ContaEmpresa : Conta
    {
        private double limiteEmprestimo;

        public ContaEmpresa()
        {

        }

        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo)
            : base(numero,titular,saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        //public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo)
        //    : base (numero,titular,saldo)
        //{
        //    LimiteEmprestimo = limiteEmprestimo;
        //}

        public void Emprestimo(double montante)
        {
            //se o montante for menor ou igual que o limite de emprestimo
            //soma o montante ao saldo
            if (montante <= limiteEmprestimo)
            {
                Saldo += montante;
            }
        }

        public double LimiteEmprestimo
        {
            get { return limiteEmprestimo; }
            set { limiteEmprestimo = value; }
        }

    }
}
