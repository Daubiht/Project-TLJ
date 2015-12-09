namespace GraphicalInterface
{
    partial class CreateMainCharacter3
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.RBVitality = new System.Windows.Forms.RadioButton();
            this.RBDefensePosition = new System.Windows.Forms.RadioButton();
            this.RBEffort = new System.Windows.Forms.RadioButton();
            this.RBConcentredHit = new System.Windows.Forms.RadioButton();
            this.RBEnergeticShot = new System.Windows.Forms.RadioButton();
            this.RBInstinct = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATTRIBUTION DE LA PREMIÈRE COMPÉTENCE";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(83, 312);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 32);
            this.buttonBack.TabIndex = 54;
            this.buttonBack.Text = "Retour";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(255, 312);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 32);
            this.buttonNext.TabIndex = 53;
            this.buttonNext.Text = "Valider";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // RBVitality
            // 
            this.RBVitality.AutoSize = true;
            this.RBVitality.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBVitality.Checked = true;
            this.RBVitality.Location = new System.Drawing.Point(164, 63);
            this.RBVitality.Name = "RBVitality";
            this.RBVitality.Size = new System.Drawing.Size(56, 17);
            this.RBVitality.TabIndex = 55;
            this.RBVitality.TabStop = true;
            this.RBVitality.Text = "Vitalité";
            this.RBVitality.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RBVitality.UseVisualStyleBackColor = true;
            // 
            // RBDefensePosition
            // 
            this.RBDefensePosition.AutoSize = true;
            this.RBDefensePosition.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBDefensePosition.Location = new System.Drawing.Point(109, 98);
            this.RBDefensePosition.Name = "RBDefensePosition";
            this.RBDefensePosition.Size = new System.Drawing.Size(111, 17);
            this.RBDefensePosition.TabIndex = 56;
            this.RBDefensePosition.Text = "Position défensive";
            this.RBDefensePosition.UseVisualStyleBackColor = true;
            // 
            // RBEffort
            // 
            this.RBEffort.AutoSize = true;
            this.RBEffort.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBEffort.Location = new System.Drawing.Point(170, 134);
            this.RBEffort.Name = "RBEffort";
            this.RBEffort.Size = new System.Drawing.Size(50, 17);
            this.RBEffort.TabIndex = 57;
            this.RBEffort.Text = "Effort";
            this.RBEffort.UseVisualStyleBackColor = true;
            // 
            // RBConcentredHit
            // 
            this.RBConcentredHit.AutoSize = true;
            this.RBConcentredHit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBConcentredHit.Location = new System.Drawing.Point(105, 169);
            this.RBConcentredHit.Name = "RBConcentredHit";
            this.RBConcentredHit.Size = new System.Drawing.Size(115, 17);
            this.RBConcentredHit.TabIndex = 58;
            this.RBConcentredHit.Text = "Frappe concentrée";
            this.RBConcentredHit.UseVisualStyleBackColor = true;
            // 
            // RBEnergeticShot
            // 
            this.RBEnergeticShot.AutoSize = true;
            this.RBEnergeticShot.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBEnergeticShot.Location = new System.Drawing.Point(124, 204);
            this.RBEnergeticShot.Name = "RBEnergeticShot";
            this.RBEnergeticShot.Size = new System.Drawing.Size(96, 17);
            this.RBEnergeticShot.TabIndex = 59;
            this.RBEnergeticShot.Text = "Tir énergétique";
            this.RBEnergeticShot.UseVisualStyleBackColor = true;
            // 
            // RBInstinct
            // 
            this.RBInstinct.AutoSize = true;
            this.RBInstinct.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBInstinct.Location = new System.Drawing.Point(161, 237);
            this.RBInstinct.Name = "RBInstinct";
            this.RBInstinct.Size = new System.Drawing.Size(59, 17);
            this.RBInstinct.TabIndex = 60;
            this.RBInstinct.Text = "Instinct";
            this.RBInstinct.UseVisualStyleBackColor = true;
            // 
            // CreateMainCharacter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RBInstinct);
            this.Controls.Add(this.RBEnergeticShot);
            this.Controls.Add(this.RBConcentredHit);
            this.Controls.Add(this.RBEffort);
            this.Controls.Add(this.RBDefensePosition);
            this.Controls.Add(this.RBVitality);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label1);
            this.Name = "CreateMainCharacter3";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.RadioButton RBVitality;
        private System.Windows.Forms.RadioButton RBDefensePosition;
        private System.Windows.Forms.RadioButton RBEffort;
        private System.Windows.Forms.RadioButton RBConcentredHit;
        private System.Windows.Forms.RadioButton RBEnergeticShot;
        private System.Windows.Forms.RadioButton RBInstinct;
    }
}
