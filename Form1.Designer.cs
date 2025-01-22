namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fICHIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOUVEAUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fERMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fICHIERToolStripMenuItem,
            this.rAPPORTToolStripMenuItem,
            this.fERMERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fICHIERToolStripMenuItem
            // 
            this.fICHIERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOUVEAUToolStripMenuItem});
            this.fICHIERToolStripMenuItem.Name = "fICHIERToolStripMenuItem";
            this.fICHIERToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.fICHIERToolStripMenuItem.Text = "FICHIER";
            // 
            // nOUVEAUToolStripMenuItem
            // 
            this.nOUVEAUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDClasseToolStripMenuItem,
            this.cRUDEtudiantToolStripMenuItem});
            this.nOUVEAUToolStripMenuItem.Name = "nOUVEAUToolStripMenuItem";
            this.nOUVEAUToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nOUVEAUToolStripMenuItem.Text = "NOUVEAU";
            // 
            // cRUDClasseToolStripMenuItem
            // 
            this.cRUDClasseToolStripMenuItem.Name = "cRUDClasseToolStripMenuItem";
            this.cRUDClasseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cRUDClasseToolStripMenuItem.Text = "CRUD Classe";
            this.cRUDClasseToolStripMenuItem.Click += new System.EventHandler(this.cRUDClasseToolStripMenuItem_Click);
            // 
            // cRUDEtudiantToolStripMenuItem
            // 
            this.cRUDEtudiantToolStripMenuItem.Name = "cRUDEtudiantToolStripMenuItem";
            this.cRUDEtudiantToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cRUDEtudiantToolStripMenuItem.Text = "CRUD Etudiant";
            this.cRUDEtudiantToolStripMenuItem.Click += new System.EventHandler(this.cRUDEtudiantToolStripMenuItem_Click);
            // 
            // rAPPORTToolStripMenuItem
            // 
            this.rAPPORTToolStripMenuItem.Name = "rAPPORTToolStripMenuItem";
            this.rAPPORTToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.rAPPORTToolStripMenuItem.Text = "RAPPORT";
            // 
            // fERMERToolStripMenuItem
            // 
            this.fERMERToolStripMenuItem.Name = "fERMERToolStripMenuItem";
            this.fERMERToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.fERMERToolStripMenuItem.Text = "FERMER";
            this.fERMERToolStripMenuItem.Click += new System.EventHandler(this.fERMERToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 482);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI PARENT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fICHIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOUVEAUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fERMERToolStripMenuItem;
    }
}

