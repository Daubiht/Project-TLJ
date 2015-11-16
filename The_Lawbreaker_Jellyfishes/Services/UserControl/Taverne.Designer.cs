namespace Services
{
    partial class Taverne
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
            this.label1 = new System.Windows.Forms.Label();
            this.LError = new System.Windows.Forms.Label();
            this.GBCharacter = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taverne";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(44, 71);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(316, 13);
            this.LError.TabIndex = 1;
            this.LError.Text = "Votre équipe est pleine, vous ne pouvez plus engager de membre";
            this.LError.Visible = false;
            // 
            // GBCharacter
            // 
            this.GBCharacter.Location = new System.Drawing.Point(3, 87);
            this.GBCharacter.Name = "GBCharacter";
            this.GBCharacter.Size = new System.Drawing.Size(407, 383);
            this.GBCharacter.TabIndex = 2;
            this.GBCharacter.TabStop = false;
            // 
            // Taverne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBCharacter);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.label1);
            this.Name = "Taverne";
            this.Size = new System.Drawing.Size(410, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.GroupBox GBCharacter;
    }
}
