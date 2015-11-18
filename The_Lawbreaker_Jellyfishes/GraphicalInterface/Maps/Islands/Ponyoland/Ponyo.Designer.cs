namespace GraphicalInterface
{
    partial class Ponyo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Marchand = new System.Windows.Forms.Button();
            this.Milice = new System.Windows.Forms.Button();
            this.Taverne = new System.Windows.Forms.Button();
            this.Coursier = new System.Windows.Forms.Button();
            this.Herboriste = new System.Windows.Forms.Button();
            this.Morgue = new System.Windows.Forms.Button();
            this.Retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Marchand
            // 
            this.Marchand.Location = new System.Drawing.Point(117, 66);
            this.Marchand.Name = "Marchand";
            this.Marchand.Size = new System.Drawing.Size(75, 23);
            this.Marchand.TabIndex = 0;
            this.Marchand.Text = "Marchand";
            this.Marchand.UseVisualStyleBackColor = true;
            this.Marchand.Click += new System.EventHandler(this.Marchand_Click);
            // 
            // Milice
            // 
            this.Milice.Location = new System.Drawing.Point(93, 181);
            this.Milice.Name = "Milice";
            this.Milice.Size = new System.Drawing.Size(75, 23);
            this.Milice.TabIndex = 1;
            this.Milice.Text = "Milice";
            this.Milice.UseVisualStyleBackColor = true;
            this.Milice.Click += new System.EventHandler(this.Milice_Click);
            // 
            // Taverne
            // 
            this.Taverne.Location = new System.Drawing.Point(256, 141);
            this.Taverne.Name = "Taverne";
            this.Taverne.Size = new System.Drawing.Size(75, 23);
            this.Taverne.TabIndex = 2;
            this.Taverne.Text = "Taverne";
            this.Taverne.UseVisualStyleBackColor = true;
            this.Taverne.Click += new System.EventHandler(this.Taverne_Click);
            // 
            // Coursier
            // 
            this.Coursier.Location = new System.Drawing.Point(231, 224);
            this.Coursier.Name = "Coursier";
            this.Coursier.Size = new System.Drawing.Size(75, 23);
            this.Coursier.TabIndex = 3;
            this.Coursier.Text = "Coursier";
            this.Coursier.UseVisualStyleBackColor = true;
            // 
            // Herboriste
            // 
            this.Herboriste.Location = new System.Drawing.Point(78, 276);
            this.Herboriste.Name = "Herboriste";
            this.Herboriste.Size = new System.Drawing.Size(75, 23);
            this.Herboriste.TabIndex = 4;
            this.Herboriste.Text = "Herboriste";
            this.Herboriste.UseVisualStyleBackColor = true;
            // 
            // Morgue
            // 
            this.Morgue.Location = new System.Drawing.Point(256, 331);
            this.Morgue.Name = "Morgue";
            this.Morgue.Size = new System.Drawing.Size(75, 23);
            this.Morgue.TabIndex = 5;
            this.Morgue.Text = "Morgue";
            this.Morgue.UseVisualStyleBackColor = true;
            this.Morgue.Click += new System.EventHandler(this.Morgue_Click);
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(322, 3);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 6;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Ponyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Morgue);
            this.Controls.Add(this.Herboriste);
            this.Controls.Add(this.Coursier);
            this.Controls.Add(this.Taverne);
            this.Controls.Add(this.Milice);
            this.Controls.Add(this.Marchand);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Ponyo";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Marchand;
        private System.Windows.Forms.Button Milice;
        private System.Windows.Forms.Button Taverne;
        private System.Windows.Forms.Button Coursier;
        private System.Windows.Forms.Button Herboriste;
        private System.Windows.Forms.Button Morgue;
        private System.Windows.Forms.Button Retour;
    }
}
