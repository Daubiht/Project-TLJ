namespace GraphicalInterface
{
    partial class SkillsTree
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
            this.LError = new System.Windows.Forms.Label();
            this.PanelToCenter = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(3, 0);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(29, 13);
            this.LError.TabIndex = 2;
            this.LError.Text = "Error";
            this.LError.Visible = false;
            // 
            // PanelToCenter
            // 
            this.PanelToCenter.AutoScroll = true;
            this.PanelToCenter.AutoSize = true;
            this.PanelToCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelToCenter.Location = new System.Drawing.Point(52, 13);
            this.PanelToCenter.Name = "PanelToCenter";
            this.PanelToCenter.Size = new System.Drawing.Size(0, 0);
            this.PanelToCenter.TabIndex = 3;
            // 
            // SkillsTree
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.PanelToCenter);
            this.Controls.Add(this.LError);
            this.Name = "SkillsTree";
            this.Size = new System.Drawing.Size(491, 508);
            this.Load += new System.EventHandler(this.SkillsTree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.Panel PanelToCenter;
    }
}
