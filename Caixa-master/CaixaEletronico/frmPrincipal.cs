using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            if (Btn_voltar_Click != null)
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }

        private void Btn_depositar_Click(object sender, EventArgs e)
        {
            if (Btn_depositar_Click != null)
            {
                frmDeposito frmDeposito = new frmDeposito();
                this.Hide();
                frmDeposito.Show();
            }
        }

        private void Btn_sacar_Click(object sender, EventArgs e)
        {
            if (Btn_sacar_Click != null)
            {
                this.Hide();
                frmSaque frmSaque = new frmSaque();
                frmSaque.Show();
            }
        }

        private void Btn_transferir_Click(object sender, EventArgs e)
        {
            if (Btn_transferir_Click != null)
            {
                this.Hide();
                frmTransferencia frmTransferencia = new frmTransferencia();
                frmTransferencia.Show();
            }
        }

        private void Btn_extrato_Click(object sender, EventArgs e)
        {
            if (Btn_extrato_Click != null)
            {
                this.Hide();
                frmConsulta frmConsulta = new frmConsulta();
                frmConsulta.Show();
            }
        }

        private void saldoAtual_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
