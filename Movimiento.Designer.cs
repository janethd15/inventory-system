namespace GestorInventario
{
    partial class Movimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimiento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtMov = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtMovId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 161);
            this.panel1.TabIndex = 68;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Font = new System.Drawing.Font("BankGothic Lt BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(49, 95);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 31);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Image = global::GestorInventario.Properties.Resources.image__2_1;
            this.label11.Location = new System.Drawing.Point(196, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 93);
            this.label11.TabIndex = 66;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Silver;
            this.btnVer.Font = new System.Drawing.Font("BankGothic Lt BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Black;
            this.btnVer.Location = new System.Drawing.Point(624, 56);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(117, 43);
            this.btnVer.TabIndex = 62;
            this.btnVer.Text = "Ver Tabla";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Silver;
            this.btnback.Font = new System.Drawing.Font("BankGothic Lt BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(49, 33);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 39);
            this.btnback.TabIndex = 63;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(276, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 45);
            this.label1.TabIndex = 51;
            this.label1.Text = "Movimientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "ProductoId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 44);
            this.label3.TabIndex = 70;
            this.label3.Text = "Tipo\r\nMovimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = " Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 72;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 22);
            this.label6.TabIndex = 73;
            this.label6.Text = "Responsable";
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(231, 295);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(264, 20);
            this.txtProdId.TabIndex = 74;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(231, 455);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(264, 20);
            this.txtCant.TabIndex = 76;
            // 
            // txtMov
            // 
            this.txtMov.Location = new System.Drawing.Point(231, 375);
            this.txtMov.Name = "txtMov";
            this.txtMov.Size = new System.Drawing.Size(264, 20);
            this.txtMov.TabIndex = 77;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(231, 609);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(264, 20);
            this.txtRes.TabIndex = 78;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.DarkGray;
            this.btneliminar.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Location = new System.Drawing.Point(607, 521);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(134, 58);
            this.btneliminar.TabIndex = 81;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(608, 373);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(133, 55);
            this.btnActualizar.TabIndex = 80;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.DarkGray;
            this.btnguardar.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.Location = new System.Drawing.Point(608, 231);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(133, 55);
            this.btnguardar.TabIndex = 79;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(231, 533);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(264, 20);
            this.txtFecha.TabIndex = 75;
            // 
            // txtMovId
            // 
            this.txtMovId.Location = new System.Drawing.Point(231, 223);
            this.txtMovId.Name = "txtMovId";
            this.txtMovId.Size = new System.Drawing.Size(264, 20);
            this.txtMovId.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "Movimiento Id";
            // 
            // Movimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(812, 688);
            this.Controls.Add(this.txtMovId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtMov);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Movimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtMov;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtMovId;
        private System.Windows.Forms.Label label7;
    }
}