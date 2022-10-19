using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Artikelverwaltung_neu
{
    class Lager
    {
        public uint Id;
        public string Standort;
        public Dictionary<Artikel, uint> Artikelbestand = new Dictionary<Artikel, uint>();

        // Konstruktor
        public Lager() { }
        public Lager(uint id, string ort)
        {
            Id = id;
            Standort = ort;
        }

        // Methoden

        public void ArtikelHinzufuegen(Artikel artikel, uint anzahl)
        {
            Artikelbestand[artikel] = anzahl;
            Datenbank.ZuLagerHinzufuegen(this, artikel);
        }
        public void InventarAnzeigen()
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            string sql = "SELECT  FROM artikel WHERE bezeichnung != 'leer';";
            var cmd3 = new NpgsqlCommand(sql, con);

            NpgsqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4));
            }

            con.Close();
        }
    }
}
