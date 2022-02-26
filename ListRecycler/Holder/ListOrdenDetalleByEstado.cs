using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.ListRecycler.Holder
{
    class ListOrdenDetalleByEstado : RecyclerView.ViewHolder
    {
        public TextView lblDispositivo, lblProblema, lblEstado;

        public ListOrdenDetalleByEstado(View itemView, Action<int> listener) : base(itemView)
        {
            lblDispositivo = itemView.FindViewById<TextView>(Resource.Id.txtODEDispo);
            lblProblema = itemView.FindViewById<TextView>(Resource.Id.txtODEProblema);
            lblEstado = itemView.FindViewById<TextView>(Resource.Id.txtODEEstado);


            //Agregamos el evento Click
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}