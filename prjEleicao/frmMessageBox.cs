using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjEleicao
{
    public partial class frmMessageBox : frmPattern
    {
        public frmMessageBox(string Message, int type)
        {
            InitializeComponent();

            lblMensagem.Text = Message;

            switch (type)
            {
                case 0:
                    pcbIcone.Image = null;
                    pnlTopBar.BackColor = Color.FromArgb(3, 169, 244);
                    this.BackColor = Color.FromArgb(3, 169, 244);
                    btnNao.Visible = false;
                    btnSim.Visible = false;
                    btnOk.Visible = true;
                    break;
                case 1:
                    pcbIcone.Image = Properties.Resources.erro;
                    pnlTopBar.BackColor = Color.FromArgb(255, 112, 67);
                    this.BackColor = Color.FromArgb(255, 112, 67);
                    btnNao.Visible = false;
                    btnSim.Visible = false;
                    btnOk.Visible = true;
                    break;

                case 2:
                    pcbIcone.Image = Properties.Resources.alert;
                    pnlTopBar.BackColor = Color.FromArgb(255, 171, 0);
                    this.BackColor = Color.FromArgb(255, 171, 0);
                    btnNao.Visible = false;
                    btnSim.Visible = false;
                    btnOk.Visible = true;
                    break;
                case 3:
                    pcbIcone.Image = Properties.Resources.question;
                    pnlTopBar.BackColor = Color.FromArgb(3, 169, 244);
                    this.BackColor = Color.FromArgb(3, 169, 244);
                    btnNao.Visible = true;
                    btnSim.Visible = true;
                    btnOk.Visible = false;
                    break;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
