namespace sistema_de_alumnos
{
    partial class Frm_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.suplidoresToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "mantenimiento";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuarioToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.consultasToolStripMenuItem.Text = "consultas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGeneralToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.reportesToolStripMenuItem.Text = "reportes";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estudiantesToolStripMenuItem.Text = "estudiantes";
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profesoresToolStripMenuItem.Text = "profesores";
            // 
            // suplidoresToolStripMenuItem
            // 
            this.suplidoresToolStripMenuItem.Name = "suplidoresToolStripMenuItem";
            this.suplidoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suplidoresToolStripMenuItem.Text = "suplidores";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "salir del sistema";
            // 
            // consultaDeUsuarioToolStripMenuItem
            // 
            this.consultaDeUsuarioToolStripMenuItem.Name = "consultaDeUsuarioToolStripMenuItem";
            this.consultaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaDeUsuarioToolStripMenuItem.Text = "consulta de usuario";
            this.consultaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUsuarioToolStripMenuItem_Click);
            // 
            // reporteGeneralToolStripMenuItem
            // 
            this.reporteGeneralToolStripMenuItem.Name = "reporteGeneralToolStripMenuItem";
            this.reporteGeneralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteGeneralToolStripMenuItem.Text = "reporte general";
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_menu";
            this.Text = "Frm_menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralToolStripMenuItem;
    }
}