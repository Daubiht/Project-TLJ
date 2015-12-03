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
            this.PTeam.Location = new System.Drawing.Point(3, 54);
            this.PTeam.Name = "PTeam";
            this.PTeam.Size = new System.Drawing.Size(397, 312);
            this.PTeam.TabIndex = 0;
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(322, 372);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 1;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipe";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(7, 35);
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
            this.Controls.Add(this.LError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.PTeam);
            this.Name = "TeamManagement";
            this.Size = new System.Drawing.Size(400, 400);
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
