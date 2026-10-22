namespace pryMeierPaz
{
    partial class Form1
    {
        private DataGridView dgvVentas;
        private Button btnValidarDatos;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private Button btnCerrar;
        private Label lblMozoDelDia;
        private Label lblImporteMozo;
        private Label lblTotalGeneral;
        private Label lblTotalComidas;
        private Label lblTotalBebidasSinAlcohol;
        private Label lblTotalBebidasConAlcohol;
        private Label lblTotalPostres;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVentas = new DataGridView();
            btnValidarDatos = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            btnCerrar = new Button();
            lblMozoDelDia = new Label();
            lblImporteMozo = new Label();
            lblTotalGeneral = new Label();
            lblTotalComidas = new Label();
            lblTotalBebidasSinAlcohol = new Label();
            lblTotalBebidasConAlcohol = new Label();
            lblTotalPostres = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvVentas.Location = new Point(30, 55);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(840, 190);
            dgvVentas.TabIndex = 0;
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.Location = new Point(30, 265);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(145, 35);
            btnValidarDatos.TabIndex = 1;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = true;
            btnValidarDatos.Click += btnValidarDatos_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Enabled = false;
            btnMozoDelDia.Location = new Point(30, 330);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(145, 35);
            btnMozoDelDia.TabIndex = 2;
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.UseVisualStyleBackColor = true;
            btnMozoDelDia.Click += btnMozoDelDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Enabled = false;
            btnTotales.Location = new Point(30, 390);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(145, 35);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(30, 550);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(145, 35);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.Location = new Point(0, 0);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(100, 23);
            lblMozoDelDia.TabIndex = 5;
            // 
            // lblImporteMozo
            // 
            lblImporteMozo.Location = new Point(0, 0);
            lblImporteMozo.Name = "lblImporteMozo";
            lblImporteMozo.Size = new Size(100, 23);
            lblImporteMozo.TabIndex = 6;
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.Location = new Point(0, 0);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(100, 23);
            lblTotalGeneral.TabIndex = 7;
            // 
            // lblTotalComidas
            // 
            lblTotalComidas.Location = new Point(0, 0);
            lblTotalComidas.Name = "lblTotalComidas";
            lblTotalComidas.Size = new Size(100, 23);
            lblTotalComidas.TabIndex = 8;
            // 
            // lblTotalBebidasSinAlcohol
            // 
            lblTotalBebidasSinAlcohol.Location = new Point(0, 0);
            lblTotalBebidasSinAlcohol.Name = "lblTotalBebidasSinAlcohol";
            lblTotalBebidasSinAlcohol.Size = new Size(100, 23);
            lblTotalBebidasSinAlcohol.TabIndex = 9;
            // 
            // lblTotalBebidasConAlcohol
            // 
            lblTotalBebidasConAlcohol.Location = new Point(0, 0);
            lblTotalBebidasConAlcohol.Name = "lblTotalBebidasConAlcohol";
            lblTotalBebidasConAlcohol.Size = new Size(100, 23);
            lblTotalBebidasConAlcohol.TabIndex = 10;
            // 
            // lblTotalPostres
            // 
            lblTotalPostres.Location = new Point(0, 0);
            lblTotalPostres.Name = "lblTotalPostres";
            lblTotalPostres.Size = new Size(100, 23);
            lblTotalPostres.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 620);
            Controls.Add(dgvVentas);
            Controls.Add(btnValidarDatos);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnTotales);
            Controls.Add(btnCerrar);
            Controls.Add(lblMozoDelDia);
            Controls.Add(lblImporteMozo);
            Controls.Add(lblTotalGeneral);
            Controls.Add(lblTotalComidas);
            Controls.Add(lblTotalBebidasSinAlcohol);
            Controls.Add(lblTotalBebidasConAlcohol);
            Controls.Add(lblTotalPostres);
            Name = "Form1";
            Text = "Bar La Milanga - Ventas diarias";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        private static void ConfigureResultLabel(Label label, string text, Point location, Size size)
        {
            label.AutoSize = false;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Location = location;
            label.Size = size;
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleLeft;
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
