using Biblioteca.Models.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Dapper;

namespace Biblioteca.Helpers
{
    public class DatabaseHelper  //contiene le query
    {
        private static string _connectionString;
        public static void InitConnectionString()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbBiblioteca"].ConnectionString;
        }

        #region heets
        public static List<Heetss> GetAllHeets()  //visualizza tutte le heets
        {
            var heets = new List<Heetss>();
            using (var connectin = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM heets";
                heets = connectin.Query<Heetss>(sql).ToList();
            }
            return heets;
        }

        public static Heetss GetHeetsById(int id)  //visualizza le heets per ID
        {
            var heets = new Heetss();
            using (var connectin = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM heets WHERE ID = @ID";
                heets = connectin.Query<Heetss>(sql, new { id }).First();
            }
            return heets;
        }
        #endregion

        #region pacchetto
        public static List<Pacchetto> GetAllPacchetti()  //visualizza tutti i libri
        {
            var pacchetto = new List<Pacchetto>();
            using (var connectin = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM pacchetto";
                pacchetto = connectin.Query<Pacchetto>(sql).ToList();
            }

            return pacchetto;
        }

        public static Pacchetto GetPacchettoById(int id)  //visualizza i libri per ID
        {
            var pacchetti = new Pacchetto();
            using (var connectin = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM pacchetto WHERE ID_pacchetto = @id";
                pacchetti = connectin.Query<Pacchetto>(sql, new { id }).First();
            }

            return pacchetti;
        }
        #endregion

        #region utente
        public static bool ExistsUtenteByEmail(string email)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT ID FROM utenti WHERE email = @email and password <>''";
                var ID = connection.Query<int>(sql, new { email }).FirstOrDefault();
                return ID > 0;
            }
        }

        public static int InsertUtente(Utente utente)
        {
            var id = 0;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var sql = "INSERT INTO utenti (nome, email, password, isprivacy) " +
                        "VALUES (@nome,@email, @password,1); " +
                        "SELECT LAST_INSERT_ID()";
                    id = connection.Query<int>(sql, utente).First();
                }
            }
            catch (Exception ex)
            {
                //TODO qui bisognerebbe loggare l'errore ex.Message
            }
            return id;
        }

        public static bool UpdatePassword(int ID_utente, string password)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var sql = "UPDATE utenti SET password = @password WHERE id = @ID_utente";
                    connection.Query(sql, new { ID_utente, password });
                }
            }
            catch (Exception ex)
            {
                //TODO qui bisognerebbe loggare l'errore ex.Message
                return false;
            }
            return true;
        }

        public static Utente GetUtenteByEmail(string email)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM utenti WHERE email = @email and password <>''";
                return connection.Query<Utente>(sql, new { email }).FirstOrDefault();
            }
        }
        #endregion

        #region tabacco
        public static List<Tabacco> GetAllTabacco()  //visualizza tutte le tabacco
        {
            var tab = new List<Tabacco>();
            using (var connectin = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM tabacco";
                tab = connectin.Query<Tabacco>(sql).ToList();
            }
            return tab;
        }

        public static Tabacco GetTabaccoById(int id)  //visualizza le Tabacco per ID
        {
            var tab = new Tabacco();
            using (var connectin = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM tabacco WHERE ID = @ID";
                tab = connectin.Query<Tabacco>(sql, new { id }).First();
            }
            return tab;
        }
        #endregion
    }
}