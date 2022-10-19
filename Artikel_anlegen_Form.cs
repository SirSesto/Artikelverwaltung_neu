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
    public partial class Artikel_anlegen_Form : Form
    {
        public Artikel_anlegen_Form()
        {
            InitializeComponent();
        }

        private void btnAnlegen_Click(object sender, EventArgs e)
        {
            Artikelverwaltung.Hinzufuegen(
                tboxName.Text,
                tboxHersteller.Text,
                tboxBeschreibung.Text,
                Convert.ToChar(rbntGroupA.Text),
                Convert.ToDouble(tboxEKPreis.Text),
                Convert.ToDouble(tboxVKPreis.Text)
                );
        }

        private void tboxName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxHersteller_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxBeschreibung_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxEKPreis_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxVKPreis_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbntGroupA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnGroupB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnGroupC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxName.Clear();
            tboxBeschreibung.Clear();
            tboxHersteller.Clear();
            tboxEKPreis.Clear();
            tboxVKPreis.Clear();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double mwSt = 1.19;
            tboxVKPreis.Text = Convert.ToString(Math.Round(Convert.ToDouble(tboxEKPreis.Text) * mwSt, 2)) ;
            
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
