namespace GraphicalInterface
{
    partial class Militia
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
            this.retour = new System.Windows.Forms.Button();
            this.Utilise = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Retour
            // 
            this.retour.AutoSize = true;
            this.retour.BackColor = System.Drawing.Color.Transparent;
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.Location = new System.Drawing.Point(600, 0);
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.retour.Size = new System.Drawing.Size(134, 72);
            this.retour.Name = "retour";
            this.retour.TabIndex = 0;
            this.retour.Text = "retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Utilise
            // 
            this.Utilise.AutoSize = true;
            this.Utilise.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.Utilise.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Utilise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Utilise.FlatAppearance.BorderSize = 0;
            this.Utilise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Utilise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Utilise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Utilise.Location = new System.Drawing.Point(300, 200);
            this.Utilise.Size = new System.Drawing.Size(450, 75);
            this.Utilise.TabIndex = 1;
            this.Utilise.Text = "Engager";
            this.Utilise.UseVisualStyleBackColor = true;
            this.Utilise.Click += new System.EventHandler(this.Utilise_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 30);
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(75, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Milice";
            //
            // label
            //
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 15);
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Location = new System.Drawing.Point(75, 100);
            this.label.TabIndex = 0;
            this.label.Text = "Milicien offre protection pour escorte maritime à personne ayant les moyens." + System.Environment.NewLine + "A payer d'avance. Non négociable.";
            // 
            // Militia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Location = new System.Drawing.Point(60, 50);
            this.Controls.Add(this.Utilise);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retour);
            this.Name = "Militia";
            this.Size = new System.Drawing.Size(750, 338);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button Utilise;
    }
}
