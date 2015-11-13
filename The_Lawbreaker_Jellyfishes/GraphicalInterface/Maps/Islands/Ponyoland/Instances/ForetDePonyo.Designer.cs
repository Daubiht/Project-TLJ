namespace GraphicalInterface
{
    partial class ForetDePonyo
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
            this.Retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(155, 115);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 0;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // ForetDePonyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Retour);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "ForetDePonyo";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Retour;
    }
}
