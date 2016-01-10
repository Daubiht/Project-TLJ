namespace GraphicalInterface
{
    partial class ItemInformations
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
            this.LPrice = new System.Windows.Forms.Label();
            this.BBuy = new System.Windows.Forms.Button();
            this.NQuantity = new System.Windows.Forms.NumericUpDown();
            this.LQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font(_fonts[1], 15);
            this.LName.Location = new System.Drawing.Point(12, 17);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(29, 13);
            this.LName.TabIndex = 0;
            this.LName.Text = "Nom";
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Font = new System.Drawing.Font(_fonts[1], 15);
            this.LPrice.Location = new System.Drawing.Point(175, 17);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(24, 13);
            this.LPrice.TabIndex = 1;
            this.LPrice.Text = "Prix";
            // 
            // BBuy
            // 
            this.BBuy.AutoSize = true;
            this.BBuy.BackColor = System.Drawing.Color.Transparent;
            this.BBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuy.FlatAppearance.BorderSize = 0;
            this.BBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuy.Font = new System.Drawing.Font(_fonts[0], 20);
            this.BBuy.Location = new System.Drawing.Point(350, 0);
            this.BBuy.Name = "BBuy";
            this.BBuy.TabIndex = 3;
            this.BBuy.Text = "acheter";
            this.BBuy.UseVisualStyleBackColor = true;
            // 
            // NQuantity
            // 
            this.NQuantity.Location = new System.Drawing.Point(280, 12);
            this.NQuantity.Name = "NQuantity";
            this.NQuantity.Size = new System.Drawing.Size(52, 20);
            this.NQuantity.TabIndex = 4;
            this.NQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NQuantity.Font = new System.Drawing.Font(_fonts[1], 15);
            this.NQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LQuantity
            // 
            this.LQuantity.AutoSize = true;
            this.LQuantity.Font = new System.Drawing.Font(_fonts[1], 15);
            this.LQuantity.Location = new System.Drawing.Point(96, 17);
            this.LQuantity.Name = "LQuantity";
            this.LQuantity.Size = new System.Drawing.Size(46, 13);
            this.LQuantity.TabIndex = 5;
            this.LQuantity.Text = "Quantity";
            // 
            // ItemInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LQuantity);
            this.Controls.Add(this.NQuantity);
            this.Controls.Add(this.BBuy);
            this.Controls.Add(this.LPrice);
            this.Controls.Add(this.LName);
            this.Name = "ItemInformations";
            this.Size = new System.Drawing.Size(445, 44);
            ((System.ComponentModel.ISupportInitialize)(this.NQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LPrice;
        private System.Windows.Forms.Button BBuy;
        private System.Windows.Forms.NumericUpDown NQuantity;
        private System.Windows.Forms.Label LQuantity;
    }
}
