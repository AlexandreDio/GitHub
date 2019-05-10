using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Comumente chamado de ADO.Net
using System.Data.SqlClient;
using System.Configuration;

namespace Cadastro.DAO
{
    // static = permite utilizar a Classe SEM a Instancialização
    // ou seja, ela já existe em memória assim que o programa executa
    public static class BancoDados
    {
        private static PessoaDAO pessoaDAO;
        private static SqlConnection conexao;
        private static SqlConnection Conexao
        {
            get
            {
                conexao = conexao 
                    ?? new SqlConnection(ConfigurationManager
                    .ConnectionStrings["Conexao"].ConnectionString);

                if (conexao.State == System.Data.ConnectionState.Closed)
                    conexao.Open();

                return conexao;
            }
        }

        public static PessoaDAO Pessoas
        {
            get {//Controla a inicilização da DAO
                pessoaDAO = pessoaDAO ?? new PessoaDAO(Conexao);
                return pessoaDAO;
            } 
            set { pessoaDAO = value; }
        }
    }
}
