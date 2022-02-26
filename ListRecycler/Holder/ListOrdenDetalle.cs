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
        public TextView lblODProblema, lblODDispositivo, lblODEstado, lblNOEstado;
        public LinearLayout linearLayoutEstado;

        public ListOrdenDetalle(View itemView, Action<int> listener) : base(itemView)
        {
            lblODDispositivo = itemView.FindViewById<TextView>(Resource.Id.txtODDispo);
            lblODProblema = itemView.FindViewById<TextView>(Resource.Id.txtODProblema);
            lblNOEstado = itemView.FindViewById<TextView>(Resource.Id.lblNOEstado);
            //linearLayoutEstado = itemView.FindViewById<LinearLayout>(Resource.Id.linearLayoutEstado);

            //if (lblODEstado.Text==null)
            //{
            //    linearLayoutEstado.Visibility = ViewStates.Gone;
            //}
            //else
            //{
            //    //lblODEstado.Visibility = ViewStates.Visible;
            //    linearLayoutEstado.Visibility = ViewStates.Visible;
            //}

            //Agregamos el evento Click
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}