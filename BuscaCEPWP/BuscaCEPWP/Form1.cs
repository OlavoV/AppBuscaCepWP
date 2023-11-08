using BuscaCEPWF;
using Refit;

namespace BuscaCEPWP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e, KeyPressEventArgs ee)
        {
            if (ee.KeyChar == 13)
            {
                BuscarCEP(maskCEP.Text);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskCep_Leave(object sender, EventArgs e)
        {
            BuscarCEP(maskCEP.Text);
        }
        async Task BuscarCEP(string CEP)
        {
            try
            {
                var cepbuscar = RestService.For<ICEPApiServices>("https://viacep.com.br/");
                var endereco = await cepbuscar.GetAddressAsync(CEP);
                txtEstado.Text = endereco.Uf;
                txtCidade.Text = endereco.Localidade;
                txtBairro.Text = endereco.Bairro;
                txtLogradouro.Text = endereco.Logradouro;
                txtComplemento.Text = endereco.Complemento;

            }
            catch (Exception e)
            {

                MessageBox.Show("Falha! \n" + e.Message);

            }









        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string limpar = "";
            maskCEP.Text = limpar;
            txtBairro.Text = limpar;
            txtCidade.Text = limpar;
            txtComplemento.Text = limpar;
            txtComplemento2.Text = limpar;
            txtEstado.Text = limpar;
            txtLogradouro.Text = limpar;
            txtNumero.Text = limpar;
        }
    }
}