namespace ZAO_PDV
{
    partial class frmPesquisarCliente
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
            this.dtgPesquisaCliente = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress_street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress_neigborhood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress_complement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress_reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress_observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAOPDVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ZAO_PDVDataSet = new ZAO_PDV._ZAO_PDVDataSet();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAOPDVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ZAO_PDVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone / Nome";
            // 
            // dtgPesquisaCliente
            // 
            this.dtgPesquisaCliente.AllowUserToAddRows = false;
            this.dtgPesquisaCliente.AllowUserToDeleteRows = false;
            this.dtgPesquisaCliente.AllowUserToResizeColumns = false;
            this.dtgPesquisaCliente.AllowUserToResizeRows = false;
            this.dtgPesquisaCliente.AutoGenerateColumns = false;
            this.dtgPesquisaCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPesquisaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.customer_name,
            this.customer_phone,
            this.adress_street,
            this.adress_number,
            this.adress_neigborhood,
            this.adress_complement,
            this.adress_reference,
            this.adress_observation});
            this.dtgPesquisaCliente.DataSource = this.zAOPDVDataSetBindingSource;
            this.dtgPesquisaCliente.Location = new System.Drawing.Point(12, 83);
            this.dtgPesquisaCliente.Name = "dtgPesquisaCliente";
            this.dtgPesquisaCliente.ReadOnly = true;
            this.dtgPesquisaCliente.RowHeadersVisible = false;
            this.dtgPesquisaCliente.Size = new System.Drawing.Size(522, 263);
            this.dtgPesquisaCliente.TabIndex = 1;
            this.dtgPesquisaCliente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisaCliente_CellEnter);
            this.dtgPesquisaCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgPesquisaCliente_KeyDown);
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "Código";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Width = 5;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Cliente";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // customer_phone
            // 
            this.customer_phone.DataPropertyName = "customer_phone";
            this.customer_phone.HeaderText = "Telefone";
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.ReadOnly = true;
            this.customer_phone.Width = 98;
            // 
            // adress_street
            // 
            this.adress_street.DataPropertyName = "adress_street";
            this.adress_street.HeaderText = "Endereço";
            this.adress_street.Name = "adress_street";
            this.adress_street.ReadOnly = true;
            this.adress_street.Width = 165;
            // 
            // adress_number
            // 
            this.adress_number.DataPropertyName = "adress_number";
            this.adress_number.HeaderText = "Número";
            this.adress_number.Name = "adress_number";
            this.adress_number.ReadOnly = true;
            this.adress_number.Width = 50;
            // 
            // adress_neigborhood
            // 
            this.adress_neigborhood.DataPropertyName = "adress_neigborhood";
            this.adress_neigborhood.HeaderText = "Bairro";
            this.adress_neigborhood.Name = "adress_neigborhood";
            this.adress_neigborhood.ReadOnly = true;
            // 
            // adress_complement
            // 
            this.adress_complement.DataPropertyName = "adress_complement";
            this.adress_complement.HeaderText = "Complemento";
            this.adress_complement.Name = "adress_complement";
            this.adress_complement.ReadOnly = true;
            this.adress_complement.Visible = false;
            // 
            // adress_reference
            // 
            this.adress_reference.DataPropertyName = "adress_reference";
            this.adress_reference.HeaderText = "Referência";
            this.adress_reference.Name = "adress_reference";
            this.adress_reference.ReadOnly = true;
            this.adress_reference.Visible = false;
            // 
            // adress_observation
            // 
            this.adress_observation.DataPropertyName = "adress_observation";
            this.adress_observation.HeaderText = "Observação";
            this.adress_observation.Name = "adress_observation";
            this.adress_observation.ReadOnly = true;
            this.adress_observation.Visible = false;
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(13, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // frmPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 358);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgPesquisaCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesquisarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZAO-PDV | Pesquisar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAOPDVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ZAO_PDVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgPesquisaCliente;
        private System.Windows.Forms.BindingSource zAOPDVDataSetBindingSource;
        private _ZAO_PDVDataSet _ZAO_PDVDataSet;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress_street;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress_neigborhood;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress_complement;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress_reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress_observation;
    }
}