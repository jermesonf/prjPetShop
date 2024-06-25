using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            FecharFormulario();
            AbrirFormulario(new frmClientes());
        }

        private void mnuAnimais_Click(object sender, EventArgs e)
        {
            FecharFormulario();
            AbrirFormulario(new frmAnimais());


        }

        //Procedimento para abrir os formulários filhos
        public void AbrirFormulario(Form formFilho)
        {

            //O formulário passado como parâmetro será
            //filho do formulário principal (referência do this)
            formFilho.MdiParent = this;
            //Define a posição inicial do formulário
            formFilho.StartPosition = FormStartPosition.CenterScreen;
            //Remove a borda do formulário para não ser movimentado
            //formFilho.FormBorderStyle = FormBorderStyle.None;
            //Exibe o formulário para o usuário
            formFilho.Show();

        }

        //Procedimento para fechar os formulários filhos
        public void FecharFormulario()
        {
            //Para cada formulário MDI aberto como formulário filho
            //será fechado ao iniciar outro.
            foreach (Form formFilhoMdi in MdiChildren)
            {
                formFilhoMdi.Close();
            }
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            //Variavel sair que recebera a escolha do usuario: yes ou no

            DialogResult sair = MessageBox.Show("Deseja sair da aplicação", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            //É verificado se o resultado desta escolha é YES
            if (sair == DialogResult.Yes)
            {
                //Encerra a aplicação
                Application.Exit();
            }
        
        }

        private void testeConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulario();
            AbrirFormulario(new frmTesteConexao());
        }
    }
}
