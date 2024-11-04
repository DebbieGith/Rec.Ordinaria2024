namespace Refuerzo2024.View.Dashboard
{
    partial class ViewDashboard
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.probarConexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultadesYEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnAsignaturas = new System.Windows.Forms.Button();
            this.btnFacultades = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelFondo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.asignaturasToolStripMenuItem,
            this.facultadesYEspecialidadesToolStripMenuItem,
            this.cerrarFormularioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.probarConexiónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // probarConexiónToolStripMenuItem
            // 
            this.probarConexiónToolStripMenuItem.Name = "probarConexiónToolStripMenuItem";
            this.probarConexiónToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.probarConexiónToolStripMenuItem.Text = "Probar conexión";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.docentesToolStripMenuItem.Text = "Docentes";
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            // 
            // facultadesYEspecialidadesToolStripMenuItem
            // 
            this.facultadesYEspecialidadesToolStripMenuItem.Name = "facultadesYEspecialidadesToolStripMenuItem";
            this.facultadesYEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.facultadesYEspecialidadesToolStripMenuItem.Text = "Facultades y Especialidades";
            // 
            // cerrarFormularioToolStripMenuItem
            // 
            this.cerrarFormularioToolStripMenuItem.Image = global::Refuerzo2024.Properties.Resources.Close;
            this.cerrarFormularioToolStripMenuItem.Name = "cerrarFormularioToolStripMenuItem";
            this.cerrarFormularioToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.cerrarFormularioToolStripMenuItem.Text = "Cerrar formulario";
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.PanelContenedor);
            this.panelFondo.Controls.Add(this.panelMenu);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 24);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1264, 637);
            this.panelFondo.TabIndex = 1;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(208, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1056, 637);
            this.PanelContenedor.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.btnEstudiantes);
            this.panelMenu.Controls.Add(this.btnDocentes);
            this.panelMenu.Controls.Add(this.btnAsignaturas);
            this.panelMenu.Controls.Add(this.btnFacultades);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(208, 637);
            this.panelMenu.TabIndex = 0;
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Image = global::Refuerzo2024.Properties.Resources.icons8_alumna_35;
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Location = new System.Drawing.Point(3, 3);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(199, 48);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            // 
            // btnDocentes
            // 
            this.btnDocentes.Image = global::Refuerzo2024.Properties.Resources.icons8_formación_34;
            this.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.Location = new System.Drawing.Point(3, 57);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(199, 48);
            this.btnDocentes.TabIndex = 1;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnAsignaturas
            // 
            this.btnAsignaturas.Image = global::Refuerzo2024.Properties.Resources.icons8_electivo_35;
            this.btnAsignaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaturas.Location = new System.Drawing.Point(3, 111);
            this.btnAsignaturas.Name = "btnAsignaturas";
            this.btnAsignaturas.Size = new System.Drawing.Size(199, 48);
            this.btnAsignaturas.TabIndex = 2;
            this.btnAsignaturas.Text = "Asignaturas";
            this.btnAsignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignaturas.UseVisualStyleBackColor = true;
            // 
            // btnFacultades
            // 
            this.btnFacultades.Image = global::Refuerzo2024.Properties.Resources.icons8_faculty_35;
            this.btnFacultades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacultades.Location = new System.Drawing.Point(3, 165);
            this.btnFacultades.Name = "btnFacultades";
            this.btnFacultades.Size = new System.Drawing.Size(199, 48);
            this.btnFacultades.TabIndex = 3;
            this.btnFacultades.Text = "Facultades y especialidades";
            this.btnFacultades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacultades.UseVisualStyleBackColor = true;
            // 
            // ViewDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Registro Académico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFondo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultadesYEspecialidadesToolStripMenuItem;
        public System.Windows.Forms.Button btnEstudiantes;
        public System.Windows.Forms.Button btnDocentes;
        public System.Windows.Forms.Button btnAsignaturas;
        public System.Windows.Forms.Button btnFacultades;
        public System.Windows.Forms.Panel PanelContenedor;
        public System.Windows.Forms.ToolStripMenuItem probarConexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarFormularioToolStripMenuItem;
    }
}