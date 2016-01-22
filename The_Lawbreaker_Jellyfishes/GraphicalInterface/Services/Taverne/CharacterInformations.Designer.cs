namespace GraphicalInterface
{
    partial class CharacterInformations
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
            this.LXP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LHealth = new System.Windows.Forms.Label();
            this.LRobustness = new System.Windows.Forms.Label();
            this.LStamina = new System.Windows.Forms.Label();
            this.LDodge = new System.Windows.Forms.Label();
            this.LPhysical = new System.Windows.Forms.Label();
            this.LMagic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BSkills = new System.Windows.Forms.Button();
            this.Retour = new System.Windows.Forms.Button();
            this.LRace = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(90, 0);
            this.LName.Name = "LName";
            this.LName.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 30);
            this.LName.Size = new System.Drawing.Size(68, 25);
            this.LName.TabIndex = 0;
            this.LName.Text = "Name";
            // 
            // LLevel
            // 
            this.LLevel.AutoSize = true;
            this.LLevel.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 20);
            this.LLevel.Location = new System.Drawing.Point(110, 90);
            this.LLevel.Name = "LLevel";
            this.LLevel.Size = new System.Drawing.Size(33, 13);
            this.LLevel.TabIndex = 1;
            this.LLevel.Text = "Level";
            // 
            // LXP
            // 
            this.LXP.AutoSize = true;
            this.LXP.Location = new System.Drawing.Point(110, 150);
            this.LXP.Name = "LXP";
            this.LXP.Size = new System.Drawing.Size(21, 13);
            this.LXP.TabIndex = 2;
            this.LXP.Text = "XP";
            this.LXP.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 20, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "caractéristiques :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "attaque physique";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "attaque magique";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "vie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "esquive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "robustesse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "fatigue";
            // 
            // LHealth
            // 
            this.LHealth.AutoSize = true;
            this.LHealth.Location = new System.Drawing.Point(200, 61);
            this.LHealth.Name = "LHealth";
            this.LHealth.Size = new System.Drawing.Size(22, 13);
            this.LHealth.TabIndex = 9;
            this.LHealth.Text = "vie";
            // 
            // LRobustness
            // 
            this.LRobustness.AutoSize = true;
            this.LRobustness.Location = new System.Drawing.Point(200, 98);
            this.LRobustness.Name = "LRobustness";
            this.LRobustness.Size = new System.Drawing.Size(22, 13);
            this.LRobustness.TabIndex = 10;
            this.LRobustness.Text = "Vie";
            // 
            // LStamina
            // 
            this.LStamina.AutoSize = true;
            this.LStamina.Location = new System.Drawing.Point(200, 138);
            this.LStamina.Name = "LStamina";
            this.LStamina.Size = new System.Drawing.Size(22, 13);
            this.LStamina.TabIndex = 11;
            this.LStamina.Text = "Vie";
            // 
            // LDodge
            // 
            this.LDodge.AutoSize = true;
            this.LDodge.Location = new System.Drawing.Point(200, 177);
            this.LDodge.Name = "LDodge";
            this.LDodge.Size = new System.Drawing.Size(22, 13);
            this.LDodge.TabIndex = 12;
            this.LDodge.Text = "Vie";
            // 
            // LPhysical
            // 
            this.LPhysical.AutoSize = true;
            this.LPhysical.Location = new System.Drawing.Point(200, 216);
            this.LPhysical.Name = "LPhysical";
            this.LPhysical.Size = new System.Drawing.Size(22, 13);
            this.LPhysical.TabIndex = 12;
            this.LPhysical.Text = "Vie";
            // 
            // LMagic
            // 
            this.LMagic.AutoSize = true;
            this.LMagic.Location = new System.Drawing.Point(200, 254);
            this.LMagic.Name = "LMagic";
            this.LMagic.Size = new System.Drawing.Size(22, 13);
            this.LMagic.TabIndex = 12;
            this.LMagic.Text = "Vie";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LMagic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LPhysical);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LDodge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LStamina);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LRobustness);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LHealth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(282, 30);
            this.panel1.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 350);
            this.panel1.TabIndex = 13;
            // 
            // BSkills
            // 
            this.BSkills.BackColor = System.Drawing.Color.Transparent;
            this.BSkills.BackgroundImage = _img;
            this.BSkills.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BSkills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSkills.Size = new System.Drawing.Size(75, 75);
            this.BSkills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSkills.Location = new System.Drawing.Point(600, 0);
            this.BSkills.FlatAppearance.BorderSize = 0;
            this.BSkills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BSkills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSkills.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 30);
            this.BSkills.Location = new System.Drawing.Point(100, 250);
            this.BSkills.Name = "BSkills";
            this.BSkills.TabIndex = 14;
            this.BSkills.UseVisualStyleBackColor = true;
            this.BSkills.Click += new System.EventHandler(this.BSkills_Click);
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
            this.Retour.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 30);
            this.Retour.Name = "Retour";
            this.Retour.TabIndex = 22;
            this.Retour.Text = "retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // LRace
            // 
            this.LRace.AutoSize = true;
            this.LRace.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 20);
            this.LRace.Location = new System.Drawing.Point(110, 50);
            this.LRace.Name = "LRace";
            this.LRace.TabIndex = 23;
            this.LRace.Text = "Race";
            // 
            // CharacterInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LRace);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.BSkills);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LXP);
            this.Controls.Add(this.LLevel);
            this.Controls.Add(this.LName);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "CharacterInformations";
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.IGCharactereManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LLevel;
        private System.Windows.Forms.Label LXP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LHealth;
        private System.Windows.Forms.Label LRobustness;
        private System.Windows.Forms.Label LStamina;
        private System.Windows.Forms.Label LDodge;
        private System.Windows.Forms.Label LPhysical;
        private System.Windows.Forms.Label LMagic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BSkills;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Label LRace;
    }
}
