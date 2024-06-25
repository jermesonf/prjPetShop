namespace UI
{
    partial class frmAnimais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimais));
            this.grpAnimal = new System.Windows.Forms.GroupBox();
            this.cboCodigoDono = new System.Windows.Forms.ComboBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCodigoPet = new System.Windows.Forms.Label();
            this.txtCodigoPet = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtRGA = new System.Windows.Forms.TextBox();
            this.lblRGA = new System.Windows.Forms.Label();
            this.cboPedigree = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtPet = new System.Windows.Forms.TextBox();
            this.picAnimais = new System.Windows.Forms.PictureBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPedigree = new System.Windows.Forms.Label();
            this.lblCodigoDono = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.grpListaAnimais = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoDono = new System.Windows.Forms.RadioButton();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dgvListaAnimais = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPesquisaDono = new System.Windows.Forms.TextBox();
            this.grpAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimais)).BeginInit();
            this.grpListaAnimais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAnimal
            // 
            this.grpAnimal.Controls.Add(this.cboCodigoDono);
            this.grpAnimal.Controls.Add(this.txtIdade);
            this.grpAnimal.Controls.Add(this.lblIdade);
            this.grpAnimal.Controls.Add(this.lblCodigoPet);
            this.grpAnimal.Controls.Add(this.txtCodigoPet);
            this.grpAnimal.Controls.Add(this.btnSair);
            this.grpAnimal.Controls.Add(this.btnLimpar);
            this.grpAnimal.Controls.Add(this.btnSalvar);
            this.grpAnimal.Controls.Add(this.txtObservacao);
            this.grpAnimal.Controls.Add(this.dtpNascimento);
            this.grpAnimal.Controls.Add(this.txtRGA);
            this.grpAnimal.Controls.Add(this.lblRGA);
            this.grpAnimal.Controls.Add(this.cboPedigree);
            this.grpAnimal.Controls.Add(this.cboSexo);
            this.grpAnimal.Controls.Add(this.txtPeso);
            this.grpAnimal.Controls.Add(this.txtTipo);
            this.grpAnimal.Controls.Add(this.txtCor);
            this.grpAnimal.Controls.Add(this.txtRaca);
            this.grpAnimal.Controls.Add(this.txtFuncionario);
            this.grpAnimal.Controls.Add(this.txtPet);
            this.grpAnimal.Controls.Add(this.picAnimais);
            this.grpAnimal.Controls.Add(this.lblObservacao);
            this.grpAnimal.Controls.Add(this.lblNascimento);
            this.grpAnimal.Controls.Add(this.lblPeso);
            this.grpAnimal.Controls.Add(this.lblSexo);
            this.grpAnimal.Controls.Add(this.lblPedigree);
            this.grpAnimal.Controls.Add(this.lblCodigoDono);
            this.grpAnimal.Controls.Add(this.lblFuncionario);
            this.grpAnimal.Controls.Add(this.lblRaca);
            this.grpAnimal.Controls.Add(this.lblCor);
            this.grpAnimal.Controls.Add(this.lblTipo);
            this.grpAnimal.Controls.Add(this.lblPet);
            this.grpAnimal.Location = new System.Drawing.Point(12, 12);
            this.grpAnimal.Name = "grpAnimal";
            this.grpAnimal.Size = new System.Drawing.Size(508, 427);
            this.grpAnimal.TabIndex = 0;
            this.grpAnimal.TabStop = false;
            this.grpAnimal.Text = "ANIMAL";
            // 
            // cboCodigoDono
            // 
            this.cboCodigoDono.FormattingEnabled = true;
            this.cboCodigoDono.Location = new System.Drawing.Point(102, 71);
            this.cboCodigoDono.Name = "cboCodigoDono";
            this.cboCodigoDono.Size = new System.Drawing.Size(172, 21);
            this.cboCodigoDono.TabIndex = 71;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(326, 228);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(43, 20);
            this.txtIdade.TabIndex = 70;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(286, 233);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 69;
            this.lblIdade.Text = "Idade";
            // 
            // lblCodigoPet
            // 
            this.lblCodigoPet.AutoSize = true;
            this.lblCodigoPet.Location = new System.Drawing.Point(8, 22);
            this.lblCodigoPet.Name = "lblCodigoPet";
            this.lblCodigoPet.Size = new System.Drawing.Size(74, 13);
            this.lblCodigoPet.TabIndex = 68;
            this.lblCodigoPet.Text = "Código do Pet";
            // 
            // txtCodigoPet
            // 
            this.txtCodigoPet.Location = new System.Drawing.Point(102, 19);
            this.txtCodigoPet.Name = "txtCodigoPet";
            this.txtCodigoPet.Size = new System.Drawing.Size(172, 20);
            this.txtCodigoPet.TabIndex = 67;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(354, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 50);
            this.btnSair.TabIndex = 66;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(265, 360);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 50);
            this.btnLimpar.TabIndex = 65;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(176, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(56, 50);
            this.btnSalvar.TabIndex = 64;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(102, 281);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(396, 72);
            this.txtObservacao.TabIndex = 63;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Checked = false;
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNascimento.Location = new System.Drawing.Point(102, 228);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNascimento.RightToLeftLayout = true;
            this.dtpNascimento.Size = new System.Drawing.Size(172, 20);
            this.dtpNascimento.TabIndex = 62;
            this.dtpNascimento.Value = new System.DateTime(2021, 7, 22, 22, 43, 41, 0);
            // 
            // txtRGA
            // 
            this.txtRGA.Location = new System.Drawing.Point(411, 228);
            this.txtRGA.Name = "txtRGA";
            this.txtRGA.Size = new System.Drawing.Size(87, 20);
            this.txtRGA.TabIndex = 61;
            // 
            // lblRGA
            // 
            this.lblRGA.AutoSize = true;
            this.lblRGA.Location = new System.Drawing.Point(375, 233);
            this.lblRGA.Name = "lblRGA";
            this.lblRGA.Size = new System.Drawing.Size(30, 13);
            this.lblRGA.TabIndex = 60;
            this.lblRGA.Text = "RGA";
            // 
            // cboPedigree
            // 
            this.cboPedigree.FormattingEnabled = true;
            this.cboPedigree.Location = new System.Drawing.Point(102, 254);
            this.cboPedigree.Name = "cboPedigree";
            this.cboPedigree.Size = new System.Drawing.Size(172, 21);
            this.cboPedigree.TabIndex = 59;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(326, 254);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboSexo.Size = new System.Drawing.Size(172, 21);
            this.cboSexo.TabIndex = 58;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(102, 202);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(172, 20);
            this.txtPeso.TabIndex = 57;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(102, 176);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(172, 20);
            this.txtTipo.TabIndex = 56;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(102, 150);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(172, 20);
            this.txtCor.TabIndex = 55;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(102, 124);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(172, 20);
            this.txtRaca.TabIndex = 54;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(102, 98);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(172, 20);
            this.txtFuncionario.TabIndex = 53;
            // 
            // txtPet
            // 
            this.txtPet.Location = new System.Drawing.Point(102, 45);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(172, 20);
            this.txtPet.TabIndex = 52;
            // 
            // picAnimais
            // 
            this.picAnimais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAnimais.BackgroundImage")));
            this.picAnimais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAnimais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAnimais.Location = new System.Drawing.Point(283, 19);
            this.picAnimais.Name = "picAnimais";
            this.picAnimais.Size = new System.Drawing.Size(215, 202);
            this.picAnimais.TabIndex = 51;
            this.picAnimais.TabStop = false;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(8, 284);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 50;
            this.lblObservacao.Text = "Observação";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(8, 233);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 49;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(8, 206);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 48;
            this.lblPeso.Text = "Peso";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(289, 257);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 47;
            this.lblSexo.Text = "Sexo";
            // 
            // lblPedigree
            // 
            this.lblPedigree.AutoSize = true;
            this.lblPedigree.Location = new System.Drawing.Point(8, 257);
            this.lblPedigree.Name = "lblPedigree";
            this.lblPedigree.Size = new System.Drawing.Size(49, 13);
            this.lblPedigree.TabIndex = 46;
            this.lblPedigree.Text = "Pedigree";
            // 
            // lblCodigoDono
            // 
            this.lblCodigoDono.AutoSize = true;
            this.lblCodigoDono.Location = new System.Drawing.Point(8, 75);
            this.lblCodigoDono.Name = "lblCodigoDono";
            this.lblCodigoDono.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoDono.TabIndex = 45;
            this.lblCodigoDono.Text = "Código do Dono";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(8, 102);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 44;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(8, 128);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 43;
            this.lblRaca.Text = "Raça";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(8, 154);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 42;
            this.lblCor.Text = "Cor";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(8, 180);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 41;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(8, 49);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(69, 13);
            this.lblPet.TabIndex = 40;
            this.lblPet.Text = "Nome do Pet";
            // 
            // grpListaAnimais
            // 
            this.grpListaAnimais.Controls.Add(this.radioButton1);
            this.grpListaAnimais.Controls.Add(this.rdoDono);
            this.grpListaAnimais.Controls.Add(this.btnDeletar);
            this.grpListaAnimais.Controls.Add(this.dgvListaAnimais);
            this.grpListaAnimais.Controls.Add(this.btnEditar);
            this.grpListaAnimais.Controls.Add(this.txtPesquisaDono);
            this.grpListaAnimais.Location = new System.Drawing.Point(526, 12);
            this.grpListaAnimais.Name = "grpListaAnimais";
            this.grpListaAnimais.Size = new System.Drawing.Size(559, 427);
            this.grpListaAnimais.TabIndex = 1;
            this.grpListaAnimais.TabStop = false;
            this.grpListaAnimais.Text = "LISTA DE ANIMAIS";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(234, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nome do Pet";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdoDono
            // 
            this.rdoDono.AutoSize = true;
            this.rdoDono.Location = new System.Drawing.Point(141, 20);
            this.rdoDono.Name = "rdoDono";
            this.rdoDono.Size = new System.Drawing.Size(87, 17);
            this.rdoDono.TabIndex = 44;
            this.rdoDono.TabStop = true;
            this.rdoDono.Text = "Código Dono";
            this.rdoDono.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(323, 360);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(56, 50);
            this.btnDeletar.TabIndex = 43;
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // dgvListaAnimais
            // 
            this.dgvListaAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAnimais.Location = new System.Drawing.Point(15, 45);
            this.dgvListaAnimais.Name = "dgvListaAnimais";
            this.dgvListaAnimais.ReadOnly = true;
            this.dgvListaAnimais.Size = new System.Drawing.Size(521, 308);
            this.dgvListaAnimais.TabIndex = 37;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(234, 360);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 50);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaDono
            // 
            this.txtPesquisaDono.Location = new System.Drawing.Point(338, 19);
            this.txtPesquisaDono.Name = "txtPesquisaDono";
            this.txtPesquisaDono.Size = new System.Drawing.Size(198, 20);
            this.txtPesquisaDono.TabIndex = 41;
            // 
            // frmAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 456);
            this.Controls.Add(this.grpListaAnimais);
            this.Controls.Add(this.grpAnimal);
            this.Name = "frmAnimais";
            this.Text = "Cadastro de Animais";
            this.grpAnimal.ResumeLayout(false);
            this.grpAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimais)).EndInit();
            this.grpListaAnimais.ResumeLayout(false);
            this.grpListaAnimais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAnimal;
        private System.Windows.Forms.ComboBox cboCodigoDono;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCodigoPet;
        private System.Windows.Forms.TextBox txtCodigoPet;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtRGA;
        private System.Windows.Forms.Label lblRGA;
        private System.Windows.Forms.ComboBox cboPedigree;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.TextBox txtPet;
        private System.Windows.Forms.PictureBox picAnimais;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPedigree;
        private System.Windows.Forms.Label lblCodigoDono;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.GroupBox grpListaAnimais;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dgvListaAnimais;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtPesquisaDono;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdoDono;
    }
}