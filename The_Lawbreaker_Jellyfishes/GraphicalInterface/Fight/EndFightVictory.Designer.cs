namespace GraphicalInterface
{
    partial class EndFightVictory
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
            if ( disposing && (components != null) )
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
            this.labelVictory = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.PDrop = new System.Windows.Forms.Panel();
            this.LGolds = new System.Windows.Forms.Label();
            this.LInfo = new System.Windows.Forms.Label();
            this.LXP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVictory
            // 
            this.labelVictory.AutoSize = true;
            this.labelVictory.Location = new System.Drawing.Point(156, 35);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(57, 13);
            this.labelVictory.TabIndex = 0;
            this.labelVictory.Text = "VICTOIRE";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(298, 349);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Suivant";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // PDrop
            // 
            this.PDrop.Location = new System.Drawing.Point(18, 151);
            this.PDrop.Name = "PDrop";
            this.PDrop.Size = new System.Drawing.Size(355, 182);
            this.PDrop.TabIndex = 2;
            // 
            // LGolds
            // 
            this.LGolds.AutoSize = true;
            this.LGolds.Location = new System.Drawing.Point(167, 103);
            this.LGolds.Name = "LGolds";
            this.LGolds.Size = new System.Drawing.Size(34, 13);
            this.LGolds.TabIndex = 3;
            this.LGolds.Text = "Golds";
            this.LGolds.Click += new System.EventHandler(this.LGolds_Click);
            // 
            // LInfo
            // 
            this.LInfo.AutoSize = true;
            this.LInfo.Location = new System.Drawing.Point(139, 73);
            this.LInfo.Name = "LInfo";
            this.LInfo.Size = new System.Drawing.Size(96, 13);
            this.LInfo.TabIndex = 4;
            this.LInfo.Text = "Vous avez gagné :";
            // 
            // LXP
            // 
            this.LXP.AutoSize = true;
            this.LXP.Location = new System.Drawing.Point(153, 129);
            this.LXP.Name = "LXP";
            this.LXP.Size = new System.Drawing.Size(60, 13);
            this.LXP.TabIndex = 5;
            this.LXP.Text = "Experience";
            // 
            // EndFightVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LXP);
            this.Controls.Add(this.LInfo);
            this.Controls.Add(this.LGolds);
            this.Controls.Add(this.PDrop);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelVictory);
            this.Name = "EndFightVictory";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.EndFightVictory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel PDrop;
        private System.Windows.Forms.Label LGolds;
        private System.Windows.Forms.Label LInfo;
        private System.Windows.Forms.Label LXP;
    }
}
