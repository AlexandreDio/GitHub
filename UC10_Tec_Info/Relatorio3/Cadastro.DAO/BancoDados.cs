using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.DAO
{
    // static = permite utilizar a Classe SEM a Instancialização
    // ou seja, ela já existe em memória assim que o programa executa
    public static class BancoDados
    {
        private static PessoaDAO pessoaDAO;
        public static PessoaDAO Pessoas
        {
            get {//Controla a inicilização da DAO
                pessoaDAO = pessoaDAO ?? new PessoaDAO();
                return pessoaDAO;
            } 
            set { pessoaDAO = value; }
        }
    }
}
