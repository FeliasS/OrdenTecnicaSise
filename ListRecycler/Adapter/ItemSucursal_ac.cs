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
    class ItemSucursal_ac : ArrayAdapter<Sucursal>
    {
        public List<Sucursal> listaCompleta_Sucursal;

        public ItemSucursal_ac(Context context, List<Sucursal> lstSucursal) : base(context, 0, lstSucursal)
        {
            listaCompleta_Sucursal = new List<Sucursal>(lstSucursal);
        }
    }
}