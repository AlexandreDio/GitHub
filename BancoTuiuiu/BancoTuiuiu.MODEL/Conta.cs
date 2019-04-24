using System;
using System.Collections.Generic;
using System.Text;

namespace BancoTuiuiu.MODEL
{
    public class Conta
    {
        public string NumConta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public Conta()
        {
        }

        public Conta(string numConta, string titular, decimal saldo)
        {
            NumConta = numConta;
            Titular = titular;
            Saldo = saldo;
        }
    }
}
