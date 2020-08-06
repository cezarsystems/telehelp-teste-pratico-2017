using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeleHelp.Negocios;

namespace TeleHelp.Interfaces
{
    public partial class FormSistema : Form
    {
        int idFuncionario;

        int flagOperacao;

        string usuarioLogado = string.Empty;

        public FormSistema(string usuario = "Administrador") // Recebendo usuário logado no sistema pelo Formlogin
        {
            InitializeComponent();

            usuarioLogado = usuario;
        }

        private void FormSistema_Load(object sender, EventArgs e)
        {          
            this.Text = string.Format("Bem-Vindo {0}!", this.usuarioLogado);
            lblUsuarioConectado.Text = string.Format("Usuário conectado: {0}", usuarioLogado);
            ControlaCampos(false);
            CarregaComboCargos();

            ToolTip renomeandoControles = new ToolTip();
            renomeandoControles.SetToolTip(this.btnBuscarRegistros, "Clique para buscar os registros como informado");
            renomeandoControles.SetToolTip(this.btnNovoRegistro, "Clique para cadastrar um novo funcionário");
            renomeandoControles.SetToolTip(this.btnAlterar, "Clique para alterar o registro selecionado");
            renomeandoControles.SetToolTip(this.btnSalvar, "Clique para salvar o registro conforme informado");
            renomeandoControles.SetToolTip(this.btnCancelar, "Clique para cancelar a edição ou a criação do novo registro");
            renomeandoControles.SetToolTip(this.btnExcluir, "Clique para excluir o registro selecionado");
            renomeandoControles.SetToolTip(this.btnExcluir, "Clique para sair da aplicação");
            renomeandoControles.SetToolTip(this.btnCarregarTdsRegistros, "Clique para carregar todos os registros da base de dados");
            renomeandoControles.SetToolTip(this.txtBuscaRapida, "Digite um nome ou parte dele para uma busca rápida");
            renomeandoControles.SetToolTip(this.dgvRegistros, "Selecione um registro da lista para editá-lo ou excluí-lo");
        }

        private void CarregaComboCargos()
        {
            var clsCon = new ClsConSQL();
            DataTable dt = new DataTable();
            dt.TableName = "DTCargos";
            dt = clsCon.DTCarregaComboCargos();

            foreach (DataRow linhas in dt.Rows)
                cmbBuscaCargoFunc.Items.Add(linhas["Cargo"]);
        }

        private void FormSistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();                
        }

        private void btnSairAplicacao_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair da aplicação?", "Saindo do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnCarregarTdsRegistros_Click(object sender, EventArgs e)
        {
            CarregaDataGridView(2);            
        }

        private void CarregaDataGridView(int idGrid)
        {
            ClsConSQL clsCon;

            DataTable dt;

            try
            {
                clsCon = new ClsConSQL();
                dt = new DataTable();
                dt = clsCon.DTBuscaTodosRegistros();

                if (dt.Rows.Count > 0)
                {
                    if (idGrid == 1)
                        dvgDados.DataSource = dt;
                    else
                        dgvRegistros.DataSource = dt;                    
                }
                else
                    MessageBox.Show("Não há registros no sistema. Favor cadastrá-los para aparecerem aqui.", "Registros inexistentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Falha ao processar a operação: " + erro.Message, "Aviso!", MessageBoxButtons.OK));
            }        
        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            int idadeFuncionario = DateTime.Today.Year - dtpDataNasc.Value.Year;
            txtIdadeCad.Text = Convert.ToString(idadeFuncionario);
        }

        private void ControlaCampos(bool flag)
        {
            foreach (TextBox txt in grpDadosFuncionarios.Controls.OfType<TextBox>())
            {
                txt.Enabled = flag;
                dtpDataNasc.Enabled = flag;
            }                      
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {           
            var cls = new ClsConSQL();
            DataSet ds = cls.BuscandoRegistros(txtNomeBusca.Text, Convert.ToInt32(txtNumRegistroBusca.Text == string.Empty ? int.MinValue : Convert.ToInt32(txtNumRegistroBusca.Text)), cmbBuscaCargoFunc.Text);

            if (ds.Tables[0].Rows.Count < 1)
                MessageBox.Show("A pesquisa não retonou resultados!", "Nenhum registro retornado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dvgDados.DataSource = ds.Tables[0];            
        }

        private void txtNumRegistroBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Só numeros são permitidos neste campo", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            LimpaControles();
            ControlaCampos(true);
            flagOperacao = 1;
            txtNomeCad.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClsConSQL clsCon = new ClsConSQL();

            int contadorCampos = 0;

            foreach (TextBox txtVazios in grpDadosFuncionarios.Controls.OfType<TextBox>())
                if (string.IsNullOrEmpty(txtVazios.Text))
                    contadorCampos++;

            if (contadorCampos > 0)
            {
                MessageBox.Show(string.Format("Existe {0} campo(s) vazio(s). Favor preenchê-los!", contadorCampos), "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (clsCon.InserindoAlterandoFuncionario(txtNomeCad.Text, dtpDataNasc.Value, txtCargoCad.Text, Convert.ToInt32(txtIdadeCad.Text), flagOperacao, idFuncionario) == true)
                {
                    MessageBox.Show("Registro gravado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaControles();
                    cmbBuscaCargoFunc.Items.Clear();
                    CarregaComboCargos();
                    txtIdadeCad.Clear();
                    ControlaCampos(false);
                    CarregaDataGridView(1);
                }
                else
                {
                    MessageBox.Show("Problemas ao gravar o registro do funcionario", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControlaCampos(false);
                    LimpaControles();
                }
            }
        }

        private void LimpaControles()
        {
            foreach (TextBox controles in grpDadosFuncionarios.Controls.OfType<TextBox>())
                controles.Clear();
            foreach (DateTimePicker controles in grpDadosFuncionarios.Controls.OfType<DateTimePicker>())
                controles.Value = DateTime.Now;
        }

        private void dvgDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgDados.Rows[e.RowIndex];
                idFuncionario = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtNomeCad.Text = row.Cells[1].Value.ToString();
                txtCargoCad.Text = row.Cells[4].Value.ToString();
                txtIdadeCad.Text = row.Cells[3].Value.ToString();
                dtpDataNasc.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                ControlaCampos(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlaCampos(false);
            txtIdadeCad.Clear();
            dvgDados.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idFuncionario != 0)
            {
                ControlaCampos(true);
                flagOperacao = 2;
            }
            else
                MessageBox.Show("Selecione antes um registro para editar", "Falha ao editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idFuncionario != 0)
            {
                if (MessageBox.Show("Deseja excluir o registro selecionado?", "Exluindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ClsConSQL clsCon = new ClsConSQL();
                    if (clsCon.DeletandoFuncionario(idFuncionario) > 0)
                    {
                        MessageBox.Show("Sucesso ao excluir o registro!", "Registro deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaControles();
                        CarregaComboCargos();
                        txtIdadeCad.Clear();
                        ControlaCampos(false);
                        CarregaDataGridView(1);
                    }
                    else
                        MessageBox.Show("Falha ao excluir o registro!", "Falha ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Selecione antes um registro para excluir", "Seleção inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);              
        }

        private void txtBuscaRapida_TextChanged(object sender, EventArgs e)
        {
            if (dgvRegistros.Rows.Count < 1)
            {
                MessageBox.Show("Primeiro carregue os dados pelo botão", "Carregar os dados primeiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                var dataTable = (DataTable)dgvRegistros.DataSource;
                var dataView = dataTable.DefaultView;
                dataView.RowFilter = string.Format("Nome like '{0}%'", txtBuscaRapida.Text);
            }
        }
    }
}
