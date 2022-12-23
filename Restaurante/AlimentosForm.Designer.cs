namespace AlmacenForms
{
    partial class AlimentosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlimentosForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.dgvListaFinal = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnOrden = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblCodCLiente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFinal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 662);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 51);
            this.button7.TabIndex = 6;
            this.button7.Text = "Platillos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "Postres";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "Postres";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bebidas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(191, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 507);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.lblCurrent);
            this.tabPage1.Controls.Add(this.dgvListaProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Visible = false;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(84, 22);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(40, 13);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "current";
            this.lblCurrent.Visible = false;
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            this.dgvListaProductos.AllowUserToDeleteRows = false;
            this.dgvListaProductos.AllowUserToResizeColumns = false;
            this.dgvListaProductos.AllowUserToResizeRows = false;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(11, 43);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersVisible = false;
            this.dgvListaProductos.Size = new System.Drawing.Size(461, 427);
            this.dgvListaProductos.TabIndex = 0;
            this.dgvListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaProductos_CellClick);
            this.dgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellContentClick);
            this.dgvListaProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellEndEdit);
            this.dgvListaProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaProductos_CellFormatting);
            this.dgvListaProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgListaProductos_CellPainting);
            this.dgvListaProductos.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvListaProductos_DefaultValuesNeeded);
            this.dgvListaProductos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaProductos_RowEnter);
            // 
            // dgvListaFinal
            // 
            this.dgvListaFinal.AllowUserToAddRows = false;
            this.dgvListaFinal.AllowUserToDeleteRows = false;
            this.dgvListaFinal.AllowUserToResizeColumns = false;
            this.dgvListaFinal.AllowUserToResizeRows = false;
            this.dgvListaFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFinal.Location = new System.Drawing.Point(707, 155);
            this.dgvListaFinal.Name = "dgvListaFinal";
            this.dgvListaFinal.RowHeadersVisible = false;
            this.dgvListaFinal.Size = new System.Drawing.Size(468, 284);
            this.dgvListaFinal.TabIndex = 9;
            this.dgvListaFinal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaFinal_CellContentClick);
            this.dgvListaFinal.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaFinal_CellEndEdit);
            this.dgvListaFinal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaFinal_CellFormatting);
            this.dgvListaFinal.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvListaFinal_DefaultValuesNeeded);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(85)))), ((int)(((byte)(118)))));
            this.button2.Location = new System.Drawing.Point(955, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Crear Orden";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrecioTotal);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(707, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Location = new System.Drawing.Point(53, 27);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(70, 42);
            this.lblPrecioTotal.TabIndex = 0;
            this.lblPrecioTotal.Text = "0.00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(85)))), ((int)(((byte)(118)))));
            this.button1.Location = new System.Drawing.Point(1067, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Borrar todo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(707, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Orden numero: ";
            // 
            // lblnOrden
            // 
            this.lblnOrden.AutoSize = true;
            this.lblnOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblnOrden.Location = new System.Drawing.Point(915, 16);
            this.lblnOrden.Name = "lblnOrden";
            this.lblnOrden.Size = new System.Drawing.Size(86, 31);
            this.lblnOrden.TabIndex = 10;
            this.lblnOrden.Text = "label2";
            this.lblnOrden.Click += new System.EventHandler(this.lblnOrden_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(357, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "label2";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(85)))), ((int)(((byte)(118)))));
            this.btnPagar.Location = new System.Drawing.Point(955, 469);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(208, 52);
            this.btnPagar.TabIndex = 12;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblCodCLiente
            // 
            this.lblCodCLiente.AutoSize = true;
            this.lblCodCLiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCodCLiente.Location = new System.Drawing.Point(707, 62);
            this.lblCodCLiente.Name = "lblCodCLiente";
            this.lblCodCLiente.Size = new System.Drawing.Size(200, 31);
            this.lblCodCLiente.TabIndex = 13;
            this.lblCodCLiente.Text = "Codigo Cliente:";
            this.lblCodCLiente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(913, 72);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(133, 20);
            this.txtCodCliente.TabIndex = 14;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNomCliente.Location = new System.Drawing.Point(815, 106);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(100, 31);
            this.lblNomCliente.TabIndex = 15;
            this.lblNomCliente.Text = "xample";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1067, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 34);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(707, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cliente:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(765, 585);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // AlimentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 663);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNomCliente);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lblCodCLiente);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblnOrden);
            this.Controls.Add(this.dgvListaFinal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlimentosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.Load += new System.EventHandler(this.AlimentosForm_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFinal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.DataGridView dgvListaFinal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnOrden;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblCodCLiente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
    }
}