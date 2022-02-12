using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.ServicesClubTec
{
    public class TramaTecnicoLista
    {
        public bool status { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<TecnicoWs> lista { get; set; }

        public TramaTecnicoLista(bool status, int code, string message, List<TecnicoWs> lista)
        {
            this.status = status;
            this.code = code;
            this.message = message;
            this.lista = lista;
        }

        public TramaTecnicoLista()
        {
        }
    }
}