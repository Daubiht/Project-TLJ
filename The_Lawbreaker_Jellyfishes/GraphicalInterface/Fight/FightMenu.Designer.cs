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
            this.toolStripAttack = new System.Windows.Forms.ToolStripButton();
            this.toolStripDefense = new System.Windows.Forms.ToolStripButton();
            this.toolStripSkills = new System.Windows.Forms.ToolStripDropDownButton();
            this.hgjhgjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghjhgjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghjghToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripInventory = new System.Windows.Forms.ToolStripDropDownButton();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCharName = new System.Windows.Forms.Label();
            this.progressBarHP = new System.Windows.Forms.ProgressBar();
            this.progressBarStamina = new System.Windows.Forms.ProgressBar();
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
            // toolStripAttack
            // 
            this.toolStripAttack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAttack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAttack.Image")));
            this.toolStripAttack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAttack.Name = "toolStripAttack";
            this.toolStripAttack.Size = new System.Drawing.Size(92, 19);
            this.toolStripAttack.Text = "Attaquer";
            this.toolStripAttack.Click += new System.EventHandler(this.toolStripAttack_Click);
            // 
            // toolStripDefense
            // 
            this.toolStripDefense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDefense.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDefense.Image")));
            this.toolStripDefense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDefense.Name = "toolStripDefense";
            this.toolStripDefense.Size = new System.Drawing.Size(92, 19);
            this.toolStripDefense.Text = "Défendre";
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
            this.toolStripSkills.Size = new System.Drawing.Size(93, 19);
            this.toolStripSkills.Text = "Compétences";
            this.toolStripSkills.ToolTipText = "Compétences";
            // 
            // hgjhgjToolStripMenuItem
            // 
            this.hgjhgjToolStripMenuItem.Name = "hgjhgjToolStripMenuItem";
            this.hgjhgjToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.hgjhgjToolStripMenuItem.Text = "hgjhgj";
            // 
            // ghjhgjToolStripMenuItem
            // 
            this.ghjhgjToolStripMenuItem.Name = "ghjhgjToolStripMenuItem";
            this.ghjhgjToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ghjhgjToolStripMenuItem.Text = "ghjhgj";
            // 
            // ghjghToolStripMenuItem
            // 
            this.ghjghToolStripMenuItem.Name = "ghjghToolStripMenuItem";
            this.ghjghToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ghjghToolStripMenuItem.Text = "ghjgh";
            // 
            // dfgdfToolStripMenuItem1
            // 
            this.dfgdfToolStripMenuItem1.Name = "dfgdfToolStripMenuItem1";
            this.dfgdfToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.dfgdfToolStripMenuItem1.Text = "dfgdf";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripInventory});
            this.toolStrip2.Location = new System.Drawing.Point(337, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(73, 71);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripInventory
            // 
            this.toolStripInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripInventory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInventory.Image")));
            this.toolStripInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInventory.Name = "toolStripInventory";
            this.toolStripInventory.Size = new System.Drawing.Size(70, 19);
            this.toolStripInventory.Text = "Inventaire";
            this.toolStripInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fuir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelCharName
            // 
            this.labelCharName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCharName.Location = new System.Drawing.Point(94, 0);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(243, 13);
            this.labelCharName.TabIndex = 3;
            this.labelCharName.Text = "Nom du personnage";
            this.labelCharName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarHP
            // 
            this.progressBarHP.BackColor = System.Drawing.Color.Cyan;
            this.progressBarHP.ForeColor = System.Drawing.Color.Red;
            this.progressBarHP.Location = new System.Drawing.Point(142, 24);
            this.progressBarHP.Name = "progressBarHP";
            this.progressBarHP.Size = new System.Drawing.Size(137, 10);
            this.progressBarHP.TabIndex = 4;
            // 
            // progressBarStamina
            // 
            this.progressBarStamina.BackColor = System.Drawing.Color.Cyan;
            this.progressBarStamina.ForeColor = System.Drawing.Color.Red;
            this.progressBarStamina.Location = new System.Drawing.Point(142, 40);
            this.progressBarStamina.Name = "progressBarStamina";
            this.progressBarStamina.Size = new System.Drawing.Size(137, 10);
            this.progressBarStamina.TabIndex = 5;
            // 
            // FightMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.progressBarStamina);
            this.Controls.Add(this.progressBarHP);
            this.Controls.Add(this.labelCharName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FightMenu";
            this.Size = new System.Drawing.Size(410, 71);
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripInventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCharName;
        private System.Windows.Forms.ToolStripButton toolStripAttack;
        private System.Windows.Forms.ToolStripButton toolStripDefense;
        private System.Windows.Forms.ProgressBar progressBarHP;
        private System.Windows.Forms.ProgressBar progressBarStamina;
    }
}
