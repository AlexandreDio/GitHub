using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesBoasPraticas.Entidades.Exceptions
{
    class DataInicioMatriculaException : Exception
    {
        public DataInicioMatriculaException(string mensagem) : base(mensagem)
        {

        }
    }
}
