namespace BarLaLuna
{
    partial class ProcesoPrincipal
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
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            lblTotal = new Label();
            label1 = new Label();
            cboProducto = new ComboBox();
            nudCantidad = new NumericUpDown();
            txtPrecioUnitario = new TextBox();
            txtTotal = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            btnEstadisticas = new Button();
            btnListado = new Button();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(63, 139);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(90, 22);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(63, 189);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(90, 22);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioUnitario.Location = new Point(13, 239);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(140, 22);
            lblPrecioUnitario.TabIndex = 2;
            lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(96, 293);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(57, 22);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 4;
            label1.Text = "Registrar Venta";
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "Te", "Cafe", "Chocolatada" });
            cboProducto.Location = new Point(159, 131);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(247, 30);
            cboProducto.TabIndex = 5;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(159, 182);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(55, 29);
            nudCantidad.TabIndex = 6;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Leave += nudCantidad_Leave;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecioUnitario.Location = new Point(159, 232);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(161, 29);
            txtPrecioUnitario.TabIndex = 7;
            txtPrecioUnitario.Leave += txtPrecioUnitario_Leave;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(159, 286);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(161, 29);
            txtTotal.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSize = true;
            btnRegistrar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(124, 341);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(141, 32);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registar Venta";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(290, 341);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 32);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.AutoSize = true;
            btnEstadisticas.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstadisticas.Location = new Point(444, 215);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(164, 32);
            btnEstadisticas.TabIndex = 11;
            btnEstadisticas.Text = "Estadísticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnListado
            // 
            btnListado.AutoSize = true;
            btnListado.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListado.Location = new Point(444, 149);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(164, 32);
            btnListado.TabIndex = 12;
            btnListado.Text = "Listado de Ventas";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(88, 89);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(65, 22);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(159, 82);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(247, 29);
            dtpFecha.TabIndex = 14;
            // 
            // ProcesoPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 402);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(btnListado);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTotal);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(nudCantidad);
            Controls.Add(cboProducto);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Name = "ProcesoPrincipal";
            Text = "Proceso Principal";
            Load += ProcesoPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private Label lblTotal;
        private Label label1;
        private ComboBox cboProducto;
        private NumericUpDown nudCantidad;
        private TextBox txtPrecioUnitario;
        private TextBox txtTotal;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Button btnEstadisticas;
        private Button btnListado;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
    }
}