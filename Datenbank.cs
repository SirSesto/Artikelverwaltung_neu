using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Artikelverwaltung_neu
{
    class Datenbank
    {
        public static NpgsqlConnection Vebindungsaufbau()
        {
            var cs = "Host=localhost;Username=postgres;Password=0000;Database=postgres;";
            var con = new NpgsqlConnection(cs);
            return con;
        }
        public static NpgsqlCommand Befehlszeile(NpgsqlConnection con)
        {
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            return cmd;
        }
        public static void InitBenutzerDb()
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            cmd.CommandText = "create table if not exists benutzer (benutzer_id BIGSERIAL, benutzername varchar(255), benutzerpasswort varchar(255));";
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public static void BenutzerHinzufuegen(Benutzer benutzer)
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            cmd.CommandText = $"insert into benutzer (benutzername, benutzerpasswort) values ('{benutzer.BenutzerName}', '{benutzer.BenutzerPasswort}')";
            cmd.ExecuteNonQuery();
            Console.WriteLine("Benutzer '{0}' hinzugefuegt.", benutzer.BenutzerName);

            con.Close();
        }

        // Artikel db 

        public static void InitArtikelDb()
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Artikel (artikel_id BIGSERIAL, artname VARCHAR(255) NOT NULL, hersteller VARCHAR(255) NOT NULL, beschreibung VARCHAR(255), gruppe VARCHAR(255), ek_preis NUMERIC NOT NULL, vk_preis NUMERIC);";
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public static int GetArtikelAnzahl()
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            string sql = "SELECT COUNT(id) FROM artikel;";

            var cmdReader = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmdReader.ExecuteReader();
            while (reader.Read())
            {
                return reader.GetInt32(0);
            }
            return -1;

        }
        public static Artikel[] ObjekteKonstruieren()
        {
            int cnt = GetArtikelAnzahl();
            Artikel[] artikels = new Artikel[cnt];

            uint id = 1;
            for (int i = 0; i < cnt; i++)
            {
                NpgsqlConnection con = Datenbank.Vebindungsaufbau();
                NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
                con.Open();

                string sql = $"select * from artikel where id = {id}";
                var cmd3 = new NpgsqlCommand(sql, con);

                NpgsqlDataReader reader = cmd3.ExecuteReader();
                while (reader.Read())
                {
                    artikels[i] = new Artikel(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
                con.Close();
                id++;
            }
            return artikels;
        }
        public static bool LoginAbfrage(string name, string passwort)
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            string sql = $"select count(*) from benutzer where benutzername = '{name}' and benutzerpasswort = '{passwort}';";
            var cmdReader = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmdReader.ExecuteReader();
            reader.Read();
            
            while (reader.Read())
            {
                if (reader.GetString(0) == "1")
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            return false;
        }
        public static void DatensatzHinzufuegen(Artikel artikel)
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            cmd.CommandText = $"INSERT INTO artikel (artname, hersteller, beschreibung, gruppe, ek_preis, vk_preis) VALUES ('{artikel.ArtName}', '{artikel.Hersteller}', '{artikel.Beschreibung}','{artikel.Gruppe}', {artikel.Ek_preis.ToString().Replace(',', '.')}, {artikel.Vk_preis.ToString().Replace(',', '.')});";
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public static void DatensatzLoeschen(uint id)
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            cmd.CommandText = "DELETE FROM artikel WHERE id =" + id;
            //cmd.CommandText = "UPDATE artikel SET bezeichnung = 'leer', hersteller = 'leer', ek_preis = 0, vk_preis = 0 WHERE id=" + id;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Artikel endgueltig geloescht.");

            con.Close();
        }
        public static void AlleArtikelAbfragen()
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            string sql = "SELECT * FROM artikel;";
            var cmd3 = new NpgsqlCommand(sql, con);

            NpgsqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4));
            }

            con.Close();
        }
        public static void ArtikelAbfragen(uint id)
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            string sql = $"select bezeichnung, hersteller from artikel where id = {id}";
            var cmd2 = new NpgsqlCommand(sql, con);

            NpgsqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
            }

            con.Close();
        }
        public static void DatensatzAbfragen(string table)
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            string sql = "select * from " + table;
            var cmd3 = new NpgsqlCommand(sql, con);

            NpgsqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
            }

            con.Close();
        }
        // Lager

        public static void InitLager()
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            cmd.CommandText = $"CREATE TABLE IF NOT EXISTS lager (id INT, ort VARCHAR(50), artikel_id INT NOT NULL, artikel_menge INT);";
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public static void ZuLagerHinzufuegen(Lager lager, Artikel artikel)
        {
            NpgsqlConnection con = Datenbank.Vebindungsaufbau();
            NpgsqlCommand cmd = Datenbank.Befehlszeile(con);
            con.Open();

            cmd.CommandText = $"INSERT INTO lager (id, ort, artikel_id, artikel_menge) VALUES ('{lager.Id}', '{lager.Standort}', {artikel.Id}, {lager.Artikelbestand[artikel]});";
            cmd.ExecuteNonQuery();

            con.Close();

            Console.WriteLine("Datenbank erfolgreich aktualisiert.");
            Console.Read();
        }
    }
}
