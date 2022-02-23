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
    public class UpdateDetalleOrden
    {
        public int idDetalleOrden { get; set; }
        public string descripcion { get; set; }
        public string imagen_inicio { get; set; }
        public string imagen_evidencia { get; set; }
        public string firma_cliente { get; set; }
        public string firma_tecnico { get; set; }
        public int estado { get; set; }
        public int id_dispositivo { get; set; }

        public UpdateDetalleOrden(int idDetalleOrden, string descripcion, string imagen_inicio, string imagen_evidencia, string firma_cliente, string firma_tecnico, int estado, int id_dispositivo)
        {
            this.idDetalleOrden = idDetalleOrden;
            this.descripcion = descripcion;
            this.imagen_inicio = imagen_inicio;
            this.imagen_evidencia = imagen_evidencia;
            this.firma_cliente = firma_cliente;
            this.firma_tecnico = firma_tecnico;
            this.estado = estado;
            this.id_dispositivo = id_dispositivo;
        }

        public UpdateDetalleOrden()
        {
        }
    }
}