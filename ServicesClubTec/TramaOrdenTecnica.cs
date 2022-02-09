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
    public class TramaOrdenTecnica
    {
        internal bool _status { get; set; }
        internal int _code { get; set; }
        internal string _message { get; set; }
        public List<OrdenTecnicaWS> _lista { get; set; }

        public TramaOrdenTecnica()
        {
        }
    }

    public class OrdenTecnicaWS
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

        public OrdenTecnicaWS(string cod_orden, string fecha_orden, string hora_orden,string estado)
        {
            COD_ORDEN = cod_orden;
            FECHA_ORDEN = fecha_orden;
            HORA_ORDEN = hora_orden;
            ESTADO = estado;
        }

        public OrdenTecnicaWS(string id_orden, string cod_orden, string asunto, string fecha_orden, string hora_orden, string remitente, string estado, string fk_sucursal, string fk_empleado)
        {
            ID_ORDEN = id_orden;
            COD_ORDEN = cod_orden;
            ASUNTO = asunto;
            FECHA_ORDEN = fecha_orden;
            HORA_ORDEN = hora_orden;
            REMITENTE = remitente;
            ESTADO = estado;
            FK_SUCURSAL = fk_sucursal;
            FK_EMPLEADO = fk_empleado;
        }

        public OrdenTecnicaWS()
        {
        }
    }
}