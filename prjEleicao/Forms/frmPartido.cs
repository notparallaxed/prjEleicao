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
    public partial class frmPartido : Form
    {
        public frmPartido()
        {
            InitializeComponent();
            pcbStatus.Visible = true;
            AsyncPesquisar.RunWorkerAsync();
        }

        public frmPartido(string sigla){
            InitializeComponent();
            pcbStatus.Visible = true;
            AsyncPesquisar.RunWorkerAsync(sigla);
            txtPesq.Text = sigla;
        }

        #region FormFocus
        private void frmPartido_Activated(object sender, EventArgs e)
        {
            UsoComum.AnimacaoBotaoMenu(UsoComum.mdi.btnPartidos, Color.FromArgb(76, 175, 80));
            UsoComum.mdi.Text = "ELECTSIS - PARTIDOS";
        }
        #endregion

        #region Variaveis
        List<Partido> listaPartidos;
            int formStatus = 0;//0 - normal | 1 - adicionar | 2 - editar;
            Regex rgx = new Regex(@"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]"); 
        #endregion

        #region Método Selecionar Partido
        private void SelecionarPartido() {
            if (lstView.SelectedIndex != -1)
            {
                btnEdit.Visible = true;
                btnExcluir.Visible = true;
                txtNome.Text = listaPartidos[lstView.SelectedIndex].Nome;
                txtNumero.Text = listaPartidos[lstView.SelectedIndex].Numero.ToString();
                txtSigla.Text = listaPartidos[lstView.SelectedIndex].Sigla;
            }
            else
            {
                txtNome.Text = "Sem Partido";
                txtNumero.Text = "- -";
                txtSigla.Text = "- -";
                btnEdit.Visible = false;
                btnExcluir.Visible = false;
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UsoComum.EditMode(this);
            foreach (Control clt in this.Controls)
            {
                if (clt is TextBox) {
                    clt.Text = "";
                }
            }
            formStatus = 1;//adicao
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UsoComum.EditMode(this);
            txtSigla.Enabled = false;
            formStatus = 2;//edicao
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Aviso.Pergunta("Você deseja excluir o partido " + listaPartidos[lstView.SelectedIndex].Sigla + " ?") == DialogResult.Yes)
            {
                AsyncExcluirPartido.RunWorkerAsync(listaPartidos[lstView.SelectedIndex].Sigla);
            }
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarPartido();            
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            pcbStatus.Visible = true;

            tmPesq.Start();
        }

        private void tmPesq_Tick(object sender, EventArgs e)
        {
            string termo = rgx.Replace(txtPesq.Text, "");

            tmPesq.Stop();
            AsyncPesquisar.RunWorkerAsync(termo);
        }

        #region CRUD

        //INSERIR PARTIDO
        private void InserirPartido_DoWork(object sender, DoWorkEventArgs e)
        {
            Partido partido = (Partido)e.Argument;
            try
            {
                partido.Salvar();
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void AsyncInserirPartido_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                Aviso.Mensagem("Partido adicionado com sucesso!");
                AsyncPesquisar.RunWorkerAsync();
            }
            else
            {
                Aviso.Erro("Algo deu errado ao adicionar partidos");
                pcbStatus.Visible = false;
            }
        }

        //ATUALIZAR PARTIDO

        private void AsyncEditarPartido_DoWork(object sender, DoWorkEventArgs e)
        {
            Partido partido = (Partido)e.Argument;
            try
            {
                partido.Editar();
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void AsyncEditarPartido_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                Aviso.Mensagem("Partido Editado com sucesso!");
                AsyncPesquisar.RunWorkerAsync();
            }
            else
            {
                Aviso.Erro("Problema ao editar partido!");
                pcbStatus.Visible = false;
            }
            txtSigla.Enabled = true;            
        }

        //EXCLUIR PARTIDO

        private void AsyncExcluirPartido_DoWork(object sender, DoWorkEventArgs e)
        {
            string sigla = (String)e.Argument;
            try
            {
                Partido.Excluir(sigla);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void AsyncExcluirPartido_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                AsyncPesquisar.RunWorkerAsync();
            }
            else
            {
                Aviso.Erro("Problema ao excluir partido!");
            }
        }

        //PESQUISAR

        private void AsyncPesquisar_DoWork(object sender, DoWorkEventArgs e)
        {
            string termo = (String)e.Argument;

            try
            {
                listaPartidos = Partido.PesquisarPartidos(termo);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void AsyncPesquisar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                lstView.Items.Clear();
                foreach (Partido part in listaPartidos)
                {
                    lstView.Items.Add(part.Nome);
                }
                if (lstView.Items.Count != 0)
                {
                    lstView.SelectedIndex = 0;
                }
                else {
                    SelecionarPartido();
                }
            }
            else
            {
                Aviso.Erro("Problema ao pesquisar!");
            }
            pcbStatus.Visible = false;
        }
       
        #endregion

        #region Salvar/Cancelar
        private void btnSave_Click(object sender, EventArgs e)
        {

            string sigla_partido = ""; 
            string nome_partido = "";  
            int nr_partido = 0;
            
            //VALIDAÇÃO DAS ENTRADAS
            if(txtNome.Text == "" || txtSigla.Text == "" || txtNumero.Text == ""){
                Aviso.Alerta("Preencha todos os campos!");
                return;
            }
            
            try{
                sigla_partido = rgx.Replace(txtSigla.Text, "").Replace(" ","");
                nome_partido = rgx.Replace(txtNome.Text, "");
                nr_partido = int.Parse(txtNumero.Text);
            }catch{
                Aviso.Alerta("O campo \"Numero Partido\" só aceita números!");
                return;
            }

            //CRIAÇÃO DO OBJETO 
            Partido partido = new Partido(sigla_partido, nome_partido , nr_partido);

            //PROCESSOS
            pcbStatus.Visible = true;
            //Inclusão
            if (formStatus == 1)
            {
                AsyncInserirPartido.RunWorkerAsync(partido);
            }//Edição
            else {
                AsyncEditarPartido.RunWorkerAsync(partido);
            }
            UsoComum.NormalMode(this);
            formStatus = 0;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UsoComum.NormalMode(this);
            formStatus = 0;//normal
            txtSigla.Enabled = true;
            SelecionarPartido();
        }
        #endregion
        
    }
}
