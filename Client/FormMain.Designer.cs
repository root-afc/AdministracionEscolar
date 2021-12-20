namespace Client
{
    partial class FormMain
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
            this.topAlumnoGradoCursoAñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topAlumnoGradoCursoAñoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crudAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaCantidadAlumnosAñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaGeneroAlumnosActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topAlumnoGradoCursoAñoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // topAlumnoGradoCursoAñoToolStripMenuItem
            // 
            this.topAlumnoGradoCursoAñoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topAlumnoGradoCursoAñoToolStripMenuItem1,
            this.crudAlumnoToolStripMenuItem,
            this.estadísticaCantidadAlumnosAñoToolStripMenuItem,
            this.estadísticaGeneroAlumnosActivosToolStripMenuItem});
            this.topAlumnoGradoCursoAñoToolStripMenuItem.Name = "topAlumnoGradoCursoAñoToolStripMenuItem";
            this.topAlumnoGradoCursoAñoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.topAlumnoGradoCursoAñoToolStripMenuItem.Text = "Menú";
            this.topAlumnoGradoCursoAñoToolStripMenuItem.Click += new System.EventHandler(this.topAlumnoGradoCursoAñoToolStripMenuItem_Click_1);
            // 
            // topAlumnoGradoCursoAñoToolStripMenuItem1
            // 
            this.topAlumnoGradoCursoAñoToolStripMenuItem1.Name = "topAlumnoGradoCursoAñoToolStripMenuItem1";
            this.topAlumnoGradoCursoAñoToolStripMenuItem1.Size = new System.Drawing.Size(263, 22);
            this.topAlumnoGradoCursoAñoToolStripMenuItem1.Text = "TopAlumnoGradoCursoAño";
            this.topAlumnoGradoCursoAñoToolStripMenuItem1.Click += new System.EventHandler(this.topAlumnoGradoCursoAñoToolStripMenuItem1_Click);
            // 
            // crudAlumnoToolStripMenuItem
            // 
            this.crudAlumnoToolStripMenuItem.Name = "crudAlumnoToolStripMenuItem";
            this.crudAlumnoToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.crudAlumnoToolStripMenuItem.Text = "CrudAlumno";
            this.crudAlumnoToolStripMenuItem.Click += new System.EventHandler(this.crudAlumnoToolStripMenuItem_Click_1);
            // 
            // estadísticaCantidadAlumnosAñoToolStripMenuItem
            // 
            this.estadísticaCantidadAlumnosAñoToolStripMenuItem.Name = "estadísticaCantidadAlumnosAñoToolStripMenuItem";
            this.estadísticaCantidadAlumnosAñoToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.estadísticaCantidadAlumnosAñoToolStripMenuItem.Text = "Estadística Cantidad Alumnos Año";
            this.estadísticaCantidadAlumnosAñoToolStripMenuItem.Click += new System.EventHandler(this.estadísticaCantidadAlumnosAñoToolStripMenuItem_Click);
            // 
            // estadísticaGeneroAlumnosActivosToolStripMenuItem
            // 
            this.estadísticaGeneroAlumnosActivosToolStripMenuItem.Name = "estadísticaGeneroAlumnosActivosToolStripMenuItem";
            this.estadísticaGeneroAlumnosActivosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.estadísticaGeneroAlumnosActivosToolStripMenuItem.Text = "Estadística Genero Alumnos Activos";
            this.estadísticaGeneroAlumnosActivosToolStripMenuItem.Click += new System.EventHandler(this.estadísticaGeneroAlumnosActivosToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 313);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "WCF Entity Services - Forms";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem topAlumnoGradoCursoAñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topAlumnoGradoCursoAñoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crudAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaCantidadAlumnosAñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaGeneroAlumnosActivosToolStripMenuItem;
    }
}