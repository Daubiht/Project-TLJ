namespace IGMapEditor
{
    partial class MapEditor
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBMap = new System.Windows.Forms.GroupBox();
            this.GBProperties = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBElementName = new System.Windows.Forms.TextBox();
            this.BSave = new System.Windows.Forms.Button();
            this.GBProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBMap
            // 
            this.GBMap.Location = new System.Drawing.Point(1, 1);
            this.GBMap.Name = "GBMap";
            this.GBMap.Size = new System.Drawing.Size(400, 381);
            this.GBMap.TabIndex = 0;
            this.GBMap.TabStop = false;
            this.GBMap.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GBProperties
            // 
            this.GBProperties.Controls.Add(this.BSave);
            this.GBProperties.Controls.Add(this.label1);
            this.GBProperties.Controls.Add(this.TBElementName);
            this.GBProperties.Location = new System.Drawing.Point(1, 388);
            this.GBProperties.Name = "GBProperties";
            this.GBProperties.Size = new System.Drawing.Size(400, 79);
            this.GBProperties.TabIndex = 1;
            this.GBProperties.TabStop = false;
            this.GBProperties.Text = "Propriétés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // TBElementName
            // 
            this.TBElementName.Location = new System.Drawing.Point(53, 17);
            this.TBElementName.Name = "TBElementName";
            this.TBElementName.Size = new System.Drawing.Size(100, 20);
            this.TBElementName.TabIndex = 0;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(319, 50);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 2;
            this.BSave.Text = "Sauver";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 477);
            this.Controls.Add(this.GBProperties);
            this.Controls.Add(this.GBMap);
            this.Name = "MapEditor";
            this.Text = "TLJ : MapEditor";
            this.Load += new System.EventHandler(this.MapEditor_Load);
            this.GBProperties.ResumeLayout(false);
            this.GBProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBMap;
        private System.Windows.Forms.GroupBox GBProperties;
        private System.Windows.Forms.TextBox TBElementName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSave;
    }
}

