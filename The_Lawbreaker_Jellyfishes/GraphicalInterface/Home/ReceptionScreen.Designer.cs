using GraphicalInterface.Properties;

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
            this.NewParty.AutoSize = true;
            this.NewParty.BackColor = System.Drawing.Color.Transparent;
            this.NewParty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewParty.FlatAppearance.BorderSize = 0;
            this.NewParty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewParty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewParty.Font = new System.Drawing.Font(_context.Font.Families[0], 35);
            this.NewParty.Name = "NewParty";
            this.NewParty.Size = new System.Drawing.Size(88, 23);
            this.NewParty.TabIndex = 0;
            this.NewParty.Text = "Nouvelle partie";
            this.NewParty.Location = new System.Drawing.Point(0, 0);
            this.NewParty.UseVisualStyleBackColor = false;
            this.NewParty.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChargeParty
            // 
            this.ChargeParty.AutoSize = true;
            this.ChargeParty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChargeParty.FlatAppearance.BorderSize = 0;
            this.ChargeParty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChargeParty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChargeParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChargeParty.Font = new System.Drawing.Font(_context.Font.Families[0], 35);
            this.ChargeParty.Name = "ChargeParty";
            this.ChargeParty.Size = new System.Drawing.Size(83, 23);
            this.ChargeParty.TabIndex = 0;
            this.ChargeParty.Text = "Charger partie";
            this.ChargeParty.Location = new System.Drawing.Point(0, 0);
            this.ChargeParty.UseVisualStyleBackColor = false;
            this.ChargeParty.Click += new System.EventHandler(this.button2_Click);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font(_context.Font.Families[0], 35);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quitter";
            this.quitButton.Location = new System.Drawing.Point(0, 0);
            this.quitButton.UseVisualStyleBackColor = false;
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewParty;
        private System.Windows.Forms.Button ChargeParty;
        private System.Windows.Forms.Button quitButton;
    }
}
