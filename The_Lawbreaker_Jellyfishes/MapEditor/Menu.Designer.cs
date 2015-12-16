﻿namespace IGMapEditor
{
    partial class Menu
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BInstance = new System.Windows.Forms.Button();
            this.BIsland = new System.Windows.Forms.Button();
            this.BCity = new System.Windows.Forms.Button();
            this.BServ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BLink = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BInstance
            // 
            this.BInstance.Location = new System.Drawing.Point(18, 125);
            this.BInstance.Name = "BInstance";
            this.BInstance.Size = new System.Drawing.Size(87, 46);
            this.BInstance.TabIndex = 0;
            this.BInstance.Tag = "instance";
            this.BInstance.Text = "Instance";
            this.BInstance.UseVisualStyleBackColor = true;
            this.BInstance.Click += new System.EventHandler(this.Tool_Click);
            // 
            // BIsland
            // 
            this.BIsland.Location = new System.Drawing.Point(18, 53);
            this.BIsland.Name = "BIsland";
            this.BIsland.Size = new System.Drawing.Size(87, 46);
            this.BIsland.TabIndex = 0;
            this.BIsland.Tag = "island";
            this.BIsland.Text = "Ile";
            this.BIsland.UseVisualStyleBackColor = true;
            this.BIsland.Click += new System.EventHandler(this.Tool_Click);
            // 
            // BCity
            // 
            this.BCity.Location = new System.Drawing.Point(18, 199);
            this.BCity.Name = "BCity";
            this.BCity.Size = new System.Drawing.Size(87, 46);
            this.BCity.TabIndex = 0;
            this.BCity.Tag = "city";
            this.BCity.Text = "Ville";
            this.BCity.UseVisualStyleBackColor = true;
            this.BCity.Click += new System.EventHandler(this.Tool_Click);
            // 
            // BServ
            // 
            this.BServ.Location = new System.Drawing.Point(18, 275);
            this.BServ.Name = "BServ";
            this.BServ.Size = new System.Drawing.Size(87, 46);
            this.BServ.TabIndex = 0;
            this.BServ.Tag = "service";
            this.BServ.Text = "Service";
            this.BServ.UseVisualStyleBackColor = true;
            this.BServ.Click += new System.EventHandler(this.Tool_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Boite à Outils";
            // 
            // BLink
            // 
            this.BLink.Location = new System.Drawing.Point(18, 349);
            this.BLink.Name = "BLink";
            this.BLink.Size = new System.Drawing.Size(87, 46);
            this.BLink.TabIndex = 0;
            this.BLink.Tag = "link";
            this.BLink.Text = "Lier";
            this.BLink.UseVisualStyleBackColor = true;
            this.BLink.Click += new System.EventHandler(this.Tool_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Entrer";
            // 
            // BEnter
            // 
            this.BEnter.Location = new System.Drawing.Point(18, 416);
            this.BEnter.Name = "BEnter";
            this.BEnter.Size = new System.Drawing.Size(87, 46);
            this.BEnter.TabIndex = 3;
            this.BEnter.Tag = "enter";
            this.BEnter.Text = "Entrer";
            this.BEnter.UseVisualStyleBackColor = true;
            this.BEnter.Click += new System.EventHandler(this.Tool_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BEnter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BIsland);
            this.Controls.Add(this.BLink);
            this.Controls.Add(this.BServ);
            this.Controls.Add(this.BCity);
            this.Controls.Add(this.BInstance);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(198, 461);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BInstance;
        private System.Windows.Forms.Button BIsland;
        private System.Windows.Forms.Button BCity;
        private System.Windows.Forms.Button BServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BEnter;
    }
}
