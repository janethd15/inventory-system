namespace GestorInventario
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnMovimiento = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ishopDataSet = new GestorInventario.IshopDataSet();
            this.ishopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ishopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ishopDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú";
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DarkGray;
            this.btnProductos.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(121, 211);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(169, 87);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.DarkGray;
            this.btnProveedores.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(502, 211);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(172, 87);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.BackColor = System.Drawing.Color.DarkGray;
            this.btnMovimiento.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimiento.Location = new System.Drawing.Point(185, 364);
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(168, 85);
            this.btnMovimiento.TabIndex = 4;
            this.btnMovimiento.Text = "Movimientos";
            this.btnMovimiento.UseVisualStyleBackColor = false;
            this.btnMovimiento.Click += new System.EventHandler(this.btnMovimiento_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(452, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 85);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 158);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Image = global::GestorInventario.Properties.Resources.image__6_;
            this.label2.Location = new System.Drawing.Point(136, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 122);
            this.label2.TabIndex = 7;
            // 
            // ishopDataSet
            // 
            this.ishopDataSet.DataSetName = "IshopDataSet";
            this.ishopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ishopDataSetBindingSource
            // 
            this.ishopDataSetBindingSource.DataSource = this.ishopDataSet;
            this.ishopDataSetBindingSource.Position = 0;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMovimiento);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "index";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ishopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ishopDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ishopDataSetBindingSource;
        private IshopDataSet ishopDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnMovimiento;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}