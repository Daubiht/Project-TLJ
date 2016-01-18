namespace GraphicalInterface
{
    partial class TeamManagement
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
            this.PTeam = new System.Windows.Forms.Panel();
            this.Retour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PTeam
            // 
            this.PTeam.Location = new System.Drawing.Point(50, 56);
            this.PTeam.Name = "PTeam";
            this.PTeam.Size = new System.Drawing.Size(651, 279);
            this.PTeam.TabIndex = 0;
            // 
            // Retour
            // 
            this.Retour.AutoSize = true;
            this.Retour.BackColor = System.Drawing.Color.Transparent;
            this.Retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Retour.Location = new System.Drawing.Point(600, 0);
            this.Retour.FlatAppearance.BorderSize = 0;
            this.Retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retour.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 30);
            this.Retour.Name = "retour";
            this.Retour.TabIndex = 3;
            this.Retour.Text = "retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipe";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(175, 36);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(29, 13);
            this.LError.TabIndex = 3;
            this.LError.Text = "Error";
            this.LError.Visible = false;
            // 
            // TeamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.PTeam);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "TeamManagement";
            this.Size = new System.Drawing.Size(750, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PTeam;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LError;
    }
}
