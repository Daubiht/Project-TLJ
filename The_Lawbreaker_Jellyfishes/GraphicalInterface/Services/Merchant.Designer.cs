namespace GraphicalInterface
{
    partial class Merchant
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LGold = new System.Windows.Forms.Label();
            this.LError = new System.Windows.Forms.Label();
            this.BAlchemist = new System.Windows.Forms.Button();
            this.BSell = new System.Windows.Forms.Button();
            this.BBuy = new System.Windows.Forms.Button();
            this.Page = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 30);
            this.button1.Location = new System.Drawing.Point(600, 0);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // LGold
            // 
            this.LGold.AutoSize = true;
            this.LGold.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 18);
            this.LGold.Location = new System.Drawing.Point(250, 15);
            this.LGold.Name = "LGold";
            this.LGold.Size = new System.Drawing.Size(34, 13);
            this.LGold.TabIndex = 3;
            this.LGold.Text = "Golds";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(127, 321);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(29, 13);
            this.LError.TabIndex = 4;
            this.LError.Text = "Error";
            this.LError.Visible = false;
            // 
            // BAlchemist
            // 
            this.BAlchemist.AutoSize = true;
            this.BAlchemist.BackColor = System.Drawing.Color.Transparent;
            this.BAlchemist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAlchemist.FlatAppearance.BorderSize = 0;
            this.BAlchemist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BAlchemist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BAlchemist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAlchemist.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 25);
            this.BAlchemist.Location = new System.Drawing.Point(25, 150);
            this.BAlchemist.TabIndex = 8;
            this.BAlchemist.Tag = "Alchemist";
            this.BAlchemist.Text = "artisanat";
            this.BAlchemist.UseVisualStyleBackColor = true;
            this.BAlchemist.Visible = false;
            this.BAlchemist.Click += new System.EventHandler(this.ChangePage);
            // 
            // BSell
            // 
            this.BSell.AutoSize = true;
            this.BSell.BackColor = System.Drawing.Color.Transparent;
            this.BSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSell.FlatAppearance.BorderSize = 0;
            this.BSell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSell.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 25);
            this.BSell.Location = new System.Drawing.Point(25, 100);
            this.BSell.TabIndex = 9;
            this.BSell.Tag = "Sell";
            this.BSell.Text = "vente";
            this.BSell.UseVisualStyleBackColor = true;
            this.BSell.Click += new System.EventHandler(this.ChangePage);
            // 
            // BBuy
            // 
            this.BBuy.AutoSize = true;
            this.BBuy.BackColor = System.Drawing.Color.Transparent;
            this.BBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuy.FlatAppearance.BorderSize = 0;
            this.BBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuy.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 25, System.Drawing.FontStyle.Underline);
            this.BBuy.Location = new System.Drawing.Point(25, 50);
            this.BBuy.TabIndex = 10;
            this.BBuy.Tag = "Buy";
            this.BBuy.Text = "achat";
            this.BBuy.UseVisualStyleBackColor = true;
            this.BBuy.Click += new System.EventHandler(this.ChangePage);
            // 
            // Page
            // 
            this.Page.AutoScroll = true;
            this.Page.Location = new System.Drawing.Point(183, 51);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(475, 275);
            this.Page.TabIndex = 11;
            // 
            // Merchant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Page);
            this.Controls.Add(this.BBuy);
            this.Controls.Add(this.BSell);
            this.Controls.Add(this.BAlchemist);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.LGold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(60, 40);
            this.Name = "Merchant";
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.IGMerchant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LGold;
        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.Button BAlchemist;
        private System.Windows.Forms.Button BSell;
        private System.Windows.Forms.Button BBuy;
        private System.Windows.Forms.Panel Page;
    }
}
