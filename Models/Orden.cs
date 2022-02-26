using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using OrdenTecnica_App.ServicesClubTec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.Models
{
    public class Orden
    {
        public string idOrden { get; set; }
        public string cod_orden { get; set; }
        public string asunto { get; set; }
        public string fecha_orden { get; set; } // Cambiar el tipo a Date
        public string hora_orden { get; set; } // Cambiar el tipo a Time
        public string fecha_atencion { get; set; }
        public string hora_atencion { get; set; }
        public string remitente { get; set; }
        public int estado { get; set; } // es un foreign key en la BD
        public string id_sucursal { get; set; } // Foreign key
        public int id_empleado { get; set; } // foreign key

        public List<DetalleOrdenWs> listaDetalleOrden { get; set; }

        public Orden()
        {

        }

        public Orden(string cod_orden, string asunto, string fecha_orden, string hora_orden, string remitente, int estado, string id_sucursal, int id_empleado, List<DetalleOrdenWs> listaDetalleOrden)
        {
            this.cod_orden = cod_orden;
            this.asunto = asunto;
            this.fecha_orden = fecha_orden;
            this.hora_orden = hora_orden;
            this.remitente = remitente;
            this.estado = estado;
            this.id_sucursal = id_sucursal;
            this.id_empleado = id_empleado;
            this.listaDetalleOrden = listaDetalleOrden;
        }

        public Orden(string idOrden, string cod_orden, string asunto, string fecha_orden, string hora_orden, string fecha_atencion, string hora_atencion, string remitente, int estado, string id_sucursal, int id_empleado, List<DetalleOrdenWs> listaDetalleOrden)
        {
            this.idOrden = idOrden;
            this.cod_orden = cod_orden;
            this.asunto = asunto;
            this.fecha_orden = fecha_orden;
            this.hora_orden = hora_orden;
            this.fecha_atencion = fecha_atencion;
            this.hora_atencion = hora_atencion;
            this.remitente = remitente;
            this.estado = estado;
            this.id_sucursal = id_sucursal;
            this.id_empleado = id_empleado;
            this.listaDetalleOrden = listaDetalleOrden;
        }
    }

    public class OrdenEmpleado
    {
        public int idOrden { get; set; }
        public int idEmpleado { get; set; }

        public OrdenEmpleado(int idOrden, int idEmpleado)
        {
            this.idOrden = idOrden;
            this.idEmpleado = idEmpleado;
        }

        public OrdenEmpleado()
        {
        }
    }
}