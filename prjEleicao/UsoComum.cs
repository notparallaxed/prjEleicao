using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace prjEleicao
{
    public static class UsoComum
    {
        public static MySqlConnection Conexao { get; set; }
        public static Usuario UsuarioAtual { get; set; }
        public static List<Modulo> Modulos { get; set; }

        public static frmPrincipal mdi { get; set; }

        #region Animation Menu

        public static void AnimacaoBotaoMenu(Button btn, Color backColor)
        {
            foreach (Control obj in mdi.pnlMenu.Controls)
            {
                if (obj is Button && obj.Tag == "btnMenu")
                {
                    obj.Width = 190;
                    obj.BackColor = Color.FromArgb(0, 188, 212);
                }
            }
            btn.Width = 200;
            btn.BackColor = backColor;//cor de fundo quando selecionado
        }
        #endregion


        //MÉTODOS PARA ALTERNAR OS MODOS DE EXIBIÇÃO DAS JANELAS
        //Os itens que possuírem a tag "editable" serão afetados
        //LEMBRE-SE de adicionar a tag para os paineis que irão funcionar durante a edição, senão os mesmos ficarão desabilitados
        //todos os itens sem a tag editable serão desabilitados para evitar erros durante o processo de edição

        #region Habilitar modo Edição
        public static void EditMode(Form janela)
        {

            foreach (Control clt in janela.Controls)
            {
                if (clt.Tag == "editable")
                {
                    if (clt is Button)
                    {
                        Button btn = (Button)clt;

                        btn.Visible = true;
                    }

                    if (clt is TextBox)
                    {
                        TextBox txt = (TextBox)clt;

                        txt.BackColor = Color.White;
                        txt.ForeColor = Color.Black;
                        txt.ReadOnly = false;
                    }

                    if (clt is Label)
                    {
                        Label lbl = (Label)clt;

                        lbl.Visible = false;
                    }

                    if (clt is ComboBox) {
                        ComboBox cb = (ComboBox)clt;

                        cb.Visible = true;
                    }

                    if (clt is CheckedListBox) {
                        clt.Visible = true;
                    }

                }
                else
                {
                    clt.Enabled = clt is Label?true:false;

                    if (clt is Button)
                    {
                        Button btn = (Button)clt;

                        btn.Visible = false;
                    }
                }

                //PARA paineis
                if (clt is Panel)
                {
                    foreach (Control cltPnl in clt.Controls)
                    {
                        if (cltPnl.Tag == "editable")
                        {
                            if (cltPnl is Button)
                            {
                                Button btn = (Button)cltPnl;

                                btn.Visible = true;
                            }

                            if (cltPnl is TextBox)
                            {
                                TextBox txt = (TextBox)cltPnl;

                                txt.BackColor = Color.White;
                                txt.ForeColor = Color.Black;
                                txt.ReadOnly = false;
                            }

                            if (clt is Label)
                            {
                                Label lbl = (Label)clt;

                                lbl.Visible = false;
                            }

                            if (clt is ComboBox)
                            {
                                ComboBox cb = (ComboBox)clt;

                                cb.Visible = true;
                            }

                            if (clt is CheckedListBox) {
                                clt.Visible = true;
                            }

                        }
                        else
                        {
                            cltPnl.Enabled = cltPnl is Label ? true : false;

                            if (cltPnl is Button)
                            {
                                Button btn = (Button)cltPnl;

                                btn.Visible = false;
                            }
                        }
                    }


                }
            }
        }

        #endregion

        #region Habilitar modo Normal

        public static void NormalMode(Form janela) {
            
            foreach (Control clt in janela.Controls)
            {
            if (clt.Tag == "editable")
                {
                    if (clt is Button)
                    {
                        Button btn = (Button)clt;

                        btn.Visible = false;
                    }

                    if (clt is TextBox)
                    {
                        TextBox txt = (TextBox)clt;

                        txt.BackColor = janela.BackColor;
                        txt.ForeColor = Color.White;
                        txt.ReadOnly = true;
                    }

                    if (clt is Label)
                    {
                        Label lbl = (Label)clt;

                        lbl.Visible = true;
                    }

                    if (clt is ComboBox)
                    {
                        ComboBox cb = (ComboBox)clt;

                        cb.Visible = false;
                    }

                    if (clt is CheckedListBox) {
                        clt.Visible = false;
                    }

                }
                else
                {
                    clt.Enabled = true;

                    if (clt is Button)
                    {
                        Button btn = (Button)clt;

                        btn.Visible = true;
                    }
                }

                //PARA paineis
                if (clt is Panel)
                {
                    foreach (Control cltPnl in clt.Controls)
                    {
                        if (cltPnl.Tag == "editable")
                        {
                            if (cltPnl is Button)
                            {
                                Button btn = (Button)cltPnl;

                                btn.Visible = false;
                            }

                            if (cltPnl is TextBox)
                            {
                                TextBox txt = (TextBox)cltPnl;

                                txt.BackColor = janela.BackColor;
                                txt.ForeColor = Color.White;
                                txt.ReadOnly = true;
                            }

                            if (clt is Label)
                            {
                                Label lbl = (Label)clt;

                                lbl.Visible = true;
                            }

                            if (clt is ComboBox)
                            {
                                ComboBox cb = (ComboBox)clt;

                                cb.Visible = false;
                            }

                            if (clt is CheckedListBox) {
                                clt.Visible = false;
                            }

                        }
                        else
                        {
                            cltPnl.Enabled = true;

                            if (cltPnl is Button)
                            {
                                Button btn = (Button)cltPnl;

                                btn.Visible = true;
                            }
                        }
                    }


                }
                
            }
        }
        #endregion
    }
}
