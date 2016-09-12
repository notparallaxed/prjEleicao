using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    public partial class frmPrincipal : frmPattern
    {
        
        public frmPrincipal()
        {
            //conexão
            MySqlConnection conexao = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD=root;DATABASE=electsis;");
            UsoComum.Conexao = conexao;
            //login
            frmLogin login = new frmLogin();
            login.ShowDialog();

            InitializeComponent();

            #region Mudar aparencia do MDI
            foreach (Control controle in this.Controls)
            {
                if (controle is MdiClient) {
                    MdiClient mdi = (MdiClient)controle;
                    mdi.BackColor = this.BackColor;
                    
                    // Get styles using Win32 calls
                    int style = GetWindowLong(mdi.Handle, GWL_STYLE);
                    int exStyle = GetWindowLong(mdi.Handle, GWL_EXSTYLE);
                    //Border Style None;
                    style &= ~WS_BORDER;
                    exStyle &= ~WS_EX_CLIENTEDGE;
                   
                    // Set the styles using Win32 calls
                    SetWindowLong(mdi.Handle, GWL_STYLE, style);
                    SetWindowLong(mdi.Handle, GWL_EXSTYLE, exStyle);

                    // Update the non-client area.
                    SetWindowPos(mdi.Handle, IntPtr.Zero, 0, 0, 0, 0,
                        SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                        SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
                    
                }
            }
            #endregion

            btnAtualUser.Text = UsoComum.UsuarioAtual.Nome;//Mostra o nome do usuário atual no botão usuários
            UsoComum.mdi = this;
            lblTopText.Text = "ELECTSIS - PRINCIPAL";

        }

        #region DLLS INUTEIS
        // Win32 Constants
        private const int GWL_STYLE = -16;
        private const int GWL_EXSTYLE = -20;

        private const int WS_BORDER = 0x00800000;
        private const int WS_EX_CLIENTEDGE = 0x00000200;

        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_SHOWWINDOW = 0x0040;
        private const uint SWP_HIDEWINDOW = 0x0080;
        private const uint SWP_NOCOPYBITS = 0x0100;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        private const uint SWP_NOSENDCHANGING = 0x0400;


        // Win32 Functions
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int Index);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd, int Index, int Value);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int X, int Y, int cx, int cy, uint uFlags);
        #endregion

        #region Variaveis
        bool logoff = false;
        #endregion

        #region Carregar módulos
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (int modulo in UsoComum.UsuarioAtual.Modulos)
            {                
                switch(modulo){
                    case 1:break;
                    case 2:
                        btnAtualUser.Click -= new EventHandler(btnAtualUser_Click);
                        btnAtualUser.Click += new EventHandler(btnAtualUser_administrator_Click);
                        break;
                    case 8:break;
                    case 9:break;
                    default:
                        foreach (Object obj in pnlMenu.Controls) {
                            if (obj is Button)
                            {
                                Button botao = (Button)obj;
                                if (botao.Name == UsoComum.Modulos.Find(x => x.Código == modulo).Componente)
                                {
                                    botao.Enabled = true;
                                }
                            }
                        }
                        break;
                }

            }
        }
        #endregion

        #region Form Closing 
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logoff)
            {
                DialogResult resultado = Aviso.Pergunta("Deseja finalizar sessão?");
                if (resultado == DialogResult.No || resultado == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    logoff = false;
                }
                else
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                }
            }
            else
            {
                DialogResult resultado = Aviso.Pergunta("Deseja sair?");
                if (resultado == DialogResult.No || resultado == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Fazer LogOff

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            //Aviso.Alerta("Função desativada temporariamente!");
            logoff = true;
            Close();
        }
        #endregion

        #region Ajustar Layout Maximized/Normal
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Height = this.Height - 30;
                form.Width = this.Width - 200;
                form.Location = new Point(200, 30);
            }
        }
        #endregion

        #region Método Abrir Janela
        private void AbrirJanela(Form janela) {

            foreach (var form in this.MdiChildren)
            {
                if (form.GetType() == janela.GetType())
                {
                    form.Focus();
                    return;
                }
            }

            janela.MdiParent = this;
            janela.Width = this.Width - 200;//form Pai menos painel lateral esquerdo
            janela.Anchor = AnchorStyles.Right;
            janela.Height = this.Height - 30;//form Pai menos barra superior
            janela.Location = new Point(200, 30);//abre o form no local correto
            janela.Show();

        }

        #endregion

        #region Instanciar Janelas
        
        //MENU
        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            AbrirJanela(new frmCandidato());
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {  
            AbrirJanela(new frmPartido());
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirJanela(new frmCargo());
        }

        private void btnUrnas_Click(object sender, EventArgs e)
        {
            AbrirJanela(new frmUrna());
        }

        private void mnuEleitor_Click(object sender, EventArgs e)
        {
            AbrirJanela(new frmEleitor());
        }

        //USUARIO
        private void btnAtualUser_Click(object sender, EventArgs e)
        {
            AbrirJanela(new frmUsuario());
        }
        //USUÁRIO ADMINISTRADOR
        void btnAtualUser_administrator_Click(object sender, EventArgs e)
        {
            AbrirJanela(new frmUsuarioAdmin());
        }

        #endregion

        #region Mudança Texto Top Bar
            private void frmPrincipal_TextChanged(object sender, EventArgs e)
        {
            lblTopText.Text = this.Text;
        }
        #endregion

    }
}
