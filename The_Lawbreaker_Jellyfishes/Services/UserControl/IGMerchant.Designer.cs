namespace Services
{
    partial class IGMerchant
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageBuy = new System.Windows.Forms.TabPage();
            this.PageSell = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
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
            this.LGold.Location = new System.Drawing.Point(328, 40);
            this.LGold.Name = "LGold";
            this.LGold.Size = new System.Drawing.Size(34, 13);
            this.LGold.TabIndex = 3;
            this.LGold.Text = "Golds";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(132, 45);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(29, 13);
            this.LError.TabIndex = 4;
            this.LError.Text = "Error";
            this.LError.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageBuy);
            this.tabControl1.Controls.Add(this.PageSell);
            this.tabControl1.Location = new System.Drawing.Point(3, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 339);
            this.tabControl1.TabIndex = 5;
            // 
            // PageBuy
            // 
            this.PageBuy.AutoScroll = true;
            this.PageBuy.Location = new System.Drawing.Point(4, 22);
            this.PageBuy.Name = "PageBuy";
            this.PageBuy.Padding = new System.Windows.Forms.Padding(3);
            this.PageBuy.Size = new System.Drawing.Size(389, 313);
            this.PageBuy.TabIndex = 0;
            this.PageBuy.Text = "Acheter";
            this.PageBuy.UseVisualStyleBackColor = true;
            // 
            // PageSell
            // 
            this.PageSell.AutoScroll = true;
            this.PageSell.Location = new System.Drawing.Point(4, 22);
            this.PageSell.Name = "PageSell";
            this.PageSell.Padding = new System.Windows.Forms.Padding(3);
            this.PageSell.Size = new System.Drawing.Size(389, 313);
            this.PageSell.TabIndex = 1;
            this.PageSell.Text = "Vendre";
            this.PageSell.UseVisualStyleBackColor = true;
            // 
            // IGMerchant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.LGold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "IGMerchant";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.IGMerchant_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LGold;
        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageBuy;
        private System.Windows.Forms.TabPage PageSell;
    }
}
