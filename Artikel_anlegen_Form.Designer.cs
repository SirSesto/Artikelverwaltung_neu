namespace Artikelverwaltung_neu
{
    partial class Artikel_anlegen_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblHersteller = new System.Windows.Forms.Label();
            this.lblBeschreibung = new System.Windows.Forms.Label();
            this.lblEKPreis = new System.Windows.Forms.Label();
            this.lblVKPreis = new System.Windows.Forms.Label();
            this.lblArtikelgruppe = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxHersteller = new System.Windows.Forms.TextBox();
            this.tboxBeschreibung = new System.Windows.Forms.TextBox();
            this.tboxEKPreis = new System.Windows.Forms.TextBox();
            this.tboxVKPreis = new System.Windows.Forms.TextBox();
            this.btnZurueck = new System.Windows.Forms.Button();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAnlegen = new System.Windows.Forms.Button();
            this.rbntGroupA = new System.Windows.Forms.RadioButton();
            this.rbtnGroupB = new System.Windows.Forms.RadioButton();
            this.rbtnGroupC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblHersteller
            // 
            this.lblHersteller.AutoSize = true;
            this.lblHersteller.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHersteller.Location = new System.Drawing.Point(26, 76);
            this.lblHersteller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHersteller.Name = "lblHersteller";
            this.lblHersteller.Size = new System.Drawing.Size(86, 23);
            this.lblHersteller.TabIndex = 1;
            this.lblHersteller.Text = "Hersteller";
            // 
            // lblBeschreibung
            // 
            this.lblBeschreibung.AutoSize = true;
            this.lblBeschreibung.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschreibung.Location = new System.Drawing.Point(26, 120);
            this.lblBeschreibung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeschreibung.Name = "lblBeschreibung";
            this.lblBeschreibung.Size = new System.Drawing.Size(106, 23);
            this.lblBeschreibung.TabIndex = 2;
            this.lblBeschreibung.Text = "Beschreibung";
            // 
            // lblEKPreis
            // 
            this.lblEKPreis.AutoSize = true;
            this.lblEKPreis.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEKPreis.Location = new System.Drawing.Point(26, 192);
            this.lblEKPreis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEKPreis.Name = "lblEKPreis";
            this.lblEKPreis.Size = new System.Drawing.Size(83, 23);
            this.lblEKPreis.TabIndex = 3;
            this.lblEKPreis.Text = "EK - Preis";
            // 
            // lblVKPreis
            // 
            this.lblVKPreis.AutoSize = true;
            this.lblVKPreis.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVKPreis.Location = new System.Drawing.Point(26, 242);
            this.lblVKPreis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVKPreis.Name = "lblVKPreis";
            this.lblVKPreis.Size = new System.Drawing.Size(83, 23);
            this.lblVKPreis.TabIndex = 4;
            this.lblVKPreis.Text = "VK - Preis";
            // 
            // lblArtikelgruppe
            // 
            this.lblArtikelgruppe.AutoSize = true;
            this.lblArtikelgruppe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikelgruppe.Location = new System.Drawing.Point(26, 320);
            this.lblArtikelgruppe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtikelgruppe.Name = "lblArtikelgruppe";
            this.lblArtikelgruppe.Size = new System.Drawing.Size(114, 23);
            this.lblArtikelgruppe.TabIndex = 5;
            this.lblArtikelgruppe.Text = "Artikelgruppe";
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(183, 39);
            this.tboxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(245, 23);
            this.tboxName.TabIndex = 6;
            this.tboxName.TextChanged += new System.EventHandler(this.tboxName_TextChanged);
            // 
            // tboxHersteller
            // 
            this.tboxHersteller.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHersteller.Location = new System.Drawing.Point(183, 79);
            this.tboxHersteller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tboxHersteller.Name = "tboxHersteller";
            this.tboxHersteller.Size = new System.Drawing.Size(245, 23);
            this.tboxHersteller.TabIndex = 7;
            this.tboxHersteller.TextChanged += new System.EventHandler(this.tboxHersteller_TextChanged);
            // 
            // tboxBeschreibung
            // 
            this.tboxBeschreibung.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBeschreibung.Location = new System.Drawing.Point(183, 120);
            this.tboxBeschreibung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tboxBeschreibung.Name = "tboxBeschreibung";
            this.tboxBeschreibung.Size = new System.Drawing.Size(245, 23);
            this.tboxBeschreibung.TabIndex = 8;
            this.tboxBeschreibung.TextChanged += new System.EventHandler(this.tboxBeschreibung_TextChanged);
            // 
            // tboxEKPreis
            // 
            this.tboxEKPreis.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEKPreis.Location = new System.Drawing.Point(183, 192);
            this.tboxEKPreis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tboxEKPreis.Name = "tboxEKPreis";
            this.tboxEKPreis.Size = new System.Drawing.Size(116, 23);
            this.tboxEKPreis.TabIndex = 9;
            this.tboxEKPreis.TextChanged += new System.EventHandler(this.tboxEKPreis_TextChanged);
            // 
            // tboxVKPreis
            // 
            this.tboxVKPreis.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVKPreis.Location = new System.Drawing.Point(183, 242);
            this.tboxVKPreis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tboxVKPreis.Name = "tboxVKPreis";
            this.tboxVKPreis.Size = new System.Drawing.Size(116, 23);
            this.tboxVKPreis.TabIndex = 10;
            this.tboxVKPreis.TextChanged += new System.EventHandler(this.tboxVKPreis_TextChanged);
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurueck.Location = new System.Drawing.Point(30, 436);
            this.btnZurueck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(88, 27);
            this.btnZurueck.TabIndex = 11;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerechnen.Location = new System.Drawing.Point(340, 242);
            this.btnBerechnen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(88, 27);
            this.btnBerechnen.TabIndex = 12;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(515, 39);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 33);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAnlegen
            // 
            this.btnAnlegen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnlegen.Location = new System.Drawing.Point(489, 422);
            this.btnAnlegen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnlegen.Name = "btnAnlegen";
            this.btnAnlegen.Size = new System.Drawing.Size(114, 41);
            this.btnAnlegen.TabIndex = 14;
            this.btnAnlegen.Text = "Anlegen";
            this.btnAnlegen.UseVisualStyleBackColor = true;
            this.btnAnlegen.Click += new System.EventHandler(this.btnAnlegen_Click);
            // 
            // rbntGroupA
            // 
            this.rbntGroupA.AutoSize = true;
            this.rbntGroupA.Checked = true;
            this.rbntGroupA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbntGroupA.Location = new System.Drawing.Point(183, 321);
            this.rbntGroupA.Name = "rbntGroupA";
            this.rbntGroupA.Size = new System.Drawing.Size(35, 22);
            this.rbntGroupA.TabIndex = 15;
            this.rbntGroupA.TabStop = true;
            this.rbntGroupA.Text = "A";
            this.rbntGroupA.UseVisualStyleBackColor = true;
            this.rbntGroupA.CheckedChanged += new System.EventHandler(this.rbntGroupA_CheckedChanged);
            // 
            // rbtnGroupB
            // 
            this.rbtnGroupB.AutoSize = true;
            this.rbtnGroupB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGroupB.Location = new System.Drawing.Point(245, 322);
            this.rbtnGroupB.Name = "rbtnGroupB";
            this.rbtnGroupB.Size = new System.Drawing.Size(34, 22);
            this.rbtnGroupB.TabIndex = 16;
            this.rbtnGroupB.Text = "B";
            this.rbtnGroupB.UseVisualStyleBackColor = true;
            this.rbtnGroupB.CheckedChanged += new System.EventHandler(this.rbtnGroupB_CheckedChanged);
            // 
            // rbtnGroupC
            // 
            this.rbtnGroupC.AutoSize = true;
            this.rbtnGroupC.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGroupC.Location = new System.Drawing.Point(310, 322);
            this.rbtnGroupC.Name = "rbtnGroupC";
            this.rbtnGroupC.Size = new System.Drawing.Size(34, 22);
            this.rbtnGroupC.TabIndex = 17;
            this.rbtnGroupC.Text = "C";
            this.rbtnGroupC.UseVisualStyleBackColor = true;
            this.rbtnGroupC.CheckedChanged += new System.EventHandler(this.rbtnGroupC_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 493);
            this.Controls.Add(this.rbtnGroupC);
            this.Controls.Add(this.rbtnGroupB);
            this.Controls.Add(this.rbntGroupA);
            this.Controls.Add(this.btnAnlegen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.btnZurueck);
            this.Controls.Add(this.tboxVKPreis);
            this.Controls.Add(this.tboxEKPreis);
            this.Controls.Add(this.tboxBeschreibung);
            this.Controls.Add(this.tboxHersteller);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lblArtikelgruppe);
            this.Controls.Add(this.lblVKPreis);
            this.Controls.Add(this.lblEKPreis);
            this.Controls.Add(this.lblBeschreibung);
            this.Controls.Add(this.lblHersteller);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Artikel anlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHersteller;
        private System.Windows.Forms.Label lblBeschreibung;
        private System.Windows.Forms.Label lblEKPreis;
        private System.Windows.Forms.Label lblVKPreis;
        private System.Windows.Forms.Label lblArtikelgruppe;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxHersteller;
        private System.Windows.Forms.TextBox tboxBeschreibung;
        private System.Windows.Forms.TextBox tboxEKPreis;
        private System.Windows.Forms.TextBox tboxVKPreis;
        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAnlegen;
        private System.Windows.Forms.RadioButton rbntGroupA;
        private System.Windows.Forms.RadioButton rbtnGroupB;
        private System.Windows.Forms.RadioButton rbtnGroupC;
    }
}

