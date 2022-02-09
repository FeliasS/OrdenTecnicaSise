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
    class OrdenAEstado
    {
        public int idEstado { get; set; }
        public int idEmpleado { get; set; }

        public OrdenAEstado(int idEstado, int idEmpleado)
        {
            this.idEstado = idEstado;
            this.idEmpleado = idEmpleado;
        }

        public OrdenAEstado()
        {
        }
    }
}