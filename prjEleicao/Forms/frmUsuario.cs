using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace prjEleicao
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        #region Variaveis
            Regex rgx = new Regex(@"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]");
        #endregion

        #region Form Focus
        private void frmUsuario_Activated(object sender, EventArgs e)
        {
                UsoComum.mdi.Text = "ELECTSIS - " + this.Text;
        }
        #endregion
        
        #region Form Load
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            AtualizarView();
        }
        #endregion

        #region AtualizarView
        private void AtualizarView() {
            UsoComum.mdi.btnAtualUser.Text = UsoComum.UsuarioAtual.Nome;
            txtNome.Text = UsoComum.UsuarioAtual.Nome;
            txtNomeUser.Text = UsoComum.UsuarioAtual.NomeLogin;
            txtPermissoes.Text = "";
            foreach (int modulo in UsoComum.UsuarioAtual.Modulos)
            {
                txtPermissoes.Text += UsoComum.Modulos.Find(x => x.Código == modulo).Nome + Environment.NewLine;
            }
        }

        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UsoComum.EditMode(this);
            lblSenhaAtual.Visible = true;
            txtSenhaAtual.Visible = true;
            txtSenhaAtual.Text = "";
            lblSenha.Visible = true;
            txtSenha.Visible = true;
            txtSenha.Text = "";
            lblConfSenha.Visible = true;
            txtConfSenha.Visible = true;
            txtConfSenha.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UsoComum.NormalMode(this);
            lblSenhaAtual.Visible = false;
            txtSenhaAtual.Visible = false;
            lblSenha.Visible = false;
            txtSenha.Visible = false;
            lblConfSenha.Visible = false;
            txtConfSenha.Visible = false;

            AtualizarView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nome = rgx.Replace(txtNome.Text,"");
            string senhaatual = rgx.Replace(txtSenhaAtual.Text, "");
            string novasenha = rgx.Replace(txtSenha.Text, "");
            string confsenha = rgx.Replace(txtConfSenha.Text, "");

            if (nome == "")
            {
                Aviso.Alerta("Preencha o nome corretamente!");
                return;
            }
            if (senhaatual == "") {
                Aviso.Alerta("Preencha a senha atual para confirmar as alterações.");
                return;
            }

            if ((novasenha != confsenha ) && (novasenha != "")) {
                Aviso.Alerta("As senhas não coincidem");
                return;
            }

            Dictionary<string, string> dados = new Dictionary<string, string>();

            dados.Add("nome", nome);
            dados.Add("senhaatual", senhaatual);
            dados.Add("senhanova", novasenha == ""?null:novasenha);

            pcbStatus.Visible = true;
            asyncEditar.RunWorkerAsync(dados);

            UsoComum.NormalMode(this);
            lblSenhaAtual.Visible = false;
            txtSenhaAtual.Visible = false;
            lblSenha.Visible = false;
            txtSenha.Visible = false;
            lblConfSenha.Visible = false;
            txtConfSenha.Visible = false;
        }

        #region AsyncInterOP

        private void asyncEditar_DoWork(object sender, DoWorkEventArgs e)
        {
            Dictionary<string, string> dados = (Dictionary<string, string>)e.Argument;

            if (Usuario.Login(UsoComum.UsuarioAtual.NomeLogin, dados["senhaatual"]) == null) {
                e.Cancel = true;
            }

            Usuario editaruser = new Usuario(dados["nome"], UsoComum.UsuarioAtual.NomeLogin, dados["senhanova"]);
            editaruser.Editar();

            UsoComum.UsuarioAtual = editaruser;
        }

        private void asyncEditar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbStatus.Visible = false;
            if ((e.Error == null) && (e.Cancelled == false))
            {
                AtualizarView();    
                Aviso.Mensagem("Dados editados com sucesso!");
            }
            else {
                if (e.Cancelled) {
                    Aviso.Alerta("Senha incorreta! Alterações não realizadas.");
                    return;
                }
                Aviso.Mensagem("Erro ao editar dados");
            }
        }

        #endregion

    }
}
