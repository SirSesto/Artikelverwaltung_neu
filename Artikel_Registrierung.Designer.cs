namespace Artikelverwaltung_neu
{
    partial class Artikel_Registrierung
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnZurueck = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxPW = new System.Windows.Forms.TextBox();
            this.tboxPWagain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrierung";
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurueck.Location = new System.Drawing.Point(12, 389);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(89, 33);
            this.btnZurueck.TabIndex = 1;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(210, 379);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(151, 43);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Registrieren";
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(185, 156);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(195, 34);
            this.tboxName.TabIndex = 3;
            this.tboxName.TextChanged += new System.EventHandler(this.tboxName_TextChanged);
            // 
            // tboxPW
            // 
            this.tboxPW.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPW.Location = new System.Drawing.Point(185, 234);
            this.tboxPW.Name = "tboxPW";
            this.tboxPW.Size = new System.Drawing.Size(195, 34);
            this.tboxPW.TabIndex = 4;
            this.tboxPW.TextChanged += new System.EventHandler(this.tboxPW_TextChanged);
            // 
            // tboxPWagain
            // 
            this.tboxPWagain.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPWagain.Location = new System.Drawing.Point(185, 315);
            this.tboxPWagain.Name = "tboxPWagain";
            this.tboxPWagain.Size = new System.Drawing.Size(195, 34);
            this.tboxPWagain.TabIndex = 5;
            this.tboxPWagain.TextChanged += new System.EventHandler(this.tboxPWagain_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Benutzername";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Passwort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Passwort wiederholen";
            // 
            // Artikel_Registrierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxPWagain);
            this.Controls.Add(this.tboxPW);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnZurueck);
            this.Controls.Add(this.label1);
            this.Name = "Artikel_Registrierung";
            this.Text = "Registrierung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxPW;
        private System.Windows.Forms.TextBox tboxPWagain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}