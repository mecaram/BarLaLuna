namespace BarLaLuna
{
    partial class ListadoDeVentas
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
            dgvListado = new DataGridView();
            lblTitulo = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // dgvListado
            // 
            dgvListado.AllowUserToAddRows = false;
            dgvListado.AllowUserToDeleteRows = false;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(35, 53);
            dgvListado.Name = "dgvListado";
            dgvListado.ReadOnly = true;
            dgvListado.Size = new Size(388, 257);
            dgvListado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(152, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Listado de Ventas";
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(152, 333);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(141, 32);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ListadoDeVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 376);
            Controls.Add(btnSalir);
            Controls.Add(lblTitulo);
            Controls.Add(dgvListado);
            Name = "ListadoDeVentas";
            Text = "Listado de Ventas";
            Load += ListadoDeVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListado;
        private Label lblTitulo;
        private Button btnSalir;
    }
}