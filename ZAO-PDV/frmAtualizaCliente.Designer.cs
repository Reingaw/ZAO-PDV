namespace ZAO_PDV
{
    partial class frmAtualizaCliente
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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress_street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress_neigborhood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAOPDVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ZAO_PDVDataSet = new ZAO_PDV._ZAO_PDVDataSet();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAOPDVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ZAO_PDVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone / Nome Cliente";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTelefone.Location = new System.Drawing.Point(12, 36);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(275, 26);
            this.txtTelefone.TabIndex = 0;
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeColumns = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.AutoGenerateColumns = false;
            this.dtgClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_name,
            this.customer_phone,
            this.adress_street,
            this.adress_neigborhood});
            this.dtgClientes.DataSource = this.zAOPDVDataSetBindingSource;
            this.dtgClientes.Location = new System.Drawing.Point(12, 82);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.Size = new System.Drawing.Size(599, 304);
            this.dtgClientes.TabIndex = 3;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Cliente";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 115;
            // 
            // customer_phone
            // 
            this.customer_phone.DataPropertyName = "customer_phone";
            this.customer_phone.HeaderText = "Telefone";
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.ReadOnly = true;
            this.customer_phone.Width = 110;
            // 
            // adress_street
            // 
            this.adress_street.DataPropertyName = "adress_street";
            this.adress_street.HeaderText = "Endereço";
            this.adress_street.Name = "adress_street";
            this.adress_street.ReadOnly = true;
            this.adress_street.Width = 260;
            // 
            // adress_neigborhood
            // 
            this.adress_neigborhood.DataPropertyName = "adress_neigborhood";
            this.adress_neigborhood.HeaderText = "Bairro";
            this.adress_neigborhood.Name = "adress_neigborhood";
            this.adress_neigborhood.ReadOnly = true;
            this.adress_neigborhood.Width = 111;
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
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(455, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(536, 36);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAtualizaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 398);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAtualizaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZAO-PDV | Atualizar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAOPDVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ZAO_PDVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource zAOPDVDataSetBindingSource;
        private _ZAO_PDVDataSet _ZAO_PDVDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress_street;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress_neigborhood;
    }
}