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
    public partial class frmUrna : Form
    {
        public frmUrna()
        {
            InitializeComponent();
            pcbStatus.Visible = true;
            asyncConsultar.RunWorkerAsync();
        }

        #region Form Focus
        private void frmUrna_Activated(object sender, EventArgs e)
        {
            UsoComum.AnimacaoBotaoMenu(UsoComum.mdi.btnUrnas, Color.FromArgb(198, 40, 40));
            UsoComum.mdi.Text = "ELECTSIS - URNAS";
        }
        #endregion

        #region Variaveis
            List<Urna> listaUrnas;
            Regex rgx = new Regex(@"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]");
        #endregion

        #region Atualizar Lista
        private void AtualizarLista(int index = 0) {
            lstView.Items.Clear();

            foreach (Urna urna in listaUrnas)
            {
                lstView.Items.Add(urna.Codigo);
            }

            if (lstView.Items.Count != 0)
            {
                lstView.SelectedIndex = index;
            }
            
            SelecionarItem();
        }
        #endregion

        #region Selecionar Item
        private void SelecionarItem() {
            if (lstView.Items.Count == 0)
            {
                txtNome.Text = "Sem urnas";
                btnExcluir.Visible = false;
            }
            else {
                txtNome.Text = listaUrnas[lstView.SelectedIndex].Codigo.ToString();
                btnExcluir.Visible = true;
            }
        }
        #endregion

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarItem();
        }


        #region Pesquisa

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            tmPesq.Start();
            pcbStatus.Visible = true;
        }

        private void tmPesq_Tick(object sender, EventArgs e)
        {
            tmPesq.Stop();

            string termo = rgx.Replace(txtPesq.Text, "");
            asyncConsultar.RunWorkerAsync(termo);
        }


        #endregion


        private void btnAdd_Click(object sender, EventArgs e)
        {
            UsoComum.EditMode(this);
            txtNome.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int codigo;
            try
            {
                codigo = int.Parse(txtNome.Text);
            }
            catch {
                Aviso.Alerta("Digite o código da urna corretamente. Somente números são permitidos!");
                return;
            }

            Urna novaurna = new Urna(codigo);
            pcbStatus.Visible = true;
            asyncSalvar.RunWorkerAsync(novaurna);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UsoComum.NormalMode(this);
            SelecionarItem();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Aviso.Pergunta("Deseja excluir a urna: " + listaUrnas[lstView.SelectedIndex].Codigo.ToString() + "?") == DialogResult.Yes)
            {
                asyncExcluir.RunWorkerAsync(listaUrnas[lstView.SelectedIndex].Codigo);
            }
        }

        #region CRUD

        //PESQUISAR

        private void asyncConsultar_DoWork(object sender, DoWorkEventArgs e)
        {
            string termo = (string)e.Argument;
            e.Result = Urna.Consultar(termo);
        }

        private void asyncConsultar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbStatus.Visible = false;
            if (e.Error == null)
            {
                listaUrnas = (List<Urna>)e.Result;
                AtualizarLista();
            }
            else {
                Aviso.Erro("Problema ao acessar o banco de dados!");
            }
        }

        //SALVAR
        private void asyncSalvar_DoWork(object sender, DoWorkEventArgs e)
        {
            Urna novaurna = (Urna)e.Argument;
            e.Result = novaurna.Salvar();
            
        }

        private void asyncSalvar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int exception = (int)e.Result;
            if (exception == 0)
            {
                Aviso.Mensagem("Urna Cadastrada com sucesso!");
                UsoComum.NormalMode(this);
                asyncConsultar.RunWorkerAsync();
            }
            else {
                if (exception == 1062)
                {
                    Aviso.Alerta("Código de Urna já cadastrado!");
                }
                else {
                    Aviso.Erro("Problema ao cadastrar urna!");
                }
            }
        }

        //EXCLUIR
        private void asyncExcluir_DoWork(object sender, DoWorkEventArgs e)
        {
            int codigo_urna = (int)e.Argument;
            Urna.Excluir(codigo_urna);
        }      

        private void asyncExcluir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Aviso.Erro("Problema ao excluir urna!");
            }
            else {
                Aviso.Mensagem("Urna excluida com sucesso!");
                asyncConsultar.RunWorkerAsync();
            }
        }
        
        #endregion

    }
}
