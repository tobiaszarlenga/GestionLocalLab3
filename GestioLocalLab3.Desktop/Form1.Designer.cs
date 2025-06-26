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
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabVenta = new TabPage();
            btnCargarProducto = new Button();
            btnAgregarAlCarrito = new Button();
            dataGridViewCarrito = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbMetodoPago = new ComboBox();
            btnRegistarVenta = new Button();
            nudCantidad = new NumericUpDown();
            cbProductos = new ComboBox();
            tabStock = new TabPage();
            label7 = new Label();
            txtTalleProducto = new TextBox();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnAgregarProducto = new Button();
            nudStockProducto = new NumericUpDown();
            nudPrecioProducto = new NumericUpDown();
            txtNombreProducto = new TextBox();
            btnCargarProductosStock = new Button();
            dataGridViewStock = new DataGridView();
            tabReporte = new TabPage();
            label8 = new Label();
            groupBox3 = new GroupBox();
            dgvVentas = new DataGridView();
            groupBox2 = new GroupBox();
            btnElimanarVenta = new Button();
            btnEditarReporte = new Button();
            groupBox1 = new GroupBox();
            btnVentasMes = new Button();
            btnVentasDia = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnDescargar = new Button();
            tabControl.SuspendLayout();
            tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            tabReporte.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabVenta);
            tabControl.Controls.Add(tabStock);
            tabControl.Controls.Add(tabReporte);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(789, 438);
            tabControl.TabIndex = 0;
            // 
            // tabVenta
            // 
            tabVenta.Controls.Add(btnCargarProducto);
            tabVenta.Controls.Add(btnAgregarAlCarrito);
            tabVenta.Controls.Add(dataGridViewCarrito);
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
            tabVenta.Size = new Size(781, 410);
            tabVenta.TabIndex = 0;
            tabVenta.Text = "Venta";
            tabVenta.UseVisualStyleBackColor = true;
            tabVenta.Click += tabVenta_Click;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Location = new Point(343, 312);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(115, 23);
            btnCargarProducto.TabIndex = 7;
            btnCargarProducto.Text = "Cargar Producto";
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(464, 312);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(109, 23);
            btnAgregarAlCarrito.TabIndex = 6;
            btnAgregarAlCarrito.Text = "Agregar al Carrito";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += button1_Click;
            // 
            // dataGridViewCarrito
            // 
            dataGridViewCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrito.Location = new Point(234, 15);
            dataGridViewCarrito.Name = "dataGridViewCarrito";
            dataGridViewCarrito.Size = new Size(520, 209);
            dataGridViewCarrito.TabIndex = 5;
            dataGridViewCarrito.CellContentClick += dataGridViewCarrito_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 138);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Metodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 53);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Producto:";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(77, 135);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 23);
            cbMetodoPago.TabIndex = 3;
            // 
            // btnRegistarVenta
            // 
            btnRegistarVenta.Location = new Point(579, 312);
            btnRegistarVenta.Name = "btnRegistarVenta";
            btnRegistarVenta.Size = new Size(107, 23);
            btnRegistarVenta.TabIndex = 2;
            btnRegistarVenta.Text = "Registar venta";
            btnRegistarVenta.UseVisualStyleBackColor = true;
            btnRegistarVenta.Click += btnRegistarVenta_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(83, 83);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 1;
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(84, 53);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(121, 23);
            cbProductos.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(label7);
            tabStock.Controls.Add(txtTalleProducto);
            tabStock.Controls.Add(btnEditarProducto);
            tabStock.Controls.Add(btnEliminarProducto);
            tabStock.Controls.Add(label6);
            tabStock.Controls.Add(label5);
            tabStock.Controls.Add(label4);
            tabStock.Controls.Add(btnAgregarProducto);
            tabStock.Controls.Add(nudStockProducto);
            tabStock.Controls.Add(nudPrecioProducto);
            tabStock.Controls.Add(txtNombreProducto);
            tabStock.Controls.Add(btnCargarProductosStock);
            tabStock.Controls.Add(dataGridViewStock);
            tabStock.Location = new Point(4, 24);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(781, 410);
            tabStock.TabIndex = 1;
            tabStock.Text = "Stock";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 109);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 12;
            label7.Text = "Talle";
            // 
            // txtTalleProducto
            // 
            txtTalleProducto.Location = new Point(90, 106);
            txtTalleProducto.Name = "txtTalleProducto";
            txtTalleProducto.Size = new Size(100, 23);
            txtTalleProducto.TabIndex = 11;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(532, 310);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(97, 23);
            btnEditarProducto.TabIndex = 10;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(635, 310);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(112, 23);
            btnEliminarProducto.TabIndex = 9;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 190);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 8;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 143);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 73);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(300, 310);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(110, 23);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // nudStockProducto
            // 
            nudStockProducto.Location = new Point(89, 182);
            nudStockProducto.Name = "nudStockProducto";
            nudStockProducto.Size = new Size(61, 23);
            nudStockProducto.TabIndex = 4;
            // 
            // nudPrecioProducto
            // 
            nudPrecioProducto.Location = new Point(89, 143);
            nudPrecioProducto.Name = "nudPrecioProducto";
            nudPrecioProducto.Size = new Size(61, 23);
            nudPrecioProducto.TabIndex = 3;
            nudPrecioProducto.ValueChanged += nudPrecioProducto_ValueChanged;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(89, 70);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(120, 23);
            txtNombreProducto.TabIndex = 2;
            // 
            // btnCargarProductosStock
            // 
            btnCargarProductosStock.Location = new Point(416, 310);
            btnCargarProductosStock.Name = "btnCargarProductosStock";
            btnCargarProductosStock.Size = new Size(110, 23);
            btnCargarProductosStock.TabIndex = 1;
            btnCargarProductosStock.Text = "Cargar Productos";
            btnCargarProductosStock.UseVisualStyleBackColor = true;
            btnCargarProductosStock.Click += btnCargarProductos_Click;
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.Location = new Point(267, 48);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.Size = new Size(505, 229);
            dataGridViewStock.TabIndex = 0;
            dataGridViewStock.CellContentClick += dataGridViewStock_CellContentClick;
            // 
            // tabReporte
            // 
            tabReporte.Controls.Add(label8);
            tabReporte.Controls.Add(groupBox3);
            tabReporte.Controls.Add(groupBox2);
            tabReporte.Controls.Add(groupBox1);
            tabReporte.Location = new Point(4, 24);
            tabReporte.Name = "tabReporte";
            tabReporte.Padding = new Padding(3);
            tabReporte.Size = new Size(781, 410);
            tabReporte.TabIndex = 2;
            tabReporte.Text = "Reporte";
            tabReporte.UseVisualStyleBackColor = true;
            tabReporte.Click += tabReporte_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(223, 19);
            label8.Name = "label8";
            label8.Size = new Size(323, 32);
            label8.TabIndex = 8;
            label8.Text = "Administracion de Reporte";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvVentas);
            groupBox3.Location = new Point(174, 86);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(525, 301);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Reporte";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(6, 16);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(513, 279);
            dgvVentas.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDescargar);
            groupBox2.Controls.Add(btnElimanarVenta);
            groupBox2.Controls.Add(btnEditarReporte);
            groupBox2.Location = new Point(6, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(148, 188);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // btnElimanarVenta
            // 
            btnElimanarVenta.Location = new Point(30, 80);
            btnElimanarVenta.Name = "btnElimanarVenta";
            btnElimanarVenta.Size = new Size(75, 23);
            btnElimanarVenta.TabIndex = 5;
            btnElimanarVenta.Text = "Eliminar";
            btnElimanarVenta.UseVisualStyleBackColor = true;
            // 
            // btnEditarReporte
            // 
            btnEditarReporte.Location = new Point(30, 41);
            btnEditarReporte.Name = "btnEditarReporte";
            btnEditarReporte.Size = new Size(75, 23);
            btnEditarReporte.TabIndex = 4;
            btnEditarReporte.Text = "Editar";
            btnEditarReporte.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVentasMes);
            groupBox1.Controls.Add(btnVentasDia);
            groupBox1.Location = new Point(6, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(148, 107);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // btnVentasMes
            // 
            btnVentasMes.Location = new Point(21, 69);
            btnVentasMes.Name = "btnVentasMes";
            btnVentasMes.Size = new Size(100, 23);
            btnVentasMes.TabIndex = 7;
            btnVentasMes.Text = "Ver Ventas Mes";
            btnVentasMes.UseVisualStyleBackColor = true;
            // 
            // btnVentasDia
            // 
            btnVentasDia.Location = new Point(21, 31);
            btnVentasDia.Name = "btnVentasDia";
            btnVentasDia.Size = new Size(100, 23);
            btnVentasDia.TabIndex = 6;
            btnVentasDia.Text = "Ver Ventas Dia";
            btnVentasDia.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(30, 118);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(75, 23);
            btnDescargar.TabIndex = 6;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabVenta.ResumeLayout(false);
            tabVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            tabStock.ResumeLayout(false);
            tabStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            tabReporte.ResumeLayout(false);
            tabReporte.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
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
        private Button btnCargarProductosStock;
        private DataGridView dataGridViewStock;
        private Button btnAgregarAlCarrito;
        private DataGridView dataGridViewCarrito;
        private NumericUpDown nudStockProducto;
        private NumericUpDown nudPrecioProducto;
        private TextBox txtNombreProducto;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAgregarProducto;
        private Button btnEliminarProducto;
        private Button btnEditarProducto;
        private Button btnCargarProducto;
        private ContextMenuStrip contextMenuStrip1;
        private Label label7;
        private TextBox txtTalleProducto;
        private GroupBox groupBox1;
        private DataGridView dgvVentas;
        private GroupBox groupBox2;
        private Button btnVentasMes;
        private Button btnVentasDia;
        private Button btnElimanarVenta;
        private Button btnEditarReporte;
        private GroupBox groupBox3;
        private Label label8;
        private Button btnDescargar;
    }
}
