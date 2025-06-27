namespace GestioLocalLab3.Desktop
{
    partial class FormularioPrincipal
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
            tabControl1 = new TabControl();
            tabVenta = new TabPage();
            dgvVentas = new DataGridView();
            btnRegistrarVenta = new Button();
            nudCantidad = new NumericUpDown();
            cboModoPago = new ComboBox();
            cboProducto = new ComboBox();
            tabStock = new TabPage();
            btnEliminarProducto = new Button();
            btnEditarProducto = new Button();
            btnAgregarProducto = new Button();
            dgvProductos = new DataGridView();
            tabPage3 = new TabPage();
            lblTotalVentas = new Label();
            btnEditarVenta = new Button();
            btnEliminarVenta = new Button();
            btnVentasMes = new Button();
            btnVentasDia = new Button();
            dgvReporte = new DataGridView();
            tabControl1.SuspendLayout();
            tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabVenta);
            tabControl1.Controls.Add(tabStock);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(804, 414);
            tabControl1.TabIndex = 0;
            // 
            // tabVenta
            // 
            tabVenta.Controls.Add(dgvVentas);
            tabVenta.Controls.Add(btnRegistrarVenta);
            tabVenta.Controls.Add(nudCantidad);
            tabVenta.Controls.Add(cboModoPago);
            tabVenta.Controls.Add(cboProducto);
            tabVenta.Location = new Point(4, 24);
            tabVenta.Name = "tabVenta";
            tabVenta.Padding = new Padding(3);
            tabVenta.Size = new Size(796, 386);
            tabVenta.TabIndex = 0;
            tabVenta.Text = "VENTAS";
            tabVenta.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(296, 30);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(454, 262);
            dgvVentas.TabIndex = 4;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(125, 252);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(75, 23);
            btnRegistrarVenta.TabIndex = 3;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(125, 197);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 2;
            // 
            // cboModoPago
            // 
            cboModoPago.FormattingEnabled = true;
            cboModoPago.Location = new Point(125, 146);
            cboModoPago.Name = "cboModoPago";
            cboModoPago.Size = new Size(121, 23);
            cboModoPago.TabIndex = 1;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(125, 101);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(121, 23);
            cboProducto.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(btnEliminarProducto);
            tabStock.Controls.Add(btnEditarProducto);
            tabStock.Controls.Add(btnAgregarProducto);
            tabStock.Controls.Add(dgvProductos);
            tabStock.Location = new Point(4, 24);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(796, 386);
            tabStock.TabIndex = 1;
            tabStock.Text = "STOCK";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(586, 324);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(75, 23);
            btnEliminarProducto.TabIndex = 3;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(491, 324);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(75, 23);
            btnEditarProducto.TabIndex = 2;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(152, 324);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(135, 23);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(130, 25);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(549, 266);
            dgvProductos.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblTotalVentas);
            tabPage3.Controls.Add(btnEditarVenta);
            tabPage3.Controls.Add(btnEliminarVenta);
            tabPage3.Controls.Add(btnVentasMes);
            tabPage3.Controls.Add(btnVentasDia);
            tabPage3.Controls.Add(dgvReporte);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(796, 386);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "REPORTE";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Location = new Point(595, 272);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(10, 15);
            lblTotalVentas.TabIndex = 5;
            lblTotalVentas.Text = ".";
            // 
            // btnEditarVenta
            // 
            btnEditarVenta.Location = new Point(700, 118);
            btnEditarVenta.Name = "btnEditarVenta";
            btnEditarVenta.Size = new Size(75, 23);
            btnEditarVenta.TabIndex = 4;
            btnEditarVenta.Text = "Editar";
            btnEditarVenta.UseVisualStyleBackColor = true;
            btnEditarVenta.Click += btnEditarVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(700, 205);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(75, 23);
            btnEliminarVenta.TabIndex = 3;
            btnEliminarVenta.Text = "Eliminar";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            // 
            // btnVentasMes
            // 
            btnVentasMes.Location = new Point(402, 297);
            btnVentasMes.Name = "btnVentasMes";
            btnVentasMes.Size = new Size(75, 23);
            btnVentasMes.TabIndex = 2;
            btnVentasMes.Text = "Ventas Mes";
            btnVentasMes.UseVisualStyleBackColor = true;
            btnVentasMes.Click += btnVentasMes_Click;
            // 
            // btnVentasDia
            // 
            btnVentasDia.Location = new Point(120, 297);
            btnVentasDia.Name = "btnVentasDia";
            btnVentasDia.Size = new Size(75, 23);
            btnVentasDia.TabIndex = 1;
            btnVentasDia.Text = "Ventas Hoy";
            btnVentasDia.UseVisualStyleBackColor = true;
            btnVentasDia.Click += btnVentasDia_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(108, 50);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.Size = new Size(560, 219);
            dgvReporte.TabIndex = 0;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormularioPrincipal";
            Text = "FormularioPrincipal";
            Load += FormularioPrincipal_Load;
            tabControl1.ResumeLayout(false);
            tabVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabVenta;
        private TabPage tabStock;
        private TabPage tabPage3;
        private ComboBox cboProducto;
        private ComboBox cboModoPago;
        private Button btnRegistrarVenta;
        private NumericUpDown nudCantidad;
        private DataGridView dgvVentas;
        private DataGridView dgvProductos;
        private Button btnEliminarProducto;
        private Button btnEditarProducto;
        private Button btnAgregarProducto;
        private Button btnEditarVenta;
        private Button btnEliminarVenta;
        private Button btnVentasMes;
        private Button btnVentasDia;
        private DataGridView dgvReporte;
        private Label lblTotalVentas;
    }
}