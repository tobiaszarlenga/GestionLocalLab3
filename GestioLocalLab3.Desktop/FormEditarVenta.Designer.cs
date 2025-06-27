namespace GestioLocalLab3.Desktop
{
    partial class FormEditarVenta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProducto = new TextBox();
            nudCantidad = new NumericUpDown();
            nudPrecio = new NumericUpDown();
            cboModoPago = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 37);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 74);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 114);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio Unitario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 151);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Modo de Pago";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(219, 37);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 4;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(219, 74);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 5;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(219, 114);
            nudPrecio.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 6;
            // 
            // cboModoPago
            // 
            cboModoPago.FormattingEnabled = true;
            cboModoPago.Location = new Point(218, 148);
            cboModoPago.Name = "cboModoPago";
            cboModoPago.Size = new Size(121, 23);
            cboModoPago.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(88, 218);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(264, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEditarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 271);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cboModoPago);
            Controls.Add(nudPrecio);
            Controls.Add(nudCantidad);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEditarVenta";
            Text = "FormEditarVenta";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProducto;
        private NumericUpDown nudCantidad;
        private NumericUpDown nudPrecio;
        private ComboBox cboModoPago;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}