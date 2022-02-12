using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using OrdenTecnica_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.Interface
{
    interface INuevaOrden
    {
        void AbrirListaPendiente();

        void AsigarOrden(Orden orden);

        void ListarOrdenCreado();
    }
}