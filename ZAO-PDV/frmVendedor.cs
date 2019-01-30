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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        string nome, funcao;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text.Trim();
            funcao = cboFuncao.SelectedItem.ToString();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Preencha o nome do vendendor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(funcao))
            {
                MessageBox.Show("Preencha o nome do vendendor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cadastrar(nome, funcao);
                listar();
            }
        }

        private void cadastrar(string nome, string funcao)
        {
            try 
	        {
                Salesperson novoVendedor = new Salesperson();
                novoVendedor.salvar(nome, funcao);
                MessageBox.Show("Vendedor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
	        }
	        catch (Exception ex)
	        {		
		        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }            
        }

        private void listar()
        {
            Salesperson novoVendedor = new Salesperson();
            DataTable dt = new DataTable();
            dt = novoVendedor.listar();

            if (dt.Rows.Count == 0)
            {
                txtNome.Focus();
            }
            else
            {
                dtgVendedor.DataSource = dt;
            }            
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            try
            {
                cboFuncao.SelectedIndex = 0;
                listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
