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
    public class TramaOrden
    {
        public bool status { get; set; }
        public int code { get; set; }
        public string message { get; set; }

        public TramaOrden(bool status, int code, string message)
        {
            this.status = status;
            this.code = code;
            this.message = message;
        }
    }
}