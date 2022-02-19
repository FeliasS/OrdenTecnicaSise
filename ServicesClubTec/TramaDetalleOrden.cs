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
    public class TramaDetalleOrden
    {
        public bool status { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<DetalleOrdenWs> lista { get; set; }

        public TramaDetalleOrden(bool status, int code, string message, List<DetalleOrdenWs> lista)
        {
            this.status = status;
            this.code = code;
            this.message = message;
            this.lista = lista;
        }

        public TramaDetalleOrden()
        {
        }
    }
}