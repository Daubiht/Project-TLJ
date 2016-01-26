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
            this.pictureWax = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWax)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVictory
            // 
            this.labelVictory.AutoSize = true;
            this.labelVictory.Location = new System.Drawing.Point(236, 35);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(57, 13);
            this.labelVictory.TabIndex = 0;
            this.labelVictory.Text = "VICTOIRE";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(548, 73);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Suivant";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // PDrop
            // 
            this.PDrop.Location = new System.Drawing.Point(87, 180);
            this.PDrop.Name = "PDrop";
            this.PDrop.Size = new System.Drawing.Size(348, 70);
            this.PDrop.TabIndex = 2;
            // 
            // LGolds
            // 
            this.LGolds.AutoSize = true;
            this.LGolds.Location = new System.Drawing.Point(236, 102);
            this.LGolds.Name = "LGolds";
            this.LGolds.Size = new System.Drawing.Size(34, 13);
            this.LGolds.TabIndex = 3;
            this.LGolds.Text = "Golds";
            this.LGolds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LGolds.Click += new System.EventHandler(this.LGolds_Click);
            // 
            // LInfo
            // 
            this.LInfo.AutoSize = true;
            this.LInfo.Location = new System.Drawing.Point(219, 73);
            this.LInfo.Name = "LInfo";
            this.LInfo.Size = new System.Drawing.Size(96, 13);
            this.LInfo.TabIndex = 4;
            this.LInfo.Text = "Vous avez gagné :";
            // 
            // LXP
            // 
            this.LXP.AutoSize = true;
            this.LXP.Location = new System.Drawing.Point(222, 128);
            this.LXP.Name = "LXP";
            this.LXP.Size = new System.Drawing.Size(60, 13);
            this.LXP.TabIndex = 5;
            this.LXP.Text = "Experience";
            this.LXP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureWax
            // 
            this.pictureWax.Location = new System.Drawing.Point(524, 129);
            this.pictureWax.Name = "pictureWax";
            this.pictureWax.Size = new System.Drawing.Size(151, 108);
            this.pictureWax.TabIndex = 6;
            this.pictureWax.TabStop = false;
            // 
            // EndFightVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureWax);
            this.Controls.Add(this.LXP);
            this.Controls.Add(this.LInfo);
            this.Controls.Add(this.LGolds);
            this.Controls.Add(this.PDrop);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelVictory);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "EndFightVictory";
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.EndFightVictory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWax)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureWax;
    }
}
