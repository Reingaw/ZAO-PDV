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
    public partial class frmAtualizaProduto : Form
    {
        public frmAtualizaProduto()
        {
            InitializeComponent();
        }

        string codeBar;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            codeBar = txtCodebar.Text.Trim();

            if (string.IsNullOrEmpty(codeBar))
            {
                txtCodebar.Focus();
            }
            else
            {
                pesquisar(codeBar);
            }
        }

        private void pesquisar(string codBar)
        {
            try
            {
                Product novoProduto = new Product();
                dtgProdutos.DataSource = novoProduto.listar(codBar);
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
