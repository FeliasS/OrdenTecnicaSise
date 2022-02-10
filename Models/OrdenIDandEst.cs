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
    public class OrdenIDandEst
    {
        public int idOrden { get; set; }
        public int idEstado { get; set; }

        public OrdenIDandEst(int idOrden, int idEstado)
        {
            this.idOrden = idOrden;
            this.idEstado = idEstado;
        }

        public OrdenIDandEst()
        {
        }
    }
}