namespace GestioLocalLab3.Desktop
{
    partial class FormProducto
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
            btnGuardarProducto = new Button();
            txtNombre = new TextBox();
            txtTalle = new TextBox();
            nudPrecio = new NumericUpDown();
            nudStockActual = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 76);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Talle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 114);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 144);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Stock Actual";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(136, 195);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(75, 23);
            btnGuardarProducto.TabIndex = 4;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(216, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtTalle
            // 
            txtTalle.Location = new Point(216, 76);
            txtTalle.Name = "txtTalle";
            txtTalle.Size = new Size(100, 23);
            txtTalle.TabIndex = 6;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(216, 114);
            nudPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(100, 23);
            nudPrecio.TabIndex = 9;
            // 
            // nudStockActual
            // 
            nudStockActual.Location = new Point(216, 142);
            nudStockActual.Name = "nudStockActual";
            nudStockActual.Size = new Size(100, 23);
            nudStockActual.TabIndex = 8;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 271);
            Controls.Add(nudStockActual);
            Controls.Add(nudPrecio);
            Controls.Add(txtTalle);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardarProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProducto";
            Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardarProducto;
        private TextBox txtNombre;
        private TextBox txtTalle;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudStockActual;
    }
}