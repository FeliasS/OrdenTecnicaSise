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
    public class TramaPostDetalleOrdWs
    {
        public string DESCRIPCION { get; set; }
        public string IMAGENES { get; set; }
        public string IMAGENES_EVIDENCIA { get; set; }
        public string FIRMA_CLIENTE { get; set; }
        public string FIRMA_TECNICO { get; set; }
        public string FK_DISPOSITIVO { get; set; }

        public TramaPostDetalleOrdWs(string dESCRIPCION, string iMAGENES, string iMAGENES_EVIDENCIA, string fIRMA_CLIENTE, string fIRMA_TECNICO, string fK_DISPOSITIVO)
        {
            DESCRIPCION = dESCRIPCION;
            IMAGENES = iMAGENES;
            IMAGENES_EVIDENCIA = iMAGENES_EVIDENCIA;
            FIRMA_CLIENTE = fIRMA_CLIENTE;
            FIRMA_TECNICO = fIRMA_TECNICO;
            FK_DISPOSITIVO = fK_DISPOSITIVO;
        }

        public TramaPostDetalleOrdWs()
        {
        }


    }
}