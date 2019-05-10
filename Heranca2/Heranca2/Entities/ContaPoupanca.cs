namespace Heranca2.Entities
{
    class ContaPoupanca : Conta
    {
        private double taxaDeJuro;

        public double TaxaDeJuro
        {
            get { return taxaDeJuro; }
            set { taxaDeJuro = value; }
        }

        //Construtor
        public ContaPoupanca()
        {

        }

        //Contrutor com parametros da classe base + classe derivada (Overload)
        public ContaPoupanca(int numero, string titular, double saldo, double taxaDeJuro)
            : base(numero,titular,saldo)
        {
            TaxaDeJuro = taxaDeJuro;
        }

        public void AtualizaSaldo(double montante)
        {

        }

        //Sobrescrever o método Saca() da Conta
        public override void Saca(double montante)
        {
            base.Saca(montante);
            Saldo -= montante;
        }
    }
}
