namespace TLJ.UI.Test
{
    partial class MainWindow
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
            this.receptionScreen1 = new TLJ.UI.Test.ReceptionScreen();
            this.SuspendLayout();
            // 
            // receptionScreen1
            // 
            this.receptionScreen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.receptionScreen1.AutoSize = true;
            this.receptionScreen1.Location = new System.Drawing.Point(78, 55);
            this.receptionScreen1.Name = "receptionScreen1";
            this.receptionScreen1.Size = new System.Drawing.Size(246, 281);
            this.receptionScreen1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.receptionScreen1);
            this.Name = "MainWindow";
            this.Text = "The Lawbreakers Jellyfishes";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReceptionScreen receptionScreen1;
    }
}

