using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models.Entity
{
    public class Pacchetto //creazione entità Utent (deve avere gli stessi campi e tipi di campi della tabella del database su phpmyadmin)
    {
        public int ID_pacchetto{ get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public double Costo { get; set; }
        public string Immagine { get; set; }
        public string Catrame { get; set; }
        public string Nicotina { get; set; }
        public string Monossido { get; set; }
        public int N_sigarette { get; set; }
        public int FK_Utenti { get; set; }
    }
}