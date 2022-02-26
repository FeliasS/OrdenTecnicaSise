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
    class TramaCliente
    {
        public bool status { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<ListaC> lista { get; set; }
        public TramaCliente()
        {
        }
    }

    class ListaC
    {
        public string ID_CLIENTE { get; set; }
        public string COD_CLIENTE { get; set; }
        public string RAZON_SOCIAL { get; set; }
        public string RUC { get; set; }
        public string TELEFONO_1 { get; set; }
        public string TELEFONO_2 { get; set; }
        public string DIRECCION { get; set; }
        public string ESTADO { get; set; }

        public ListaC()
        {
        }
    }
}