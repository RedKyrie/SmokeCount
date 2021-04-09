using Biblioteca.Models.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Biblioteca.Helpers
{
    public class PathHelper
    {
        private static string _uploadspath;
        private static string _imglibropath;
        public static string GetPacchettoImagePath(Pacchetto pacchetto)
        {
            return $"{_uploadspath}{_imglibropath}/{pacchetto.ID_pacchetto}/{pacchetto.Immagine}";
        }

        public static string GetPacchettoUrl(int id)
        {
            return $"/home/detail/{id}";
        }

        public static string GetHeetsUrl(int id)
        {
            return $"/home/detailheets/{id}";
        }
        public static string GetTabaccoUrl(int id)
        {
            return $"/home/detailtabacco/{id}";
        }

        public static void InitPaths()
        {
            _uploadspath = ConfigurationManager.AppSettings["uploadspath"];
            _imglibropath = ConfigurationManager.AppSettings["imglibropath"];
        }
    }
}