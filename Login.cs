using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Artikelverwaltung_neu
{
    class Login
    {
        public static void Einloggen()
        {
            bool einloggen = true;
            while (einloggen)
            {
                Console.Clear();
                // user input
                Console.WriteLine("Benutzername:");
                string name = Console.ReadLine();
                Console.WriteLine("Passwort:");
                string passwort = Console.ReadLine();
                // db abfrage
                if (Datenbank.LoginAbfrage(name, passwort))
                    einloggen = false;
            }
        }
    }
}