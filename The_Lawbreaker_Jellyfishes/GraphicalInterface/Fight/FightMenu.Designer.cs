namespace GraphicalInterface.Fighting
{
    partial class FightMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSkills = new System.Windows.Forms.ToolStripDropDownButton();
            this.hgjhgjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghjhgjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghjghToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCharName = new System.Windows.Forms.Label();
            this.toolStripDefense = new System.Windows.Forms.ToolStripButton();
            this.toolStripAttack = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAttack,
            this.toolStripDefense,
            this.toolStripSkills});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(94, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSkills
            // 
            this.toolStripSkills.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSkills.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hgjhgjToolStripMenuItem,
            this.ghjhgjToolStripMenuItem,
            this.ghjghToolStripMenuItem,
            this.dfgdfToolStripMenuItem1});
            this.toolStripSkills.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSkills.Image")));
            this.toolStripSkills.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSkills.Name = "toolStripSkills";
            this.toolStripSkills.Size = new System.Drawing.Size(91, 19);
            this.toolStripSkills.Text = "Compétences";
            this.toolStripSkills.ToolTipText = "Compétences";
            // 
            // hgjhgjToolStripMenuItem
            // 
            this.hgjhgjToolStripMenuItem.Name = "hgjhgjToolStripMenuItem";
            this.hgjhgjToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hgjhgjToolStripMenuItem.Text = "hgjhgj";
            // 
            // ghjhgjToolStripMenuItem
            // 
            this.ghjhgjToolStripMenuItem.Name = "ghjhgjToolStripMenuItem";
            this.ghjhgjToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ghjhgjToolStripMenuItem.Text = "ghjhgj";
            // 
            // ghjghToolStripMenuItem
            // 
            this.ghjghToolStripMenuItem.Name = "ghjghToolStripMenuItem";
            this.ghjghToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ghjghToolStripMenuItem.Text = "ghjgh";
            // 
            // dfgdfToolStripMenuItem1
            // 
            this.dfgdfToolStripMenuItem1.Name = "dfgdfToolStripMenuItem1";
            this.dfgdfToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dfgdfToolStripMenuItem1.Text = "dfgdf";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton4});
            this.toolStrip2.Location = new System.Drawing.Point(327, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(73, 71);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(70, 19);
            this.toolStripDropDownButton4.Text = "Inventaire";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fuir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelCharName
            // 
            this.labelCharName.AutoSize = true;
            this.labelCharName.Location = new System.Drawing.Point(155, 11);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(103, 13);
            this.labelCharName.TabIndex = 3;
            this.labelCharName.Text = "Nom du personnage";
            // 
            // toolStripDefense
            // 
            this.toolStripDefense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDefense.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDefense.Image")));
            this.toolStripDefense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDefense.Name = "toolStripDefense";
            this.toolStripDefense.Size = new System.Drawing.Size(91, 19);
            this.toolStripDefense.Text = "Défendre";
            // 
            // toolStripAttack
            // 
            this.toolStripAttack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAttack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAttack.Image")));
            this.toolStripAttack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAttack.Name = "toolStripAttack";
            this.toolStripAttack.Size = new System.Drawing.Size(92, 19);
            this.toolStripAttack.Text = "Attaquer";
            // 
            // FightMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelCharName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FightMenu";
            this.Size = new System.Drawing.Size(400, 71);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSkills;
        private System.Windows.Forms.ToolStripMenuItem hgjhgjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghjhgjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghjghToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgdfToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCharName;
        private System.Windows.Forms.ToolStripButton toolStripAttack;
        private System.Windows.Forms.ToolStripButton toolStripDefense;
    }
}
