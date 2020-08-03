namespace Codevit.Vista.Sistemas.Catalogos.Sat
{
    partial class frmCatAduanas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatAduanas));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fgAduanas = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgAduanas)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMenu.BackgroundImage")));
            this.tsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(395, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ForeColor = System.Drawing.Color.White;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbEditar
            // 
            this.tsbEditar.ForeColor = System.Drawing.Color.White;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(57, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fgAduanas);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 235);
            this.panel1.TabIndex = 1;
            // 
            // fgAduanas
            // 
            this.fgAduanas.ColumnInfo = "10,0,0,0,0,95,Columns:";
            this.fgAduanas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgAduanas.Location = new System.Drawing.Point(0, 0);
            this.fgAduanas.Name = "fgAduanas";
            this.fgAduanas.Rows.DefaultSize = 19;
            this.fgAduanas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fgAduanas.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgAduanas.Size = new System.Drawing.Size(394, 235);
            this.fgAduanas.TabIndex = 0;
            // 
            // frmCatAduanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 264);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCatAduanas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogos de Aduanas";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgAduanas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1FlexGrid.C1FlexGrid fgAduanas;
    }
}