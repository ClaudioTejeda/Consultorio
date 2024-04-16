namespace Consultorio
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.citasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeMedicosToolStripMenuItem});
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.medicosToolStripMenuItem.Text = "Medicos";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDePacientesToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // gestionDeMedicosToolStripMenuItem
            // 
            this.gestionDeMedicosToolStripMenuItem.Name = "gestionDeMedicosToolStripMenuItem";
            this.gestionDeMedicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDeMedicosToolStripMenuItem.Text = "Gestion de Medicos";
            this.gestionDeMedicosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeMedicosToolStripMenuItem_Click);
            // 
            // gestionDePacientesToolStripMenuItem
            // 
            this.gestionDePacientesToolStripMenuItem.Name = "gestionDePacientesToolStripMenuItem";
            this.gestionDePacientesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestionDePacientesToolStripMenuItem.Text = "Gestion de Pacientes";
            this.gestionDePacientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDePacientesToolStripMenuItem_Click);
            // 
            // gestionDeCitasToolStripMenuItem
            // 
            this.gestionDeCitasToolStripMenuItem.Name = "gestionDeCitasToolStripMenuItem";
            this.gestionDeCitasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDeCitasToolStripMenuItem.Text = "Gestion de Citas";
            this.gestionDeCitasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCitasToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCitasToolStripMenuItem;
    }
}

