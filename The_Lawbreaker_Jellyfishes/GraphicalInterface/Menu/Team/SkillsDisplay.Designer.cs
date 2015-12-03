namespace GraphicalInterface
{
    partial class SkillsDisplay
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
            this.SkillsTab = new System.Windows.Forms.TabControl();
            this.PagePA = new System.Windows.Forms.TabPage();
            this.MA = new System.Windows.Forms.TabPage();
            this.PageH = new System.Windows.Forms.TabPage();
            this.PageS = new System.Windows.Forms.TabPage();
            this.PageR = new System.Windows.Forms.TabPage();
            this.PageD = new System.Windows.Forms.TabPage();
            this.LSkillPoint = new System.Windows.Forms.Label();
            this.SkillsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SkillsTab
            // 
            this.SkillsTab.Controls.Add(this.PagePA);
            this.SkillsTab.Controls.Add(this.MA);
            this.SkillsTab.Controls.Add(this.PageH);
            this.SkillsTab.Controls.Add(this.PageS);
            this.SkillsTab.Controls.Add(this.PageR);
            this.SkillsTab.Controls.Add(this.PageD);
            this.SkillsTab.Location = new System.Drawing.Point(3, 39);
            this.SkillsTab.Name = "SkillsTab";
            this.SkillsTab.SelectedIndex = 0;
            this.SkillsTab.Size = new System.Drawing.Size(701, 537);
            this.SkillsTab.TabIndex = 0;
            this.SkillsTab.SelectedIndexChanged += new System.EventHandler(this.SkillsTab_SelectedIndexChanged);
            // 
            // PagePA
            // 
            this.PagePA.Location = new System.Drawing.Point(4, 22);
            this.PagePA.Name = "PagePA";
            this.PagePA.Padding = new System.Windows.Forms.Padding(3);
            this.PagePA.Size = new System.Drawing.Size(693, 511);
            this.PagePA.TabIndex = 0;
            this.PagePA.Tag = "0";
            this.PagePA.Text = "Attaque Physique";
            this.PagePA.UseVisualStyleBackColor = true;
            // 
            // MA
            // 
            this.MA.Location = new System.Drawing.Point(4, 22);
            this.MA.Name = "MA";
            this.MA.Padding = new System.Windows.Forms.Padding(3);
            this.MA.Size = new System.Drawing.Size(693, 511);
            this.MA.TabIndex = 1;
            this.MA.Tag = "1";
            this.MA.Text = "Attaque Magique";
            this.MA.UseVisualStyleBackColor = true;
            // 
            // PageH
            // 
            this.PageH.Location = new System.Drawing.Point(4, 22);
            this.PageH.Name = "PageH";
            this.PageH.Padding = new System.Windows.Forms.Padding(3);
            this.PageH.Size = new System.Drawing.Size(693, 511);
            this.PageH.TabIndex = 2;
            this.PageH.Tag = "2";
            this.PageH.Text = "Vie";
            this.PageH.UseVisualStyleBackColor = true;
            // 
            // PageS
            // 
            this.PageS.Location = new System.Drawing.Point(4, 22);
            this.PageS.Name = "PageS";
            this.PageS.Padding = new System.Windows.Forms.Padding(3);
            this.PageS.Size = new System.Drawing.Size(693, 511);
            this.PageS.TabIndex = 3;
            this.PageS.Tag = "3";
            this.PageS.Text = "Fatigue";
            this.PageS.UseVisualStyleBackColor = true;
            // 
            // PageR
            // 
            this.PageR.Location = new System.Drawing.Point(4, 22);
            this.PageR.Name = "PageR";
            this.PageR.Padding = new System.Windows.Forms.Padding(3);
            this.PageR.Size = new System.Drawing.Size(693, 511);
            this.PageR.TabIndex = 4;
            this.PageR.Tag = "4";
            this.PageR.Text = "Robustesse";
            this.PageR.UseVisualStyleBackColor = true;
            // 
            // PageD
            // 
            this.PageD.Location = new System.Drawing.Point(4, 22);
            this.PageD.Name = "PageD";
            this.PageD.Padding = new System.Windows.Forms.Padding(3);
            this.PageD.Size = new System.Drawing.Size(693, 511);
            this.PageD.TabIndex = 5;
            this.PageD.Tag = "5";
            this.PageD.Text = "Esquive";
            this.PageD.UseVisualStyleBackColor = true;
            // 
            // LSkillPoint
            // 
            this.LSkillPoint.AutoSize = true;
            this.LSkillPoint.Location = new System.Drawing.Point(607, 23);
            this.LSkillPoint.Name = "LSkillPoint";
            this.LSkillPoint.Size = new System.Drawing.Size(50, 13);
            this.LSkillPoint.TabIndex = 1;
            this.LSkillPoint.Text = "SkillPoint";
            // 
            // SkillsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LSkillPoint);
            this.Controls.Add(this.SkillsTab);
            this.Name = "SkillsDisplay";
            this.Size = new System.Drawing.Size(707, 576);
            this.Load += new System.EventHandler(this.SkillTree_Load);
            this.SkillsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl SkillsTab;
        private System.Windows.Forms.TabPage PagePA;
        private System.Windows.Forms.TabPage MA;
        private System.Windows.Forms.TabPage PageH;
        private System.Windows.Forms.TabPage PageS;
        private System.Windows.Forms.TabPage PageR;
        private System.Windows.Forms.TabPage PageD;
        private System.Windows.Forms.Label LSkillPoint;
    }
}
