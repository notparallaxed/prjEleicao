using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    public partial class frmUsuarioAdmin : Form
    {
        public frmUsuarioAdmin()
        {
            InitializeComponent();
            pcbStatus.Visible = true;
            asyncConsultar.RunWorkerAsync();
        }

        #region Form Load
        private void frmUsuarioAdmin_Load(object sender, EventArgs e)
        {
            foreach (int moduser in UsoComum.UsuarioAtual.Modulos)
            {
                if (listaModulos.Find(x => x.Código == moduser).Componente == "mnuPermissao")
                {
                    chkPermissoes.Tag = "editable";
                }
            }
        }
        #endregion

        #region Variaveis
        List<Usuario> listaUsuarios;
            List<Modulo> listaModulos;
            int formStatus = 0;//0 = normal, 1 = adding, 2 = editing
            Regex rgx = new Regex(@"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]");
        #endregion
        
        #region Selecionar
            private void Selecionar(int index) {
                txtNome.Text = listaUsuarios[index].Nome;
                txtNmLogin.Text = listaUsuarios[index].NomeLogin;
                //limpar lista de permissões
                lblPermissoes.Text = "";
                foreach (int mod in chkPermissoes.CheckedIndices)
                {
                    chkPermissoes.SetItemChecked(mod, false);
                }
                //carregar lista de permissões
                foreach (int moduser in listaUsuarios[index].Modulos)
                {
                    chkPermissoes.SetItemChecked(listaModulos.FindIndex(x => x.Código == moduser), true);
                    lblPermissoes.Text += listaModulos.Find(x => x.Código == moduser).Nome + Environment.NewLine;
                }
                if (listaUsuarios[index].NomeLogin == UsoComum.UsuarioAtual.NomeLogin)
                {
                    btnExcluir.Visible = false;
                }
                else {
                    btnExcluir.Visible = true;
                }
                
            }
        #endregion

        #region AsyncInterOP

        //Consultar
        private void asyncConsultar_DoWork(object sender, DoWorkEventArgs e)
        {
            string termo = (string)e.Argument;
            listaModulos = Modulo.Consultar();
            e.Result = Usuario.Consultar(termo != ""?termo:null);
        }
        private void asyncConsultar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                //atualiza lista de permissões
                chkPermissoes.Items.Clear();
                foreach (Modulo mod in listaModulos)
                {
                    chkPermissoes.Items.Add(mod.Nome);
                }

                //atualiza lista de usuários
                listaUsuarios = (List<Usuario>)e.Result;
                lstView.Items.Clear();
                foreach (Usuario user in listaUsuarios)
	            {
		            lstView.Items.Add(user.Nome);
	            }
                if (lstView.Items.Count != 0) {
                    lstView.SelectedIndex = 0;
                }

                pcbStatus.Visible = false;
            }
            else {
                pcbStatus.Visible = false;
                Aviso.Erro("Erro ao consultar usuários.");
            }
        }

        //Inserir
        private void asyncInserir_DoWork(object sender, DoWorkEventArgs e)
        {
            Usuario novouser = (Usuario)e.Argument;

            novouser.Salvar();
        }
        private void asyncInserir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                formStatus = 0;
                txtConfSenha.Visible = false;
                txtSenha.Visible = false;
                lblSenha.Visible = false;
                lblConfSenha.Visible = false;
                UsoComum.NormalMode(this);
                txtNmLogin.Tag = "";

                asyncConsultar.RunWorkerAsync();
                Aviso.Mensagem("Usuário inserido com sucesso");
                
            }
            else
            {
                pcbStatus.Visible = false;
                
                MySqlException erro = (MySqlException)e.Error;
                if (erro.Number == 1062) {
                    Aviso.Erro("Nome de usuário já existente!");
                    return;
                }

                Aviso.Erro("Problema ao inserir usuário");

            }

        }

        //Editar
        private void asyncEditar_DoWork(object sender, DoWorkEventArgs e)
        {
            Usuario editaruser = (Usuario)e.Argument;

            editaruser.Editar();
        }
        private void asyncEditar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                asyncConsultar.RunWorkerAsync();
                Aviso.Mensagem("Usuário editado com sucesso!");
            }
            else
            {
                pcbStatus.Visible = false;
                Aviso.Erro("Problema ao editar usuário!");
            }
        }


        //Excluir
        private void asyncExcluir_DoWork(object sender, DoWorkEventArgs e)
        {
            string nomelogin = (string)e.Argument;

            Usuario.Excluir(nomelogin);
        }
        private void asyncExcluir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                asyncConsultar.RunWorkerAsync();
                Aviso.Mensagem("Usuário excluido com sucesso!");
            }
            else
            {
                pcbStatus.Visible = false;
                Aviso.Mensagem("Problema ao excluír usuário");
            }
        }


        #endregion

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecionar(lstView.SelectedIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            formStatus = 1;
            txtNmLogin.Tag = "editable";
            UsoComum.EditMode(this);
            txtNmLogin.Text = "";
            txtNome.Text = "";
            foreach (int mod in chkPermissoes.CheckedIndices)
            {
                chkPermissoes.SetItemChecked(mod, false);
            }
            txtSenha.Clear();
            txtConfSenha.Clear();
            lblSenha.Visible = true;
            lblConfSenha.Visible = true;
            txtSenha.Visible = true;
            txtConfSenha.Visible = true;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formStatus = 0;
            UsoComum.NormalMode(this);
            txtSenha.Clear();
            txtConfSenha.Clear();
            lblSenha.Visible = false;
            txtSenha.Visible = false;
            lblConfSenha.Visible = false;
            txtConfSenha.Visible = false;
            Selecionar(lstView.SelectedIndex);
            txtNmLogin.Tag = "";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nome = rgx.Replace(txtNome.Text, "");
            string NomeLogin = rgx.Replace(txtNmLogin.Text, "");
            string senha = rgx.Replace(txtSenha.Text, "");
            string confsenha = rgx.Replace(txtSenha.Text, "");
            
            //validação
            if (nome == "") {
                Aviso.Alerta("Preencha o nome");
                return;
            }
            if (NomeLogin == "") {
                Aviso.Alerta("Preencha o Nome de Usuário");
                return;
            }

            //inserir novo usuário
            if (formStatus == 1)
            {
                //validação de senha
                if (senha == "")
                {
                    Aviso.Alerta("Preencha uma senha");
                    return;
                }
                if (senha != confsenha)
                {
                    Aviso.Alerta("As senhas não coincidem");
                    return;
                }

                Usuario novouser = new Usuario(nome, NomeLogin, senha);
                foreach (int mod in chkPermissoes.CheckedIndices)
                {
                    novouser.Modulos.Add(listaModulos[mod].Código);
                }

                pcbStatus.Visible = true;

                asyncInserir.RunWorkerAsync(novouser);
            }
            else { 
                //editar usuario
                senha = senha == "" ? null : senha;

                Usuario editaruser = new Usuario(nome, NomeLogin, senha);
                foreach (int mod in chkPermissoes.CheckedIndices)
                {
                    editaruser.Modulos.Add(listaModulos[mod].Código);
                }

                pcbStatus.Visible = true;

                asyncEditar.RunWorkerAsync(editaruser);

                txtConfSenha.Clear();
                txtSenha.Clear();
                lblConfSenha.Visible = false;
                txtConfSenha.Visible = false;
                lblSenha.Visible = false;
                txtSenha.Visible = false;
                UsoComum.NormalMode(this);
            }

            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listaUsuarios[lstView.SelectedIndex].NomeLogin == "admin") {
                Aviso.Alerta("Você não pode excluir o administrador do sistema!");
                return;
            }
            if (Aviso.Pergunta("Deseja excluir: " + listaUsuarios[lstView.SelectedIndex].Nome + "") == DialogResult.Yes) {
                pcbStatus.Visible = true;
                asyncExcluir.RunWorkerAsync(listaUsuarios[lstView.SelectedIndex].NomeLogin);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formStatus = 2;
            UsoComum.EditMode(this);
            lblSenha.Visible = true;
            txtSenha.Visible = true;
            lblConfSenha.Visible = true;
            txtConfSenha.Visible = true;
        }

        private void tmPesq_Tick(object sender, EventArgs e)
        {
            tmPesq.Stop();
            string termo = rgx.Replace(txtPesq.Text, "");

            asyncConsultar.RunWorkerAsync(termo);
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            pcbStatus.Visible = true;
            tmPesq.Stop();
            tmPesq.Start();
        }
        
    }
}