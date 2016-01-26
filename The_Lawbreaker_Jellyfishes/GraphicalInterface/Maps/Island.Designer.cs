namespace GraphicalInterface
{
    partial class Island
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
            this.Retour.AutoSize = true;
            this.Retour.BackColor = System.Drawing.Color.Transparent;
            this.Retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Retour.Location = new System.Drawing.Point(600, 0);
            this.Retour.FlatAppearance.BorderSize = 0;
            this.Retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retour.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 30);
            this.Retour.Name = "retour";
            this.Retour.TabIndex = 2;
            this.Retour.Text = "retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Island
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Retour);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "Island";
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.Island_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Retour;
    }
}
