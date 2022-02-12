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
    public class TecnicoWs
    {
        public int ID_EMPLEADO { get; set; }
        public string COD_EMPLEADO { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string TELEFONO_MOVIL_1 { get; set; }
        public string PERFIL { get; set; }

        public TecnicoWs(int iD_EMPLEADO, string cOD_EMPLEADO, string nOMBRES, string aPELLIDOS, string tELEFONO_MOVIL_1, string pERFIL)
        {
            ID_EMPLEADO = iD_EMPLEADO;
            COD_EMPLEADO = cOD_EMPLEADO;
            NOMBRES = nOMBRES;
            APELLIDOS = aPELLIDOS;
            TELEFONO_MOVIL_1 = tELEFONO_MOVIL_1;
            PERFIL = pERFIL;
        }

    }
}