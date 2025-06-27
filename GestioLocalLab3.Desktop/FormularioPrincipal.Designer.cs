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
            tabPage1 = new TabPage();
            cboModoPago = new ComboBox();
            cboProducto = new ComboBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            nudCantidad = new NumericUpDown();
            btnRegistrarVenta = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(804, 414);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegistrarVenta);
            tabPage1.Controls.Add(nudCantidad);
            tabPage1.Controls.Add(cboModoPago);
            tabPage1.Controls.Add(cboProducto);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(796, 386);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "VENTAS";
            tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(796, 386);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "STOCK";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(796, 386);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "REPORTE";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(125, 197);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 2;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(125, 252);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(75, 23);
            btnRegistrarVenta.TabIndex = 3;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
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
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cboProducto;
        private ComboBox cboModoPago;
        private Button btnRegistrarVenta;
        private NumericUpDown nudCantidad;
    }
}