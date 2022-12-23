namespace Almacen
{
    partial class formAlmacen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cargar_excel = new System.Windows.Forms.Button();
            this.btn_GuardarEnBd = new System.Windows.Forms.Button();
            this.btnCargarRuta = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(638, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_cargar_excel
            // 
            this.btn_cargar_excel.Location = new System.Drawing.Point(95, 286);
            this.btn_cargar_excel.Name = "btn_cargar_excel";
            this.btn_cargar_excel.Size = new System.Drawing.Size(105, 96);
            this.btn_cargar_excel.TabIndex = 1;
            this.btn_cargar_excel.Text = "Cargar excel (csv,xls)";
            this.btn_cargar_excel.UseVisualStyleBackColor = true;
            this.btn_cargar_excel.Click += new System.EventHandler(this.btn_cargar_excel_Click);
            // 
            // btn_GuardarEnBd
            // 
            this.btn_GuardarEnBd.Location = new System.Drawing.Point(1004, 286);
            this.btn_GuardarEnBd.Name = "btn_GuardarEnBd";
            this.btn_GuardarEnBd.Size = new System.Drawing.Size(127, 102);
            this.btn_GuardarEnBd.TabIndex = 2;
            this.btn_GuardarEnBd.Text = "Regisrar productos";
            this.btn_GuardarEnBd.UseVisualStyleBackColor = true;
            // 
            // btnCargarRuta
            // 
            this.btnCargarRuta.Location = new System.Drawing.Point(328, 62);
            this.btnCargarRuta.Name = "btnCargarRuta";
            this.btnCargarRuta.Size = new System.Drawing.Size(136, 41);
            this.btnCargarRuta.TabIndex = 3;
            this.btnCargarRuta.Text = "Selccionar Archivo";
            this.btnCargarRuta.UseVisualStyleBackColor = true;
            this.btnCargarRuta.Click += new System.EventHandler(this.btnCargarRuta_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(509, 72);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(218, 23);
            this.txtRuta.TabIndex = 4;
            // 
            // formAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 668);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnCargarRuta);
            this.Controls.Add(this.btn_GuardarEnBd);
            this.Controls.Add(this.btn_cargar_excel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAlmacen";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_cargar_excel;
        private Button btn_GuardarEnBd;
        private Button btnCargarRuta;
        private TextBox txtRuta;
    }
}