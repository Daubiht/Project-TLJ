namespace GraphicalInterface
{
    partial class CreateMainCharacter2
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
            this.Stats = new System.Windows.Forms.Label();
            this.TextLife = new System.Windows.Forms.Label();
            this.TextRobustness = new System.Windows.Forms.Label();
            this.TextDodge = new System.Windows.Forms.Label();
            this.TextStamina = new System.Windows.Forms.Label();
            this.TextPhysicalDamage = new System.Windows.Forms.Label();
            this.TextMagicDamage = new System.Windows.Forms.Label();
            this.assignedStats = new System.Windows.Forms.Label();
            this.resultatVie = new System.Windows.Forms.Label();
            this.resultatRobustesse = new System.Windows.Forms.Label();
            this.resultatFatigue = new System.Windows.Forms.Label();
            this.resultatAttaquePhysique = new System.Windows.Forms.Label();
            this.resultatAttaqueMagique = new System.Windows.Forms.Label();
            this.resultatEsquive = new System.Windows.Forms.Label();
            this.mVie = new System.Windows.Forms.Button();
            this.mRobustesse = new System.Windows.Forms.Button();
            this.mFatigue = new System.Windows.Forms.Button();
            this.mAttaquePhysique = new System.Windows.Forms.Button();
            this.mAttaqueMagique = new System.Windows.Forms.Button();
            this.mEsquive = new System.Windows.Forms.Button();
            this.pVie = new System.Windows.Forms.Button();
            this.pRobustesse = new System.Windows.Forms.Button();
            this.pFatigue = new System.Windows.Forms.Button();
            this.pAttaquePhysique = new System.Windows.Forms.Button();
            this.pAttaqueMagique = new System.Windows.Forms.Button();
            this.pEsquive = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stats
            // 
            this.Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Stats.AutoSize = true;
            this.Stats.Font = new System.Drawing.Font(_context.Font.Families[1], 30);
            this.Stats.Location = new System.Drawing.Point(175, 0);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(128, 13);
            this.Stats.TabIndex = 1;
            this.Stats.Text = "attribution des statistiques";
            // 
            // TextLife
            // 
            this.TextLife.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLife.AutoSize = true;
            this.TextLife.Font = new System.Drawing.Font(_context.Font.Families[0], 18);
            this.TextLife.Location = new System.Drawing.Point(120, 59);
            this.TextLife.Name = "TextLife";
            this.TextLife.Padding = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.TextLife.Size = new System.Drawing.Size(87, 13);
            this.TextLife.TabIndex = 2;
            this.TextLife.Text = "vie";
            // 
            // TextRobustness
            // 
            this.TextRobustness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextRobustness.AutoSize = true;
            this.TextRobustness.Font = new System.Drawing.Font(_context.Font.Families[0], 18);
            this.TextRobustness.Location = new System.Drawing.Point(120, 137);
            this.TextRobustness.Name = "TextRobustness";
            this.TextRobustness.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.TextRobustness.Size = new System.Drawing.Size(88, 13);
            this.TextRobustness.TabIndex = 3;
            this.TextRobustness.Text = "robustesse";
            // 
            // TextDodge
            // 
            this.TextDodge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDodge.AutoSize = true;
            this.TextDodge.Font = new System.Drawing.Font(_context.Font.Families[0], 18);
            this.TextDodge.Location = new System.Drawing.Point(400, 205);
            this.TextDodge.Name = "TextDodge";
            this.TextDodge.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.TextDodge.Size = new System.Drawing.Size(85, 13);
            this.TextDodge.TabIndex = 4;
            this.TextDodge.Text = "esquive";
            // 
            // TextStamina
            // 
            this.TextStamina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextStamina.AutoSize = true;
            this.TextStamina.Font = new System.Drawing.Font(_context.Font.Families[0], 18);
            this.TextStamina.Location = new System.Drawing.Point(120, 205);
            this.TextStamina.Name = "TextStamina";
            this.TextStamina.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.TextStamina.Size = new System.Drawing.Size(87, 13);
            this.TextStamina.TabIndex = 5;
            this.TextStamina.Text = "fatigue";
            // 
            // TextPhysicalDamage
            // 
            this.TextPhysicalDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPhysicalDamage.AutoSize = true;
            this.TextPhysicalDamage.Font = new System.Drawing.Font(_context.Font.Families[0], 18);
            this.TextPhysicalDamage.Location = new System.Drawing.Point(400, 59);
            this.TextPhysicalDamage.Name = "TextPhysicalDamage";
            this.TextPhysicalDamage.Size = new System.Drawing.Size(89, 13);
            this.TextPhysicalDamage.TabIndex = 6;
            this.TextPhysicalDamage.Text = "attaque physique";
            // 
            // TextMagicDamage
            // 
            this.TextMagicDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextMagicDamage.AutoSize = true;
            this.TextMagicDamage.Font = new System.Drawing.Font(_context.Font.Families[0], 18);
            this.TextMagicDamage.Location = new System.Drawing.Point(400, 137);
            this.TextMagicDamage.Name = "TextMagicDamage";
            this.TextMagicDamage.Size = new System.Drawing.Size(87, 13);
            this.TextMagicDamage.TabIndex = 7;
            this.TextMagicDamage.Text = "attaque magique";
            // 
            // assignedStats
            // 
            this.assignedStats.AutoSize = true;
            this.assignedStats.Location = new System.Drawing.Point(360, 40);
            this.assignedStats.Name = "assignedStats";
            this.assignedStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedStats.Size = new System.Drawing.Size(19, 13);
            this.assignedStats.TabIndex = 30;
            this.assignedStats.Text = "20";
            // 
            // resultatVie
            // 
            this.resultatVie.AutoSize = true;
            this.resultatVie.Location = new System.Drawing.Point(282, 90);
            this.resultatVie.Name = "resultatVie";
            this.resultatVie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatVie.Size = new System.Drawing.Size(25, 13);
            this.resultatVie.TabIndex = 9;
            this.resultatVie.Text = "+25";
            // 
            // resultatRobustesse
            // 
            this.resultatRobustesse.AutoSize = true;
            this.resultatRobustesse.Location = new System.Drawing.Point(282, 167);
            this.resultatRobustesse.Name = "resultatRobustesse";
            this.resultatRobustesse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatRobustesse.Size = new System.Drawing.Size(25, 13);
            this.resultatRobustesse.TabIndex = 10;
            this.resultatRobustesse.Text = "+4";
            // 
            // resultatFatigue
            // 
            this.resultatFatigue.AutoSize = true;
            this.resultatFatigue.Location = new System.Drawing.Point(282, 235);
            this.resultatFatigue.Name = "resultatFatigue";
            this.resultatFatigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatFatigue.Size = new System.Drawing.Size(25, 13);
            this.resultatFatigue.TabIndex = 11;
            this.resultatFatigue.Text = "+10";
            // 
            // resultatAttaquePhysique
            // 
            this.resultatAttaquePhysique.AutoSize = true;
            this.resultatAttaquePhysique.Location = new System.Drawing.Point(595, 90);
            this.resultatAttaquePhysique.Name = "resultatAttaquePhysique";
            this.resultatAttaquePhysique.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatAttaquePhysique.Size = new System.Drawing.Size(25, 13);
            this.resultatAttaquePhysique.TabIndex = 12;
            this.resultatAttaquePhysique.Text = "+30";
            // 
            // resultatAttaqueMagique
            // 
            this.resultatAttaqueMagique.AutoSize = true;
            this.resultatAttaqueMagique.Location = new System.Drawing.Point(595, 167);
            this.resultatAttaqueMagique.Name = "resultatAttaqueMagique";
            this.resultatAttaqueMagique.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatAttaqueMagique.Size = new System.Drawing.Size(25, 13);
            this.resultatAttaqueMagique.TabIndex = 13;
            this.resultatAttaqueMagique.Text = "+15";
            // 
            // resultatEsquive
            // 
            this.resultatEsquive.AutoSize = true;
            this.resultatEsquive.Location = new System.Drawing.Point(595, 235);
            this.resultatEsquive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatEsquive.Name = "resultatEsquive";
            this.resultatEsquive.Size = new System.Drawing.Size(25, 13);
            this.resultatEsquive.TabIndex = 14;
            this.resultatEsquive.Text = "+10";
            // 
            // mVie
            // 
            this.mVie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mVie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mVie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mVie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mVie.Location = new System.Drawing.Point(250, 85);
            this.mVie.Name = "mVie";
            this.mVie.Size = new System.Drawing.Size(27, 22);
            this.mVie.TabIndex = 15;
            this.mVie.Text = "-";
            this.mVie.UseVisualStyleBackColor = true;
            this.mVie.Click += new System.EventHandler(this.mVie_Click);
            // 
            // mRobustesse
            // 
            this.mRobustesse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mRobustesse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mRobustesse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mRobustesse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mRobustesse.Location = new System.Drawing.Point(250, 162);
            this.mRobustesse.Name = "mRobustesse";
            this.mRobustesse.Size = new System.Drawing.Size(27, 22);
            this.mRobustesse.TabIndex = 16;
            this.mRobustesse.Text = "-";
            this.mRobustesse.UseVisualStyleBackColor = true;
            this.mRobustesse.Click += new System.EventHandler(this.mRobustesse_Click);
            // 
            // mFatigue
            // 
            this.mFatigue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mFatigue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mFatigue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mFatigue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mFatigue.Location = new System.Drawing.Point(250, 230);
            this.mFatigue.Name = "mFatigue";
            this.mFatigue.Size = new System.Drawing.Size(27, 22);
            this.mFatigue.TabIndex = 17;
            this.mFatigue.Text = "-";
            this.mFatigue.UseVisualStyleBackColor = true;
            this.mFatigue.Click += new System.EventHandler(this.mFatigue_Click);
            // 
            // mAttaquePhysique
            // 
            this.mAttaquePhysique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mAttaquePhysique.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mAttaquePhysique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mAttaquePhysique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mAttaquePhysique.Location = new System.Drawing.Point(563, 85);
            this.mAttaquePhysique.Name = "mAttaquePhysique";
            this.mAttaquePhysique.Size = new System.Drawing.Size(27, 22);
            this.mAttaquePhysique.TabIndex = 18;
            this.mAttaquePhysique.Text = "-";
            this.mAttaquePhysique.UseVisualStyleBackColor = true;
            this.mAttaquePhysique.Click += new System.EventHandler(this.mAttaquePhysique_Click);
            // 
            // mAttaqueMagique
            // 
            this.mAttaqueMagique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mAttaqueMagique.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mAttaqueMagique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mAttaqueMagique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mAttaqueMagique.Location = new System.Drawing.Point(563, 162);
            this.mAttaqueMagique.Name = "mAttaqueMagique";
            this.mAttaqueMagique.Size = new System.Drawing.Size(27, 22);
            this.mAttaqueMagique.TabIndex = 19;
            this.mAttaqueMagique.Text = "-";
            this.mAttaqueMagique.UseVisualStyleBackColor = true;
            this.mAttaqueMagique.Click += new System.EventHandler(this.mAttaqueMagique_Click);
            // 
            // mEsquive
            // 
            this.mEsquive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mEsquive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mEsquive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mEsquive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mEsquive.Location = new System.Drawing.Point(563, 230);
            this.mEsquive.Name = "mEsquive";
            this.mEsquive.Size = new System.Drawing.Size(27, 22);
            this.mEsquive.TabIndex = 20;
            this.mEsquive.Text = "-";
            this.mEsquive.UseVisualStyleBackColor = true;
            this.mEsquive.Click += new System.EventHandler(this.mEsquive_Click);
            // 
            // pVie
            // 
            this.pVie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pVie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pVie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pVie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pVie.Location = new System.Drawing.Point(302, 85);
            this.pVie.Name = "pVie";
            this.pVie.Size = new System.Drawing.Size(27, 22);
            this.pVie.TabIndex = 21;
            this.pVie.Text = "+";
            this.pVie.UseVisualStyleBackColor = true;
            this.pVie.Click += new System.EventHandler(this.button7_Click);
            // 
            // pRobustesse
            // 
            this.pRobustesse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pRobustesse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pRobustesse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pRobustesse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pRobustesse.Location = new System.Drawing.Point(302, 162);
            this.pRobustesse.Name = "pRobustesse";
            this.pRobustesse.Size = new System.Drawing.Size(27, 22);
            this.pRobustesse.TabIndex = 22;
            this.pRobustesse.Text = "+";
            this.pRobustesse.UseVisualStyleBackColor = true;
            this.pRobustesse.Click += new System.EventHandler(this.pRobustesse_Click);
            // 
            // pFatigue
            // 
            this.pFatigue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pFatigue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pFatigue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pFatigue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pFatigue.Location = new System.Drawing.Point(302, 230);
            this.pFatigue.Name = "pFatigue";
            this.pFatigue.Size = new System.Drawing.Size(27, 22);
            this.pFatigue.TabIndex = 23;
            this.pFatigue.Text = "+";
            this.pFatigue.UseVisualStyleBackColor = true;
            this.pFatigue.Click += new System.EventHandler(this.pFatigue_Click_1);
            // 
            // pAttaquePhysique
            // 
            this.pAttaquePhysique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAttaquePhysique.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pAttaquePhysique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pAttaquePhysique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAttaquePhysique.Location = new System.Drawing.Point(615, 85);
            this.pAttaquePhysique.Name = "pAttaquePhysique";
            this.pAttaquePhysique.Size = new System.Drawing.Size(27, 22);
            this.pAttaquePhysique.TabIndex = 24;
            this.pAttaquePhysique.Text = "+";
            this.pAttaquePhysique.UseVisualStyleBackColor = true;
            this.pAttaquePhysique.Click += new System.EventHandler(this.pAttaquePhysique_Click);
            // 
            // pAttaqueMagique
            // 
            this.pAttaqueMagique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAttaqueMagique.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pAttaqueMagique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pAttaqueMagique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAttaqueMagique.Location = new System.Drawing.Point(615, 162);
            this.pAttaqueMagique.Name = "pAttaqueMagique";
            this.pAttaqueMagique.Size = new System.Drawing.Size(27, 22);
            this.pAttaqueMagique.TabIndex = 25;
            this.pAttaqueMagique.Text = "+";
            this.pAttaqueMagique.UseVisualStyleBackColor = true;
            this.pAttaqueMagique.Click += new System.EventHandler(this.pAttaqueMagique_Click);
            // 
            // pEsquive
            // 
            this.pEsquive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pEsquive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pEsquive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pEsquive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pEsquive.Location = new System.Drawing.Point(615, 230);
            this.pEsquive.Name = "pEsquive";
            this.pEsquive.Size = new System.Drawing.Size(27, 22);
            this.pEsquive.TabIndex = 26;
            this.pEsquive.Text = "+";
            this.pEsquive.UseVisualStyleBackColor = true;
            this.pEsquive.Click += new System.EventHandler(this.pEsquive_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.AutoSize = true;
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font(_context.Font.Families[1], 30);
            this.buttonNext.Location = new System.Drawing.Point(550, 280);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 32);
            this.buttonNext.TabIndex = 27;
            this.buttonNext.Text = "valider";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.AutoSize = true;
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font(_context.Font.Families[1], 30);
            this.button14.Location = new System.Drawing.Point(50, 280);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 32);
            this.button14.TabIndex = 28;
            this.button14.Text = "retour";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font(_context.Font.Families[1], 30);
            this.buttonReset.Location = new System.Drawing.Point(280, 280);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(111, 27);
            this.buttonReset.TabIndex = 29;
            this.buttonReset.Text = "réinitialiser";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // CreateMainCharacter2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pEsquive);
            this.Controls.Add(this.pAttaqueMagique);
            this.Controls.Add(this.pAttaquePhysique);
            this.Controls.Add(this.pFatigue);
            this.Controls.Add(this.pRobustesse);
            this.Controls.Add(this.pVie);
            this.Controls.Add(this.mEsquive);
            this.Controls.Add(this.mAttaqueMagique);
            this.Controls.Add(this.mAttaquePhysique);
            this.Controls.Add(this.mFatigue);
            this.Controls.Add(this.mRobustesse);
            this.Controls.Add(this.mVie);
            this.Controls.Add(this.resultatEsquive);
            this.Controls.Add(this.resultatAttaqueMagique);
            this.Controls.Add(this.resultatAttaquePhysique);
            this.Controls.Add(this.resultatFatigue);
            this.Controls.Add(this.resultatRobustesse);
            this.Controls.Add(this.resultatVie);
            this.Controls.Add(this.assignedStats);
            this.Controls.Add(this.TextMagicDamage);
            this.Controls.Add(this.TextPhysicalDamage);
            this.Controls.Add(this.TextStamina);
            this.Controls.Add(this.TextDodge);
            this.Controls.Add(this.TextRobustness);
            this.Controls.Add(this.TextLife);
            this.Controls.Add(this.Stats);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "CreateMainCharacter2";
            this.Size = new System.Drawing.Size(750, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Label TextLife;
        private System.Windows.Forms.Label TextRobustness;
        private System.Windows.Forms.Label TextDodge;
        private System.Windows.Forms.Label TextStamina;
        private System.Windows.Forms.Label TextPhysicalDamage;
        private System.Windows.Forms.Label TextMagicDamage;
        private System.Windows.Forms.Label assignedStats;
        private System.Windows.Forms.Label resultatVie;
        private System.Windows.Forms.Label resultatRobustesse;
        private System.Windows.Forms.Label resultatFatigue;
        private System.Windows.Forms.Label resultatAttaquePhysique;
        private System.Windows.Forms.Label resultatAttaqueMagique;
        private System.Windows.Forms.Label resultatEsquive;
        private System.Windows.Forms.Button mVie;
        private System.Windows.Forms.Button mRobustesse;
        private System.Windows.Forms.Button mFatigue;
        private System.Windows.Forms.Button mAttaquePhysique;
        private System.Windows.Forms.Button mAttaqueMagique;
        private System.Windows.Forms.Button mEsquive;
        private System.Windows.Forms.Button pVie;
        private System.Windows.Forms.Button pRobustesse;
        private System.Windows.Forms.Button pFatigue;
        private System.Windows.Forms.Button pAttaquePhysique;
        private System.Windows.Forms.Button pAttaqueMagique;
        private System.Windows.Forms.Button pEsquive;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button buttonReset;
    }
}
