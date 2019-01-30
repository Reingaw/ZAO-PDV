using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAO_PDV
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();            
        }

        Sales novaVenda = new Sales();
        string vendedor;
        
        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                vendedor = txtVendedor.Text.Trim();

                if (string.IsNullOrEmpty(vendedor))
                {                    
                    txtVendedor.Focus();
                }
                else
                {
                    try
                    {
                        listVendedor(vendedor);                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                listCliente(txtCliente.Text);
            }

            if (e.KeyValue == 119)
            {
                txtCliente.Enabled = false;
                gpbClientes.Visible = false;
                txtProduto.Focus();
                txtCliente.Text = string.Empty;
            }
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 119)
            {
                txtCliente.Enabled = true;
                gpbClientes.Visible = true;
                txtCliente.Focus();
            }
        }

        private void listVendedor(string vendedor)
        {
            DataTable dt = new DataTable();
            dt = novaVenda.salesperson(vendedor);
            if (dt.Rows.Count > 0)
            {
                txtVendedor.Text = dt.Rows[0]["salesperson_name"].ToString();
                txtVendedor.Enabled = false;
                txtProduto.Enabled = true;
                txtProduto.Focus();
            }
            else
            {
                MessageBox.Show("Vendedor não Cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVendedor.Text = string.Empty;
            }
        }

        private void listCliente(string telefone)
        {
            frmPesquisarCliente novaPesquisa = new frmPesquisarCliente(telefone);
            novaPesquisa.ShowDialog();

            dadosCliente(novaPesquisa.nome, novaPesquisa.endereco, novaPesquisa.numero, novaPesquisa.bairro, novaPesquisa.complemento, novaPesquisa.referencia, novaPesquisa.observacao);

            txtProduto.Focus();
        }

        public void dadosCliente(string nome, string endereço, string numero,
                                 string bairro, string complemento, string referencia, string observacao)
        {
            lblNomeCliente.Text = nome;
            lblEnderecoCliente.Text = endereço +" Nº: "+ numero;
            lblComplementoCliente.Text = complemento;
            lblReferenciaCliente.Text = referencia;

            txtCliente.Enabled = false;
            txtProduto.Focus();
        }
    }
}
