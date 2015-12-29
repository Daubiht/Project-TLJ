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
            this.retour.Name = "retour";
            this.retour.TabIndex = 0;
            this.retour.Text = "retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Utilise
            // 
            this.Utilise.Location = new System.Drawing.Point(123, 127);
            this.Utilise.Name = "Utilise";
            this.Utilise.Size = new System.Drawing.Size(167, 99);
            this.Utilise.TabIndex = 1;
            this.Utilise.Text = "Utilise";
            this.Utilise.UseVisualStyleBackColor = true;
            this.Utilise.Click += new System.EventHandler(this.Utilise_Click);
            // 
            // Militia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Location = new System.Drawing.Point(60, 50);
            this.Controls.Add(this.Utilise);
            this.Controls.Add(this.retour);
            this.Name = "Militia";
            this.Size = new System.Drawing.Size(750, 338);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button Utilise;
    }
}
