
namespace AlmacenForms
{
    partial class VerPedido
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
            this.lnlNOrden = new System.Windows.Forms.Label();
            this.txtNOrden = new System.Windows.Forms.TextBox();
            this.dgvDetalleOrden = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // lnlNOrden
            // 
            this.lnlNOrden.AutoSize = true;
            this.lnlNOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlNOrden.Location = new System.Drawing.Point(40, 141);
            this.lnlNOrden.Name = "lnlNOrden";
            this.lnlNOrden.Size = new System.Drawing.Size(152, 20);
            this.lnlNOrden.TabIndex = 0;
            this.lnlNOrden.Text = "Numero de orden:";
            // 
            // txtNOrden
            // 
            this.txtNOrden.Location = new System.Drawing.Point(198, 141);
            this.txtNOrden.Name = "txtNOrden";
            this.txtNOrden.Size = new System.Drawing.Size(61, 20);
            this.txtNOrden.TabIndex = 1;
            this.txtNOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOrden_KeyPress);
            // 
            // dgvDetalleOrden
            // 
            this.dgvDetalleOrden.AllowUserToAddRows = false;
            this.dgvDetalleOrden.AllowUserToDeleteRows = false;
            this.dgvDetalleOrden.AllowUserToResizeColumns = false;
            this.dgvDetalleOrden.AllowUserToResizeRows = false;
            this.dgvDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleOrden.Location = new System.Drawing.Point(287, 98);
            this.dgvDetalleOrden.Name = "dgvDetalleOrden";
            this.dgvDetalleOrden.ReadOnly = true;
            this.dgvDetalleOrden.Size = new System.Drawing.Size(553, 382);
            this.dgvDetalleOrden.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(34, 182);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(225, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCliente.Location = new System.Drawing.Point(361, 66);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(293, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(608, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(662, 66);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "label1";
            // 
            // VerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 613);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvDetalleOrden);
            this.Controls.Add(this.txtNOrden);
            this.Controls.Add(this.lnlNOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerPedido";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.VerPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnlNOrden;
        private System.Windows.Forms.TextBox txtNOrden;
        private System.Windows.Forms.DataGridView dgvDetalleOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
    }
}