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
    public class TramaOrdenLista
    {
        internal bool status { get; set; }
        internal int code { get; set; }
        internal string message { get; set; }
        public List<OrdenWs> lista { get; set; }

        public TramaOrdenLista(bool status, int code, string message, List<OrdenWs> lista)
        {
            this.status = status;
            this.code = code;
            this.message = message;
            this.lista = lista;
        }
    }
}