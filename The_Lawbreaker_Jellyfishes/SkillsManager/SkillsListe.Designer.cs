namespace SkillsManager
{
    partial class SkillsListe
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
            this.PSkillList = new System.Windows.Forms.Panel();
            this.BSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BAddSkill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBFiltreStats = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.CBRequiredStat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NRequiredStatValue = new System.Windows.Forms.NumericUpDown();
            this.CBRequiredSkill = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NRequiredStatValue)).BeginInit();
            this.SuspendLayout();
            // 
            // PSkillList
            // 
            this.PSkillList.AutoScroll = true;
            this.PSkillList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PSkillList.Location = new System.Drawing.Point(3, 84);
            this.PSkillList.Name = "PSkillList";
            this.PSkillList.Size = new System.Drawing.Size(757, 445);
            this.PSkillList.TabIndex = 0;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(676, 617);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(84, 27);
            this.BSave.TabIndex = 1;
            this.BSave.Text = "Sauvegarder";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des Skills";
            // 
            // BAddSkill
            // 
            this.BAddSkill.Location = new System.Drawing.Point(679, 567);
            this.BAddSkill.Name = "BAddSkill";
            this.BAddSkill.Size = new System.Drawing.Size(75, 23);
            this.BAddSkill.TabIndex = 3;
            this.BAddSkill.Text = "Ajouter";
            this.BAddSkill.UseVisualStyleBackColor = true;
            this.BAddSkill.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trier par Stat :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CBFiltreStats
            // 
            this.CBFiltreStats.FormattingEnabled = true;
            this.CBFiltreStats.Items.AddRange(new object[] {
            "Attaque Physique",
            "Attaque Magique",
            "Vie",
            "Robustesse",
            "Fatigue",
            "Esquive"});
            this.CBFiltreStats.Location = new System.Drawing.Point(222, 57);
            this.CBFiltreStats.Name = "CBFiltreStats";
            this.CBFiltreStats.Size = new System.Drawing.Size(121, 21);
            this.CBFiltreStats.TabIndex = 5;
            this.CBFiltreStats.SelectedIndexChanged += new System.EventHandler(this.CBFiltreStats_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Attaque Magique",
            "Attaque Physique",
            "Esquive",
            "Fatigue",
            "Robustesse",
            "Vie"});
            this.comboBox1.Location = new System.Drawing.Point(475, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trier par Skill :";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(15, 542);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(65, 13);
            this.LError.TabIndex = 8;
            this.LError.Text = "Petite Erreur";
            this.LError.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom :";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(56, 569);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(100, 20);
            this.TName.TabIndex = 10;
            // 
            // CBRequiredStat
            // 
            this.CBRequiredStat.FormattingEnabled = true;
            this.CBRequiredStat.Items.AddRange(new object[] {
            "Attaque Physique",
            "Attaque Magique",
            "Vie",
            "Robustesse",
            "Fatigue",
            "Esquive"});
            this.CBRequiredStat.Location = new System.Drawing.Point(267, 569);
            this.CBRequiredStat.Name = "CBRequiredStat";
            this.CBRequiredStat.Size = new System.Drawing.Size(121, 21);
            this.CBRequiredStat.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stat Requise :";
            // 
            // NRequiredStatValue
            // 
            this.NRequiredStatValue.Location = new System.Drawing.Point(398, 570);
            this.NRequiredStatValue.Name = "NRequiredStatValue";
            this.NRequiredStatValue.Size = new System.Drawing.Size(59, 20);
            this.NRequiredStatValue.TabIndex = 13;
            // 
            // CBRequiredSkill
            // 
            this.CBRequiredSkill.FormattingEnabled = true;
            this.CBRequiredSkill.Items.AddRange(new object[] {
            "Attaque Physique",
            "Attaque Magique",
            "Vie",
            "Robustesse",
            "Fatigue",
            "Esquive"});
            this.CBRequiredSkill.Location = new System.Drawing.Point(95, 595);
            this.CBRequiredSkill.Name = "CBRequiredSkill";
            this.CBRequiredSkill.Size = new System.Drawing.Size(121, 21);
            this.CBRequiredSkill.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Skill Requis :";
            // 
            // SkillsListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBRequiredSkill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NRequiredStatValue);
            this.Controls.Add(this.CBRequiredStat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBFiltreStats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BAddSkill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.PSkillList);
            this.Name = "SkillsListe";
            this.Size = new System.Drawing.Size(763, 647);
            this.Load += new System.EventHandler(this.SkillsListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NRequiredStatValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PSkillList;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BAddSkill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBFiltreStats;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.ComboBox CBRequiredStat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NRequiredStatValue;
        private System.Windows.Forms.ComboBox CBRequiredSkill;
        private System.Windows.Forms.Label label6;
    }
}
