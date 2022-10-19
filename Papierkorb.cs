using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung_neu
{
    class Papierkorb
    {
        private uint Volumen;
        public uint[] Korb;

        // konstruktor

        public Papierkorb() { }
        public Papierkorb(uint volumen)
        {
            Volumen = volumen;
            Korb = new uint[volumen];

            /*for (int i = 0; i < Korb.Length; i++)
            {
                Korb[i] = 0;
            }*/
        }

        // methoden
        public void InPapierkorb(uint id)
        {
            for (int i = 0; i < Korb.Length; i++)
            {
                if (Korb[i] == 0)
                {
                    Korb[i] = id;
                    break;
                }
            }
            if (Korb[Korb.Length - 1] != 0) Console.WriteLine("Papierkorb ist voll!");
        }
        /*
        public void Anzeigen(Artikel[] artikels)
        {
            for(int i = 0; i < this.Korb.Length; i++)
            {
                if (Korb[i] == 0) Console.WriteLine(" leer");
                else
                {
                    Artikelverwaltung.Anzeigen(Korb[i]);
                }

                // Ausgabe mit Objekt-Properties
                //Console.WriteLine(artikels[i].Hersteller + " " + artikels[i].Bezeichnung);
            }
        }
        */
        public void Leeren()
        {
            for (int i = 0; i < Korb.Length; i++)
            {
                if (Korb[i] != 0)
                {
                    Datenbank.DatensatzLoeschen(Korb[i]);
                    Korb[i] = 0;
                }
            }
        }
        public void Zuruecksetzen()
        {
            for (int i = 0; i < this.Korb.Length; i++)
            {
                Korb[i] = 0;
            }
        }
    }
}
