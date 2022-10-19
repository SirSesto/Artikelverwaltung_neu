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
    public partial class Artikel_Registrierung : Form
    {
        public Artikel_Registrierung()
        {
            InitializeComponent();
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            Artikel_LogIn logi = new Artikel_LogIn();
            logi.Show();
            this.Close();
        }

        private void tboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxPW_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxPWagain_TextChanged(object sender, EventArgs e)
        {
            string pw1 = tboxPW.Text;
            string pw2 = tboxPWagain.Text;
            if (pw1 == pw2)
            {

            }
            else
            {
                MessageBox.Show("Passwort stimmt nicht überein!",
                    "Hinweis", MessageBoxButtons.OK);
            }
        }
    }
}
