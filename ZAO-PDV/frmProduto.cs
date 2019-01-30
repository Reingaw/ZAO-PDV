using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAO_PDV
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        Product novoProduto = new Product();
        Category novaCategoria = new Category();
        Manufacturer novoFabricante = new Manufacturer();
        string description, category, manufacturer, codeBar;
        float costPrice, icms, cofins, mLucro, sellPrice;
        int stock;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            description = txtProductDescription.Text.Trim();
            category = cboCategoria.SelectedItem.ToString();
            manufacturer = cboFabricante.SelectedItem.ToString();
            costPrice = float.Parse(txtCostPrice.Text.Trim());
            sellPrice = float.Parse(txtSellPrice.Text.Trim());
            stock = int.Parse(txtEstoque.Text.Trim());
            codeBar = txtCodeBar.Text.Trim();

            if (description == null || category == null || manufacturer == null || costPrice <= 0 || 
                sellPrice <= 0 || stock <= 0 || codeBar == null)
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    novoProduto.salvar(description, category, manufacturer, costPrice, sellPrice, stock, codeBar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + description + category + manufacturer + costPrice + sellPrice + stock + codeBar, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void sumPrices (float costPrice, float icms, float cofins, float mLucro, float sellPrice)
        {
            float markUpDivisor = (100 - (icms + cofins + mLucro + 6)) / 100;
            float markUpMultiplicador = 1 / markUpDivisor;
            
            sellPrice = costPrice * markUpMultiplicador;
            Convert.ToDecimal(sellPrice, new CultureInfo("pt-br"));

            if (sellPrice == 0)
            {
                txtSellPrice.Text = "0,00";
            }
            else
            {
                txtSellPrice.Text = sellPrice.ToString("N2");
            }            
        }

        private void txtSellPrice_Enter(object sender, EventArgs e)
        {
            costPrice = float.Parse(txtCostPrice.Text);
            icms = float.Parse(txtIcms.Text);
            cofins = float.Parse(txtCofins.Text);
            mLucro = float.Parse(txtMargem.Text);            

            sumPrices(costPrice, icms, cofins, mLucro, sellPrice);
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            ArrayList categorias = new ArrayList();
            ArrayList fabricantes = new ArrayList();

            txtEstoque.Text = "0";
            txtCostPrice.Text = "0,00";
            txtIcms.Text = "18";
            txtCofins.Text = "1";
            txtMargem.Text = "35";

            try
            {
                categorias = listCategory();
                fabricantes = listManufacturer();

                cboCategoria.DataSource = categorias;
                cboFabricante.DataSource = fabricantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private ArrayList listCategory()
        {
            DataTable dt = new DataTable();
            ArrayList categorias = new ArrayList();
            dt = novaCategoria.listar();

            foreach (DataRow dataRow in dt.Rows)
            {
                categorias.Add(string.Join(";", dataRow.ItemArray.Select(item => item.ToString())));
            }

            return categorias;                     
        }

        private ArrayList listManufacturer()
        {
            DataTable dt = new DataTable();
            ArrayList fabricantes = new ArrayList();
            dt = novoFabricante.listar();

            foreach (DataRow dataRow in dt.Rows)
            {
                fabricantes.Add(string.Join(";", dataRow.ItemArray.Select(item => item.ToString())));
            }

            return fabricantes;
        }
    }
}
