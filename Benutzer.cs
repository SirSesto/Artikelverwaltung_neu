using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung_neu
{
    class Benutzer
    {
        public string BenutzerName;
        private string _Benutzerpasswort;
        public string BenutzerPasswort
        {
            get { return _Benutzerpasswort; }
            set { _Benutzerpasswort = value; }
        }

        // Konstruktor

        public Benutzer() { }
        public Benutzer(string benutzerName)
        {
            BenutzerName = benutzerName;
        }
        public Benutzer(string name, string passwort)
        {
            BenutzerName = name;
            BenutzerPasswort = passwort;
        }
    }
}
