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
            this.panelInformation = new System.Windows.Forms.Panel();
            this.BarHp = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCharName
            // 
            this.labelCharName.BackColor = System.Drawing.Color.Transparent;
            this.labelCharName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCharName.Enabled = false;
            this.labelCharName.Location = new System.Drawing.Point(0, 0);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(70, 31);
            this.labelCharName.TabIndex = 0;
            this.labelCharName.Text = "JEROMETE";
            this.labelCharName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHPText
            // 
            this.labelHPText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHPText.AutoSize = true;
            this.labelHPText.Enabled = false;
            this.labelHPText.Location = new System.Drawing.Point(4, 70);
            this.labelHPText.Name = "labelHPText";
            this.labelHPText.Size = new System.Drawing.Size(22, 13);
            this.labelHPText.TabIndex = 1;
            this.labelHPText.Text = "HP";
            // 
            // labelHPResult
            // 
            this.labelHPResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHPResult.AutoSize = true;
            this.labelHPResult.Enabled = false;
            this.labelHPResult.Location = new System.Drawing.Point(30, 71);
            this.labelHPResult.Name = "labelHPResult";
            this.labelHPResult.Size = new System.Drawing.Size(19, 13);
            this.labelHPResult.TabIndex = 2;
            this.labelHPResult.Text = "85";
            // 
            // labelStaminaText
            // 
            this.labelStaminaText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStaminaText.AutoSize = true;
            this.labelStaminaText.Enabled = false;
            this.labelStaminaText.Location = new System.Drawing.Point(4, 83);
            this.labelStaminaText.Name = "labelStaminaText";
            this.labelStaminaText.Size = new System.Drawing.Size(42, 13);
            this.labelStaminaText.TabIndex = 3;
            this.labelStaminaText.Text = "Fatigue";
            // 
            // labelStaminaResult
            // 
            this.labelStaminaResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStaminaResult.AutoSize = true;
            this.labelStaminaResult.Enabled = false;
            this.labelStaminaResult.Location = new System.Drawing.Point(42, 84);
            this.labelStaminaResult.Name = "labelStaminaResult";
            this.labelStaminaResult.Size = new System.Drawing.Size(19, 13);
            this.labelStaminaResult.TabIndex = 4;
            this.labelStaminaResult.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 16);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.Transparent;
            this.panelInformation.Controls.Add(this.BarHp);
            this.panelInformation.Controls.Add(this.labelCharName);
            this.panelInformation.Controls.Add(this.labelHPText);
            this.panelInformation.Controls.Add(this.labelStaminaResult);
            this.panelInformation.Controls.Add(this.labelHPResult);
            this.panelInformation.Controls.Add(this.labelStaminaText);
            this.panelInformation.Enabled = false;
            this.panelInformation.Location = new System.Drawing.Point(187, 3);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(70, 100);
            this.panelInformation.TabIndex = 6;
            // 
            // BarHp
            // 
            this.BarHp.Location = new System.Drawing.Point(7, 34);
            this.BarHp.Name = "BarHp";
            this.BarHp.Size = new System.Drawing.Size(54, 10);
            this.BarHp.TabIndex = 5;
            // 
            // PanelCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 9);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PanelCharacter";
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Size = new System.Drawing.Size(274, 142);
            this.Load += new System.EventHandler(this.PanelCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCharName;
        private System.Windows.Forms.Label labelHPText;
        private System.Windows.Forms.Label labelHPResult;
        private System.Windows.Forms.Label labelStaminaText;
        private System.Windows.Forms.Label labelStaminaResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.ProgressBar BarHp;
    }
}
