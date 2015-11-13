namespace GraphicalInterface
{
    partial class Ponyoland
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
            this.Ponyo = new System.Windows.Forms.Button();
            this.ValleeDePonyo = new System.Windows.Forms.Button();
            this.ForetDePonyo = new System.Windows.Forms.Button();
            this.Retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ponyo
            // 
            this.Ponyo.Location = new System.Drawing.Point(163, 165);
            this.Ponyo.Name = "Ponyo";
            this.Ponyo.Size = new System.Drawing.Size(90, 47);
            this.Ponyo.TabIndex = 0;
            this.Ponyo.Text = "Ponyo";
            this.Ponyo.UseVisualStyleBackColor = true;
            this.Ponyo.Click += new System.EventHandler(this.Ponyo_Click);
            // 
            // ValleeDePonyo
            // 
            this.ValleeDePonyo.Location = new System.Drawing.Point(48, 48);
            this.ValleeDePonyo.Name = "ValleeDePonyo";
            this.ValleeDePonyo.Size = new System.Drawing.Size(87, 48);
            this.ValleeDePonyo.TabIndex = 1;
            this.ValleeDePonyo.Text = "Vallée de Ponyo";
            this.ValleeDePonyo.UseVisualStyleBackColor = true;
            this.ValleeDePonyo.Click += new System.EventHandler(this.ValleeDePonyo_Click);
            // 
            // ForetDePonyo
            // 
            this.ForetDePonyo.Location = new System.Drawing.Point(257, 288);
            this.ForetDePonyo.Name = "ForetDePonyo";
            this.ForetDePonyo.Size = new System.Drawing.Size(108, 66);
            this.ForetDePonyo.TabIndex = 2;
            this.ForetDePonyo.Text = "Fôret de Ponyo";
            this.ForetDePonyo.UseVisualStyleBackColor = true;
            this.ForetDePonyo.Click += new System.EventHandler(this.ForetDePonyo_Click);
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(322, 3);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 3;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Ponyoland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.ForetDePonyo);
            this.Controls.Add(this.ValleeDePonyo);
            this.Controls.Add(this.Ponyo);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Ponyoland";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ponyo;
        private System.Windows.Forms.Button ValleeDePonyo;
        private System.Windows.Forms.Button ForetDePonyo;
        private System.Windows.Forms.Button Retour;
    }
}
