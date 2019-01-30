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
    public partial class frmPesquisarCliente : Form
    {
        public frmPesquisarCliente(string telefone)
        {
            InitializeComponent();
            txtSearch.Text = telefone;
            listCliente(txtSearch.Text);
        }

        public string nome, telefone, endereco, numero, bairro, complemento, referencia, observacao;

        private void listCliente(string telefone)
        {
            try
            {
                Sales novaVenda = new Sales();
                DataTable dt;
                dt = novaVenda.customer(telefone);
                dtgPesquisaCliente.DataSource = dt;
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                Close();
            }
        }  

        private void dtgPesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                Close();
            }

            if (e.KeyValue == 13)
            {
                nome = dtgPesquisaCliente.CurrentRow.Cells[1].Value.ToString();
                telefone = dtgPesquisaCliente.CurrentRow.Cells[2].Value.ToString();
                endereco = dtgPesquisaCliente.CurrentRow.Cells[3].Value.ToString();
                numero = dtgPesquisaCliente.CurrentRow.Cells[4].Value.ToString();
                bairro = dtgPesquisaCliente.CurrentRow.Cells[5].Value.ToString();
                complemento = dtgPesquisaCliente.CurrentRow.Cells[6].Value.ToString();
                referencia = dtgPesquisaCliente.CurrentRow.Cells[7].Value.ToString();
                observacao = dtgPesquisaCliente.CurrentRow.Cells[8].Value.ToString();
                                
                Close();
            }
        }

        private void dtgPesquisaCliente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtgPesquisaCliente.DefaultCellStyle.BackColor = Color.SkyBlue;
            dtgPesquisaCliente.DefaultCellStyle.SelectionForeColor = Color.White;
            dtgPesquisaCliente.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
        }              
    }
}
