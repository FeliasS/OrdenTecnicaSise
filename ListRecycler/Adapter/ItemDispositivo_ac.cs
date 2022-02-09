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

namespace OrdenTecnica_App.ListRecycler.Adapter
{
    class ItemDispositivo_ac : ArrayAdapter<Dispositivo>
    {
        public List<Dispositivo> listCompleta_Dispositivo;

        public ItemDispositivo_ac(Context context, List<Dispositivo> lstDispositivo) : base(context, 0, lstDispositivo)
        {
            listCompleta_Dispositivo = new List<Dispositivo>(lstDispositivo);
        }
    }
}