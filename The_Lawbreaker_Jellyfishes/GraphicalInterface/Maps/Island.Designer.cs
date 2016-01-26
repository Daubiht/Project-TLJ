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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Retour
            // 
            this.Retour.AutoSize = true;
            this.Retour.BackColor = System.Drawing.Color.Transparent;
            this.Retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Retour.FlatAppearance.BorderSize = 0;
            this.Retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retour.Location = new System.Drawing.Point(600, 0);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(134, 72);
            this.Retour.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 30);
            this.Retour.TabIndex = 0;
            this.Retour.Text = "retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // pictureBox1
            // 

            this.pictureBox1.Controls.Add(Retour);
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Island
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "Island";
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.Island_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
