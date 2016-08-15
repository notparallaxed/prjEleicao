using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjEleicao
{
    

    public static class Aviso
    {
        public static DialogResult Mensagem(string Message){
            frmMessageBox aviso = new frmMessageBox(Message, 0);
            aviso.ShowDialog();
            return aviso.DialogResult;
        }

        public static DialogResult Erro(string Message) {
            frmMessageBox aviso = new frmMessageBox(Message, 1);
            aviso.ShowDialog();
            return aviso.DialogResult;
        }
        public static DialogResult Alerta(string Message)
        {
            frmMessageBox aviso = new frmMessageBox(Message, 2);
            aviso.ShowDialog();
            return aviso.DialogResult;
        }
        public static DialogResult Pergunta(string Message)
        {
            frmMessageBox aviso = new frmMessageBox(Message, 3);
            aviso.ShowDialog();
            return aviso.DialogResult;
        }
    }
}
