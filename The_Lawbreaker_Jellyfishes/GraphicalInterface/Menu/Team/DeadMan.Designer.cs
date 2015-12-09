namespace GraphicalInterface
{
    partial class DeadMan
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
            this.button1 = new System.Windows.Forms.Button();
            this.LName = new System.Windows.Forms.Label();
            this.LLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resuciter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Resurection_Click);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(12, 17);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name";
            // 
            // LLevel
            // 
            this.LLevel.AutoSize = true;
            this.LLevel.Location = new System.Drawing.Point(115, 17);
            this.LLevel.Name = "LLevel";
            this.LLevel.Size = new System.Drawing.Size(33, 13);
            this.LLevel.TabIndex = 2;
            this.LLevel.Text = "Level";
            // 
            // DeadMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LLevel);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.button1);
            this.Name = "DeadMan";
            this.Size = new System.Drawing.Size(302, 47);
            this.Load += new System.EventHandler(this.DeadMan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LLevel;
    }
}
