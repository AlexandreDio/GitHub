using Cadastro.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.DAO
{
    //DAO - Data Access Objects
    public class PessoaDAO
    {
        private SqlConnection conexao;
        private List<Pessoa> repositorio;
        //Construtor - será executado quando criar uma nova DAO
        //Exemplo:     PessoaDAO dao = new PessoaDAO();
        public PessoaDAO(SqlConnection conexao)
        {
            //Ações de Construção
            this.conexao = conexao;
            repositorio = new List<Pessoa>();
        }
        //Ações da DAO - Métodos
        //Pesquisar
        public List<Pessoa> Pesquisar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @" SELECT * FROM   Pessoas ";
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    repositorio.Clear();
                    while (reader.Read())
                    {
                        repositorio.Add(new Pessoa()
                        {   Codigo = Convert.ToInt32(reader["Codigo"].ToString()),
                            Nome = reader["Nome"].ToString(),
                            Fone = reader["Fone"].ToString(),
                            Endereco = reader["Endereco"].ToString(),
                            Estado = reader["Estado"].ToString(),
                            Cidade = reader["Cidade"].ToString(),
                            Numero = reader["Numero"].ToString()
                        });
                    }
                }
            }
            catch (Exception) { throw; }
            return repositorio;
        }
        public List<Pessoa> Pesquisar(string nome)
        {
                       
            return repositorio.ToList();
        }
        //Consultar
        public Pessoa Consultar(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @" SELECT * FROM Pessoas WHERE Codigo = @Codigo";
            Pessoa pessoa=null;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    pessoa = new Pessoa() {
                        Codigo = Convert.ToInt32(reader["Codigo"].ToString()),
                        Nome = reader["Nome"].ToString(),
                        Fone = reader["Fone"].ToString(),
                        Endereco = reader["Endereco"].ToString(),
                        Estado = reader["Estado"].ToString(),
                        Cidade = reader["Cidade"].ToString(),
                        Numero = reader["Numero"].ToString() };
                }
            }
            catch (Exception)
            {
                throw;
            }

            return pessoa;
        }
        //Inserir
        public bool Inserir(Pessoa pessoa)
        {   //Adiciona a Pessoa no Repositorio
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @" INSERT INTO Pessoas 
                                 (Nome, Estado, Cidade, Fone, Numero, Endereco) 
                          VALUES (@Nome, @Estado, @Cidade, @Fone, @Numero, @Endereco) ";
            bool sucesso;
            try
            {
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);//Fazer um pra cada campo
#region parametros
                cmd.Parameters.AddWithValue("@Estado", pessoa.Estado);
                cmd.Parameters.AddWithValue("@Cidade", pessoa.Cidade);
                cmd.Parameters.AddWithValue("@Fone", pessoa.Fone);
                cmd.Parameters.AddWithValue("@Numero", pessoa.Numero);
                cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
#endregion
                //Executa o comando no Banco de Dados, sem retornar registros
                cmd.ExecuteNonQuery(); 
                sucesso = true;
            }
            catch (Exception)
            {
                sucesso = false;
            }
            return sucesso; //Retorna verdadeiro=inseriu, falso=erro
        }
        //Alterar
        public bool Alterar(Pessoa pessoa)
        {
            var indice = repositorio.IndexOf(Consultar(pessoa.Codigo));

            repositorio[indice] = pessoa;

            return true; //Retorna verdadeiro=alterou, falso=erro
        }
        //Excluir
        public bool Excluir(Pessoa pessoa)
        {
            return false; //Retorna verdadeiro=excluiu, falso=erro
        }
    }
}
