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
    public partial class frmAtualizaCliente : Form
    {
        public frmAtualizaCliente()
        {
            InitializeComponent();
        }

        
        string telefone;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pesquisar(string telefone)
        {                        
            try
            {
                Customer novoCliente = new Customer();
                dtgClientes.DataSource = novoCliente.pesquisarCliente(telefone);                
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            telefone = txtTelefone.Text.Trim();

            if (string.IsNullOrEmpty(telefone))
            {
                txtTelefone.Focus();
            }
            else
            {
                pesquisar(telefone);
            }            
        }
    }
}
