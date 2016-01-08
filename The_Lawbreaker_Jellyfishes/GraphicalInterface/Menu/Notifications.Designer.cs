namespace GraphicalInterface
{
    partial class Notifications
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // retour
            // 
            this.retour.AutoSize = true;
            this.retour.BackColor = System.Drawing.Color.Transparent;
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 30);
            this.retour.Location = new System.Drawing.Point(600, 0);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(134, 72);
            this.retour.TabIndex = 1;
            this.retour.Text = "retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 272);
            this.panel1.TabIndex = 2;
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.retour);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "Notifications";
            this.Size = new System.Drawing.Size(750, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Panel panel1;
    }
}
