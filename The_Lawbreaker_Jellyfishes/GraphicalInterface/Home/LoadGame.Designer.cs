﻿namespace GraphicalInterface
{
    partial class LoadGame
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
            this.slot1 = new System.Windows.Forms.Button();
            this.slot2 = new System.Windows.Forms.Button();
            this.slot3 = new System.Windows.Forms.Button();
            this.slot4 = new System.Windows.Forms.Button();
            this.slot5 = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // slot1
            // 
            this.slot1.Enabled = false;
            this.slot1.Location = new System.Drawing.Point(113, 24);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(178, 64);
            this.slot1.TabIndex = 0;
            this.slot1.Text = "Slot 1 - Vide";
            this.slot1.UseVisualStyleBackColor = true;
            this.slot1.Click += new System.EventHandler(ChooseGame);
            // 
            // slot2
            // 
            this.slot2.Enabled = false;
            this.slot2.Location = new System.Drawing.Point(113, 94);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(178, 64);
            this.slot2.TabIndex = 0;
            this.slot2.Text = "Slot 2 - Vide";
            this.slot2.UseVisualStyleBackColor = true;
            this.slot2.Click += new System.EventHandler(ChooseGame);
            // 
            // slot3
            // 
            this.slot3.Enabled = false;
            this.slot3.Location = new System.Drawing.Point(113, 164);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(178, 64);
            this.slot3.TabIndex = 0;
            this.slot3.Text = "Slot 3 - Vide";
            this.slot3.UseVisualStyleBackColor = true;
            this.slot3.Click += new System.EventHandler(ChooseGame);
            // 
            // slot4
            // 
            this.slot4.Enabled = false;
            this.slot4.Location = new System.Drawing.Point(113, 234);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(178, 64);
            this.slot4.TabIndex = 0;
            this.slot4.Text = "Slot 4 - Vide";
            this.slot4.UseVisualStyleBackColor = true;
            this.slot4.Click += new System.EventHandler(ChooseGame);
            // 
            // slot5
            // 
            this.slot5.Enabled = false;
            this.slot5.Location = new System.Drawing.Point(113, 304);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(178, 64);
            this.slot5.TabIndex = 0;
            this.slot5.Text = "Slot 5 - Vide";
            this.slot5.UseVisualStyleBackColor = true;
            this.slot5.Click += new System.EventHandler(ChooseGame);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(322, 3);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 23);
            this.retour.TabIndex = 1;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.retour);
            this.Controls.Add(this.slot5);
            this.Controls.Add(this.slot4);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "LoadGame";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button slot1;
        private System.Windows.Forms.Button slot2;
        private System.Windows.Forms.Button slot3;
        private System.Windows.Forms.Button slot4;
        private System.Windows.Forms.Button slot5;
        private System.Windows.Forms.Button retour;
    }
}
