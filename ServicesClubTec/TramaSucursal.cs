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
    class TramaSucursal
    {
        public bool status { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<ListaS> lista { get; set; }
        public TramaSucursal()
        {
        }
    }

    class ListaS
    {
        public string ID_SUCURSAL { get; set; }
        public string COD_CLIENTE_SUCURSAL { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string NOMBRE_CONTACTO { get; set; }
        public string TELEFONO_CONTACTO { get; set; }
        public string CARGO_CONTACTO { get; set; }
        public string ESTADO { get; set; }
        public string FK_CLIENTE { get; set; }

        public ListaS()
        {
        }
    }
}