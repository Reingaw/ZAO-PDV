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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        string nome, nivel, senha;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text.Trim();
            nivel = cboNivel.SelectedItem.ToString();
            senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo nome não pode ser vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(nivel))
            {
                MessageBox.Show("Selecione o nivel do usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Digite uma senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cadastrar(nome, nivel, senha);
            }

        }

        private void cadastrar(string nome, string nivel, string senha)
        {
            try
            {
                User novoUsuario = new User();
                novoUsuario.salvar(nome, nivel, senha);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
