﻿namespace GraphicalInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // jeter
            // 
            this.jeter.Location = new System.Drawing.Point(3, 3);
            this.jeter.Name = "jeter";
            this.jeter.Size = new System.Drawing.Size(75, 23);
            this.jeter.TabIndex = 0;
            this.jeter.Text = "Jeter";
            this.jeter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(322, 3);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 23);
            this.retour.TabIndex = 2;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 318);
            this.panel1.TabIndex = 3;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jeter);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Panel panel1;
    }
}
