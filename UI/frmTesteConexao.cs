﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PARA USO DAS CLASSE DOS PROJETOS BLL
using BLL;

namespace UI
{
    public partial class frmTesteConexao : Form
    {
        public frmTesteConexao()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            //Instância da classe TesteConexao = Carregar na memória
            //Atribuir a uma variável
            TesteConexao teste = new TesteConexao();
            //Executar o método que está dentro da classe TesteConexao
            teste.Verificar();
            //Verificação do resultado do teste
            if (teste.conectar == null)
            {
                lblMensagem.BackColor = Color.Red;
                lblMensagem.Text = "Falha!";
                MessageBox.Show(teste.mensagem, "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                lblMensagem.BackColor = Color.Blue;
                lblMensagem.Text = "Sucesso!";
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quer realmente sair?");
            Application.Exit();
        }

   
    }
}
