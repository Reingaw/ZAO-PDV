namespace ZAO_PDV
{
    partial class frmAtualizaProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.product_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_sell_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAOPDVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ZAO_PDVDataSet = new ZAO_PDV._ZAO_PDVDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodebar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAOPDVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ZAO_PDVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(616, 41);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(697, 41);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.AllowUserToAddRows = false;
            this.dtgProdutos.AllowUserToDeleteRows = false;
            this.dtgProdutos.AllowUserToResizeColumns = false;
            this.dtgProdutos.AllowUserToResizeRows = false;
            this.dtgProdutos.AutoGenerateColumns = false;
            this.dtgProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_description,
            this.product_category,
            this.product_sell_price,
            this.product_stock});
            this.dtgProdutos.DataSource = this.zAOPDVDataSetBindingSource;
            this.dtgProdutos.Location = new System.Drawing.Point(12, 91);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.RowHeadersVisible = false;
            this.dtgProdutos.Size = new System.Drawing.Size(760, 458);
            this.dtgProdutos.TabIndex = 3;
            // 
            // product_description
            // 
            this.product_description.DataPropertyName = "product_description";
            this.product_description.HeaderText = "Descrição do Produto";
            this.product_description.Name = "product_description";
            this.product_description.Width = 305;
            // 
            // product_category
            // 
            this.product_category.DataPropertyName = "product_category";
            this.product_category.HeaderText = "Categoria do Produto";
            this.product_category.Name = "product_category";
            this.product_category.Width = 202;
            // 
            // product_sell_price
            // 
            this.product_sell_price.DataPropertyName = "product_sell_price";
            this.product_sell_price.HeaderText = "Preço de Venda";
            this.product_sell_price.Name = "product_sell_price";
            this.product_sell_price.Width = 150;
            // 
            // product_stock
            // 
            this.product_stock.DataPropertyName = "product_stock";
            this.product_stock.HeaderText = "Estoque";
            this.product_stock.Name = "product_stock";
            // 
            // zAOPDVDataSetBindingSource
            // 
            this.zAOPDVDataSetBindingSource.DataSource = this._ZAO_PDVDataSet;
            this.zAOPDVDataSetBindingSource.Position = 0;
            // 
            // _ZAO_PDVDataSet
            // 
            this._ZAO_PDVDataSet.DataSetName = "_ZAO_PDVDataSet";
            this._ZAO_PDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cód. Barra / Desc. Produto";
            // 
            // txtCodebar
            // 
            this.txtCodebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodebar.Location = new System.Drawing.Point(12, 41);
            this.txtCodebar.Name = "txtCodebar";
            this.txtCodebar.Size = new System.Drawing.Size(427, 26);
            this.txtCodebar.TabIndex = 0;
            // 
            // frmAtualizaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.txtCodebar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAtualizaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZAO-PDV | Atualizar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAOPDVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ZAO_PDVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodebar;
        private System.Windows.Forms.BindingSource zAOPDVDataSetBindingSource;
        private _ZAO_PDVDataSet _ZAO_PDVDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_sell_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_stock;
    }
}