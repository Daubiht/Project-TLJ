namespace GraphicalInterface
{
    partial class Medic
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
            this.Retour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LMessage = new System.Windows.Forms.Label();
            this.LMoney = new System.Windows.Forms.Label();
            this.LCostTotal = new System.Windows.Forms.Label();
            this.LCostHigh = new System.Windows.Forms.Label();
            this.LCostMid = new System.Windows.Forms.Label();
            this.LCostLow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(322, 3);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 0;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Médecin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soigner 30% de la vie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Tag = "0";
            this.button1.Text = "Soigner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Heal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Tag = "50";
            this.button2.Text = "Payer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Tag = "50";
            this.label3.Text = "Soigner 50% de la vie ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Tag = "75";
            this.button3.Text = "Payer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soigner 75% de la vie ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Tag = "100";
            this.button4.Text = "Payer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Soigner 100% de la vie";
            // 
            // LMessage
            // 
            this.LMessage.AutoSize = true;
            this.LMessage.Location = new System.Drawing.Point(172, 58);
            this.LMessage.Name = "LMessage";
            this.LMessage.Size = new System.Drawing.Size(50, 13);
            this.LMessage.TabIndex = 10;
            this.LMessage.Text = "Message";
            // 
            // LMoney
            // 
            this.LMoney.AutoSize = true;
            this.LMoney.Location = new System.Drawing.Point(353, 56);
            this.LMoney.Name = "LMoney";
            this.LMoney.Size = new System.Drawing.Size(22, 13);
            this.LMoney.TabIndex = 11;
            this.LMoney.Text = "PO";
            // 
            // LCostTotal
            // 
            this.LCostTotal.AutoSize = true;
            this.LCostTotal.Location = new System.Drawing.Point(214, 321);
            this.LCostTotal.Name = "LCostTotal";
            this.LCostTotal.Size = new System.Drawing.Size(28, 13);
            this.LCostTotal.TabIndex = 12;
            this.LCostTotal.Text = "Cost";
            // 
            // LCostHigh
            // 
            this.LCostHigh.AutoSize = true;
            this.LCostHigh.Location = new System.Drawing.Point(214, 251);
            this.LCostHigh.Name = "LCostHigh";
            this.LCostHigh.Size = new System.Drawing.Size(28, 13);
            this.LCostHigh.TabIndex = 13;
            this.LCostHigh.Text = "Cost";
            // 
            // LCostMid
            // 
            this.LCostMid.AutoSize = true;
            this.LCostMid.Location = new System.Drawing.Point(214, 180);
            this.LCostMid.Name = "LCostMid";
            this.LCostMid.Size = new System.Drawing.Size(28, 13);
            this.LCostMid.TabIndex = 14;
            this.LCostMid.Text = "Cost";
            // 
            // LCostLow
            // 
            this.LCostLow.AutoSize = true;
            this.LCostLow.Location = new System.Drawing.Point(214, 111);
            this.LCostLow.Name = "LCostLow";
            this.LCostLow.Size = new System.Drawing.Size(28, 13);
            this.LCostLow.TabIndex = 15;
            this.LCostLow.Text = "Cost";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LCostLow);
            this.Controls.Add(this.LCostMid);
            this.Controls.Add(this.LCostHigh);
            this.Controls.Add(this.LCostTotal);
            this.Controls.Add(this.LMoney);
            this.Controls.Add(this.LMessage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Retour);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Doctor";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LMessage;
        private System.Windows.Forms.Label LMoney;
        private System.Windows.Forms.Label LCostTotal;
        private System.Windows.Forms.Label LCostHigh;
        private System.Windows.Forms.Label LCostMid;
        private System.Windows.Forms.Label LCostLow;
        private System.Windows.Forms.Button Retour;

        private void label1_Click(object sender, System.EventArgs e)
        {

        }


    }
}
