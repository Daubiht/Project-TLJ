namespace GraphicalInterface
{
    public partial class Mortuary
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
            this.retour = new System.Windows.Forms.Button();
            this.TCMPage1 = new System.Windows.Forms.Panel();
            this.equipe = new System.Windows.Forms.Label();
            this.TCMPage2 = new System.Windows.Forms.Panel();
            this.morgue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Morgue";
            // 
            // retour
            // 
            this.retour.AutoSize = true;
            this.retour.BackColor = System.Drawing.Color.Transparent;
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 30);
            this.retour.Location = new System.Drawing.Point(600, 0);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(134, 72);
            this.retour.TabIndex = 0;
            this.retour.Text = "retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // TCMPage1
            // 
            this.TCMPage1.BackColor = System.Drawing.Color.Transparent;
            this.TCMPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCMPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TCMPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TCMPage1.Location = new System.Drawing.Point(25, 72);
            this.TCMPage1.Name = "TCMPage1";
            this.TCMPage1.Size = new System.Drawing.Size(339, 264);
            this.TCMPage1.TabIndex = 5;
            // 
            // equipe
            // 
            this.equipe.AutoSize = true;
            this.equipe.Location = new System.Drawing.Point(692, 56);
            this.equipe.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 18);
            this.equipe.Name = "equipe";
            this.equipe.Size = new System.Drawing.Size(39, 13);
            this.equipe.TabIndex = 2;
            this.equipe.Text = "equipe";
            // 
            // TCMPage2
            // 
            this.TCMPage2.BackColor = System.Drawing.Color.Transparent;
            this.TCMPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCMPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TCMPage2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TCMPage2.Location = new System.Drawing.Point(401, 72);
            this.TCMPage2.Name = "TCMPage2";
            this.TCMPage2.Size = new System.Drawing.Size(339, 264);
            this.TCMPage2.TabIndex = 6;
            // 
            // morgue
            // 
            this.morgue.AutoSize = true;
            this.morgue.Location = new System.Drawing.Point(310, 56);
            this.morgue.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 18);
            this.morgue.Name = "morgue";
            this.morgue.Size = new System.Drawing.Size(42, 13);
            this.morgue.TabIndex = 2;
            this.morgue.Text = "morgue";
            // 
            // Mortuary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.morgue);
            this.Controls.Add(this.equipe);
            this.Controls.Add(this.TCMPage2);
            this.Controls.Add(this.TCMPage1);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "Mortuary";
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.Mortuary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Panel TCMPage1;
        private System.Windows.Forms.Panel TCMPage2;
        private System.Windows.Forms.Label equipe;
        private System.Windows.Forms.Label morgue;
    }
}
