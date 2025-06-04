namespace GestioLocalLab3.Desktop
{
    partial class Form1
    {
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
            tabControl = new TabControl();
            tabVenta = new TabPage();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbMetodoPago = new ComboBox();
            btnRegistarVenta = new Button();
            nudCantidad = new NumericUpDown();
            cbProductos = new ComboBox();
            tabStock = new TabPage();
            tabReporte = new TabPage();
            dgvProductos = new DataGridView();
            btnCargarProductos = new Button();
            cbMes = new ComboBox();
            nudDia = new NumericUpDown();
            btnConsultarReporte = new Button();
            lblResultado = new Label();
            tabControl.SuspendLayout();
            tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            tabStock.SuspendLayout();
            tabReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDia).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabVenta);
            tabControl.Controls.Add(tabStock);
            tabControl.Controls.Add(tabReporte);
            tabControl.Location = new Point(4, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(797, 446);
            tabControl.TabIndex = 0;
            // 
            // tabVenta
            // 
            tabVenta.Controls.Add(label3);
            tabVenta.Controls.Add(label2);
            tabVenta.Controls.Add(label1);
            tabVenta.Controls.Add(cbMetodoPago);
            tabVenta.Controls.Add(btnRegistarVenta);
            tabVenta.Controls.Add(nudCantidad);
            tabVenta.Controls.Add(cbProductos);
            tabVenta.Location = new Point(4, 24);
            tabVenta.Name = "tabVenta";
            tabVenta.Padding = new Padding(3);
            tabVenta.Size = new Size(789, 418);
            tabVenta.TabIndex = 0;
            tabVenta.Text = "Venta";
            tabVenta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Metodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 56);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Producto:";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(108, 138);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 23);
            cbMetodoPago.TabIndex = 3;
            // 
            // btnRegistarVenta
            // 
            btnRegistarVenta.Location = new Point(121, 192);
            btnRegistarVenta.Name = "btnRegistarVenta";
            btnRegistarVenta.Size = new Size(107, 23);
            btnRegistarVenta.TabIndex = 2;
            btnRegistarVenta.Text = "Registar venta";
            btnRegistarVenta.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(108, 93);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 1;
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(108, 53);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(121, 23);
            cbProductos.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(btnCargarProductos);
            tabStock.Controls.Add(dgvProductos);
            tabStock.Location = new Point(4, 24);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(789, 418);
            tabStock.TabIndex = 1;
            tabStock.Text = "Stock";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // tabReporte
            // 
            tabReporte.Controls.Add(lblResultado);
            tabReporte.Controls.Add(btnConsultarReporte);
            tabReporte.Controls.Add(nudDia);
            tabReporte.Controls.Add(cbMes);
            tabReporte.Location = new Point(4, 24);
            tabReporte.Name = "tabReporte";
            tabReporte.Padding = new Padding(3);
            tabReporte.Size = new Size(789, 418);
            tabReporte.TabIndex = 2;
            tabReporte.Text = "Reporte";
            tabReporte.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(329, 18);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(441, 317);
            dgvProductos.TabIndex = 0;
            // 
            // btnCargarProductos
            // 
            btnCargarProductos.Location = new Point(34, 50);
            btnCargarProductos.Name = "btnCargarProductos";
            btnCargarProductos.Size = new Size(121, 40);
            btnCargarProductos.TabIndex = 1;
            btnCargarProductos.Text = "Cargar Productos";
            btnCargarProductos.UseVisualStyleBackColor = true;
            // 
            // cbMes
            // 
            cbMes.FormattingEnabled = true;
            cbMes.Location = new Point(61, 89);
            cbMes.Name = "cbMes";
            cbMes.Size = new Size(121, 23);
            cbMes.TabIndex = 1;
            // 
            // nudDia
            // 
            nudDia.Location = new Point(61, 142);
            nudDia.Name = "nudDia";
            nudDia.Size = new Size(120, 23);
            nudDia.TabIndex = 2;
            // 
            // btnConsultarReporte
            // 
            btnConsultarReporte.Location = new Point(83, 272);
            btnConsultarReporte.Name = "btnConsultarReporte";
            btnConsultarReporte.Size = new Size(75, 23);
            btnConsultarReporte.TabIndex = 3;
            btnConsultarReporte.Text = "Consultar";
            btnConsultarReporte.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(103, 221);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(10, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabVenta.ResumeLayout(false);
            tabVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            tabStock.ResumeLayout(false);
            tabReporte.ResumeLayout(false);
            tabReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabVenta;
        private TabPage tabStock;
        private TabPage tabReporte;
        private NumericUpDown nudCantidad;
        private ComboBox cbProductos;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbMetodoPago;
        private Button btnRegistarVenta;
        private Button btnCargarProductos;
        private DataGridView dgvProductos;
        private Label lblResultado;
        private Button btnConsultarReporte;
        private NumericUpDown nudDia;
        private ComboBox cbMes;
    }
}
