using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Para uso das classe do projeto BLL
using BLL;

namespace UI
{
    public partial class frmAnimais : Form
    {
        public frmAnimais()
        {
            InitializeComponent();
        }

        //Instancia da classe AnimaisDTO
        AnimaisDTO animais = new AnimaisDTO();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Acesso as variaveis por meio do objeto animais.
            //animais.CodigoPet = Convert.ToInt32(txtCodigoPet.Text);
            //animais.CodigoDono = Convert.ToInt32(txtCodigoDono.Text);   
            //animais.NomePet = txtPet.Text;
            //animais.Nascimento = dtpNascimento.Value.Date;

            //TESTE DE FUNCIONAMENTO
            //Este MessageBox sera substituido pelo metodo de insercao
            //MessageBox.Show(animais.CodigoPet.ToString() +
            //animais.CodigoDono.ToString() +
            //animais.NomePet +
            //animais.Nascimento);



            //Instância da classe SalvarAnimais
            SalvarAnimais salvarAnimais = new SalvarAnimais();

            //Acesso às variáveis por meio do objeto animais.
            //animais.codigoPet = Convert.ToInt32(txtCodigoPet.Text);
            animais.CodigoDono = Convert.ToInt32(cboCodigoDono.Text);
            animais.NomePet = txtPet.Text;
            animais.Funcionario = txtFuncionario.Text;

            //Teste de funcionamento
            //Chamada do método InserirDados por meio do objeto salvarAnimais
            salvarAnimais.InserirDados(animais);

            //Exibir a mensagem de Sucesso ou Falha
            MessageBox.Show(animais.Mensagem, "Aviso", MessageBoxButtons.OK);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
