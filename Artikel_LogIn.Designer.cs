namespace Artikelverwaltung_neu
{
    partial class Artikel_LogIn
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.tboxBenutzername = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.tboxPasswort = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnBenutzerReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(192, 45);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(82, 38);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzername.Location = new System.Drawing.Point(176, 112);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(109, 21);
            this.lblBenutzername.TabIndex = 1;
            this.lblBenutzername.Text = "Benutzername";
            // 
            // tboxBenutzername
            // 
            this.tboxBenutzername.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBenutzername.Location = new System.Drawing.Point(163, 138);
            this.tboxBenutzername.Name = "tboxBenutzername";
            this.tboxBenutzername.Size = new System.Drawing.Size(132, 28);
            this.tboxBenutzername.TabIndex = 2;
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswort.Location = new System.Drawing.Point(195, 193);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(72, 21);
            this.lblPasswort.TabIndex = 3;
            this.lblPasswort.Text = "Passwort";
            // 
            // tboxPasswort
            // 
            this.tboxPasswort.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPasswort.Location = new System.Drawing.Point(163, 218);
            this.tboxPasswort.Name = "tboxPasswort";
            this.tboxPasswort.Size = new System.Drawing.Size(132, 28);
            this.tboxPasswort.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(183, 282);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 31);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Location = new System.Drawing.Point(12, 421);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(80, 29);
            this.btnBeenden.TabIndex = 6;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnBenutzerReg
            // 
            this.btnBenutzerReg.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenutzerReg.Location = new System.Drawing.Point(349, 421);
            this.btnBenutzerReg.Name = "btnBenutzerReg";
            this.btnBenutzerReg.Size = new System.Drawing.Size(115, 29);
            this.btnBenutzerReg.TabIndex = 7;
            this.btnBenutzerReg.Text = "Registrieren";
            this.btnBenutzerReg.UseVisualStyleBackColor = true;
            this.btnBenutzerReg.Click += new System.EventHandler(this.btnBenutzerReg_Click);
            // 
            // Artikel_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 462);
            this.Controls.Add(this.btnBenutzerReg);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tboxPasswort);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.tboxBenutzername);
            this.Controls.Add(this.lblBenutzername);
            this.Controls.Add(this.lblLogin);
            this.Name = "Artikel_LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.TextBox tboxBenutzername;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.TextBox tboxPasswort;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnBenutzerReg;
    }
}