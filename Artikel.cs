using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung_neu
{
    class Artikel
    {
        public int Id { get; set; }
        public string ArtName { get; set; }
        public string Beschreibung { get; set; }
        public char Gruppe { get; set; }
        public string Hersteller { get; set; }
        private double ek_preis;
        private double vk_preis;
        public double Ek_preis
        {
            get { return ek_preis; }
            set
            {
                if (value > 0)
                    ek_preis = value;
                else
                    Console.WriteLine("Preis muss größer als 0 sein!");
            }
        }
        public double Vk_preis
        {
            get { return vk_preis; }
            set
            {
                if (value > 0)
                    vk_preis = value;
                else
                    Console.WriteLine("Preis muss größer als 0 sein!");
            }
        }
        public uint ArtikelAnzahl = 0;

        // Konstrukoren

        public Artikel()
        {
            ArtikelAnzahl++;
        }
        public Artikel(int id, string artname, string hersteller)
        {
            this.Id = id;
            this.ArtName = artname;
            this.Hersteller = hersteller;
        }
        public Artikel(string artname, string hersteller, string beschreibung, char gruppe, double ek_preis, double vk_preis)
        {
            ArtName = artname;
            Hersteller = hersteller;
            Beschreibung = beschreibung;
            Gruppe = gruppe;
            Ek_preis = ek_preis;
            Vk_preis = vk_preis;
        }

        public Artikel(uint id, string artname, string hersteller, double ek_preis, double vk_preis)
        {
            Id = Convert.ToInt32(id);
            ArtName = artname;
            Hersteller = hersteller;
            Ek_preis = ek_preis;
            Vk_preis = vk_preis;
        }

        // Methoden

        public void ArtikelInfo()
        {
            Console.WriteLine("Bezeichnung = {0}, Hersteller = {1}, EK-Preis = {2}, VK-Preis = {3}", ArtName, Hersteller, Beschreibung, Gruppe, ek_preis, vk_preis);
        }

        /*public double VKBerechnung(double marge, double ekPreis, int mwst, Kosten selbstkosten)
        {
            double vkPreis = marge + ekPreis + mwst + selbstkosten.nbKosten;
            return vkPreis;
        }*/
    }
}
