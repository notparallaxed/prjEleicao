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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
            pcbStatus.Visible = true;
            AsyncPesquisar.RunWorkerAsync();
            Selecionar(0);
        }

        #region Form Focus
            private void frmCargo_Activated(object sender, EventArgs e)
        {
            UsoComum.AnimacaoBotaoMenu(UsoComum.mdi.mnuCargo, Color.FromArgb(255, 200, 0));
            UsoComum.mdi.Text = "ELECTSIS - CARGOS";
        }
        #endregion
        
        #region Variáveis
        int formStatus = 0;//0 = normal | 1 = adicioanr | 2 = editar
            int waitingForSelection = -1;////pausar seleção enquanto Async roda, recebe o index q será selecionado
            List<Cargo> listaCargos;
            Regex rgx = new Regex(@"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]"); 
        #endregion

        #region Selecionar Cargo

            private void Selecionar(int index) {
                //pausar seleção enquanto Async roda
                if (AsyncPesquisar.IsBusy) {
                    waitingForSelection = index;
                    return;
                }
                //Seleciona o Index
                if (lstView.Items.Count > 0)
                {
                    lstView.SelectedIndex = index;
                    txtNome.Text = listaCargos[index].Nome;
                    txtQtDigitos.Text = listaCargos[index].QuantidadeDigitos.ToString();
                    btnEdit.Visible = true;
                    btnExcluir.Visible = true;
                }
                else {
                    txtNome.Text = "Sem Cargos";
                    txtQtDigitos.Text = "- -";
                    btnEdit.Visible = false;
                    btnExcluir.Visible = false;
                }
            }
            
            private void lstView_SelectedIndexChanged(object sender, EventArgs e)
            {
                Selecionar(lstView.SelectedIndex);
            }
    
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtQtDigitos.Text = "";
            UsoComum.EditMode(this);
            formStatus = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UsoComum.EditMode(this);
            formStatus = 2;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Aviso.Pergunta("Deseja Excluir " + listaCargos[lstView.SelectedIndex].Nome + "?") == DialogResult.Yes)
            {
                pcbStatus.Visible = true;
                AsyncExcluir.RunWorkerAsync(listaCargos[lstView.SelectedIndex].Codigo);
            }
        }

        #region AsyncInterOP
        
        //PESQUISAR
        private void AsyncPesquisar_DoWork(object sender, DoWorkEventArgs e)
        {
            string termo = (String)e.Argument;

            listaCargos = Cargo.PesquisarCargos(termo);
        }

        private void AsyncPesquisar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbStatus.Visible = false;

            if (e.Error == null)
            {
                lstView.Items.Clear();
                foreach (Cargo cargo in listaCargos)
                {
                    lstView.Items.Add(cargo.Nome);
                }
                //caso houver seleção pendente
                if (waitingForSelection > -1)
                {
                     Selecionar(waitingForSelection);
                     waitingForSelection = -1;
                }
                
            }
            else {
                Aviso.Erro("Problema ao listar Cargos!");
            }
        }

        //INSERIR
        private void AsyncInserir_DoWork(object sender, DoWorkEventArgs e)
        {
            Cargo novocargo = (Cargo)e.Argument;
            novocargo.Salvar();
        }

        private void AsyncInserir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                AsyncPesquisar.RunWorkerAsync();
                Selecionar(0);
                Aviso.Mensagem("Cargo inserido com sucesso!");
            }
            else
            {
                Aviso.Erro("Problema ao inserir cargo!");
                pcbStatus.Visible = false;
            }
            
        }
        #endregion

        //EXCLUIR
        private void AsyncExcluir_DoWork(object sender, DoWorkEventArgs e)
        {
            Cargo.Excluir((int)e.Argument);
        }

        private void AsyncExcluir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                AsyncPesquisar.RunWorkerAsync();
                Selecionar(0);
                Aviso.Mensagem("Excluido com sucesso!");
            }
            else
            {
                Aviso.Erro("Problema ao excluir! \r" + e.Error.Message);
                pcbStatus.Visible = false;
            }

        }

        //EDITAR
        private void AsyncEditar_DoWork(object sender, DoWorkEventArgs e)
        {
            Cargo editarcargo = (Cargo)e.Argument;
            editarcargo.Editar();
        }

        private void AsyncEditar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                AsyncPesquisar.RunWorkerAsync();
                Selecionar(0);
                Aviso.Mensagem("Cargo editado com sucesso!");
            }
            else
            {
                Aviso.Erro("Problema ao editar candidato! \r" + e.Error.Message);
                pcbStatus.Visible = false;
            }
        }


        #region Salvar/Cancelar

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UsoComum.NormalMode(this);
            formStatus = 0;
            Selecionar(lstView.SelectedIndex);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtQtDigitos.Text == "") {
                Aviso.Alerta("Preencha todos os campos!");
                return;
            }
             
            string nome = rgx.Replace(txtNome.Text, "");
            int qtdigitos = 0;

            try{
                
                 qtdigitos = int.Parse(txtQtDigitos.Text);
            }
            catch{
                Aviso.Alerta("Coloque somente números no campo Quantidade de Digítos!");
                return;
            }

            if (formStatus == 1)//adição
            {
                pcbStatus.Visible = true;
                Cargo novocargo = new Cargo(0, nome, qtdigitos);
                AsyncInserir.RunWorkerAsync(novocargo);
                UsoComum.NormalMode(this);
                formStatus = 0;
            }
            else {
                pcbStatus.Visible = true;
                Cargo editarcargo = new Cargo(listaCargos[lstView.SelectedIndex].Codigo, nome, qtdigitos);
                AsyncEditar.RunWorkerAsync(editarcargo);
                UsoComum.NormalMode(this);
                formStatus = 0;
            }



        }

        #endregion

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            pcbStatus.Visible = true;
            tmPesq.Dispose();
            tmPesq.Start();
        }

        private void tmPesq_Tick(object sender, EventArgs e)
        {
            tmPesq.Stop();
            string termo = rgx.Replace(txtPesq.Text, "");
            AsyncPesquisar.RunWorkerAsync(termo);
            Selecionar(0);
        }









    }
}
