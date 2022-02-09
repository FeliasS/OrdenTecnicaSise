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
using OrdenTecnica_App.Models;

namespace OrdenTecnica_App.Controller
{
    class CDetalle_Orden
    {
        public bool GuardarDetalleOrden(Detalle_Orden dOrden)
        {
            // consumimos el servicio
            return true;
        }

        //public List<Detalle_Orden> ListarO_Detalle()
        //{
        //    List<Detalle_Orden> lstO_Detalle = new List<Detalle_Orden>();
        //    for (int i = 0; i < 3; i++)
        //    {
        //        lstO_Detalle.Add(new Detalle_Orden("C00" +i,"Sensor de Calor","Pendiente"));
        //    }

        //    return lstO_Detalle;
        //}
    }
}