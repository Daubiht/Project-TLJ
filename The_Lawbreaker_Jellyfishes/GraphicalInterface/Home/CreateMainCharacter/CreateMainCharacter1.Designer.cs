﻿namespace GraphicalInterface
{
    partial class CreateMainCharacter1
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
            this.components = new System.ComponentModel.Container();
            this.Pseudo = new System.Windows.Forms.Label();
            this.PseudoField = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Sex = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Label();
            this.ComboBoxRace = new System.Windows.Forms.ComboBox();
            this.ValidButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ButtonMan = new System.Windows.Forms.RadioButton();
            this.ButtonWoman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pseudo
            // 
            this.Pseudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pseudo.AutoSize = true;
            this.Pseudo.Location = new System.Drawing.Point(100, 98);
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.Size = new System.Drawing.Size(43, 13);
            this.Pseudo.TabIndex = 0;
            this.Pseudo.Text = "Pseudo";
            // 
            // PseudoField
            // 
            this.PseudoField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PseudoField.Location = new System.Drawing.Point(154, 95);
            this.PseudoField.MaxLength = 10;
            this.PseudoField.Name = "PseudoField";
            this.PseudoField.Size = new System.Drawing.Size(134, 20);
            this.PseudoField.TabIndex = 1;
            this.PseudoField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Sex
            // 
            this.Sex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(100, 164);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(31, 13);
            this.Sex.TabIndex = 3;
            this.Sex.Text = "Sexe";
            // 
            // Race
            // 
            this.Race.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Race.AutoSize = true;
            this.Race.Location = new System.Drawing.Point(100, 230);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(33, 13);
            this.Race.TabIndex = 6;
            this.Race.Text = "Race";
            // 
            // ComboBoxRace
            // 
            this.ComboBoxRace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxRace.Location = new System.Drawing.Point(154, 222);
            this.ComboBoxRace.Name = "ComboBoxRace";
            this.ComboBoxRace.Size = new System.Drawing.Size(134, 21);
            this.ComboBoxRace.TabIndex = 7;
            this.ComboBoxRace.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRace_SelectedIndexChanged);
            // 
            // ValidButton
            // 
            this.ValidButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValidButton.BackColor = System.Drawing.SystemColors.Control;
            this.ValidButton.Location = new System.Drawing.Point(213, 321);
            this.ValidButton.Name = "ValidButton";
            this.ValidButton.Size = new System.Drawing.Size(75, 32);
            this.ValidButton.TabIndex = 8;
            this.ValidButton.Text = "Valider";
            this.ValidButton.UseVisualStyleBackColor = true;
            this.ValidButton.Click += new System.EventHandler(this.Valid_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.AutoSize = true;
            this.BackButton.Location = new System.Drawing.Point(103, 321);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Retour";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonMan
            // 
            this.ButtonMan.AutoSize = true;
            this.ButtonMan.Checked = true;
            this.ButtonMan.Location = new System.Drawing.Point(154, 164);
            this.ButtonMan.Name = "ButtonMan";
            this.ButtonMan.Size = new System.Drawing.Size(61, 17);
            this.ButtonMan.TabIndex = 10;
            this.ButtonMan.TabStop = true;
            this.ButtonMan.Text = "Homme";
            this.ButtonMan.UseVisualStyleBackColor = true;
            this.ButtonMan.CheckedChanged += new System.EventHandler(this.ButtonMan_CheckedChanged);
            // 
            // ButtonWoman
            // 
            this.ButtonWoman.AutoSize = true;
            this.ButtonWoman.Location = new System.Drawing.Point(229, 164);
            this.ButtonWoman.Name = "ButtonWoman";
            this.ButtonWoman.Size = new System.Drawing.Size(59, 17);
            this.ButtonWoman.TabIndex = 11;
            this.ButtonWoman.Text = "Femme";
            this.ButtonWoman.UseVisualStyleBackColor = true;
            this.ButtonWoman.CheckedChanged += new System.EventHandler(this.ButtonWoman_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateMainCharacter1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonWoman);
            this.Controls.Add(this.ButtonMan);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ValidButton);
            this.Controls.Add(this.ComboBoxRace);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.PseudoField);
            this.Controls.Add(this.Pseudo);
            this.Name = "CreateMainCharacter1";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pseudo;
        private System.Windows.Forms.TextBox PseudoField;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Race;
        private System.Windows.Forms.ComboBox ComboBoxRace;
        private System.Windows.Forms.Button ValidButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RadioButton ButtonMan;
        private System.Windows.Forms.RadioButton ButtonWoman;
        private System.Windows.Forms.Label label1;
    }
}
