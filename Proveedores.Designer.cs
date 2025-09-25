namespace GestorInventario
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtCui = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.DarkGray;
            this.btneliminar.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Location = new System.Drawing.Point(607, 462);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(134, 58);
            this.btneliminar.TabIndex = 64;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Silver;
            this.btnback.Font = new System.Drawing.Font("BankGothic Lt BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(49, 40);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(108, 35);
            this.btnback.TabIndex = 63;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Silver;
            this.btnVer.Font = new System.Drawing.Font("BankGothic Lt BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Black;
            this.btnVer.Location = new System.Drawing.Point(608, 53);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(133, 55);
            this.btnVer.TabIndex = 62;
            this.btnVer.Text = "Ver Tabla";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(607, 336);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(133, 55);
            this.btnActualizar.TabIndex = 61;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.DarkGray;
            this.btnguardar.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.Location = new System.Drawing.Point(607, 216);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(133, 55);
            this.btnguardar.TabIndex = 60;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtConta
            // 
            this.txtConta.ForeColor = System.Drawing.Color.Black;
            this.txtConta.Location = new System.Drawing.Point(207, 435);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(276, 20);
            this.txtConta.TabIndex = 59;
            // 
            // txtCui
            // 
            this.txtCui.ForeColor = System.Drawing.Color.Black;
            this.txtCui.Location = new System.Drawing.Point(207, 248);
            this.txtCui.Name = "txtCui";
            this.txtCui.Size = new System.Drawing.Size(276, 20);
            this.txtCui.TabIndex = 58;
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(207, 344);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 20);
            this.txtNombre.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(77, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 55;
            this.label9.Text = "Contacto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(86, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "CUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(77, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(258, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 45);
            this.label1.TabIndex = 51;
            this.label1.Text = "Proveedores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 169);
            this.panel1.TabIndex = 67;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Font = new System.Drawing.Font("BankGothic Lt BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(49, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 32);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Image = global::GestorInventario.Properties.Resources.image__2_1;
            this.label11.Location = new System.Drawing.Point(175, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 63);
            this.label11.TabIndex = 66;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(797, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtCui);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtCui;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
    }
}