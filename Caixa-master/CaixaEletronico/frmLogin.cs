using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acssConta = maskedTextBox1.Text;

            if (acssConta == "12345")
            {
                MessageBox.Show("Login efetuado");
                this.Hide();
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();


            }
            else
            {
                MessageBox.Show("Conta não encontrada");
            }
        }

        private void acssConta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

