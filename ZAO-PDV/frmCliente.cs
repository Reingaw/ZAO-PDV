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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        Customer novoCliente = new Customer();
        Adress novoEndereco = new Adress();
        string telefone, nome, dataCadastro;
        string rua, numero, bairro, complemento, referencia, observacao;
        int id;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            telefone = txtTelefoneCliente.Text.Trim();
            nome = txtNomeCliente.Text.Trim();
            dataCadastro = DateTime.Now.ToShortDateString();

            rua = txtEnderecoCliente.Text.Trim();
            numero = txtNumeroCliente.Text.Trim();
            bairro = txtBairro.Text.Trim();
            complemento = txtComplementoCliente.Text.Trim();
            referencia = txtReferenciaCliente.Text.Trim();
            observacao = txtObservacaCliente.Text.Trim();

            if (string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("O campo Telefone não pode ser vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo Nome não pode ser vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(rua))
            {
                MessageBox.Show("O campo Endereço não pode ser vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    novoCliente.salvar(telefone, nome, dataCadastro);

                    id = retornaID(telefone);

                    novoEndereco.salvar(rua, numero, bairro, complemento, referencia, observacao, id);

                    MessageBox.Show("Cliente salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {                    
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int retornaID(string telefone)
        {
            DataTable dt = new DataTable();
            int customer_id;

            dt = novoCliente.retornaId(telefone);

            customer_id = int.Parse(dt.Rows[0]["customer_id"].ToString());

            return customer_id;
        }       
    }
}
