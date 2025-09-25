namespace GestorInventario
{
    partial class VerTablaProdu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerTablaProdu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVeriStock = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.intelafDataSet = new GestorInventario.IntelafDataSet();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new GestorInventario.IntelafDataSetTableAdapters.ProductosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelafDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnVeriStock);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 133);
            this.panel1.TabIndex = 0;
            // 
            // btnVeriStock
            // 
            this.btnVeriStock.BackColor = System.Drawing.Color.Silver;
            this.btnVeriStock.Font = new System.Drawing.Font("BankGothic Lt BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriStock.ForeColor = System.Drawing.Color.Black;
            this.btnVeriStock.Location = new System.Drawing.Point(96, 41);
            this.btnVeriStock.Name = "btnVeriStock";
            this.btnVeriStock.Size = new System.Drawing.Size(98, 64);
            this.btnVeriStock.TabIndex = 65;
            this.btnVeriStock.Text = "Verificar Stock";
            this.btnVeriStock.UseVisualStyleBackColor = false;
            this.btnVeriStock.Click += new System.EventHandler(this.btnVeriStock_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Silver;
            this.btnback.Font = new System.Drawing.Font("BankGothic Lt BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(649, 41);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(115, 64);
            this.btnback.TabIndex = 64;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label2
            // 
            this.label2.Image = global::GestorInventario.Properties.Resources.image__2_1;
            this.label2.Location = new System.Drawing.Point(228, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 79);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Tabla \r\nProductos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn,
            this.proveedorIdDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.productosBindingSource2;
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(29, 172);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(842, 291);
            this.dgvProductos.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // stockMinimoDataGridViewTextBoxColumn
            // 
            this.stockMinimoDataGridViewTextBoxColumn.DataPropertyName = "StockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.HeaderText = "StockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.Name = "stockMinimoDataGridViewTextBoxColumn";
            // 
            // proveedorIdDataGridViewTextBoxColumn
            // 
            this.proveedorIdDataGridViewTextBoxColumn.DataPropertyName = "ProveedorId";
            this.proveedorIdDataGridViewTextBoxColumn.HeaderText = "ProveedorId";
            this.proveedorIdDataGridViewTextBoxColumn.Name = "proveedorIdDataGridViewTextBoxColumn";
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataMember = "Productos";
            this.productosBindingSource2.DataSource = this.intelafDataSet;
            // 
            // intelafDataSet
            // 
            this.intelafDataSet.DataSetName = "IntelafDataSet";
            this.intelafDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.intelafDataSet;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.intelafDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // VerTablaProdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(905, 533);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerTablaProdu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerTabla";
            this.Load += new System.EventHandler(this.VerTablaProdu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelafDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvProductos;
        private IntelafDataSet intelafDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private IntelafDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource2;
        private System.Windows.Forms.Button btnVeriStock;
    }
}