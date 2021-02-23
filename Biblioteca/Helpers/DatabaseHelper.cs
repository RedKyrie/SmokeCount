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
    }
}