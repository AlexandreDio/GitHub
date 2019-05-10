using Cadastro.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.DAO
{
    //DAO - Data Access Objects
    public class PessoaDAO
    {
        private List<Pessoa> repositorio;
        //Construtor - será executado quando criar uma nova DAO
        //Exemplo:     PessoaDAO dao = new PessoaDAO();
        public PessoaDAO()
        {
            //Ações de Construção
            repositorio = new List<Pessoa>();
        }
        //Ações da DAO - Métodos
        //Pesquisar
        public List<Pessoa> Pesquisar()
        {
            return repositorio;
        }
        public List<Pessoa> Pesquisar(string nome)
        {

            var resultado = repositorio
                //Where - Estrutura do Linq para pesquisas
                // p.Nome == nome - pesquisa pela igualdade
                // p.Nome.Contains(nome) - pesquisa o valor no campo
                // do valor na lista com o valor recebido
                .Where(p => p.Nome.Contains(nome));

            return resultado.ToList();
        }
        //Consultar
        public Pessoa Consultar(int codigo)
        {
            var pessoa = repositorio
                //Método que retorna o primeiro elemento
                // de um resultado de filtro, ou sem filtro
                .FirstOrDefault(p=> p.Codigo == codigo);

            return pessoa;
        }
        //Inserir
        public bool Inserir(Pessoa pessoa)
        {
            //Adiciona a Pessoa no Repositorio

            //Gambi para codigo automático
            //Recupera o maior valor de código existente e soma 1
            //Utilizando o método Max com Lambda
            pessoa.Codigo = 
                repositorio.Count == 0 
                ? 1 
                : repositorio.Max(p => p.Codigo) + 1;

            repositorio.Add(pessoa);
            //TODO - Inserir - Implementar Persistência

            return true; //Retorna verdadeiro=inseriu, falso=erro
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
