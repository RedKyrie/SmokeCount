﻿using Biblioteca.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models.View
{
    public class DetailViewModel
    {
        public Pacchetto Pacchetto { get; set; }
        public string MessaggioErrore { get; set; } //Da non usare se non neccessario
    }
}