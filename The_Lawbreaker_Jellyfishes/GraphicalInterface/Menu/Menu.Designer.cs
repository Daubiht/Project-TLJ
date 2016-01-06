namespace GraphicalInterface
{
    public partial class Menu
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
            this.equipe = new System.Windows.Forms.Button();
            this.inventaire = new System.Windows.Forms.Button();
            this.notifications = new System.Windows.Forms.Button();
            this.sauvegarde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equipe
            // 
            this.equipe.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.equipe.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.equipe.Text = "equipes";
            this.equipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equipe.FlatAppearance.BorderSize = 0;
            this.equipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.equipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equipe.Location = new System.Drawing.Point(0, 0);
            this.equipe.Name = "equipe";
            this.equipe.UseVisualStyleBackColor = true;
            this.equipe.Click += new System.EventHandler(this.equipe_Click);
            this.equipe.Size = new System.Drawing.Size(135, 50);
            // 
            // inventaire
            // 
            this.inventaire.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.inventaire.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.inventaire.Text = "inventaire";
            this.inventaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventaire.FlatAppearance.BorderSize = 0;
            this.inventaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inventaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventaire.Location = new System.Drawing.Point(150, 0);
            this.inventaire.Name = "inventaire";
            this.inventaire.UseVisualStyleBackColor = true;
            this.inventaire.Click += new System.EventHandler(this.inventaire_Click);
            this.inventaire.Size = new System.Drawing.Size(170, 50);
            // 
            // notifications
            // 
            this.notifications.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.notifications.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.notifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notifications.FlatAppearance.BorderSize = 0;
            this.notifications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.notifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.notifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifications.Location = new System.Drawing.Point(400, 0);
            this.notifications.Name = "notifications";
            this.notifications.Size = new System.Drawing.Size(185, 50);
            this.notifications.TabIndex = 0;
            this.notifications.Text = "notifications";
            this.notifications.UseVisualStyleBackColor = true;
            this.notifications.Click += new System.EventHandler(this.notifications_Click);
            // 
            // sauvegarde
            // 
            this.sauvegarde.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 30);
            this.sauvegarde.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sauvegarde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sauvegarde.FlatAppearance.BorderSize = 0;
            this.sauvegarde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sauvegarde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sauvegarde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sauvegarde.Location = new System.Drawing.Point(550, 0);
            this.sauvegarde.Name = "sauvegarde";
            this.sauvegarde.Size = new System.Drawing.Size(200, 50);
            this.sauvegarde.TabIndex = 0;
            this.sauvegarde.Text = "sauvegarde";
            this.sauvegarde.UseVisualStyleBackColor = true;
            this.sauvegarde.Click += new System.EventHandler(this.sauvegarde_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sauvegarde);
            this.Controls.Add(this.notifications);
            this.Controls.Add(this.inventaire);
            this.Controls.Add(this.equipe);
            this.Location = new System.Drawing.Point(60, 390);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(750, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button equipe;
        private System.Windows.Forms.Button inventaire;
        private System.Windows.Forms.Button notifications;
        private System.Windows.Forms.Button sauvegarde;
    }
}
