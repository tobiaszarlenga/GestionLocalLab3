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
            dataGridViewCarrito.Location = new Point(301, 15);
            dataGridViewCarrito.Name = "dataGridViewCarrito";
            dataGridViewCarrito.Size = new Size(453, 274);
            dataGridViewCarrito.TabIndex = 5;
            dataGridViewCarrito.CellContentClick += dataGridViewCarrito_CellContentClick;
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
            label6.Location = new Point(47, 143);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 8;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 106);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 74);
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
            nudStockProducto.Location = new Point(89, 141);
            nudStockProducto.Name = "nudStockProducto";
            nudStockProducto.Size = new Size(61, 23);
            nudStockProducto.TabIndex = 4;
            // 
            // nudPrecioProducto
            // 
            nudPrecioProducto.Location = new Point(89, 104);
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
            dataGridViewStock.Location = new Point(273, 48);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.Size = new Size(499, 229);
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
            tabReporte.Location = new Point(4, 24);
            tabReporte.Name = "tabReporte";
            tabReporte.Padding = new Padding(3);
            tabReporte.Size = new Size(781, 410);
            tabReporte.TabIndex = 2;
            tabReporte.Text = "Reporte";
            tabReporte.UseVisualStyleBackColor = true;
            tabReporte.Click += tabReporte_Click;
            // 
            // lblTotalMes
            // 
            lblTotalMes.AutoSize = true;
            lblTotalMes.Location = new Point(465, 172);
            lblTotalMes.Name = "lblTotalMes";
            lblTotalMes.Size = new Size(67, 15);
            lblTotalMes.TabIndex = 6;
            lblTotalMes.Text = "lblTotalMes";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(329, 119);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(10, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = ".";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnVerReporte
            // 
            btnVerReporte.Location = new Point(61, 263);
            btnVerReporte.Name = "btnVerReporte";
            btnVerReporte.Size = new Size(75, 23);
            btnVerReporte.TabIndex = 3;
            btnVerReporte.Text = "Consultar";
            btnVerReporte.UseVisualStyleBackColor = true;
            btnVerReporte.Click += btnVerReporte_Click;
            // 
            // nudDia
            // 
            nudDia.Location = new Point(61, 119);
            nudDia.Name = "nudDia";
            nudDia.Size = new Size(120, 23);
            nudDia.TabIndex = 2;
            // 
            // cbMes
            // 
            cbMes.FormattingEnabled = true;
            cbMes.Location = new Point(61, 73);
            cbMes.Name = "cbMes";
            cbMes.Size = new Size(121, 23);
            cbMes.TabIndex = 1;
            cbMes.SelectedIndexChanged += cbMes_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
    }
}
