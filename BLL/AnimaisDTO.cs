using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importar os namespaces para conexão
using System.Data;
using DAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class AnimaisDTO
    {
        public int CodigoPet { get; set; }
        public string NomePet { get; set; }
        public int CodigoDono { get; set; }
        public string Funcionario { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public string Tipo { get; set; }
        public decimal Peso { get; set; }
        public DateTime Nascimento { get; set; }
        public int RGA { get; set; }
        public string Pedigree { get; set; }
        public string Sexo { get; set; }
        public string Observacao { get; set; }
        public string Mensagem { get; set; }
    }

    public class SalvarAnimais
    {

        public void InserirDados(AnimaisDTO dados)
        {
            try
            {
                //String com o comando Insert do Banco
                string sql = "INSERT INTO tb_animais (AnNomePet," +
                "AnClCodigo, AnFnNome) VALUES (@nomePet, @codigoDono, @nomeFuncionario)";
                //Variável que receberá o resultado da Conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substiruídos
                cmd.Parameters.Add(new MySqlParameter("@nomePet", dados.NomePet));
                cmd.Parameters.Add(new MySqlParameter("@codigoDono", dados.CodigoDono));
                cmd.Parameters.Add(new MySqlParameter("@nomeFuncionario", dados.Funcionario));
                //Realiza a contagem de registros inseridos.
                int registrosInseridos = cmd.ExecuteNonQuery();

                //Verifica se algum registro foi inserido no Banco de Dados.
                if (registrosInseridos >= 1 )
                {
                    dados.Mensagem = "Registro inserido com Sucesso";
                }
                else
                {
                    dados.Mensagem = "Falaha ao inserir registro!";
                }

                //FechA A CONEXAO COM O BANCO DE DADOS
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarAnimais - InserirDados" + erro.Message;
                
            }
        }
    }
}   
