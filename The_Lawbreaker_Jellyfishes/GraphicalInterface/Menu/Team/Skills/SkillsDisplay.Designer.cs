using System.Drawing;

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
            this.LSkillPoint = new System.Windows.Forms.Label();
            this.BAP = new System.Windows.Forms.Button();
            this.BAM = new System.Windows.Forms.Button();
            this.BV = new System.Windows.Forms.Button();
            this.BF = new System.Windows.Forms.Button();
            this.BR = new System.Windows.Forms.Button();
            this.BE = new System.Windows.Forms.Button();
            this.PSkills = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LSkillPoint
            // 
            this.LSkillPoint.BackColor = System.Drawing.Color.Transparent;
            this.LSkillPoint.Font = new System.Drawing.Font(_font.Families[1], 16);
            this.LSkillPoint.AutoSize = true;
            this.LSkillPoint.Location = new System.Drawing.Point(47, 39);
            this.LSkillPoint.Name = "LSkillPoint";
            this.LSkillPoint.Size = new System.Drawing.Size(50, 13);
            this.LSkillPoint.TabIndex = 1;
            this.LSkillPoint.Text = "SkillPoint";
            // 
            // BAP
            // 
            this.BAP.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.BAP.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAP.BackColor = System.Drawing.Color.Transparent;
            this.BAP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAP.Font = new System.Drawing.Font(_font.Families[0], 16);
            this.BAP.Location = new System.Drawing.Point(18, 128);
            this.BAP.Name = "BAP";
            this.BAP.Size = new System.Drawing.Size(157, 40);
            this.BAP.TabIndex = 2;
            this.BAP.Tag = "0";
            this.BAP.Text = "attaque physique";
            this.BAP.UseVisualStyleBackColor = true;
            this.BAP.Click += new System.EventHandler(this.SkillsTab_SelectedIndexChanged);
            // 
            // BAM
            // 
            this.BAM.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.BAM.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAM.BackColor = System.Drawing.Color.Transparent;
            this.BAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAM.Font = new System.Drawing.Font(_font.Families[0], 16);
            this.BAM.Location = new System.Drawing.Point(18, 176);
            this.BAM.Name = "BAM";
            this.BAM.Size = new System.Drawing.Size(157, 40);
            this.BAM.TabIndex = 3;
            this.BAM.Tag = "1";
            this.BAM.Text = "attaque magique";
            this.BAM.UseVisualStyleBackColor = true;
            this.BAM.Click += new System.EventHandler(this.SkillsTab_SelectedIndexChanged);
            // 
            // BV
            //
            this.BV.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.BV.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BV.BackColor = System.Drawing.Color.Transparent;
            this.BV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BV.Font = new System.Drawing.Font(_font.Families[0], 16);
            this.BV.Location = new System.Drawing.Point(18, 227);
            this.BV.Name = "BV";
            this.BV.Size = new System.Drawing.Size(157, 40);
            this.BV.TabIndex = 4;
            this.BV.Tag = "2";
            this.BV.Text = "vie";
            this.BV.UseVisualStyleBackColor = true;
            this.BV.Click += new System.EventHandler(this.SkillsTab_SelectedIndexChanged);
            // 
            // BF
            // 
            this.BF.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.BF.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BF.BackColor = System.Drawing.Color.Transparent;
            this.BF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BF.Font = new System.Drawing.Font(_font.Families[0], 16);
            this.BF.Location = new System.Drawing.Point(18, 281);
            this.BF.Name = "BF";
            this.BF.Size = new System.Drawing.Size(157, 40);
            this.BF.TabIndex = 5;
            this.BF.Tag = "3";
            this.BF.Text = "fatigue";
            this.BF.UseVisualStyleBackColor = true;
            this.BF.Click += new System.EventHandler(this.SkillsTab_SelectedIndexChanged);
            // 
            // BR
            // 
            this.BR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.BR.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BR.BackColor = System.Drawing.Color.Transparent;
            this.BR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BR.Font = new System.Drawing.Font(_font.Families[0], 16);
            this.BR.Location = new System.Drawing.Point(18, 331);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(157, 40);
            this.BR.TabIndex = 6;
            this.BR.Tag = "4";
            this.BR.Text = "robustesse";
            this.BR.UseVisualStyleBackColor = true;
            this.BR.Click += new System.EventHandler(this.SkillsTab_SelectedIndexChanged);
            // 
            // BE
            // 
            this.BE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.BE.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BE.BackColor = System.Drawing.Color.Transparent;
            this.BE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BE.Font = new System.Drawing.Font(_font.Families[0], 16);
            this.BE.Location = new System.Drawing.Point(18, 388);
            this.BE.Name = "BE";
            this.BE.Size = new System.Drawing.Size(157, 40);
            this.BE.TabIndex = 7;
            this.BE.Tag = "5";
            this.BE.Text = "esquive";
            this.BE.UseVisualStyleBackColor = true;
            this.BE.Click += new System.EventHandler(this.SkillsTab_SelectedIndexChanged);
            // 
            // PSkills
            // 
            this.PSkills.AutoScroll = true;
            this.PSkills.Location = new System.Drawing.Point(176, 60);
            this.PSkills.Name = "PSkills";
            this.PSkills.Size = new System.Drawing.Size(500, 513);
            this.PSkills.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font(_font.Families[1], 19);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Arbre de Competences";
            // 
            // SkillsDisplay
            // 
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skillsForm));

            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PSkills);
            this.Controls.Add(this.BE);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.BF);
            this.Controls.Add(this.BV);
            this.Controls.Add(this.BAM);
            this.Controls.Add(this.BAP);
            this.Controls.Add(this.LSkillPoint);
            this.Name = "SkillsDisplay";
            this.Size = new System.Drawing.Size(707, 576);
            this.Load += new System.EventHandler(this.SkillTree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LSkillPoint;
        private System.Windows.Forms.Button BAP;
        private System.Windows.Forms.Button BAM;
        private System.Windows.Forms.Button BV;
        private System.Windows.Forms.Button BF;
        private System.Windows.Forms.Button BR;
        private System.Windows.Forms.Button BE;
        private System.Windows.Forms.Panel PSkills;
        private System.Windows.Forms.Label label1;
    }
}
