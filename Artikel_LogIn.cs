using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artikelverwaltung_neu
{
    public partial class Artikel_LogIn : Form
    {
        public Artikel_LogIn()
        {
            InitializeComponent();
        }

        private void btnBenutzerReg_Click(object sender, EventArgs e)
        {
            Artikel_Registrierung f = new Artikel_Registrierung();
            f.Show();
            this.Hide();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = tboxBenutzername.Text;
            string passwort = tboxPasswort.Text;


            if ((tboxBenutzername.Text == null) || (tboxPasswort.Text == null))
            {
                EingabeFalsch();
            }
            else
            {
                Datenbank.LoginAbfrage(name, passwort);
            }
        }
        private void EingabeFalsch()
        {
            MessageBox.Show("Eingegebene Daten falsch!", "Achtung", MessageBoxButtons.OK);
        }
    }
}
