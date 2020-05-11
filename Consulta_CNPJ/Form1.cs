using Consulta_CNPJ.API;
using Refit;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Consulta_CNPJ
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }                
        private async void RequestApi()
        {
            var cnpjEmpresa = RestService.For <ICnpjApiService>("https://www.receitaws.com.br");

            string cnpjInformado = textBoxNumeroCnpj.Text.ToString();
            cnpjInformado = cnpjInformado.Replace(".", "").Replace("-", "").Replace("/", "");

            CnpjResponse resultadoApi = await cnpjEmpresa.GetAddressAsync(cnpjInformado);

            this.textBoxNome.Text = resultadoApi.Nome;
            this.textBoxFantasia.Text = resultadoApi.Fantasia;
            this.textBoxEmail.Text = resultadoApi.Email;
            this.textBoxLogradouro.Text = resultadoApi.Logradouro;
            this.textBoxNumero.Text = resultadoApi.Numero;
            this.textBoxUF.Text = resultadoApi.UF;
            this.textBoxMunicipio.Text = resultadoApi.Municipio;
            this.textBoxTelefone.Text = resultadoApi.Telefone;
            this.textBoxPorte.Text = resultadoApi.Porte;
            this.textBoxTipo.Text = resultadoApi.Tipo;
            this.textBoxSituacao.Text = resultadoApi.Situação;
            this.textBoxDataAbertura.Text = resultadoApi.Data_Abertura;

            var valor = double.Parse(resultadoApi.Capital_Social);
            valor = valor / 100;
            this.textBoxCapitalSocial.Text = valor.ToString("C", CultureInfo.CurrentCulture);
        }                                     
        private void Button1_Click_1(object sender, EventArgs e)
        {
            //public static async Task Chamada_Api()
            
            try
            {
               RequestApi();                   
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na consulta do 'CNPJ': " + erro);
            }
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
