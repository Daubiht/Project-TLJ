namespace Services
{
    public partial class IGMortuary
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
            this.TCMortuary = new System.Windows.Forms.TabControl();
            this.TCMPage1 = new System.Windows.Forms.TabPage();
            this.TCMPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TCMortuary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Morgue";
            this.label1.UseMnemonic = false;
            // 
            // TCMortuary
            // 
            this.TCMortuary.Controls.Add(this.TCMPage1);
            this.TCMortuary.Controls.Add(this.TCMPage2);
            this.TCMortuary.Location = new System.Drawing.Point(3, 69);
            this.TCMortuary.Name = "TCMortuary";
            this.TCMortuary.SelectedIndex = 0;
            this.TCMortuary.Size = new System.Drawing.Size(407, 401);
            this.TCMortuary.TabIndex = 3;
            // 
            // TCMPage1
            // 
            this.TCMPage1.Location = new System.Drawing.Point(4, 22);
            this.TCMPage1.Name = "TCMPage1";
            this.TCMPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TCMPage1.Size = new System.Drawing.Size(399, 375);
            this.TCMPage1.TabIndex = 0;
            this.TCMPage1.Text = "Morgue";
            this.TCMPage1.UseVisualStyleBackColor = true;
            // 
            // TCMPage2
            // 
            this.TCMPage2.Location = new System.Drawing.Point(4, 22);
            this.TCMPage2.Name = "TCMPage2";
            this.TCMPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TCMPage2.Size = new System.Drawing.Size(399, 375);
            this.TCMPage2.TabIndex = 1;
            this.TCMPage2.Text = "Equipe";
            this.TCMPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // IGMortuary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TCMortuary);
            this.Controls.Add(this.label1);
            this.Name = "IGMortuary";
            this.Size = new System.Drawing.Size(410, 470);
            this.Load += new System.EventHandler(Taverne.Taverne_Load);
            this.TCMortuary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TCMortuary;
        private System.Windows.Forms.TabPage TCMPage1;
        private System.Windows.Forms.TabPage TCMPage2;
        private System.Windows.Forms.Label label2;
    }
}
