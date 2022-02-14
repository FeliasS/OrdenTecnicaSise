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

namespace OrdenTecnica_App.Interface
{
    interface ISolucionOrden
    {
        void AbrirSolucionOrden0(OrdenWs orden);
        void AbrirSolucionOrden();
        void AbrirOrdenProceso();
    }
}