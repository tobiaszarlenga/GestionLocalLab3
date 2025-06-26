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
            lblTotalMes = new Label();
            lblResultado = new Label();
            btnVerReporte = new Button();
            nudDia = new NumericUpDown();
            cbMes = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl.SuspendLayout();
            tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            tabReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDia).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabVenta);
            tabControl.Controls.Add(tabStock);
            tabControl.Controls.Add(tabReporte);
            tabControl.Location = new Point(17, 20);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1127, 730);
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
            tabVenta.Location = new Point(4, 34);
            tabVenta.Margin = new Padding(4, 5, 4, 5);
            tabVenta.Name = "tabVenta";
            tabVenta.Padding = new Padding(4, 5, 4, 5);
            tabVenta.Size = new Size(1119, 692);
            tabVenta.TabIndex = 0;
            tabVenta.Text = "Venta";
            tabVenta.UseVisualStyleBackColor = true;
            tabVenta.Click += tabVenta_Click;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Location = new Point(490, 520);
            btnCargarProducto.Margin = new Padding(4, 5, 4, 5);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(164, 38);
            btnCargarProducto.TabIndex = 7;
            btnCargarProducto.Text = "Cargar Producto";
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(663, 520);
            btnAgregarAlCarrito.Margin = new Padding(4, 5, 4, 5);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(156, 38);
            btnAgregarAlCarrito.TabIndex = 6;
            btnAgregarAlCarrito.Text = "Agregar al Carrito";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += button1_Click;
            // 
            // dataGridViewCarrito
            // 
            dataGridViewCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrito.Location = new Point(334, 25);
            dataGridViewCarrito.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCarrito.Name = "dataGridViewCarrito";
            dataGridViewCarrito.RowHeadersWidth = 62;
            dataGridViewCarrito.Size = new Size(743, 348);
            dataGridViewCarrito.TabIndex = 5;
            dataGridViewCarrito.CellContentClick += dataGridViewCarrito_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 230);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 4;
            label3.Text = "Metodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 4;
            label1.Text = "Producto:";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(110, 225);
            cbMetodoPago.Margin = new Padding(4, 5, 4, 5);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(171, 33);
            cbMetodoPago.TabIndex = 3;
            // 
            // btnRegistarVenta
            // 
            btnRegistarVenta.Location = new Point(827, 520);
            btnRegistarVenta.Margin = new Padding(4, 5, 4, 5);
            btnRegistarVenta.Name = "btnRegistarVenta";
            btnRegistarVenta.Size = new Size(153, 38);
            btnRegistarVenta.TabIndex = 2;
            btnRegistarVenta.Text = "Registar venta";
            btnRegistarVenta.UseVisualStyleBackColor = true;
            btnRegistarVenta.Click += btnRegistarVenta_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(119, 138);
            nudCantidad.Margin = new Padding(4, 5, 4, 5);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(171, 31);
            nudCantidad.TabIndex = 1;
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(120, 88);
            cbProductos.Margin = new Padding(4, 5, 4, 5);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(171, 33);
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
            tabStock.Location = new Point(4, 34);
            tabStock.Margin = new Padding(4, 5, 4, 5);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(4, 5, 4, 5);
            tabStock.Size = new Size(1119, 692);
            tabStock.TabIndex = 1;
            tabStock.Text = "Stock";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 182);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 12;
            label7.Text = "Talle";
            // 
            // txtTalleProducto
            // 
            txtTalleProducto.Location = new Point(129, 177);
            txtTalleProducto.Margin = new Padding(4, 5, 4, 5);
            txtTalleProducto.Name = "txtTalleProducto";
            txtTalleProducto.Size = new Size(141, 31);
            txtTalleProducto.TabIndex = 11;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(760, 517);
            btnEditarProducto.Margin = new Padding(4, 5, 4, 5);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(139, 38);
            btnEditarProducto.TabIndex = 10;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(907, 517);
            btnEliminarProducto.Margin = new Padding(4, 5, 4, 5);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(160, 38);
            btnEliminarProducto.TabIndex = 9;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 317);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 8;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 238);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 122);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(429, 517);
            btnAgregarProducto.Margin = new Padding(4, 5, 4, 5);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(157, 38);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // nudStockProducto
            // 
            nudStockProducto.Location = new Point(127, 303);
            nudStockProducto.Margin = new Padding(4, 5, 4, 5);
            nudStockProducto.Name = "nudStockProducto";
            nudStockProducto.Size = new Size(87, 31);
            nudStockProducto.TabIndex = 4;
            // 
            // nudPrecioProducto
            // 
            nudPrecioProducto.Location = new Point(127, 238);
            nudPrecioProducto.Margin = new Padding(4, 5, 4, 5);
            nudPrecioProducto.Name = "nudPrecioProducto";
            nudPrecioProducto.Size = new Size(87, 31);
            nudPrecioProducto.TabIndex = 3;
            nudPrecioProducto.ValueChanged += nudPrecioProducto_ValueChanged;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(127, 117);
            txtNombreProducto.Margin = new Padding(4, 5, 4, 5);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(170, 31);
            txtNombreProducto.TabIndex = 2;
            // 
            // btnCargarProductosStock
            // 
            btnCargarProductosStock.Location = new Point(594, 517);
            btnCargarProductosStock.Margin = new Padding(4, 5, 4, 5);
            btnCargarProductosStock.Name = "btnCargarProductosStock";
            btnCargarProductosStock.Size = new Size(157, 38);
            btnCargarProductosStock.TabIndex = 1;
            btnCargarProductosStock.Text = "Cargar Productos";
            btnCargarProductosStock.UseVisualStyleBackColor = true;
            btnCargarProductosStock.Click += btnCargarProductos_Click;
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.Location = new Point(381, 80);
            dataGridViewStock.Margin = new Padding(4, 5, 4, 5);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.RowHeadersWidth = 62;
            dataGridViewStock.Size = new Size(721, 382);
            dataGridViewStock.TabIndex = 0;
            dataGridViewStock.CellContentClick += dataGridViewStock_CellContentClick;
            // 
            // tabReporte
            // 
            tabReporte.Controls.Add(lblTotalMes);
            tabReporte.Controls.Add(lblResultado);
            tabReporte.Controls.Add(btnVerReporte);
            tabReporte.Controls.Add(nudDia);
            tabReporte.Controls.Add(cbMes);
            tabReporte.Location = new Point(4, 34);
            tabReporte.Margin = new Padding(4, 5, 4, 5);
            tabReporte.Name = "tabReporte";
            tabReporte.Padding = new Padding(4, 5, 4, 5);
            tabReporte.Size = new Size(1119, 692);
            tabReporte.TabIndex = 2;
            tabReporte.Text = "Reporte";
            tabReporte.UseVisualStyleBackColor = true;
            tabReporte.Click += tabReporte_Click;
            // 
            // lblTotalMes
            // 
            lblTotalMes.AutoSize = true;
            lblTotalMes.Location = new Point(664, 287);
            lblTotalMes.Margin = new Padding(4, 0, 4, 0);
            lblTotalMes.Name = "lblTotalMes";
            lblTotalMes.Size = new Size(101, 25);
            lblTotalMes.TabIndex = 6;
            lblTotalMes.Text = "lblTotalMes";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(470, 198);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(16, 25);
            lblResultado.TabIndex = 4;
            lblResultado.Text = ".";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnVerReporte
            // 
            btnVerReporte.Location = new Point(87, 438);
            btnVerReporte.Margin = new Padding(4, 5, 4, 5);
            btnVerReporte.Name = "btnVerReporte";
            btnVerReporte.Size = new Size(107, 38);
            btnVerReporte.TabIndex = 3;
            btnVerReporte.Text = "Consultar";
            btnVerReporte.UseVisualStyleBackColor = true;
            btnVerReporte.Click += btnVerReporte_Click;
            // 
            // nudDia
            // 
            nudDia.Location = new Point(87, 198);
            nudDia.Margin = new Padding(4, 5, 4, 5);
            nudDia.Name = "nudDia";
            nudDia.Size = new Size(171, 31);
            nudDia.TabIndex = 2;
            // 
            // cbMes
            // 
            cbMes.FormattingEnabled = true;
            cbMes.Location = new Point(87, 122);
            cbMes.Margin = new Padding(4, 5, 4, 5);
            cbMes.Name = "cbMes";
            cbMes.Size = new Size(171, 33);
            cbMes.TabIndex = 1;
            cbMes.SelectedIndexChanged += cbMes_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(tabControl);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnCargarProductosStock;
        private DataGridView dataGridViewStock;
        private Label lblResultado;
        private Button btnVerReporte;
        private NumericUpDown nudDia;
        private ComboBox cbMes;
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
        private Label lblTotalMes;
        private ContextMenuStrip contextMenuStrip1;
        private Label label7;
        private TextBox txtTalleProducto;
    }
}
