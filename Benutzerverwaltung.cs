using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung_neu
{
    class Benutzerverwaltung
    {
        public static Benutzer InitBenutzer(string name)
        {
            Benutzer benutzer = new Benutzer(name);
            return benutzer;
        }
        public static Benutzer BenutzerErstellen()
        {
            string name = "test";
            string passwort = "PassTest";
            Benutzer benutzer = new Benutzer(name, passwort);
            Datenbank.BenutzerHinzufuegen(benutzer);

            return benutzer;
        }
        public Benutzer BenutzerAbfrage()
        {
            return BenutzerErstellen();
        }
    }
}
