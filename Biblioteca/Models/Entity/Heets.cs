using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models.Entity
{
    public class Heets
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public double Costo { get; set; }
        public string Immagine { get; set; }
        public string Catrame { get; set; }
        public string Nicotina { get; set; }
        public string Monossido { get; set; }
        public int N_sigarette { get; set; }
    }
}