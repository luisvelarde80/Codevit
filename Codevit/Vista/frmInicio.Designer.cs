namespace Codevit
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenus = new System.Windows.Forms.MenuStrip();
            this.tsmiVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContabilidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecursosHumanos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSistemasCat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCatSat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatAduanas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatFormaPago = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatMetodoPago = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatMoneda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatProductoServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatRegimenFiscal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatTipoRelacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSatUsoCfdi = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenus
            // 
            this.msMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVentas,
            this.tsmiAlmacen,
            this.tsmiCompras,
            this.tsmiContabilidad,
            this.tsmiRecursosHumanos,
            this.tsmiSistemas});
            this.msMenus.Location = new System.Drawing.Point(0, 0);
            this.msMenus.Name = "msMenus";
            this.msMenus.Size = new System.Drawing.Size(1177, 24);
            this.msMenus.TabIndex = 0;
            this.msMenus.Text = "menuStrip1";
            // 
            // tsmiVentas
            // 
            this.tsmiVentas.Name = "tsmiVentas";
            this.tsmiVentas.Size = new System.Drawing.Size(53, 20);
            this.tsmiVentas.Text = "Ventas";
            // 
            // tsmiAlmacen
            // 
            this.tsmiAlmacen.Name = "tsmiAlmacen";
            this.tsmiAlmacen.Size = new System.Drawing.Size(66, 20);
            this.tsmiAlmacen.Text = "Almacen";
            // 
            // tsmiCompras
            // 
            this.tsmiCompras.Name = "tsmiCompras";
            this.tsmiCompras.Size = new System.Drawing.Size(67, 20);
            this.tsmiCompras.Text = "Compras";
            // 
            // tsmiContabilidad
            // 
            this.tsmiContabilidad.Name = "tsmiContabilidad";
            this.tsmiContabilidad.Size = new System.Drawing.Size(87, 20);
            this.tsmiContabilidad.Text = "Contabilidad";
            // 
            // tsmiRecursosHumanos
            // 
            this.tsmiRecursosHumanos.Name = "tsmiRecursosHumanos";
            this.tsmiRecursosHumanos.Size = new System.Drawing.Size(121, 20);
            this.tsmiRecursosHumanos.Text = "Recursos Humanos";
            // 
            // tsmiSistemas
            // 
            this.tsmiSistemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSistemasCat});
            this.tsmiSistemas.Name = "tsmiSistemas";
            this.tsmiSistemas.Size = new System.Drawing.Size(65, 20);
            this.tsmiSistemas.Text = "Sistemas";
            // 
            // tsmiSistemasCat
            // 
            this.tsmiSistemasCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCatSat});
            this.tsmiSistemasCat.Name = "tsmiSistemasCat";
            this.tsmiSistemasCat.Size = new System.Drawing.Size(180, 22);
            this.tsmiSistemasCat.Text = "Catalogos";
            // 
            // tsmiCatSat
            // 
            this.tsmiCatSat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSatAduanas,
            this.tsmiSatFormaPago,
            this.tsmiSatMetodoPago,
            this.tsmiSatMoneda,
            this.tsmiSatProductoServicio,
            this.tsmiSatRegimenFiscal,
            this.tsmiSatTipoRelacion,
            this.tsmiSatUsoCfdi});
            this.tsmiCatSat.Name = "tsmiCatSat";
            this.tsmiCatSat.Size = new System.Drawing.Size(180, 22);
            this.tsmiCatSat.Text = "SAT";
            // 
            // tsmiSatAduanas
            // 
            this.tsmiSatAduanas.Name = "tsmiSatAduanas";
            this.tsmiSatAduanas.Size = new System.Drawing.Size(180, 22);
            this.tsmiSatAduanas.Text = "Aduanas";
            this.tsmiSatAduanas.Click += new System.EventHandler(this.tsmiSatAduanas_Click);
            // 
            // tsmiSatFormaPago
            // 
            this.tsmiSatFormaPago.Name = "tsmiSatFormaPago";
            this.tsmiSatFormaPago.Size = new System.Drawing.Size(180, 22);
            this.tsmiSatFormaPago.Text = "Formas de Pago";
            this.tsmiSatFormaPago.Click += new System.EventHandler(this.tsmiSatFormaPago_Click);
            // 
            // tsmiSatMetodoPago
            // 
            this.tsmiSatMetodoPago.Name = "tsmiSatMetodoPago";
            this.tsmiSatMetodoPago.Size = new System.Drawing.Size(180, 22);
            this.tsmiSatMetodoPago.Text = "Metodo de Pago";
            this.tsmiSatMetodoPago.Click += new System.EventHandler(this.tsmiSatMetodoPago_Click);
            // 
            // tsmiSatMoneda
            // 
            this.tsmiSatMoneda.Name = "tsmiSatMoneda";
            this.tsmiSatMoneda.Size = new System.Drawing.Size(180, 22);
            this.tsmiSatMoneda.Text = "Moneda";
            this.tsmiSatMoneda.Click += new System.EventHandler(this.tsmiSatMoneda_Click);
            // 
            // tsmiSatProductoServicio
            // 
            this.tsmiSatProductoServicio.Name = "tsmiSatProductoServicio";
            this.tsmiSatProductoServicio.Size = new System.Drawing.Size(180, 22);
            this.tsmiSatProductoServicio.Text = "Producto Servicio";
            this.tsmiSatProductoServicio.Click += new System.EventHandler(this.tsmiSatProductoServicio_Click);
            // 
            // tsmiSatRegimenFiscal
            // 
            this.tsmiSatRegimenFiscal.Name = "tsmiSatRegimenFiscal";
            this.tsmiSatRegimenFiscal.Size = new System.Drawing.Size(180, 22);
            this.tsmiSatRegimenFiscal.Text = "Regimen Fiscal";
            // 
            // tsmiSatTipoRelacion
            // 
            this.tsmiSatTipoRelacion.Name = "tsmiSatTipoRelacion";
            this.tsmiSatTipoRelacion.Size = new System.Drawing.Size(180, 22);
            this.tsmiSatTipoRelacion.Text = "Tipo Relación";
            // 
            // tsmiSatUsoCfdi
            // 
            this.tsmiSatUsoCfdi.Name = "tsmiSatUsoCfdi";
            this.tsmiSatUsoCfdi.Size = new System.Drawing.Size(180, 22);
            this.tsmiSatUsoCfdi.Text = "Uso CFDI";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 578);
            this.Controls.Add(this.msMenus);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenus;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codevit";
            this.msMenus.ResumeLayout(false);
            this.msMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenus;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlmacen;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompras;
        private System.Windows.Forms.ToolStripMenuItem tsmiContabilidad;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecursosHumanos;
        private System.Windows.Forms.ToolStripMenuItem tsmiSistemas;
        private System.Windows.Forms.ToolStripMenuItem tsmiSistemasCat;
        private System.Windows.Forms.ToolStripMenuItem tsmiCatSat;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatAduanas;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatFormaPago;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatMetodoPago;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatMoneda;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatProductoServicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatRegimenFiscal;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatTipoRelacion;
        private System.Windows.Forms.ToolStripMenuItem tsmiSatUsoCfdi;
    }
}

