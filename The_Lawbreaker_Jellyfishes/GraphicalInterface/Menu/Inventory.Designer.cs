namespace GraphicalInterface
{
    partial class Inventory
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
            this.jeter = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // jeter
            // 
            this.jeter.AutoSize = true;
            this.jeter.BackColor = System.Drawing.Color.Transparent;
            this.jeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jeter.FlatAppearance.BorderSize = 0;
            this.jeter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jeter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jeter.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.jeter.Location = new System.Drawing.Point(0, 0);
            this.jeter.Name = "jeter";
            this.jeter.Size = new System.Drawing.Size(75, 23);
            this.jeter.TabIndex = 0;
            this.jeter.Text = "jeter";
            this.jeter.UseVisualStyleBackColor = false;
            this.jeter.Click += new System.EventHandler(this.jeter_Click);
            // 
            // retour
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
            this.retour.TabIndex = 2;
            this.retour.Text = "retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 275);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.jeter);
            this.panel2.Controls.Add(this.retour);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 50);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 15);
            this.label1.Location = new System.Drawing.Point(346, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(60, 50);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button jeter;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
