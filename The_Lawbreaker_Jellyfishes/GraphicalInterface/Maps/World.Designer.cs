namespace GraphicalInterface
{
    partial class World
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
            this.Ponyoland = new System.Windows.Forms.Button();
            this.IleDevastee = new System.Windows.Forms.Button();
            this.IlePerdue = new System.Windows.Forms.Button();
            this.Genefort = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ponyoland
            // 
            this.Ponyoland.Location = new System.Drawing.Point(154, 60);
            this.Ponyoland.Name = "Ponyoland";
            this.Ponyoland.Size = new System.Drawing.Size(118, 31);
            this.Ponyoland.TabIndex = 0;
            this.Ponyoland.Text = "Ponyoland";
            this.Ponyoland.UseVisualStyleBackColor = true;
            this.Ponyoland.Click += new System.EventHandler(this.Ponyoland_Click);
            // 
            // IleDevastee
            // 
            this.IleDevastee.Location = new System.Drawing.Point(24, 185);
            this.IleDevastee.Name = "IleDevastee";
            this.IleDevastee.Size = new System.Drawing.Size(129, 23);
            this.IleDevastee.TabIndex = 1;
            this.IleDevastee.Text = "L\'île dévastée";
            this.IleDevastee.UseVisualStyleBackColor = true;
            this.IleDevastee.Click += new System.EventHandler(this.IleDevastee_Click);
            // 
            // IlePerdue
            // 
            this.IlePerdue.Location = new System.Drawing.Point(270, 185);
            this.IlePerdue.Name = "IlePerdue";
            this.IlePerdue.Size = new System.Drawing.Size(113, 23);
            this.IlePerdue.TabIndex = 2;
            this.IlePerdue.Text = "L\'île perdue";
            this.IlePerdue.UseVisualStyleBackColor = true;
            this.IlePerdue.Click += new System.EventHandler(this.IlePerdue_Click);
            // 
            // Genefort
            // 
            this.Genefort.Location = new System.Drawing.Point(154, 316);
            this.Genefort.Name = "Genefort";
            this.Genefort.Size = new System.Drawing.Size(118, 28);
            this.Genefort.TabIndex = 3;
            this.Genefort.Text = "Genefort";
            this.Genefort.UseVisualStyleBackColor = true;
            this.Genefort.Click += new System.EventHandler(this.Genefort_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(193, 231);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(37, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Visible = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // World
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Genefort);
            this.Controls.Add(this.IlePerdue);
            this.Controls.Add(this.IleDevastee);
            this.Controls.Add(this.Ponyoland);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "World";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.World_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ponyoland;
        private System.Windows.Forms.Button IleDevastee;
        private System.Windows.Forms.Button IlePerdue;
        private System.Windows.Forms.Button Genefort;
        private System.Windows.Forms.Button ok;
    }
}
