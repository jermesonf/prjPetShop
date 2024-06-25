using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//IMPORTAR O CONTEUDO DE BLL PARA O FORMULARIO
using BLL;
using Correios;

namespace UI
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia da Classe ClientesDTO
            //Adicionar Referencia do Projeto BLL para acessar a classe
            //ADICIONAR O CODIGO using BLL no inicio deste arquivo



            //ClientesDTO clientes  = new ClientesDTO();

            //clientes.Codigo = Convert.ToInt32(txtCodigo.Text);
            //clientes.Nome = txtNome.Text;
            //clientes.Cep = mskCEP.Text;

            //MessageBox.Show(clientes.Codigo.ToString() + "\n\r" + clientes.Nome + "\n\r" + clientes.Cep, "TESTE");

            //Instância das classes = Criar um objeto
            ClientesDTO clientes = new ClientesDTO();
            SalvarClientes salvarClientes = new SalvarClientes();
            //Alimentar as variáveis por meio deste objeto.
            //clientes.codigo = Convert.ToInt32(txtCodigo.Text);
            clientes.Nome = txtNome.Text;
            clientes.Cep = mskCEP.Text;
            clientes.Email = txtEmail.Text;
            clientes.Endereco = txtEndereco.Text;
            clientes.Numero = Convert.ToInt32(txtNumero.Text);
            clientes.Bairro = txtBairro.Text;
            clientes.Cidade = txtCidade.Text;
            clientes.UF = txtUF.Text;
            clientes.Telefone = mskTelefone.Text;
            clientes.Complemento = txtComplemento.Text;

            if (rdoFeminino.Checked)
            {
                clientes.Sexo = "Feminino";
            }
            else
            {
                clientes.Sexo = "Masculino";
            }


            //Execucao do metodo InserirDados com todas as variaveis
            salvarClientes.InserirDados(clientes);

            //ATUALIZAR O GRID APOS O INSET
            CarregarGrid();
            
           

            //Chamada do método SalvarClientes
            salvarClientes.InserirDados(clientes);

            //Exibir a mensagem de Sucesso ou Falha
            MessageBox.Show(clientes.Mensagem, "Aviso",
            MessageBoxButtons.OK);
            
     
        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            //INSTANCIAR A CLASSE DOS CORREIOS
            CorreiosApi correios = new CorreiosApi();
            
            //TRY CATCH E PARA TRATAMENTO DE ERRROS
            try
            {
                //EXECUTAR A FUNCAO CONSULTA CEP
                var retornoCep = correios.consultaCEP(mskCEP.Text.Replace("-", ""));
                if (retornoCep != null)
                {
                    //RETORNOCEP funciona como um vetor ou um objeto
                    txtEndereco.Text = retornoCep.end;
                    txtUF.Text = retornoCep.uf;
                    txtCidade.Text = retornoCep.cidade;
                    txtBairro.Text = retornoCep.bairro;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString()+ " - " + erro.Data, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Variavel sair receberá a escolha do usuario: yesr ou no
            DialogResult sair = MessageBox.Show("Deseja sair da aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //é verificado se o resultado desta escolha é yes
            if (sair == DialogResult.Yes)
            {
                //Encerrar a aplicação
                Application.Exit();
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            BuscarNovoCodigo();
        }

        public void CarregarGrid()
        {
            //Instancia da classe ConsultarClientes e Clientes DTO
            ConsultarClientes consultarClientes = new ConsultarClientes();
            ClientesDTO clientes = new ClientesDTO();

            //Atribuição dos registros  ao DataGridView
            dgvListaClientes.DataSource = consultarClientes.ListarDadosClientes(clientes);

            //Procedimento para alterar os titulos e propriedades das colunas
            ConfigurarDataGridView();

            //Verificar se houve erro na estrutura da tabela
            if (!string.IsNullOrEmpty(clientes.Mensagem))
            {
                MessageBox.Show(clientes.Mensagem);
            }

        }


        public void ConfigurarDataGridView()
        {
            ////Verificar se o DataGridView contém linhas
            //if (dgvListaClientes.Rows.Count != 0)
            //{
            //    //Renomear o cabeçalho das colunas no DataGridView
            //    dgvListaClientes.Columns[0].HeaderText = "Código";
            //    dgvListaClientes.Columns[1].HeaderText = "Nome";
            //    dgvListaClientes.Columns[2].HeaderText = "CEP";
            //    dgvListaClientes.Columns[3].HeaderText = "E-mail";
            //    //Configurar a largura das colunas no DataGridView
            //    dgvListaClientes.Columns[0].Width = 50;
            //    dgvListaClientes.Columns[1].Width = 150;
            //    //Alinhar o conteúdo das colunas
            //    dgvListaClientes.Columns[0].DefaultCellStyle.Alignment =
            //    DataGridViewContentAlignment.MiddleCenter;
            //}

            //Verificar se o DataGridView contém linhas
            if (dgvListaClientes.Rows.Count != 0)
            {
                dgvListaClientes.ReadOnly = true;
                //Formatar o cabeçalho/titulo da coluna
                dgvListaClientes.Columns[0].HeaderText = "Código";
                dgvListaClientes.Columns[1].HeaderText = "Nome";
                dgvListaClientes.Columns[2].HeaderText = "CEP";
                dgvListaClientes.Columns[3].HeaderText = "E-Mail";
                dgvListaClientes.Columns[4].HeaderText = "Endereco";
                dgvListaClientes.Columns[5].HeaderText = "N";
                dgvListaClientes.Columns[6].HeaderText = "Bairro";
                dgvListaClientes.Columns[7].HeaderText = "Cidade";
                dgvListaClientes.Columns[8].HeaderText = "UF";
                dgvListaClientes.Columns[9].HeaderText = "Telefone";
                dgvListaClientes.Columns[10].HeaderText = "Complemento";
                dgvListaClientes.Columns[11].HeaderText = "Sexo";

                //Formatar a largura da coluna
                dgvListaClientes.Columns[0].Width = 50;
                dgvListaClientes.Columns[1].Width = 150;
                dgvListaClientes.Columns[2].Width = 80;
                dgvListaClientes.Columns[3].Width = 180;
                dgvListaClientes.Columns[4].Width = 150;
                dgvListaClientes.Columns[5].Width = 40;
                dgvListaClientes.Columns[8].Width = 30;

                //Alinhamento do conteúdo da coluna
                dgvListaClientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        public void LimparCampos()
        {
            txtCodigo.Clear(); //Função .Clear()
            txtNome.Text = ""; //Vazio ""
            mskCEP.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            mskTelefone.Clear();
            txtComplemento.Clear();
            rdoFeminino.Checked = true;
            rdoMasculino.Checked = false;
            btnAtualizar.Visible = false;
            btnSalvar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            LimparCampos();
            BuscarNovoCodigo();

        }


        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {        
                //Instância da classe ConsultarClientes
                //NomeClasse variavel = new NomeClasse();
                ConsultarClientes consultarClientes = new ConsultarClientes();
                //Instância da classe ClientesDTO
                ClientesDTO clientes = new ClientesDTO();
                //Amazenar o nome do TextBox
                clientes.Nome = txtPesquisa.Text;
                //Chamada do método para a pesquisa e preenchimento do DataGridView
                dgvListaClientes.DataSource = consultarClientes.ListarDadosClientesFiltro(clientes);
                //Configurar o DataGridView
                ConfigurarDataGridView();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Instância das classes AtualizarClientes e ClientesDTO
            AtualizarClientes atualizarClientes = new AtualizarClientes();
            ClientesDTO clientes = new ClientesDTO();
            //Verificar se determinados campos foram preenchidos.
            //Repita esta estrutura de IF / ELSE IF para as informações obrigatórias.
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtNome.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Campo Número obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }
            //Armazenar as informações do formulário
            clientes.Codigo = Convert.ToInt32(txtCodigo.Text);
            clientes.Nome = txtNome.Text;
            clientes.Cep = mskCEP.Text;
            clientes.Email = txtEmail.Text;
            clientes.Endereco = txtEndereco.Text;
            clientes.Numero = Convert.ToInt32(txtNumero.Text);
            clientes.Bairro = txtBairro.Text;
            clientes.Cidade = txtCidade.Text;
            clientes.UF = txtUF.Text;
            clientes.Telefone = mskTelefone.Text;
            clientes.Complemento = txtComplemento.Text;
            if (rdoFeminino.Checked == true)
            {
                clientes.Sexo = "Feminino";
            }
            else
            {
                clientes.Sexo = "Masculino";
            }
            //Utilização do método AtualizarDados com os dados do cliente como parâmetro
            atualizarClientes.AtualizarDados(clientes);
            //Atualizar e configurar o DataGridView após atualização
            CarregarGrid();
            ConfigurarDataGridView();
            MessageBox.Show(clientes.Mensagem, "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            BuscarNovoCodigo();

        }

        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evitar o erro no clique dos títulos (linha -1)
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                txtCodigo.Text = dgvListaClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvListaClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                mskCEP.Text = dgvListaClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dgvListaClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEndereco.Text = dgvListaClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNumero.Text = dgvListaClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtBairro.Text = dgvListaClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCidade.Text = dgvListaClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtUF.Text = dgvListaClientes.Rows[e.RowIndex].Cells[8].Value.ToString();
                mskTelefone.Text = dgvListaClientes.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtComplemento.Text = dgvListaClientes.Rows[e.RowIndex].Cells[10].Value.ToString();
                if (dgvListaClientes.Rows[e.RowIndex].Cells[11].Value.ToString() == "Feminino")
                {
                    rdoFeminino.Checked = true;
                }
                else
                {
                    rdoMasculino.Checked = true;
                }
                btnAtualizar.Visible = true; //Ou enable
                btnSalvar.Enabled = false;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //Instanciar a Classe DeletarClientes - Método DeletarDados
            DeletarClientes deletarClientes = new DeletarClientes();
            //Instanciar a Classe ClientesDTO - Atributos/Variáveis
            ClientesDTO clientes = new ClientesDTO();
            //Armazenar o código para exclusão
            clientes.Codigo = Convert.ToInt32(txtCodigo.Text);
            //Confirmação para exclusão do registro
            DialogResult confirmacao = MessageBox.Show("Deseja deletar o registro? Código " +
            txtCodigo.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao == DialogResult.Yes)
            {
                //Executar o método de exclusão
                deletarClientes.DeletarDados(clientes);
                CarregarGrid();
                ConfigurarDataGridView();
                LimparCampos();
                MessageBox.Show(clientes.Mensagem, "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                
                BuscarNovoCodigo();
            }
        }


        public void BuscarNovoCodigo()
        {
            //Instancias das Classes
            ConsultarClientes consultar = new ConsultarClientes();
            ClientesDTO clientes = new ClientesDTO();

            //Execução do método NovoCodigo
            consultar.NovoCodigo(clientes);

            txtCodigo.Text = clientes.Codigo.ToString();
        }
    }
}
