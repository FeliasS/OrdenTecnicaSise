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
        public string FECHA_ATENCION { get; set; }
        public string HORA_ATENCION { get; set; }
        public string REMITENTE { get; set; }
        public string ESTADO { get; set; }
        public string FK_SUCURSAL { get; set; }
        public string FK_EMPLEADO { get; set; }
        public List<DetalleOrdenWs> listaDetalleOrden { get; set; }

        public OrdenTecnicaWS(string iD_ORDEN, string cOD_ORDEN, string aSUNTO, string fECHA_ORDEN, string hORA_ORDEN, string fECHA_ATENCION, string hORA_ATENCION, string rEMITENTE, string eSTADO, string fK_SUCURSAL, string fK_EMPLEADO, List<DetalleOrdenWs> listaDetalleOrden)
        {
            ID_ORDEN = iD_ORDEN;
            COD_ORDEN = cOD_ORDEN;
            ASUNTO = aSUNTO;
            FECHA_ORDEN = fECHA_ORDEN;
            HORA_ORDEN = hORA_ORDEN;
            FECHA_ATENCION = fECHA_ATENCION;
            HORA_ATENCION = hORA_ATENCION;
            REMITENTE = rEMITENTE;
            ESTADO = eSTADO;
            FK_SUCURSAL = fK_SUCURSAL;
            FK_EMPLEADO = fK_EMPLEADO;
            this.listaDetalleOrden = listaDetalleOrden;
        }

        public OrdenTecnicaWS()
        {
        }
    }
}