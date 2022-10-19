using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Artikelverwaltung_neu
{
    class Artikelverwaltung
    {
        public static void Hinzufuegen(string artname, string hersteller, string beschr, char gruppe, double ek, double vk)
        {
            // Abfrage der Parameter
            
            Artikel a = new Artikel(artname, hersteller, beschr, gruppe, ek, vk);
            // Hochladen in die Datenbank
            Datenbank.DatensatzHinzufuegen(a);
        }
        public void Loeschen(Papierkorb p)
        {
            // papierkorb aus main raus

            bool del = true;
            while (del)
            {
                Console.WriteLine("[z]Zuerueck\nGeben Sie die ID des zu loeschenden Artikels ein:");
                string cmd = Console.ReadLine();
                if (cmd == "z")
                {
                    del = false;
                    break;
                }
                uint id = Convert.ToUInt32(cmd);
                p.InPapierkorb(id);
            }

        }
        public void AlleAnzeigen()
        {
            Console.Clear();
            Datenbank.AlleArtikelAbfragen();
            Console.Read();
        }
        public void Anzeigen(uint id)
        {
            Datenbank.ArtikelAbfragen(id);
        }
        public Artikel GetArtikel(uint id, Artikel[] artikels)
        {
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i].Id == id)
                {
                    Artikel a = artikels[i];
                    return a;
                }
                else Console.WriteLine("Kein Ergebnis!");
            }
            return null;
        }
    }
}
