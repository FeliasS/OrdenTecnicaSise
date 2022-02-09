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
    class ItemCliente_ac : ArrayAdapter<Cliente>
    {
        public List<Cliente> listCompletaCliente;
        public ItemCliente_ac(Context context, List<Cliente> lstCliente) : base(context, 0,lstCliente)
        {
            listCompletaCliente = new List<Cliente>(lstCliente);
        }
    }
}