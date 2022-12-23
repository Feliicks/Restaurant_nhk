namespace AlmacenForms
{
    partial class formInsumos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.btnRegistrarInsumo = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumReg = new System.Windows.Forms.TextBox();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(50, 151);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(680, 423);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(50, 92);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(145, 43);
            this.btnSeleccionarArchivo.TabIndex = 1;
            this.btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnRegistrarInsumo
            // 
            this.btnRegistrarInsumo.Location = new System.Drawing.Point(776, 81);
            this.btnRegistrarInsumo.Name = "btnRegistrarInsumo";
            this.btnRegistrarInsumo.Size = new System.Drawing.Size(116, 36);
            this.btnRegistrarInsumo.TabIndex = 2;
            this.btnRegistrarInsumo.Text = "Registrar";
            this.btnRegistrarInsumo.UseVisualStyleBackColor = true;
            this.btnRegistrarInsumo.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(238, 110);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(204, 20);
            this.txtRuta.TabIndex = 3;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(577, 81);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(135, 64);
            this.btnImportar.TabIndex = 4;
            this.btnImportar.Text = "Importar archivo";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(224, 48);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbProveedor.TabIndex = 5;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NIT:";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(480, 45);
            this.txtNit.Name = "txtNit";
            this.txtNit.ReadOnly = true;
            this.txtNit.Size = new System.Drawing.Size(204, 20);
            this.txtNit.TabIndex = 8;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(465, 117);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(44, 13);
            this.lblTest.TabIndex = 9;
            this.lblTest.Text = "Ejemplo";
            this.lblTest.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ruta: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "NumeroRegistro";
            // 
            // txtNumReg
            // 
            this.txtNumReg.Location = new System.Drawing.Point(881, 22);
            this.txtNumReg.Name = "txtNumReg";
            this.txtNumReg.Size = new System.Drawing.Size(204, 20);
            this.txtNumReg.TabIndex = 12;
            this.txtNumReg.Visible = false;
            // 
            // dgvTest
            // 
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(755, 151);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.Size = new System.Drawing.Size(401, 423);
            this.dgvTest.TabIndex = 13;
            this.dgvTest.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(77, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "label5";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.lblNumReg.Location = new System.Drawing.Point(477, 22);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(83, 13);
            this.lblNumReg.TabIndex = 15;
            this.lblNumReg.Text = "NumeroRegistro";
            // 
            // formInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 613);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.txtNumReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnRegistrarInsumo);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formInsumos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.Button btnRegistrarInsumo;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumReg;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumReg;
    }
}

