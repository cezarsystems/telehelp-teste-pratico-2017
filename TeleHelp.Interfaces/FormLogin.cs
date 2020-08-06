using System;
using System.Windows.Forms;
using TeleHelp.Negocios;
using System.Data;

namespace TeleHelp.Interfaces
{
    public partial class FormLogin : Form
    {
        DataTable dt;
        ClsConSQL clsCon;

        public FormLogin()
        {
            InitializeComponent();
        } 
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            ToolTipControles();
            this.Text = "TeleHelp - Sistema de cadastro de funcionários";
        } 

        private void btnCancelar_Click(object sender, EventArgs e)
        {          
            if (MessageBox.Show("Deseja sair da aplicação?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void ToolTipControles()
        {
            ToolTip renomeandoControles = new ToolTip();
            renomeandoControles.SetToolTip(this.btnLogin, "Clique para efetuar o login");
            renomeandoControles.SetToolTip(this.btnCancelar, "Clique para cancelar e sair da aplicação");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarioLogin.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de usuário", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtSenhaLogin.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de senha", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                clsCon = new ClsConSQL();
                dt = new DataTable();
                dt = clsCon.DTUtilizadorSistema(txtUsuarioLogin.Text, txtSenhaLogin.Text);

                if (dt.Rows.Count > 0)
                {
                    FormSistema abrirFormSistema = new FormSistema(dt.Rows[0][0].ToString()); // Informa o usuário logado neste formulário
                    this.Hide();
                    abrirFormSistema.Show();
                }
                else
                    MessageBox.Show("Usuário e/ou senha incorreto(s). Verifique se o usuário existe", "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Falha ao processar a operação: " + erro.Message, "Aviso!", MessageBoxButtons.OK));                           
            }
        }             
    }
}
