namespace Monitor_comanda
{
    partial class Form1
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
            this.nOrden = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.nomCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTerminado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOrden
            // 
            this.nOrden.BackColor = System.Drawing.Color.Firebrick;
            this.nOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOrden.ForeColor = System.Drawing.Color.Snow;
            this.nOrden.Location = new System.Drawing.Point(13, 9);
            this.nOrden.Name = "nOrden";
            this.nOrden.Size = new System.Drawing.Size(45, 45);
            this.nOrden.TabIndex = 0;
            this.nOrden.Text = "label1";
            this.nOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(16, 57);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(337, 245);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomCliente
            // 
            this.nomCliente.AutoSize = true;
            this.nomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomCliente.Location = new System.Drawing.Point(75, 9);
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.Size = new System.Drawing.Size(46, 17);
            this.nomCliente.TabIndex = 2;
            this.nomCliente.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTerminado);
            this.panel1.Controls.Add(this.nomCliente);
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Controls.Add(this.nOrden);
            this.panel1.Location = new System.Drawing.Point(10, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 370);
            this.panel1.TabIndex = 3;
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(26, 308);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(304, 50);
            this.btnTerminado.TabIndex = 3;
            this.btnTerminado.Text = "Finalizar preparacion";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Monitor Comanda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nOrden;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label nomCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTerminado;
    }
}

