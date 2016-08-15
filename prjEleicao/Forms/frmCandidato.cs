using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace prjEleicao
{
    public partial class frmCandidato : Form
    {
        public frmCandidato()
        {
            InitializeComponent();
            pcbStatus.Visible = true;
            AsyncPesquisar.RunWorkerAsync();
            SelecionarCandidato();
        }


        #region FormFocus
        private void frmCandidato_Activated(object sender, EventArgs e)
        {
            UsoComum.AnimacaoBotaoMenu(UsoComum.mdi.btnCandidatos, Color.FromArgb(63, 81, 181));
            UsoComum.mdi.Text = "ELECTSIS - CANDIDATOS";
        }
            
        #endregion

        #region Variaveis
        List<Candidato> listaCandidatos;
            List<Partido> listaPartidos;
            int formStatus = 0;//0 - normal | 1 - Adding | 2 - Editing
            Regex rgx = new Regex(@"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]");
        #endregion

        //Pesquisar e Selecionar
        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            pcbStatus.Visible = true;
            tmPesq.Start();

        }

        private void tmPesq_Tick(object sender, EventArgs e)
        {

            tmPesq.Stop();
            string termo = rgx.Replace(txtPesq.Text, "");

            AsyncPesquisar.RunWorkerAsync(termo);

        }
        //SELECIONAR

        #region Método Selecionar
        private void SelecionarCandidato()
        {
            if (lstView.SelectedIndex != -1)
            {
                //carregar foto
                if (File.Exists(@"img/" + listaCandidatos[lstView.SelectedIndex].Codigo + ".jpg"))
                {
                    pcbFotoCandidato.ImageLocation = @"img/" + listaCandidatos[lstView.SelectedIndex].Codigo + ".jpg";
                }
                else
                {
                    pcbFotoCandidato.Image = Properties.Resources.noimage;
                }
                txtNomeCandidato.Text = listaCandidatos[lstView.SelectedIndex].Nome;
                foreach (Partido partido in listaPartidos)
                {
                    if (partido.Sigla == listaCandidatos[lstView.SelectedIndex].Sigla)
                    {
                        lblPartido.Text = partido.Nome;
                        break;
                    }
                }
                btnEditCand.Visible = true;
                btnExcluirCand.Visible = true;
                btnVerPartido.Visible = true;
            }
            else
            {
                pcbFotoCandidato.Image = Properties.Resources.noimage;
                txtNomeCandidato.Text = "Sem Candidato";
                lblPartido.Text = "- -";
                btnEditCand.Visible = false;
                btnExcluirCand.Visible = false;
                btnVerPartido.Visible = false;
            }
        }
        #endregion

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarCandidato();
        }

        //Adicionar Editar Excluir
        private void btnAddCandidato_Click(object sender, EventArgs e)
        {
            UsoComum.EditMode(this);
            txtNomeCandidato.Text = "";
            cbPartido.Text = "Selecione um Partido";
            formStatus = 1;
        }

        private void btnEditCand_Click(object sender, EventArgs e)
        {
            UsoComum.EditMode(this);
            cbPartido.SelectedItem = listaCandidatos[lstView.SelectedIndex].Sigla;
            formStatus = 2;
        }

        private void btnExcluirCand_Click(object sender, EventArgs e)
        {
            if (Aviso.Pergunta("Deseja apagar o candidato " + listaCandidatos[lstView.SelectedIndex].Nome + " ?") == DialogResult.Yes)
            {
                pcbStatus.Visible = true;
                AsyncExcluir.RunWorkerAsync(listaCandidatos[lstView.SelectedIndex].Codigo.ToString());
            }

        }       

        //Selecionar Partidos
        private void cbPartido_DropDown(object sender, EventArgs e)
        {
            AsyncPesquisar.RunWorkerAsync();

            cbPartido.Items.Clear();
            foreach (Partido partido in listaPartidos)
            {
                cbPartido.Items.Add(partido.Sigla);
            }
        }

        //Ver Partido
        private void btnVerPartido_Click(object sender, EventArgs e)
        {

            //ACHAR MDI
            frmPrincipal mdi = null;

            foreach (var form in Application.OpenForms)
            {
                if (form is frmPrincipal)
                {
                    mdi = (frmPrincipal)form;
                    break;
                }
            }

            //Achar form partido
            foreach (var form in mdi.MdiChildren)
            {
                if (form.GetType() == typeof(frmPartido))
                {
                    foreach (Control panel in form.Controls)
                    {
                        if (panel is Panel)
                        {
                            foreach (Control pesq in panel.Controls)
                            {
                                if (pesq is TextBox)
                                {
                                    pesq.Text = listaCandidatos[lstView.SelectedIndex].Sigla;
                                }
                            }
                        }
                    }
                    form.Focus();
                    return;
                }
            }

            frmPartido partidos = new frmPartido(listaCandidatos[lstView.SelectedIndex].Sigla);

            partidos.MdiParent = mdi;
            partidos.Width = mdi.Width - 200;//form Pai menos painel lateral esquerdo
            partidos.Anchor = AnchorStyles.Right;
            partidos.Height = mdi.Height - 30;//form Pai menos barra superior
            partidos.Location = new Point(200, 30);//abre o form no local correto
            partidos.Show();

        }
        

        #region AsyncInterOp

        //PESQUISAR - LISTAR
        private void AsyncPesquisar_DoWork(object sender, DoWorkEventArgs e)
        {
            string termo = (String)e.Argument;

            try
            {
                if (formStatus == 0)
                {
                    listaCandidatos = Candidato.PesquisarCandidatos(termo);
                }
                listaPartidos = Partido.PesquisarPartidos("");
            }
            catch {
                e.Cancel = true;
            }
        }

        private void AsyncPesquisar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (formStatus == 0)
                {
                    lstView.Items.Clear();

                    foreach (Candidato candidato in listaCandidatos)
                    {
                        lstView.Items.Add(candidato.Nome);
                    }


                    if (lstView.Items.Count > 0)
                    {
                        lstView.SelectedIndex = 0;
                    }
                    else
                    {
                        SelecionarCandidato();
                    }
                }
                pcbStatus.Visible = false;
            }
            else {
                pcbStatus.Visible = false;
                Aviso.Erro("Problema ao listar candidatos!");
            }
        }

        //INSERIR
        private void AsyncInserir_DoWork(object sender, DoWorkEventArgs e)
        {
            Candidato candidato = (Candidato)e.Argument;

            try
            {
                //salvar foto
                if (pcbFotoCandidato.ImageLocation != null)
                {
                    if (!Directory.Exists(@"img"))
                    {
                        Directory.CreateDirectory(@"img");
                    }
                    File.Copy(pcbFotoCandidato.ImageLocation, @"img/" + candidato.Codigo + ".jpg", true);
                }
                //salvar no banco
                candidato.Salvar();
            }
            catch {
                e.Cancel = true;
            }
        }

        private void AsyncInserir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AsyncPesquisar.RunWorkerAsync();

            if (!e.Cancelled)
            {
               Aviso.Mensagem("Novo candidato adicionado!");
            }
            else
            {
                Aviso.Erro("Problema ao adicionar novo candidato");
            }
        }

        //EXCLUIR

        private void AsyncExcluir_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Candidato.Excluir((String)e.Argument);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void AsyncExcluir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AsyncPesquisar.RunWorkerAsync();

            if (!e.Cancelled)
            {
                Aviso.Mensagem("Candidato apagado com sucesso!");
            }
            else
            {
                pcbStatus.Visible = false;
                Aviso.Erro("Problema ao apagar candidato!");
            }
        }

        //EDITAR
        private void AsyncEditar_DoWork(object sender, DoWorkEventArgs e)
        {
            Candidato candidato = (Candidato)e.Argument;

            try
            {
                //salvar foto
                if (pcbFotoCandidato.ImageLocation != null)
                {
                    if (!Directory.Exists(@"img"))
                    {
                        Directory.CreateDirectory(@"img");
                    }
                    string location = pcbFotoCandidato.ImageLocation;
                    pcbFotoCandidato.Image = Properties.Resources.noimage;
                    File.Copy(location, @"img/" + candidato.Codigo + ".jpg", true);
                    pcbFotoCandidato.ImageLocation = location;
                }
                candidato.Editar();
            }
            catch {
                e.Cancel = true;
            }
        }

        private void AsyncEditar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AsyncPesquisar.RunWorkerAsync();
            if (!e.Cancelled)
            {
                Aviso.Mensagem("Candidato Editado com sucesso!");
            }
            else
            {
                Aviso.Erro("Problema ao editar candidato!");
            }
        }


        #endregion


        #region Save/Cancel

        private void btnSaveCand_Click(object sender, EventArgs e)
        {   
            //VALIDAÇÃO
            if (txtNomeCandidato.Text == "")
            {
                Aviso.Alerta("Preencha o Nome do candidato!");
                return;
            }

            if (cbPartido.SelectedIndex == -1)
            {
                Aviso.Alerta("Selecione o Partido do Candidato!");
                return;
            }

            //INSERÇÃO
            string nomeCandidato = rgx.Replace(txtNomeCandidato.Text, "");
            string siglaCandidato = listaPartidos[cbPartido.SelectedIndex].Sigla;
            int codigoCandidato = listaCandidatos.Count > 0 ? listaCandidatos.Max(obj => obj.Codigo) + 1 : 1;

            Candidato candidato = new Candidato(codigoCandidato, nomeCandidato, siglaCandidato);

            pcbStatus.Visible = true;
            //adição
            if (formStatus == 1)
            {
                AsyncInserir.RunWorkerAsync(candidato);
            }
            else//edição
            {
                candidato.Codigo = listaCandidatos[lstView.SelectedIndex].Codigo;
                AsyncEditar.RunWorkerAsync(candidato);
            }
            
            UsoComum.NormalMode(this);
            formStatus = 0;
        }

        private void btnCancelCand_Click(object sender, EventArgs e)
        {
            UsoComum.NormalMode(this);
            lstView_SelectedIndexChanged(sender, e);
            formStatus = 0;
        }

        #endregion

        private void btnAlterarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDiag = new OpenFileDialog();

            if (fileDiag.ShowDialog() == DialogResult.OK) {
                pcbFotoCandidato.ImageLocation = fileDiag.FileName;
            }

        }



    }
}
