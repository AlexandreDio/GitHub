using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTuiuiu.Entidades
{
    class SaldoInsuficiente : Exception
    {
        public SaldoInsuficiente(string mensagem) : base(mensagem)
        {

        }
    }
}
