namespace SkillsManager
{
    partial class IGSkill
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
            this.BErase = new System.Windows.Forms.Button();
            this.CBStat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBRequiredSkill = new System.Windows.Forms.ComboBox();
            this.NRequiredStatValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NRequiredStatValue)).BeginInit();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(19, 26);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(55, 20);
            this.LName.TabIndex = 0;
            this.LName.Text = "Name";
            // 
            // BErase
            // 
            this.BErase.Location = new System.Drawing.Point(674, 14);
            this.BErase.Name = "BErase";
            this.BErase.Size = new System.Drawing.Size(43, 40);
            this.BErase.TabIndex = 1;
            this.BErase.Text = "Suppr";
            this.BErase.UseVisualStyleBackColor = true;
            this.BErase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // CBStat
            // 
            this.CBStat.FormattingEnabled = true;
            this.CBStat.Items.AddRange(new object[] {
            "Attaque Physique",
            "Attaque Magique",
            "Vie",
            "Robustesse",
            "Fatigue",
            "Esquive"});
            this.CBStat.Location = new System.Drawing.Point(174, 25);
            this.CBStat.Name = "CBStat";
            this.CBStat.Size = new System.Drawing.Size(121, 21);
            this.CBStat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stat : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Skill Requis : ";
            // 
            // CBRequiredSkill
            // 
            this.CBRequiredSkill.FormattingEnabled = true;
            this.CBRequiredSkill.Location = new System.Drawing.Point(487, 25);
            this.CBRequiredSkill.Name = "CBRequiredSkill";
            this.CBRequiredSkill.Size = new System.Drawing.Size(121, 21);
            this.CBRequiredSkill.TabIndex = 8;
            this.CBRequiredSkill.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NRequiredStatValue
            // 
            this.NRequiredStatValue.Location = new System.Drawing.Point(302, 25);
            this.NRequiredStatValue.Name = "NRequiredStatValue";
            this.NRequiredStatValue.Size = new System.Drawing.Size(54, 20);
            this.NRequiredStatValue.TabIndex = 10;
            this.NRequiredStatValue.ValueChanged += new System.EventHandler(this.NRequiredStatValue_ValueChanged);
            // 
            // IGSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NRequiredStatValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBRequiredSkill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBStat);
            this.Controls.Add(this.BErase);
            this.Controls.Add(this.LName);
            this.Name = "IGSkill";
            this.Size = new System.Drawing.Size(730, 69);
            this.Load += new System.EventHandler(this.IGSkill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NRequiredStatValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Button BErase;
        private System.Windows.Forms.ComboBox CBStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBRequiredSkill;
        private System.Windows.Forms.NumericUpDown NRequiredStatValue;
    }
}
