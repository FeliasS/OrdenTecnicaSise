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

namespace OrdenTecnica_App.Models
{
    class Sucursal
    {
        internal int _ID_SUCURSAL { get; set; }

        internal string _COD_CLIENT_SUCURSAL { get; set; }

        internal string _DIRECCION { get; set; }

        internal string _TELEFONO { get; set; }

        internal string _NOMBRE_CONTACTO { get; set; }

        internal string _TELEFONO_CONTACTO { get; set; }

        internal string _CARGO_CONTACTO { get; set; }

        internal int _ESTADO { get; set; }

        internal int _FK_CLIENTE { get; set; } // Asociar con Cliente

    }
}