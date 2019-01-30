using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAO_PDV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();                        
        }
                
        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto novoProduto = new frmProduto();
            novoProduto.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente novoCliente = new frmCliente();
            novoCliente.ShowDialog();
        }

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria novaCategoria = new frmCategoria();
            novaCategoria.ShowDialog();
        }

        private void cadastrarFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFabricante novoFabricante = new frmFabricante();
            novoFabricante.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmDataHora.Start();

            MessageBox.Show("Bem-Vindo ao Sistema ZAO-PDV");
        }

        private void tmDataHora_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            //lblHora.Text = this.Data + " - " + this.Hora + ":" + this.Segundos;
            lblHora.Text = time.ToString();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario novoUsuario = new frmUsuario();
            novoUsuario.ShowDialog();
        }

        private void atualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtualizaCliente novoClienteAtualizado = new frmAtualizaCliente();
            novoClienteAtualizado.ShowDialog();
        }

        private void atualizarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtualizaProduto novoProdutoAtualizado = new frmAtualizaProduto();
            novoProdutoAtualizado.ShowDialog();
        }

        private void cadastrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor novoVendedor = new frmVendedor();
            novoVendedor.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmVendas novaVenda = new frmVendas();
            novaVenda.ShowDialog();
        }        
    }
}
