using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para uso dos metodos MYSQL
using MySql.Data.MySqlClient;
//para uso dos metodos do projeto DAL
using DAL;

namespace BLL
{
    public class TesteConexao
    {
        //RECEBERA O RETORNO DO METODO OBTER CONEXAO
        public MySqlConnection conectar = null;
        //RECEBERA O RETORNO DAS EXCESSOES (ERROS)
        public string mensagem = string.Empty;

        //METODO PARA VERIFICAR A CONEXAO
        public void Verificar()
        {
            conectar = Conexao.obterConexao();
            mensagem = Conexao.mensagem;
        }
    }
}
