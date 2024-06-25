using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using DAL;
using MySqlX.XDevAPI;

namespace BLL
{
    public class ClientesDTO
    {
        //ATRIBUTOS = VARIAVEIS
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Complemento { get; set; }
        public string Sexo { get; set; }

        public string Mensagem { get; set; }
    }

    public class SalvarClientes
    {
        public void InserirDados(ClientesDTO dados)
        {
            try
            {
                //Instrução de inserção no banco de dados
                string sql = "INSERT INTO tb_cliente(ClNome,ClCep, ClEmail, ClEndereco," +
                    "ClNumero, ClBairro, ClCidade, ClUF, ClTelefone, ClComplemento, ClSexo)" +
                    "VALUES (@nome, @cep, @email, @endereco, @numero, @bairro, @cidade, @uf, " +
                    "@telefone, @complemento, @sexo)";

                //Instância que realizará a conexão e execução do Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;

                //Parâmetros a serem substituídos
                //Fatal ERROR - caso os parâmetros @ estejam errados
                cmd.Parameters.Add(new MySqlParameter("@nome", dados.Nome));
                cmd.Parameters.Add(new MySqlParameter("@cep", dados.Cep));
                cmd.Parameters.Add(new MySqlParameter("@email", dados.Email));
                cmd.Parameters.Add(new MySqlParameter("@endereco", dados.Endereco));
                cmd.Parameters.Add(new MySqlParameter("@numero", dados.Numero));
                cmd.Parameters.Add(new MySqlParameter("@bairro", dados.Bairro));
                cmd.Parameters.Add(new MySqlParameter("@cidade", dados.Cidade));
                cmd.Parameters.Add(new MySqlParameter("@uf", dados.UF));
                cmd.Parameters.Add(new MySqlParameter("@telefone", dados.Telefone));
                cmd.Parameters.Add(new MySqlParameter("@complemento", dados.Complemento));
                cmd.Parameters.Add(new MySqlParameter("@sexo", dados.Sexo));



                //Contagem de registros inseridos e execução do Insert
                //ExecuteNonQuery = retorna o número de linhas alteradas
                int registrosInseridos = cmd.ExecuteNonQuery();

                //Verificação de quantos registros foram inseridos
                if (registrosInseridos >= 1)
                {
                    dados.Mensagem = "Registro inserido com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao inserir o registro!";
                }
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarCliente - InserirDados - " +
                erro.ErrorCode +
                erro.Message;
            }
        }
    }

    public class ConsultarClientes
    {
        //SELECT
        public DataTable ListarDadosClientes(ClientesDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * FROM tb_cliente";
                //Comando para o SELECT e a Conexão - MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Adaptar os dados do BD para o formato de tabela
                //com a execução da Conexão e SELECT
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechar a conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "Erro - ConsultarClientes - ListarDadosClientes " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }

        //SELECT com WHERE ou LIKE
        public DataTable ListarDadosClientesFiltro(ClientesDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();//Objeto chamado tabela
            try
            {
                /*Opção 1 - Instrção de comando SLECT com Where

                string sql = "SELECT * FROM tb_cliente WHERE  ClNome = @nome";*/

                //Opção 2 - Instrução de comando para o Banco de dados com WHERE
                string sql = "SELECT * FROM tb_cliente WHERE ClNome LIKE @nome";

                //Comando para o SELECT e a Conexão - MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Substitui o parâmetro @nome para o conteúdo digitado
                cmd.Parameters.Add(new MySqlParameter("@nome","%" + dados.Nome + "%"));

                //Adaptar os dados do BD para o formato de tabela
                //com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                //Preenchimento da variavel em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);

                //Fechar a conexão
                Conexao.fecharConexao();
            }
            catch(MySqlException erro)
            {
                dados.Mensagem = "Erro - ConsultarClientes - ListarDadosClientesFiltro - " + erro.Message.ToString();
            }

            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno sera no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }


        public void NovoCodigo(ClientesDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de Dados
                string sql = "SELECT ClCodigo FROM tb_cliente ORDER BY " +
                "ClCodigo DESC LIMIT 1";
                //Variável que receberá o resultado da Conexão e Comando SELECT
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                if (dr.HasRows)
                {
                    //Enquanto houver dados
                    while (dr.Read())
                    {
                        dados.Codigo = dr.GetInt32(0) + 1;
                    }//11 + 1 = 12
                }
                else
                {
                    dados.Codigo = 1;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarClientes - NovoCodigo " +
                erro.Message.ToString();
            }
        }
     
    }

    public class AtualizarClientes
    {
        public void AtualizarDados(ClientesDTO dados)
        {

            try
            {
                //String com o comando de atualização
                string sql = "UPDATE tb_cliente SET ClNome=@nome," +
                "ClCEP=@cep,ClEmail=@email,ClEndereco=@endereco," +
                "ClNumero=@numero,ClBairro=@bairro,ClCidade=@cidade," +
                "ClUF=@uf,ClTelefone=@telefone,ClComplemento=@complemento," +
                "ClSexo=@sexo WHERE ClCodigo=@codigo";
                //Uso da abertura de Conexão e da string sql
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Stored Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos (@) por variáveis
                cmd.Parameters.Add(new MySqlParameter("@nome", dados.Nome));
                cmd.Parameters.Add(new MySqlParameter("@cep", dados.Cep));
                cmd.Parameters.Add(new MySqlParameter("@email", dados.Email));
                cmd.Parameters.Add(new MySqlParameter("@endereco", dados.Endereco));
                cmd.Parameters.Add(new MySqlParameter("@numero", dados.Numero));
                cmd.Parameters.Add(new MySqlParameter("@bairro", dados.Bairro));
                cmd.Parameters.Add(new MySqlParameter("@cidade", dados.Cidade));
                cmd.Parameters.Add(new MySqlParameter("@uf", dados.UF));
                cmd.Parameters.Add(new MySqlParameter("@telefone", dados.Telefone));
                cmd.Parameters.Add(new MySqlParameter("@complemento", dados.Complemento));
                cmd.Parameters.Add(new MySqlParameter("@sexo", dados.Sexo));
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
                //Quantidade de registros atualizados
                int registrosAtualizados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi atualizado
                if (registrosAtualizados >= 1)
                {
                    dados.Mensagem = "Sucesso ao atualizar o registro!";
                }
                else
                {
                    dados.Mensagem = "Falha ao atualizar o registro!";
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - AtualizarClientes - AtualizarDados - " +
                erro.Message.ToString();
                
            }
        }

    }

    public class DeletarClientes
    {
        public void DeletarDados(ClientesDTO dados)
        {
            try
            {
                //Comando Delete para o BD
                string sql = "DELETE FROM tb_cliente WHERE ClCodigo=@codigo";
                //Variável que receberá o resultado da Conexão e Delete
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Declarar o tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
                //Execução do comando
                int registrosDeletados = cmd.ExecuteNonQuery();
                //Verificação da exclusão do registros
                if (registrosDeletados >= 1)
                {
                    dados.Mensagem = "Registro deletado com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao deletar o registro!";
                }
                Conexao.fecharConexao();
            }
            catch (Exception erro)
            {

                dados.Mensagem = "ERRO - DeletarClientes - DeletarDados" + erro.Message;
            }
        }
    }
}
