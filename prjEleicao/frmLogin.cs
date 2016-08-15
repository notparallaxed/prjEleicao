using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    public partial class frmLogin : frmPattern
    {
        public frmLogin()
        {
            InitializeComponent();
            if (Properties.Settings.Default.LembrarUsuario != "")
            {
                chkLembrar.Checked = true;
                txtUser.Text = Properties.Settings.Default.LembrarUsuario;
                txtSenha.Focus();
            }
        }

        #region Animation
        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackgroundImage = null;

            btn.Text = "ENTRAR";
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackgroundImage = Properties.Resources.login;

            btn.Text = "";
        }

        #endregion

        #region Entrar

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            pcbStatus.Visible = true;

            bgWork.RunWorkerAsync();

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        #endregion

        #region BD async query

        //FAZER LOGIN
        private void bgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                UsoComum.Conexao.Open();

                MySqlCommand login = new MySqlCommand("SELECT nm_usuario, nm_login FROM usuario WHERE nm_login='" + txtUser.Text + "' AND nm_senha=md5('" + txtSenha.Text + "');", UsoComum.Conexao);
                MySqlDataReader dados = login.ExecuteReader();
                e.Result = dados;
            }
            catch
            {
                UsoComum.Conexao.Close();
                e.Cancel = true;
            }

        }

        private void bgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbStatus.Visible = false;
            if (!e.Cancelled)
            {

                MySqlDataReader dados = (MySqlDataReader)e.Result;

                if (dados.Read())
                {
                    //lembrar do usuario na próxima inicialização
                    if (chkLembrar.Checked)
                    {
                        Properties.Settings.Default.LembrarUsuario = txtUser.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.LembrarUsuario = "";
                        Properties.Settings.Default.Save();
                    }
                    //usuario atual
                    Usuario usuarioAtual = new Usuario(dados["nm_usuario"].ToString(), dados["nm_login"].ToString());

                    UsoComum.UsuarioAtual = usuarioAtual;

                    pcbStatus.Visible = true;
                    asyncLoadModules.RunWorkerAsync();

                }
                else
                {
                    Aviso.Alerta("Nome de usuário ou senha incorretos!");
                    UsoComum.Conexao.Close();
                }
                dados.Close();
            }
            else {
                Aviso.Erro("Erro ao conectar ao Banco de dados!");
            }
                      
        }
        
        //CARREGAR MÓDULOS DE USUÁRIO
        private void asyncLoadModules_DoWork(object sender, DoWorkEventArgs e)
        {
            UsoComum.UsuarioAtual.CarregarModulos();
            UsoComum.Modulos = Modulo.Consultar();
        }

        private void asyncLoadModules_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbStatus.Visible = false;
            if (e.Error == null)
            {
                Close();
            }
            else {
                Aviso.Erro("Problema ao carregar os módulos de usuário");
            }
        }

        #endregion

        #region form closing
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UsoComum.UsuarioAtual == null) {
                Environment.Exit(0);
            }
        }
        #endregion
    }
}