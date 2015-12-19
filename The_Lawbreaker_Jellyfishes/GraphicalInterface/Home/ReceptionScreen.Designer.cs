namespace GraphicalInterface
{
    partial class ReceptionScreen
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
            this.NewParty = new System.Windows.Forms.Button();
            this.ChargeParty = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewParty
            // 
            this.NewParty.AccessibleName = "";
            this.NewParty.BackColor = System.Drawing.SystemColors.Control;
            this.NewParty.Location = new System.Drawing.Point(0, 0);
            this.NewParty.Name = "NewParty";
            this.NewParty.Size = new System.Drawing.Size(243, 71);
            this.NewParty.TabIndex = 0;
            this.NewParty.Text = "Nouvelle partie";
            this.NewParty.UseVisualStyleBackColor = true;
            this.NewParty.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChargeParty
            // 
            this.ChargeParty.Location = new System.Drawing.Point(0, 108);
            this.ChargeParty.Name = "ChargeParty";
            this.ChargeParty.Size = new System.Drawing.Size(243, 71);
            this.ChargeParty.TabIndex = 1;
            this.ChargeParty.Text = "Charger partie";
            this.ChargeParty.UseVisualStyleBackColor = true;
            this.ChargeParty.Click += new System.EventHandler(this.button2_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(0, 207);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(243, 71);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quitter";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.Leave_Click);
            // 
            // ReceptionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.ChargeParty);
            this.Controls.Add(this.NewParty);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "ReceptionScreen";
            this.Size = new System.Drawing.Size(750, 338);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewParty;
        private System.Windows.Forms.Button ChargeParty;
        private System.Windows.Forms.Button quitButton;
    }
}
