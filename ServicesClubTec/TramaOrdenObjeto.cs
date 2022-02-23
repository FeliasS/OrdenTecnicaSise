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
    class TramaOrdenObjeto
    {
        public bool status { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public OrdenTecnicaWS objeto { get; set; }

        public TramaOrdenObjeto(bool status, int code, string message, OrdenTecnicaWS objeto)
        {
            this.status = status;
            this.code = code;
            this.message = message;
            this.objeto = objeto;
        }
    }
}