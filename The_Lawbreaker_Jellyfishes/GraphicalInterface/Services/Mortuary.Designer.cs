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
            this.TCMPage1 = new System.Windows.Forms.GroupBox();
            this.TCMPage2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Morgue";
            this.label1.UseMnemonic = false;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(331, 3);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 23);
            this.retour.TabIndex = 4;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // TCMPage1
            // 
            this.TCMPage1.Location = new System.Drawing.Point(25, 72);
            this.TCMPage1.Name = "TCMPage1";
            this.TCMPage1.Size = new System.Drawing.Size(339, 254);
            this.TCMPage1.TabIndex = 5;
            this.TCMPage1.TabStop = false;
            this.TCMPage1.Text = "Morgue";
            // 
            // TCMPage2
            // 
            this.TCMPage2.BackColor = System.Drawing.Color.Transparent;
            this.TCMPage2.Location = new System.Drawing.Point(401, 72);
            this.TCMPage2.Name = "TCMPage2";
            this.TCMPage2.Size = new System.Drawing.Size(339, 254);
            this.TCMPage2.TabIndex = 6;
            this.TCMPage2.TabStop = false;
            this.TCMPage2.Text = "Equipe";
            // 
            // Mortuary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
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
        private System.Windows.Forms.GroupBox TCMPage1;
        private System.Windows.Forms.GroupBox TCMPage2;
    }
}
