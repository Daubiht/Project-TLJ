namespace GraphicalInterface
{
    partial class FightUserControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxBackground
            // 
            this.PictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxBackground.Name = "PictureBoxBackground";
            this.PictureBoxBackground.Size = new System.Drawing.Size(100, 50);
            this.PictureBoxBackground.TabIndex = 0;
            this.PictureBoxBackground.TabStop = false;
            // 
            // FightUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PictureBoxBackground);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "FightUserControl";
            this.Size = new System.Drawing.Size(750, 380);
            this.Load += new System.EventHandler(this.FightUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxBackground;
    }
}
