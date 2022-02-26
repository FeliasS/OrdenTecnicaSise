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
    class TramaDispositivo
    {
        public bool status { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public List<ListaD> lista { get; set; }
        public TramaDispositivo()
        {
        }
    }

    public class ListaD
    {
        public string ID_DISPOSITIVO { get; set; }
        public string COD_DISPOSITIVO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public object IMAGEN { get; set; }
        public string ESTADO { get; set; }
        public string FK_TIPOSISTEMA { get; set; }
        public string FK_DISPOSITIVO_NOMENCLATURA { get; set; }

        public ListaD()
        {
        }
    }
}