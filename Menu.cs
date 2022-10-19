using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung_neu
{
    class Menu
    {
        /*string titel;
        string beschreibung;
        string befehle;*/

        public Menu()
        {
        }

        public static void Interface(string titel, string beschreibung, string befehle)
        {
            Console.Clear();
            Console.WriteLine("=> " + titel);
            Console.WriteLine(" " + beschreibung);
            Console.WriteLine(" " + befehle);
        }
    }
}
