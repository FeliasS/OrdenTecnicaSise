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
    public class OrdenWs
    {
        public string ID_ORDEN { get; set; }
        public string COD_ORDEN { get; set; }
        public string ASUNTO { get; set; }
        public string FECHA_ORDEN { get; set; }
        public string HORA_ORDEN { get; set; }
        public string REMITENTE { get; set; }
        public string ESTADO { get; set; }
        public string FK_SUCURSAL { get; set; }
        public string FK_EMPLEADO { get; set; }


        public OrdenWs()
        {
        }
    }
}