using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.ListRecycler.Holder
{
    class ListOrdenDetalle : RecyclerView.ViewHolder
    {
        //Definimos los elementos del item_listOrdenDetalle
        public TextView lblODCodigo, lblODDispositivo, lblODEstado;

        public ListOrdenDetalle(View itemView, Action<int> listener) : base(itemView)
        {
            lblODCodigo = itemView.FindViewById<TextView>(Resource.Id.txtODCodigo);
            lblODDispositivo = itemView.FindViewById<TextView>(Resource.Id.txtODDispo);
            lblODEstado = itemView.FindViewById<TextView>(Resource.Id.txtODEstado);

            //Agregamos el evento Click
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}