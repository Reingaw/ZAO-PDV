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
    public partial class frmFabricante : Form
    {
        public frmFabricante()
        {
            InitializeComponent();
        }

        Manufacturer novoFabricante = new Manufacturer();
        string fabricante;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fabricante = txtFabricante.Text.Trim();
            if (string.IsNullOrEmpty(fabricante))
            {
                MessageBox.Show("O nome do fabricante não pode ser vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    novoFabricante.salvar(fabricante);
                    MessageBox.Show("Fabricante salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {                    
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
