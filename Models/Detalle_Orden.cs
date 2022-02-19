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
        public string ID_ORDEN_DETALLE { get; set; }
        public string COD_ORDEN_DETALLE { get; set; }
        public string DESCRIPCION { get; set; }
        public string IMAGENES { get; set; }
        public string IMAGENES_EVIDENCIA { get; set; }
        public string FIRMA_CLIENTE { get; set; }
        public string FIRMA_TECNICO { get; set; }
        public string ESTADO { get; set; }
        public string FK_DISPOSITIVO { get; set; }
        public string FK_ORDEN { get; set; }

        public Detalle_Orden(string iD_ORDEN_DETALLE, string cOD_ORDEN_DETALLE, string dESCRIPCION, string iMAGENES, string iMAGENES_EVIDENCIA, string fIRMA_CLIENTE, string fIRMA_TECNICO, string eSTADO, string fK_DISPOSITIVO, string fK_ORDEN)
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
            FK_ORDEN = fK_ORDEN;
        }

        public Detalle_Orden()
        {
        }
    }
}