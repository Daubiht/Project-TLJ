namespace GraphicalInterface.Services
{
    partial class CharacterBar
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
            this.LName = new System.Windows.Forms.Label();
            this.LLevel = new System.Windows.Forms.Label();
            this.PBHealth = new System.Windows.Forms.ProgressBar();
            this.PBStamina = new System.Windows.Forms.ProgressBar();
            this.BInfos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(3, 21);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(41, 15);
            this.LName.TabIndex = 0;
            this.LName.Text = "Name";
            // 
            // LLevel
            // 
            this.LLevel.AutoSize = true;
            this.LLevel.Location = new System.Drawing.Point(64, 23);
            this.LLevel.Name = "LLevel";
            this.LLevel.Size = new System.Drawing.Size(33, 13);
            this.LLevel.TabIndex = 1;
            this.LLevel.Text = "Level";
            // 
            // PBHealth
            // 
            this.PBHealth.Location = new System.Drawing.Point(176, 10);
            this.PBHealth.Maximum = 147;
            this.PBHealth.Name = "PBHealth";
            this.PBHealth.Size = new System.Drawing.Size(100, 16);
            this.PBHealth.TabIndex = 2;
            // 
            // PBStamina
            // 
            this.PBStamina.Location = new System.Drawing.Point(176, 35);
            this.PBStamina.Name = "PBStamina";
            this.PBStamina.Size = new System.Drawing.Size(100, 16);
            this.PBStamina.TabIndex = 3;
            // 
            // BInfos
            // 
            this.BInfos.Location = new System.Drawing.Point(343, 11);
            this.BInfos.Name = "BInfos";
            this.BInfos.Size = new System.Drawing.Size(47, 37);
            this.BInfos.TabIndex = 4;
            this.BInfos.Text = "Infos";
            this.BInfos.UseVisualStyleBackColor = true;
            this.BInfos.Click += new System.EventHandler(this.Info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fatigue :";
            // 
            // BPosition
            // 
            this.BPosition.Location = new System.Drawing.Point(290, 12);
            this.BPosition.Name = "BPosition";
            this.BPosition.Size = new System.Drawing.Size(47, 37);
            this.BPosition.TabIndex = 7;
            this.BPosition.Text = "Infos";
            this.BPosition.UseVisualStyleBackColor = true;
            this.BPosition.Click += new System.EventHandler(this.BPosition_Click);
            // 
            // CharacterBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BInfos);
            this.Controls.Add(this.PBStamina);
            this.Controls.Add(this.PBHealth);
            this.Controls.Add(this.LLevel);
            this.Controls.Add(this.LName);
            this.Name = "CharacterBar";
            this.Size = new System.Drawing.Size(396, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LLevel;
        private System.Windows.Forms.ProgressBar PBHealth;
        private System.Windows.Forms.ProgressBar PBStamina;
        private System.Windows.Forms.Button BInfos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BPosition;
    }
}
