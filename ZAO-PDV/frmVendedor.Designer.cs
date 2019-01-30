namespace ZAO_PDV
{
    partial class frmVendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cboFuncao = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtgVendedor = new System.Windows.Forms.DataGridView();
            this._ZAO_PDVDataSet = new ZAO_PDV._ZAO_PDVDataSet();
            this.zAOPDVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesperson_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesperson_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesperson_function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ZAO_PDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAOPDVDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(258, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Função";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(408, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(327, 424);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadatrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cboFuncao
            // 
            this.cboFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboFuncao.FormattingEnabled = true;
            this.cboFuncao.Items.AddRange(new object[] {
            "VENDEDOR",
            "CAIXA"});
            this.cboFuncao.Location = new System.Drawing.Point(262, 48);
            this.cboFuncao.Name = "cboFuncao";
            this.cboFuncao.Size = new System.Drawing.Size(221, 28);
            this.cboFuncao.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNome.Location = new System.Drawing.Point(12, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 26);
            this.txtNome.TabIndex = 5;
            // 
            // dtgVendedor
            // 
            this.dtgVendedor.AllowUserToAddRows = false;
            this.dtgVendedor.AllowUserToDeleteRows = false;
            this.dtgVendedor.AllowUserToResizeColumns = false;
            this.dtgVendedor.AllowUserToResizeRows = false;
            this.dtgVendedor.AutoGenerateColumns = false;
            this.dtgVendedor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesperson_id,
            this.salesperson_name,
            this.salesperson_function});
            this.dtgVendedor.DataSource = this.zAOPDVDataSetBindingSource;
            this.dtgVendedor.Location = new System.Drawing.Point(12, 105);
            this.dtgVendedor.Name = "dtgVendedor";
            this.dtgVendedor.ReadOnly = true;
            this.dtgVendedor.RowHeadersVisible = false;
            this.dtgVendedor.Size = new System.Drawing.Size(471, 303);
            this.dtgVendedor.TabIndex = 6;
            // 
            // _ZAO_PDVDataSet
            // 
            this._ZAO_PDVDataSet.DataSetName = "_ZAO_PDVDataSet";
            this._ZAO_PDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zAOPDVDataSetBindingSource
            // 
            this.zAOPDVDataSetBindingSource.DataSource = this._ZAO_PDVDataSet;
            this.zAOPDVDataSetBindingSource.Position = 0;
            // 
            // salesperson_id
            // 
            this.salesperson_id.DataPropertyName = "salesperson_id";
            this.salesperson_id.HeaderText = "Código";
            this.salesperson_id.Name = "salesperson_id";
            this.salesperson_id.ReadOnly = true;
            this.salesperson_id.Width = 52;
            // 
            // salesperson_name
            // 
            this.salesperson_name.DataPropertyName = "salesperson_name";
            this.salesperson_name.HeaderText = "Nome do Vendedor";
            this.salesperson_name.Name = "salesperson_name";
            this.salesperson_name.ReadOnly = true;
            this.salesperson_name.Width = 215;
            // 
            // salesperson_function
            // 
            this.salesperson_function.DataPropertyName = "salesperson_function";
            this.salesperson_function.HeaderText = "Função do Vendedor";
            this.salesperson_function.Name = "salesperson_function";
            this.salesperson_function.ReadOnly = true;
            this.salesperson_function.Width = 200;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 459);
            this.ControlBox = false;
            this.Controls.Add(this.dtgVendedor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cboFuncao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZAO-PDV | Cadatrar Vendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ZAO_PDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAOPDVDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cboFuncao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dtgVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesperson_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesperson_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesperson_function;
        private System.Windows.Forms.BindingSource zAOPDVDataSetBindingSource;
        private _ZAO_PDVDataSet _ZAO_PDVDataSet;
    }
}