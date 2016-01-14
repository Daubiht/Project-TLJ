namespace GraphicalInterface
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCharName
            // 
            this.labelCharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCharName.Enabled = false;
            this.labelCharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharName.Location = new System.Drawing.Point(0, 0);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(67, 32);
            this.labelCharName.TabIndex = 0;
            this.labelCharName.Text = "JEROMETE";
            this.labelCharName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHPText
            // 
            this.labelHPText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHPText.AutoSize = true;
            this.labelHPText.Enabled = false;
            this.labelHPText.Location = new System.Drawing.Point(2, 28);
            this.labelHPText.Name = "labelHPText";
            this.labelHPText.Size = new System.Drawing.Size(22, 13);
            this.labelHPText.TabIndex = 1;
            this.labelHPText.Text = "HP";
            // 
            // labelHPResult
            // 
            this.labelHPResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHPResult.AutoSize = true;
            this.labelHPResult.Enabled = false;
            this.labelHPResult.Location = new System.Drawing.Point(42, 28);
            this.labelHPResult.Name = "labelHPResult";
            this.labelHPResult.Size = new System.Drawing.Size(19, 13);
            this.labelHPResult.TabIndex = 2;
            this.labelHPResult.Text = "85";
            // 
            // labelStaminaText
            // 
            this.labelStaminaText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStaminaText.AutoSize = true;
            this.labelStaminaText.Enabled = false;
            this.labelStaminaText.Location = new System.Drawing.Point(2, 46);
            this.labelStaminaText.Name = "labelStaminaText";
            this.labelStaminaText.Size = new System.Drawing.Size(42, 13);
            this.labelStaminaText.TabIndex = 3;
            this.labelStaminaText.Text = "Fatigue";
            // 
            // labelStaminaResult
            // 
            this.labelStaminaResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStaminaResult.AutoSize = true;
            this.labelStaminaResult.Enabled = false;
            this.labelStaminaResult.Location = new System.Drawing.Point(42, 47);
            this.labelStaminaResult.Name = "labelStaminaResult";
            this.labelStaminaResult.Size = new System.Drawing.Size(19, 13);
            this.labelStaminaResult.TabIndex = 4;
            this.labelStaminaResult.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 16);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // PanelCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelStaminaResult);
            this.Controls.Add(this.labelStaminaText);
            this.Controls.Add(this.labelHPResult);
            this.Controls.Add(this.labelHPText);
            this.Controls.Add(this.labelCharName);
            this.Name = "PanelCharacter";
            this.Size = new System.Drawing.Size(67, 62);
            this.Load += new System.EventHandler(this.PanelCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCharName;
        private System.Windows.Forms.Label labelHPText;
        private System.Windows.Forms.Label labelHPResult;
        private System.Windows.Forms.Label labelStaminaText;
        private System.Windows.Forms.Label labelStaminaResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
