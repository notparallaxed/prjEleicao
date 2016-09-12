using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace prjEleicao
{
    public partial class frmEleitor : Form
    {
        public frmEleitor()
        {
            InitializeComponent();
            pcbStatus.Visible = true;
            asyncConsultar.RunWorkerAsync();
        }

        #region Form Focus
        private void frmEleitor_Activated(object sender, EventArgs e)
        {
            UsoComum.AnimacaoBotaoMenu(UsoComum.mdi.mnuEleitor, Color.FromArgb(192, 202, 51));
            UsoComum.mdi.Text = "ELECTSIS - " + this.Text; 
        }
        #endregion

        #region Selecionar item
        private void SelecionarItem(int index) {
            try
            {
                lstView.SelectedIndex = index;

                txtNome.Text = listaEleitores[index].Nome;
                txtCPF.Text = listaEleitores[index].CPF;
                btnEdit.Visible = true;
                btnExcluir.Visible = true;
            }
            catch {
                txtNome.Text = "Sem Eleitores";
                txtCPF.Text = "--";
                btnEdit.Visible = false;
                btnExcluir.Visible = false;
            }
        }
        #endregion

        #region Variáveis
            List<Eleitor> listaEleitores;
            int formStatus = 0; // 0 - normal | 1 - adding | 2 - editing
            Regex rgx = new Regex(@"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]");
        #endregion

        #region AsyncInterOP 

        //CONSULTAR
        private void asyncConsultar_DoWork(object sender, DoWorkEventArgs e)
        {
            string termo = (string)e.Argument;
            listaEleitores = Eleitor.Consultar(termo);
        }
        private void asyncConsultar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                lstView.Items.Clear();
                foreach (Eleitor eleitor in listaEleitores)
                {
                    lstView.Items.Add(eleitor.Nome);
                }
                SelecionarItem(0);
                pcbStatus.Visible = false;
            }
            else {
                pcbStatus.Visible = false;
                Aviso.Erro("Problema ao consultar eleitores!");
            }
        }
        
        //INSERIR
        private void asyncInserir_DoWork(object sender, DoWorkEventArgs e)
        {
            Eleitor novoeleitor = (Eleitor)e.Argument;
            novoeleitor.Salvar();
        }
        private void asyncInserir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                asyncConsultar.RunWorkerAsync();
                Aviso.Mensagem("Eleitor salvo com sucesso!");
            }
            else
            {
                pcbStatus.Visible = false;
                SelecionarItem(0);
                Aviso.Erro("Problema ao salvar eleitor");
            }
        }

        //EDITAR
        private void asyncEditar_DoWork(object sender, DoWorkEventArgs e)
        {
            Eleitor editareleitor = (Eleitor)e.Argument;

            editareleitor.Editar();
        }
        private void asyncEditar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                asyncConsultar.RunWorkerAsync();
                Aviso.Mensagem("Eleitor editado com sucesso!");
            }
            else
            {
                pcbStatus.Visible = false;
                SelecionarItem(0);
                Aviso.Erro("Problema ao editar eleitor.");
            }
        }

        //EXCLUIR
        private void asyncExcluir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                asyncConsultar.RunWorkerAsync();
                Aviso.Mensagem("Eleitor excluído com sucesso.");
            }
            else
            {
                pcbStatus.Visible = false;
                Aviso.Erro("Problema ao excluir");
            }
        }
        private void asyncExcluir_DoWork(object sender, DoWorkEventArgs e)
        {
            int codigo = (int)e.Argument;

            Eleitor.Excluir(codigo);
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formStatus = 1;
            UsoComum.EditMode(this);
            txtNome.Text = "";
            txtCPF.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formStatus = 0;
            UsoComum.NormalMode(this);
            SelecionarItem(lstView.SelectedIndex);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nome = rgx.Replace(txtNome.Text, "");
            string cpf = txtCPF.Text.Replace(".", "").Replace(" ", "");

            if (nome == "") {
                Aviso.Alerta("Digite o nome corretamente");
                return;
            }
            if (cpf.Length < 12 || !cpf.Contains("-")) {
                Aviso.Alerta("Digite um número válido de CPF");
                return;
            }

            pcbStatus.Visible = true;
            
            if (formStatus == 1)//salvar
            {
                Eleitor novoeleitor = new Eleitor(0, nome, cpf);

                asyncInserir.RunWorkerAsync(novoeleitor);
            }
            else {//editar
 
                Eleitor editareleitor = new Eleitor(listaEleitores[lstView.SelectedIndex].Codigo, nome, cpf);

                asyncEditar.RunWorkerAsync(editareleitor);
            }

            formStatus = 0;
            UsoComum.NormalMode(this);

        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarItem(lstView.SelectedIndex);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formStatus = 2;
            UsoComum.EditMode(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Aviso.Pergunta("Deseja excluir: " + listaEleitores[lstView.SelectedIndex].Nome + "?") == DialogResult.Yes) {
                pcbStatus.Visible = true;
                asyncExcluir.RunWorkerAsync(listaEleitores[lstView.SelectedIndex].Codigo);
            }
        }

        private void tmPesq_Tick(object sender, EventArgs e)
        {
            tmPesq.Stop();
            string termo = rgx.Replace(txtPesq.Text, "");
            asyncConsultar.RunWorkerAsync(termo);
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            tmPesq.Start();
            pcbStatus.Visible = true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            /*
            Aviso.Mensagem("Para importar dados de uma planilha Excel corretamente, coloque os NOMES na coluna A e os CPFs na coluna B.");

            OpenFileDialog planilha = new OpenFileDialog();
            planilha.Filter = "Planilha Excel 2007 ou superior | *.xlsx";

            if (planilha.ShowDialog() == DialogResult.OK) {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + planilha.FileName + ";Extended Properties=’Excel 12.0 Xml;HDR=YES’;");

                try
                {
                    con.Open();    
                }
                catch (Exception ex) {
                    Aviso.Erro(ex.Message);
                    return;
                }

                OleDbCommand consultar = new OleDbCommand("SELECT * from [Sheet1$];", con);
                OleDbDataReader dados = consultar.ExecuteReader();

                while (dados.Read()) {
                    MessageBox.Show(dados[0].ToString());
                }

            }
            */
        }
    }
}
