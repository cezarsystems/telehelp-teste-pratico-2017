namespace TeleHelp.Interfaces
{
    partial class FormSistema
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSistema));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControle = new System.Windows.Forms.TabControl();
            this.tabGerCadastro = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovoRegistro = new System.Windows.Forms.Button();
            this.grpBuscaRegistros = new System.Windows.Forms.GroupBox();
            this.txtNumRegistroBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.cmbBuscaCargoFunc = new System.Windows.Forms.ComboBox();
            this.lblCargoBusca = new System.Windows.Forms.Label();
            this.lblNumRegistroBusca = new System.Windows.Forms.Label();
            this.lblNomeBusca = new System.Windows.Forms.Label();
            this.txtNomeBusca = new System.Windows.Forms.TextBox();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            this.grpDadosFuncionarios = new System.Windows.Forms.GroupBox();
            this.lblIdadeCad = new System.Windows.Forms.Label();
            this.lblCargoCad = new System.Windows.Forms.Label();
            this.lblDtpDataNasc = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtIdadeCad = new System.Windows.Forms.TextBox();
            this.txtCargoCad = new System.Windows.Forms.TextBox();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.tabRegistros = new System.Windows.Forms.TabPage();
            this.txtBuscaRapida = new System.Windows.Forms.TextBox();
            this.lblPesquisaRapida = new System.Windows.Forms.Label();
            this.btnCarregarTdsRegistros = new System.Windows.Forms.Button();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.picSistema = new System.Windows.Forms.PictureBox();
            this.lblUsuarioConectado = new System.Windows.Forms.Label();
            this.btnSairAplicacao = new System.Windows.Forms.Button();
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.tabControle.SuspendLayout();
            this.tabGerCadastro.SuspendLayout();
            this.grpBuscaRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.grpDadosFuncionarios.SuspendLayout();
            this.tabRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControle
            // 
            this.tabControle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControle.Controls.Add(this.tabGerCadastro);
            this.tabControle.Controls.Add(this.tabRegistros);
            this.tabControle.Location = new System.Drawing.Point(12, 79);
            this.tabControle.Name = "tabControle";
            this.tabControle.SelectedIndex = 0;
            this.tabControle.Size = new System.Drawing.Size(782, 368);
            this.tabControle.TabIndex = 0;
            // 
            // tabGerCadastro
            // 
            this.tabGerCadastro.Controls.Add(this.btnExcluir);
            this.tabGerCadastro.Controls.Add(this.btnCancelar);
            this.tabGerCadastro.Controls.Add(this.btnSalvar);
            this.tabGerCadastro.Controls.Add(this.btnAlterar);
            this.tabGerCadastro.Controls.Add(this.btnNovoRegistro);
            this.tabGerCadastro.Controls.Add(this.grpBuscaRegistros);
            this.tabGerCadastro.Controls.Add(this.dvgDados);
            this.tabGerCadastro.Controls.Add(this.grpDadosFuncionarios);
            this.tabGerCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabGerCadastro.Name = "tabGerCadastro";
            this.tabGerCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerCadastro.Size = new System.Drawing.Size(774, 342);
            this.tabGerCadastro.TabIndex = 0;
            this.tabGerCadastro.Text = "Gerenciar Cadastros";
            this.tabGerCadastro.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(693, 316);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(612, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(531, 316);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(450, 316);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Editar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoRegistro.Location = new System.Drawing.Point(369, 316);
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnNovoRegistro.TabIndex = 8;
            this.btnNovoRegistro.Text = "Novo";
            this.btnNovoRegistro.UseVisualStyleBackColor = true;
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // grpBuscaRegistros
            // 
            this.grpBuscaRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuscaRegistros.Controls.Add(this.txtNumRegistroBusca);
            this.grpBuscaRegistros.Controls.Add(this.btnBuscarRegistros);
            this.grpBuscaRegistros.Controls.Add(this.cmbBuscaCargoFunc);
            this.grpBuscaRegistros.Controls.Add(this.lblCargoBusca);
            this.grpBuscaRegistros.Controls.Add(this.lblNumRegistroBusca);
            this.grpBuscaRegistros.Controls.Add(this.lblNomeBusca);
            this.grpBuscaRegistros.Controls.Add(this.txtNomeBusca);
            this.grpBuscaRegistros.Location = new System.Drawing.Point(6, 87);
            this.grpBuscaRegistros.Name = "grpBuscaRegistros";
            this.grpBuscaRegistros.Size = new System.Drawing.Size(762, 48);
            this.grpBuscaRegistros.TabIndex = 5;
            this.grpBuscaRegistros.TabStop = false;
            this.grpBuscaRegistros.Text = "Buscar Por:";
            // 
            // txtNumRegistroBusca
            // 
            this.txtNumRegistroBusca.Location = new System.Drawing.Point(415, 18);
            this.txtNumRegistroBusca.Name = "txtNumRegistroBusca";
            this.txtNumRegistroBusca.Size = new System.Drawing.Size(95, 20);
            this.txtNumRegistroBusca.TabIndex = 5;
            this.txtNumRegistroBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRegistroBusca_KeyPress);
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarRegistros.Location = new System.Drawing.Point(704, 18);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(52, 23);
            this.btnBuscarRegistros.TabIndex = 7;
            this.btnBuscarRegistros.Text = "Buscar";
            this.btnBuscarRegistros.UseVisualStyleBackColor = true;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // cmbBuscaCargoFunc
            // 
            this.cmbBuscaCargoFunc.FormattingEnabled = true;
            this.cmbBuscaCargoFunc.Location = new System.Drawing.Point(561, 18);
            this.cmbBuscaCargoFunc.Name = "cmbBuscaCargoFunc";
            this.cmbBuscaCargoFunc.Size = new System.Drawing.Size(137, 21);
            this.cmbBuscaCargoFunc.TabIndex = 6;
            // 
            // lblCargoBusca
            // 
            this.lblCargoBusca.AutoSize = true;
            this.lblCargoBusca.Location = new System.Drawing.Point(516, 21);
            this.lblCargoBusca.Name = "lblCargoBusca";
            this.lblCargoBusca.Size = new System.Drawing.Size(38, 13);
            this.lblCargoBusca.TabIndex = 5;
            this.lblCargoBusca.Text = "Cargo:";
            // 
            // lblNumRegistroBusca
            // 
            this.lblNumRegistroBusca.AutoSize = true;
            this.lblNumRegistroBusca.Location = new System.Drawing.Point(360, 21);
            this.lblNumRegistroBusca.Name = "lblNumRegistroBusca";
            this.lblNumRegistroBusca.Size = new System.Drawing.Size(49, 13);
            this.lblNumRegistroBusca.TabIndex = 3;
            this.lblNumRegistroBusca.Text = "Registro:";
            // 
            // lblNomeBusca
            // 
            this.lblNomeBusca.AutoSize = true;
            this.lblNomeBusca.Location = new System.Drawing.Point(6, 21);
            this.lblNomeBusca.Name = "lblNomeBusca";
            this.lblNomeBusca.Size = new System.Drawing.Size(38, 13);
            this.lblNomeBusca.TabIndex = 3;
            this.lblNomeBusca.Text = "Nome:";
            // 
            // txtNomeBusca
            // 
            this.txtNomeBusca.Location = new System.Drawing.Point(75, 18);
            this.txtNomeBusca.Name = "txtNomeBusca";
            this.txtNomeBusca.Size = new System.Drawing.Size(265, 20);
            this.txtNomeBusca.TabIndex = 4;
            // 
            // dvgDados
            // 
            this.dvgDados.AllowUserToAddRows = false;
            this.dvgDados.AllowUserToDeleteRows = false;
            this.dvgDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvgDados.GridColor = System.Drawing.SystemColors.Control;
            this.dvgDados.Location = new System.Drawing.Point(6, 141);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.ReadOnly = true;
            this.dvgDados.RowHeadersVisible = false;
            this.dvgDados.Size = new System.Drawing.Size(762, 171);
            this.dvgDados.TabIndex = 1;
            this.dvgDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDados_CellClick);
            // 
            // grpDadosFuncionarios
            // 
            this.grpDadosFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosFuncionarios.Controls.Add(this.lblIdadeCad);
            this.grpDadosFuncionarios.Controls.Add(this.lblCargoCad);
            this.grpDadosFuncionarios.Controls.Add(this.lblDtpDataNasc);
            this.grpDadosFuncionarios.Controls.Add(this.lblNomeCad);
            this.grpDadosFuncionarios.Controls.Add(this.dtpDataNasc);
            this.grpDadosFuncionarios.Controls.Add(this.txtIdadeCad);
            this.grpDadosFuncionarios.Controls.Add(this.txtCargoCad);
            this.grpDadosFuncionarios.Controls.Add(this.txtNomeCad);
            this.grpDadosFuncionarios.Location = new System.Drawing.Point(6, 6);
            this.grpDadosFuncionarios.Name = "grpDadosFuncionarios";
            this.grpDadosFuncionarios.Size = new System.Drawing.Size(762, 75);
            this.grpDadosFuncionarios.TabIndex = 0;
            this.grpDadosFuncionarios.TabStop = false;
            this.grpDadosFuncionarios.Text = "Cadastrar:";
            // 
            // lblIdadeCad
            // 
            this.lblIdadeCad.AutoSize = true;
            this.lblIdadeCad.Location = new System.Drawing.Point(516, 25);
            this.lblIdadeCad.Name = "lblIdadeCad";
            this.lblIdadeCad.Size = new System.Drawing.Size(37, 13);
            this.lblIdadeCad.TabIndex = 4;
            this.lblIdadeCad.Text = "Idade:";
            // 
            // lblCargoCad
            // 
            this.lblCargoCad.AutoSize = true;
            this.lblCargoCad.Location = new System.Drawing.Point(6, 51);
            this.lblCargoCad.Name = "lblCargoCad";
            this.lblCargoCad.Size = new System.Drawing.Size(38, 13);
            this.lblCargoCad.TabIndex = 3;
            this.lblCargoCad.Text = "Cargo:";
            // 
            // lblDtpDataNasc
            // 
            this.lblDtpDataNasc.AutoSize = true;
            this.lblDtpDataNasc.Location = new System.Drawing.Point(346, 25);
            this.lblDtpDataNasc.Name = "lblDtpDataNasc";
            this.lblDtpDataNasc.Size = new System.Drawing.Size(66, 13);
            this.lblDtpDataNasc.TabIndex = 3;
            this.lblDtpDataNasc.Text = "Nascimento:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 25);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCad.TabIndex = 3;
            this.lblNomeCad.Text = "Nome:";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(415, 22);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(95, 20);
            this.dtpDataNasc.TabIndex = 1;
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // txtIdadeCad
            // 
            this.txtIdadeCad.Location = new System.Drawing.Point(559, 22);
            this.txtIdadeCad.Name = "txtIdadeCad";
            this.txtIdadeCad.ReadOnly = true;
            this.txtIdadeCad.Size = new System.Drawing.Size(93, 20);
            this.txtIdadeCad.TabIndex = 2;
            // 
            // txtCargoCad
            // 
            this.txtCargoCad.Location = new System.Drawing.Point(75, 48);
            this.txtCargoCad.Name = "txtCargoCad";
            this.txtCargoCad.Size = new System.Drawing.Size(265, 20);
            this.txtCargoCad.TabIndex = 3;
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Location = new System.Drawing.Point(75, 22);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(265, 20);
            this.txtNomeCad.TabIndex = 0;
            // 
            // tabRegistros
            // 
            this.tabRegistros.Controls.Add(this.txtBuscaRapida);
            this.tabRegistros.Controls.Add(this.lblPesquisaRapida);
            this.tabRegistros.Controls.Add(this.btnCarregarTdsRegistros);
            this.tabRegistros.Controls.Add(this.dgvRegistros);
            this.tabRegistros.Location = new System.Drawing.Point(4, 22);
            this.tabRegistros.Name = "tabRegistros";
            this.tabRegistros.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistros.Size = new System.Drawing.Size(774, 342);
            this.tabRegistros.TabIndex = 1;
            this.tabRegistros.Text = "Registros";
            this.tabRegistros.UseVisualStyleBackColor = true;
            // 
            // txtBuscaRapida
            // 
            this.txtBuscaRapida.Location = new System.Drawing.Point(295, 13);
            this.txtBuscaRapida.Name = "txtBuscaRapida";
            this.txtBuscaRapida.Size = new System.Drawing.Size(467, 20);
            this.txtBuscaRapida.TabIndex = 1;
            this.txtBuscaRapida.TextChanged += new System.EventHandler(this.txtBuscaRapida_TextChanged);
            // 
            // lblPesquisaRapida
            // 
            this.lblPesquisaRapida.AutoSize = true;
            this.lblPesquisaRapida.Location = new System.Drawing.Point(168, 16);
            this.lblPesquisaRapida.Name = "lblPesquisaRapida";
            this.lblPesquisaRapida.Size = new System.Drawing.Size(121, 13);
            this.lblPesquisaRapida.TabIndex = 2;
            this.lblPesquisaRapida.Text = "Busca rápida de nomes:";
            // 
            // btnCarregarTdsRegistros
            // 
            this.btnCarregarTdsRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCarregarTdsRegistros.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarTdsRegistros.Image")));
            this.btnCarregarTdsRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregarTdsRegistros.Location = new System.Drawing.Point(6, 11);
            this.btnCarregarTdsRegistros.Name = "btnCarregarTdsRegistros";
            this.btnCarregarTdsRegistros.Size = new System.Drawing.Size(156, 23);
            this.btnCarregarTdsRegistros.TabIndex = 0;
            this.btnCarregarTdsRegistros.Text = "Carregar Registros";
            this.btnCarregarTdsRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregarTdsRegistros.UseVisualStyleBackColor = true;
            this.btnCarregarTdsRegistros.Click += new System.EventHandler(this.btnCarregarTdsRegistros_Click);
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistros.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRegistros.Location = new System.Drawing.Point(6, 40);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.Size = new System.Drawing.Size(762, 296);
            this.dgvRegistros.TabIndex = 0;
            // 
            // picSistema
            // 
            this.picSistema.Image = global::TeleHelp.Interfaces.Properties.Resources.img_cadeado;
            this.picSistema.Location = new System.Drawing.Point(12, 8);
            this.picSistema.Name = "picSistema";
            this.picSistema.Size = new System.Drawing.Size(76, 64);
            this.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSistema.TabIndex = 1;
            this.picSistema.TabStop = false;
            // 
            // lblUsuarioConectado
            // 
            this.lblUsuarioConectado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuarioConectado.AutoSize = true;
            this.lblUsuarioConectado.Location = new System.Drawing.Point(16, 458);
            this.lblUsuarioConectado.Name = "lblUsuarioConectado";
            this.lblUsuarioConectado.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioConectado.TabIndex = 2;
            // 
            // btnSairAplicacao
            // 
            this.btnSairAplicacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSairAplicacao.Location = new System.Drawing.Point(709, 453);
            this.btnSairAplicacao.Name = "btnSairAplicacao";
            this.btnSairAplicacao.Size = new System.Drawing.Size(75, 23);
            this.btnSairAplicacao.TabIndex = 13;
            this.btnSairAplicacao.Text = "Sair";
            this.btnSairAplicacao.UseVisualStyleBackColor = true;
            this.btnSairAplicacao.Click += new System.EventHandler(this.btnSairAplicacao_Click);
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.BackColor = System.Drawing.SystemColors.Control;
            this.lblApresentacao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblApresentacao.Location = new System.Drawing.Point(94, 30);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(496, 22);
            this.lblApresentacao.TabIndex = 4;
            this.lblApresentacao.Text = "SISTEMA DE CADASTRO DE FUNCIONÁRIOS - TELEHELP";
            // 
            // FormSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 482);
            this.Controls.Add(this.lblApresentacao);
            this.Controls.Add(this.btnSairAplicacao);
            this.Controls.Add(this.lblUsuarioConectado);
            this.Controls.Add(this.picSistema);
            this.Controls.Add(this.tabControle);
            this.MinimumSize = new System.Drawing.Size(822, 478);
            this.Name = "FormSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSistema_FormClosed);
            this.Load += new System.EventHandler(this.FormSistema_Load);
            this.tabControle.ResumeLayout(false);
            this.tabGerCadastro.ResumeLayout(false);
            this.grpBuscaRegistros.ResumeLayout(false);
            this.grpBuscaRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            this.grpDadosFuncionarios.ResumeLayout(false);
            this.grpDadosFuncionarios.PerformLayout();
            this.tabRegistros.ResumeLayout(false);
            this.tabRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControle;
        private System.Windows.Forms.TabPage tabGerCadastro;
        private System.Windows.Forms.TabPage tabRegistros;
        private System.Windows.Forms.PictureBox picSistema;
        private System.Windows.Forms.Label lblUsuarioConectado;
        private System.Windows.Forms.Button btnSairAplicacao;
        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.Button btnCarregarTdsRegistros;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.GroupBox grpDadosFuncionarios;
        private System.Windows.Forms.Label lblIdadeCad;
        private System.Windows.Forms.Label lblCargoCad;
        private System.Windows.Forms.Label lblDtpDataNasc;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtIdadeCad;
        private System.Windows.Forms.TextBox txtCargoCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.DataGridView dvgDados;
        private System.Windows.Forms.GroupBox grpBuscaRegistros;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.ComboBox cmbBuscaCargoFunc;
        private System.Windows.Forms.Label lblCargoBusca;
        private System.Windows.Forms.Label lblNumRegistroBusca;
        private System.Windows.Forms.Label lblNomeBusca;
        private System.Windows.Forms.TextBox txtNomeBusca;
        private System.Windows.Forms.TextBox txtNumRegistroBusca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovoRegistro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtBuscaRapida;
        private System.Windows.Forms.Label lblPesquisaRapida;
    }
}