using System;
using System.Collections;
using System.Windows.Forms;

namespace Bebela.Modas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList usuario = new ArrayList();

        private void PopularDgv()
        {
            ServicoPLA servicoPLA = new ServicoPLA();
            var retorno = servicoPLA.ListarCompraPorUsuario(GetReferencialClienteSelecionado(cbxCliente.Text), cbxCliente.Text);
            dgvCompras.DataSource = retorno.Item2;

        }
        private int GetReferencialClienteSelecionado(string nome)
        {
            ServicoPLA servicoPLA = new ServicoPLA();
            var retorno = servicoPLA.ListarCliente();
            int referencialClienteSelecionado = 0;

            if (retorno.Item2.Rows.Count != 0)
            {
                int contador = 0;

                while (retorno.Item2.Rows.Count != contador)
                {
                    if (nome == retorno.Item2.Rows[contador]["Nome"].ToString())
                    {

                        string aux = retorno.Item2.Rows[contador]["Referencial"].ToString();
                        referencialClienteSelecionado = int.Parse(aux);

                        return referencialClienteSelecionado;
                    }
                    contador++;
                }

            }
            return 0;

        }
        private void ListarCliente()
        {
            ServicoPLA servicoPLA = new ServicoPLA();
            var retorno = servicoPLA.ListarCliente();

            if (retorno.Item2.Rows.Count != 0)
            {
                int aux = 0;

                while (retorno.Item2.Rows.Count != aux)
                {
                    cbxCliente.Items.Add(retorno.Item2.Rows[aux]["Nome"].ToString());
                    aux++;
                }

            }

        }
        private void ListarProduto()
        {

            ServicoPLA servicoPLA = new ServicoPLA();
            var retorno = servicoPLA.ListarProduto();

            if (retorno.Item2.Rows.Count != 0)
            {
                int aux = 0;

                while (retorno.Item2.Rows.Count != aux)
                {
                    cbxProduto.Items.Add(retorno.Item2.Rows[aux]["Descricao_Produto"].ToString());
                    aux++;
                }

            }

        }

        private void OcultarBotoesFicha()
        {
            cbxProduto.Enabled = false;
            dudQuantidade.Enabled = false;
            txtValor.Enabled = false;
            cbxSituação.Enabled = false;
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void ExibirBotoesFicha()
        {
            cbxProduto.Enabled = true;
            dudQuantidade.Enabled = true;
            txtValor.Enabled = true;
            cbxSituação.Enabled = true;
            btnCadastrar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void limparCamposCompra()
        {
            cbxProduto.Text = "";
            dudQuantidade.Text = "";
            txtValor.Text = "";
            cbxSituação.Text = "";
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarCliente();
            ListarProduto();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            ServicoPLA servicoPLA = new ServicoPLA();



            var retorno = servicoPLA.CadastrarCompra(GetReferencialClienteSelecionado(cbxCliente.Text), cbxProduto.Text, dudQuantidade.SelectedIndex, double.Parse(txtValor.Text), cbxSituação.Text);

            if (retorno.indicadorErro == 0)
                MessageBox.Show("Cadastrar compra", retorno.DescricaoMensagem);
            else
                MessageBox.Show("Cadastrar Compra", "Erro ao cadastrar a compra");

            limparCamposCompra();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopularDgv();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
