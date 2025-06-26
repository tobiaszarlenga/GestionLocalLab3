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
            btnAgregarProducto = new Button();
            dgvStock = new DataGridView();
            tabReporte = new TabPage();
            label8 = new Label();
            groupBox3 = new GroupBox();
            dgvVentas = new DataGridView();
            groupBox2 = new GroupBox();
            btnDescargar = new Button();
            btnElimanarVenta = new Button();
            btnEditarReporte = new Button();
            groupBox1 = new GroupBox();
            btnVentasMes = new Button();
            btnVentasDia = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl.SuspendLayout();
            tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
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
            tabControl.Location = new Point(14, 16);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(902, 584);
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
            tabVenta.Location = new Point(4, 29);
            tabVenta.Margin = new Padding(3, 4, 3, 4);
            tabVenta.Name = "tabVenta";
            tabVenta.Padding = new Padding(3, 4, 3, 4);
            tabVenta.Size = new Size(894, 551);
            tabVenta.TabIndex = 0;
            tabVenta.Text = "Venta";
            tabVenta.UseVisualStyleBackColor = true;
            tabVenta.Click += tabVenta_Click;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Location = new Point(392, 416);
            btnCargarProducto.Margin = new Padding(3, 4, 3, 4);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(131, 31);
            btnCargarProducto.TabIndex = 7;
            btnCargarProducto.Text = "Cargar Producto";
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(530, 416);
            btnAgregarAlCarrito.Margin = new Padding(3, 4, 3, 4);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(125, 31);
            btnAgregarAlCarrito.TabIndex = 6;
            btnAgregarAlCarrito.Text = "Agregar al Carrito";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += button1_Click;
            // 
            // dataGridViewCarrito
            // 
            dataGridViewCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrito.Location = new Point(267, 20);
            dataGridViewCarrito.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCarrito.Name = "dataGridViewCarrito";
            dataGridViewCarrito.RowHeadersWidth = 51;
            dataGridViewCarrito.Size = new Size(594, 279);
            dataGridViewCarrito.TabIndex = 5;
            dataGridViewCarrito.CellContentClick += dataGridViewCarrito_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 184);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Metodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 111);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 71);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 4;
            label1.Text = "Producto:";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(88, 180);
            cbMetodoPago.Margin = new Padding(3, 4, 3, 4);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(138, 28);
            cbMetodoPago.TabIndex = 3;
            // 
            // btnRegistarVenta
            // 
            btnRegistarVenta.Location = new Point(662, 416);
            btnRegistarVenta.Margin = new Padding(3, 4, 3, 4);
            btnRegistarVenta.Name = "btnRegistarVenta";
            btnRegistarVenta.Size = new Size(122, 31);
            btnRegistarVenta.TabIndex = 2;
            btnRegistarVenta.Text = "Registar venta";
            btnRegistarVenta.UseVisualStyleBackColor = true;
            btnRegistarVenta.Click += btnRegistarVenta_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(95, 111);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(137, 27);
            nudCantidad.TabIndex = 1;
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(96, 71);
            cbProductos.Margin = new Padding(3, 4, 3, 4);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(138, 28);
            cbProductos.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(btnEditarProducto);
            tabStock.Controls.Add(btnEliminarProducto);
            tabStock.Controls.Add(btnAgregarProducto);
            tabStock.Controls.Add(dgvStock);
            tabStock.Location = new Point(4, 29);
            tabStock.Margin = new Padding(3, 4, 3, 4);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3, 4, 3, 4);
            tabStock.Size = new Size(894, 551);
            tabStock.TabIndex = 1;
            tabStock.Text = "Stock";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(612, 493);
            btnEditarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(111, 31);
            btnEditarProducto.TabIndex = 10;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(741, 493);
            btnEliminarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(128, 31);
            btnEliminarProducto.TabIndex = 9;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(20, 493);
            btnAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(126, 31);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(6, 8);
            dgvStock.Margin = new Padding(3, 4, 3, 4);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(878, 469);
            dgvStock.TabIndex = 0;
            dgvStock.CellContentClick += dataGridViewStock_CellContentClick;
            // 
            // tabReporte
            // 
 feature/winforms
            tabReporte.Controls.Add(lblTotalMes);
            tabReporte.Controls.Add(lblResultado);
            tabReporte.Controls.Add(btnVerReporte);
            tabReporte.Controls.Add(nudDia);
            tabReporte.Controls.Add(cbMes);
            tabReporte.Location = new Point(4, 29);
            tabReporte.Margin = new Padding(3, 4, 3, 4);

            tabReporte.Name = "tabReporte";
            tabReporte.Padding = new Padding(3, 4, 3, 4);
            tabReporte.Size = new Size(894, 551);
            tabReporte.TabIndex = 2;
            tabReporte.Text = "Reporte";
            tabReporte.UseVisualStyleBackColor = true;
            tabReporte.Click += tabReporte_Click;
            // 
 feature/winforms
            // lblTotalMes
            // 
            lblTotalMes.AutoSize = true;
            lblTotalMes.Location = new Point(531, 229);
            lblTotalMes.Name = "lblTotalMes";
            lblTotalMes.Size = new Size(86, 20);
            lblTotalMes.TabIndex = 6;
            lblTotalMes.Text = "lblTotalMes";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(376, 159);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(12, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = ".";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnVerReporte
            // 
            btnVerReporte.Location = new Point(70, 351);
            btnVerReporte.Margin = new Padding(3, 4, 3, 4);
            btnVerReporte.Name = "btnVerReporte";
            btnVerReporte.Size = new Size(86, 31);
            btnVerReporte.TabIndex = 3;
            btnVerReporte.Text = "Consultar";
            btnVerReporte.UseVisualStyleBackColor = true;
            btnVerReporte.Click += btnVerReporte_Click;
            // 
            // nudDia
            // 
            nudDia.Location = new Point(70, 159);
            nudDia.Margin = new Padding(3, 4, 3, 4);
            nudDia.Name = "nudDia";
            nudDia.Size = new Size(137, 27);
            nudDia.TabIndex = 2;
            // 
            // cbMes
            // 
            cbMes.FormattingEnabled = true;
            cbMes.Location = new Point(70, 97);
            cbMes.Margin = new Padding(3, 4, 3, 4);
            cbMes.Name = "cbMes";
            cbMes.Size = new Size(138, 28);
            cbMes.TabIndex = 1;
            cbMes.SelectedIndexChanged += cbMes_SelectedIndexChanged;

            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabVenta.ResumeLayout(false);
            tabVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
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
 feature/winforms
        private DataGridView dgvStock;
        private Label lblResultado;
        private Button btnVerReporte;
        private NumericUpDown nudDia;
        private ComboBox cbMes;
 develop
        private Button btnAgregarAlCarrito;
        private DataGridView dataGridViewCarrito;
        private Button btnAgregarProducto;
        private Button btnEliminarProducto;
        private Button btnEditarProducto;
        private Button btnCargarProducto;
        private ContextMenuStrip contextMenuStrip1;
 feature/winforms

    }
}
