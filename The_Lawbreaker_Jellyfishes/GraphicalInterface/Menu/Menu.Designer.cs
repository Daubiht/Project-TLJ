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
            this.equipe.Location = new System.Drawing.Point(15, 13);
            this.equipe.Name = "equipe";
            this.equipe.Size = new System.Drawing.Size(75, 23);
            this.equipe.TabIndex = 0;
            this.equipe.Text = "Equipes";
            this.equipe.UseVisualStyleBackColor = true;
            this.equipe.Click += new System.EventHandler(this.equipe_Click);
            // 
            // inventaire
            // 
            this.inventaire.Location = new System.Drawing.Point(112, 13);
            this.inventaire.Name = "inventaire";
            this.inventaire.Size = new System.Drawing.Size(75, 23);
            this.inventaire.TabIndex = 0;
            this.inventaire.Text = "Inventaire";
            this.inventaire.UseVisualStyleBackColor = true;
            this.inventaire.Click += new System.EventHandler(this.inventaire_Click);
            // 
            // notifications
            // 
            this.notifications.Location = new System.Drawing.Point(209, 13);
            this.notifications.Name = "notifications";
            this.notifications.Size = new System.Drawing.Size(75, 23);
            this.notifications.TabIndex = 0;
            this.notifications.Text = "Notifications";
            this.notifications.UseVisualStyleBackColor = true;
            this.notifications.Click += new System.EventHandler(this.notifications_Click);
            // 
            // sauvegarde
            // 
            this.sauvegarde.Location = new System.Drawing.Point(306, 13);
            this.sauvegarde.Name = "sauvegarde";
            this.sauvegarde.Size = new System.Drawing.Size(75, 23);
            this.sauvegarde.TabIndex = 0;
            this.sauvegarde.Text = "Sauvegarde";
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
