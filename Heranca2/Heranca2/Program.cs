using System.Collections.Generic;
using Heranca2.Entities;
using System;
using System.Globalization;

namespace Heranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> list = new List<Conta>();

            Conta cc1 = new Conta(); //instanciar o objeto CC
            ContaPoupanca cp1 = new ContaPoupanca(); //instanciar o objeto CP

            //Conta Corrente
            cc1.Numero = 1001;
            cc1.Deposita(500.124578);
            cc1.Saca(100.12345);

            //Conta Poupança
            cp1.Numero = 1002;
            cp1.Deposita(500.124578);
            cp1.Saca(100.12345);

            //Imprimir na tela com apenas 2 casas decimais e com ponto como separador
            Console.WriteLine($"Minha C/C {cc1.Numero} possui saldo de " +
                $"U$ {cc1.Saldo.ToString("F2",CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"Minha C/P {cp1.Numero} possui saldo de " +
                $"U$ {cp1.Saldo.ToString("F2",CultureInfo.InvariantCulture)} ");

            //Realizar uma transferência da C/C para C/P
            cc1.Transfere(5000.0,cp1);

            //Imprimir na tela o saldo atualizado após a transferência
            Console.WriteLine($"Transferência da C/C para C/P U$: {cp1.Saldo.ToString("F2",CultureInfo.InvariantCulture)} ");


            //list.Add(new ContaPoupanca(1001,"Tony Stark",500.123,0.0123));
            //list.Add(new ContaEmpresa(1002, "Thor", 500.123, 400.78945));
            //list.Add(new ContaPoupanca(1003,"Capitã Marvel",500.123,0.01987456));
            //list.Add(new ContaEmpresa(1004,"Thanos", 500.123, 999.9999999));

            //double sum = 0.0;
            ////Saldo de todas as Contas
            //foreach (Conta acc in list)
            //{
            //    sum += acc.Saldo;
            //}

            ////Imprimir o saldo das contas
            //Console.WriteLine($"Saldo total da C/C: {sum.ToString("F2")}");

            ////Sacar 50.0 de cada conta
            //foreach (Conta acc in list)
            //{
            //    acc.Saca(10.0);
            //}

            ////Imprimir na tela o resultado
            //foreach (Conta acc in list)
            //{
            //    Console.WriteLine($"Saldo atualizado da Conta: {acc.Numero} {acc.Saldo.ToString("F2") }");
            //}



        }
    }
}
