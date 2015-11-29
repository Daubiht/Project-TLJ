namespace GraphicalInterface.Fight
{
    partial class PanelCharacter
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
            this.labelCharName = new System.Windows.Forms.Label();
            this.labelHPText = new System.Windows.Forms.Label();
            this.labelHPResult = new System.Windows.Forms.Label();
            this.labelStaminaText = new System.Windows.Forms.Label();
            this.labelStaminaResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCharName
            // 
            this.labelCharName.AutoSize = true;
            this.labelCharName.Location = new System.Drawing.Point(3, 0);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(103, 13);
            this.labelCharName.TabIndex = 0;
            this.labelCharName.Text = "Nom du personnage";
            // 
            // labelHPText
            // 
            this.labelHPText.AutoSize = true;
            this.labelHPText.Location = new System.Drawing.Point(15, 25);
            this.labelHPText.Name = "labelHPText";
            this.labelHPText.Size = new System.Drawing.Size(22, 13);
            this.labelHPText.TabIndex = 1;
            this.labelHPText.Text = "HP";
            // 
            // labelHPResult
            // 
            this.labelHPResult.AutoSize = true;
            this.labelHPResult.Location = new System.Drawing.Point(63, 25);
            this.labelHPResult.Name = "labelHPResult";
            this.labelHPResult.Size = new System.Drawing.Size(19, 13);
            this.labelHPResult.TabIndex = 2;
            this.labelHPResult.Text = "85";
            // 
            // labelStaminaText
            // 
            this.labelStaminaText.AutoSize = true;
            this.labelStaminaText.Location = new System.Drawing.Point(15, 48);
            this.labelStaminaText.Name = "labelStaminaText";
            this.labelStaminaText.Size = new System.Drawing.Size(42, 13);
            this.labelStaminaText.TabIndex = 3;
            this.labelStaminaText.Text = "Fatigue";
            // 
            // labelStaminaResult
            // 
            this.labelStaminaResult.AutoSize = true;
            this.labelStaminaResult.Location = new System.Drawing.Point(63, 48);
            this.labelStaminaResult.Name = "labelStaminaResult";
            this.labelStaminaResult.Size = new System.Drawing.Size(19, 13);
            this.labelStaminaResult.TabIndex = 4;
            this.labelStaminaResult.Text = "10";
            // 
            // PanelCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelStaminaResult);
            this.Controls.Add(this.labelStaminaText);
            this.Controls.Add(this.labelHPResult);
            this.Controls.Add(this.labelHPText);
            this.Controls.Add(this.labelCharName);
            this.Name = "PanelCharacter";
            this.Size = new System.Drawing.Size(108, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCharName;
        private System.Windows.Forms.Label labelHPText;
        private System.Windows.Forms.Label labelHPResult;
        private System.Windows.Forms.Label labelStaminaText;
        private System.Windows.Forms.Label labelStaminaResult;
    }
}
