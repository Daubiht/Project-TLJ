﻿namespace GraphicalInterface
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
            this.retour = new System.Windows.Forms.Button();
            this.PTavern = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taverne";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(-2, 70);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(316, 13);
            this.LError.TabIndex = 1;
            this.LError.Text = "Votre équipe est au complet.";
            this.LError.Visible = false;
            // 
            // retour
            // 
            this.retour.AutoSize = true;
            this.retour.BackColor = System.Drawing.Color.Transparent;
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.Location = new System.Drawing.Point(600, 0);
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 30);
            this.retour.Name = "retour";
            this.retour.TabIndex = 3;
            this.retour.Text = "retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // PTavern
            // 
            this.PTavern.AutoScroll = true;
            this.PTavern.Location = new System.Drawing.Point(340, 50);
            this.PTavern.Name = "PTavern";
            this.PTavern.Size = new System.Drawing.Size(525, 319);
            this.PTavern.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 0);
            this.label2.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Taverne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PTavern);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.label1);
            this.Name = "Taverne";
            this.Location = new System.Drawing.Point(60, 50);
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.Taverne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Panel PTavern;
        private System.Windows.Forms.Label label2;
    }
}
