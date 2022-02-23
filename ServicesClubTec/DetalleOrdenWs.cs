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
    public class DetalleOrdenWs
    {
        public string ID_ORDEN_DETALLE { get; set; }
        public string COD_ORDEN_DETALLE { get; set; }
        public string DESCRIPCION { get; set; }
        public string IMAGENES { get; set; }
        public string IMAGENES_EVIDENCIA { get; set; }
        public string FIRMA_CLIENTE { get; set; }
        public string FIRMA_TECNICO { get; set; }
        public int ESTADO { get; set; }
        public string FK_DISPOSITIVO { get; set; }

        public DetalleOrdenWs(string iD_ORDEN_DETALLE, string cOD_ORDEN_DETALLE, string dESCRIPCION, string iMAGENES, string iMAGENES_EVIDENCIA, string fIRMA_CLIENTE, string fIRMA_TECNICO, int eSTADO, string fK_DISPOSITIVO)
        {
            ID_ORDEN_DETALLE = iD_ORDEN_DETALLE;
            COD_ORDEN_DETALLE = cOD_ORDEN_DETALLE;
            DESCRIPCION = dESCRIPCION;
            IMAGENES = iMAGENES;
            IMAGENES_EVIDENCIA = iMAGENES_EVIDENCIA;
            FIRMA_CLIENTE = fIRMA_CLIENTE;
            FIRMA_TECNICO = fIRMA_TECNICO;
            ESTADO = eSTADO;
            FK_DISPOSITIVO = fK_DISPOSITIVO;
        }

        public DetalleOrdenWs()
        {
        }
        //public string FK_ORDEN { get; set; }




    }
}