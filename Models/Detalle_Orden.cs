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
    public class Detalle_Orden
    {
        internal int _ID_DETALLE_ORDEN { get; set; }
        internal string _COD_DETALLE_ORD { get; set; }
        internal string _DESCRIPCION { get; set; }
        internal string _IMAGEN { get; set; }
        internal string _ESTADO { get; set; } // Cambiar el tipo de dato a estado
        internal string _FK_DISPOSITIVO { get; set; } // Asociar con la clase Dispositivo (Cambiar el tido de dato en el adapter detalle orden)
        internal Orden _FK_ORDEN { get; set; } // Asociar con la clase Orden 

        public Detalle_Orden(string cOD_DETALLE_ORD, string dESCRIPCION, string eSTADO, string fK_DISPOSITIVO)
        {
            _COD_DETALLE_ORD = cOD_DETALLE_ORD;
            _DESCRIPCION = dESCRIPCION;
            _ESTADO = eSTADO;
            _FK_DISPOSITIVO = fK_DISPOSITIVO;
        }

        public Detalle_Orden()
        {
        }
    }
}