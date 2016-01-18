namespace GraphicalInterface
{
    partial class FiltredInventory
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
            this.PInfoOldItem = new System.Windows.Forms.Panel();
            this.BDesequip = new System.Windows.Forms.Button();
            this.LOldName = new System.Windows.Forms.Label();
            this.PInfoItem = new System.Windows.Forms.Panel();
            this.BEquip = new System.Windows.Forms.Button();
            this.LNewName = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.Panel();
            this.BRetour = new System.Windows.Forms.Button();
            this.LError = new System.Windows.Forms.Label();
            this.PInfoOldItem.SuspendLayout();
            this.PInfoItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // PInfoOldItem
            // 
            this.PInfoOldItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PInfoOldItem.Controls.Add(this.BDesequip);
            this.PInfoOldItem.Controls.Add(this.LOldName);
            this.PInfoOldItem.Location = new System.Drawing.Point(3, 49);
            this.PInfoOldItem.Name = "PInfoOldItem";
            this.PInfoOldItem.Size = new System.Drawing.Size(200, 140);
            this.PInfoOldItem.TabIndex = 0;
            // 
            // BDesequip
            // 
            this.BDesequip.Location = new System.Drawing.Point(58, 112);
            this.BDesequip.Name = "BDesequip";
            this.BDesequip.Size = new System.Drawing.Size(75, 23);
            this.BDesequip.TabIndex = 2;
            this.BDesequip.Text = "Déséquiper";
            this.BDesequip.UseVisualStyleBackColor = true;
            this.BDesequip.Visible = false;
            this.BDesequip.Click += new System.EventHandler(this.Desequip_Click);
            // 
            // LOldName
            // 
            this.LOldName.AutoSize = true;
            this.LOldName.Location = new System.Drawing.Point(74, 9);
            this.LOldName.Name = "LOldName";
            this.LOldName.Size = new System.Drawing.Size(0, 13);
            this.LOldName.TabIndex = 1;
            this.LOldName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PInfoItem
            // 
            this.PInfoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PInfoItem.Controls.Add(this.BEquip);
            this.PInfoItem.Controls.Add(this.LNewName);
            this.PInfoItem.Location = new System.Drawing.Point(3, 195);
            this.PInfoItem.Name = "PInfoItem";
            this.PInfoItem.Size = new System.Drawing.Size(200, 140);
            this.PInfoItem.TabIndex = 1;
            // 
            // BEquip
            // 
            this.BEquip.Location = new System.Drawing.Point(58, 112);
            this.BEquip.Name = "BEquip";
            this.BEquip.Size = new System.Drawing.Size(75, 23);
            this.BEquip.TabIndex = 1;
            this.BEquip.Text = "Equiper";
            this.BEquip.UseVisualStyleBackColor = true;
            this.BEquip.Visible = false;
            this.BEquip.Click += new System.EventHandler(this.Equip_Click);
            // 
            // LNewName
            // 
            this.LNewName.AutoSize = true;
            this.LNewName.Location = new System.Drawing.Point(73, 9);
            this.LNewName.Name = "LNewName";
            this.LNewName.Size = new System.Drawing.Size(0, 13);
            this.LNewName.TabIndex = 0;
            this.LNewName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(209, 49);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(533, 286);
            this.inventory.TabIndex = 2;
            // 
            // BRetour
            // 
            this.BRetour.AutoSize = true;
            this.BRetour.BackColor = System.Drawing.Color.Transparent;
            this.BRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRetour.Location = new System.Drawing.Point(600, 0);
            this.BRetour.FlatAppearance.BorderSize = 0;
            this.BRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRetour.Font = new System.Drawing.Font(((MainForm)_contextForm).Font.Families[0], 30);
            this.BRetour.Name = "retour";
            this.BRetour.TabIndex = 3;
            this.BRetour.Text = "retour";
            this.BRetour.UseVisualStyleBackColor = true;
            this.BRetour.Click += new System.EventHandler(this.BRetour_Click);
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(19, 19);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(35, 13);
            this.LError.TabIndex = 4;
            this.LError.Text = "label1";
            this.LError.Visible = false;
            // 
            // FiltredInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LError);
            this.Controls.Add(this.BRetour);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.PInfoItem);
            this.Controls.Add(this.PInfoOldItem);
            this.Location = new System.Drawing.Point(50, 60);
            this.Name = "FiltredInventory";
            this.Size = new System.Drawing.Size(750, 338);
            this.Load += new System.EventHandler(this.IGFiltredInventory_Load);
            this.PInfoOldItem.ResumeLayout(false);
            this.PInfoOldItem.PerformLayout();
            this.PInfoItem.ResumeLayout(false);
            this.PInfoItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PInfoOldItem;
        private System.Windows.Forms.Panel PInfoItem;
        private System.Windows.Forms.Panel inventory;
        private System.Windows.Forms.Button BRetour;
        private System.Windows.Forms.Label LNewName;
        private System.Windows.Forms.Label LOldName;
        private System.Windows.Forms.Button BEquip;
        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.Button BDesequip;
    }
}
