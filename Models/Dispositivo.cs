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
    public class Dispositivo
    {
        internal int _ID_DISPOSITIVO { get; set; }
        internal string _COD_DISPOSITIVO { get; set; }
        internal string _NOMBRE { get; set; }
        internal string _DESCRIPCION { get; set; }
        internal string _IMAGEN { get; set; }
        internal int _ESTADO { get; set; }
        internal int _FK_TIPOSISTEMA { get; set; }
        internal int _FK_DISPOSITIVO_NOMENCLATURA { get; set; }

        public Dispositivo()
        {
        }
    }
}