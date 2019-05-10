namespace Heranca2.Entities
{
    class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

        public Conta()
        {

        }

        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public virtual void Saca(double montante)
        {
            this.saldo -= montante + 5.0;
        }

        public virtual void Deposita(double montante)
        {
            this.saldo += montante;
        }

        public virtual void Transfere(double montante, Conta destino)
        {
            this.Saca(montante);
            destino.Deposita(montante);
        }

        public double Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

    }
}
