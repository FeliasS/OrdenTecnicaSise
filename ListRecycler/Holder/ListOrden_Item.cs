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
using AndroidX.RecyclerView.Widget;

namespace OrdenTecnica_App.ListRecycler.Holder
{
    class ListOrden_Item : RecyclerView.ViewHolder
    {
        // Definiendo los elementos del Holder
        public TextView lblCodigo, lblAsunto, lblFecha, lblHora, lblEstado;

        // Modificamos el constructor para que reciba un nuevo argumento de evento Click en el Holder
        public ListOrden_Item(View itemView, Action<int> listener) : base(itemView)
        {
            // Intanciamos los elementos
            lblCodigo = itemView.FindViewById<TextView>(Resource.Id.lblCodigo);
            lblAsunto = itemView.FindViewById<TextView>(Resource.Id.lblAsunto);
            lblFecha = itemView.FindViewById<TextView>(Resource.Id.lblFecha);
            lblHora = itemView.FindViewById<TextView>(Resource.Id.lblHora);
            lblEstado = itemView.FindViewById<TextView>(Resource.Id.lblEstado);

            // Agregamos el evento Click
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}