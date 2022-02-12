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
    class ListTecnicos : RecyclerView.ViewHolder
    {
        public TextView lblCodTecnico, lblNombTecnico;
        public ListTecnicos(View itemView, Action<int>listener) : base(itemView)
        {
            lblCodTecnico = itemView.FindViewById<TextView>(Resource.Id.lblCodTecnico);
            lblNombTecnico = itemView.FindViewById<TextView>(Resource.Id.lblNomTecnico);

            //Agregamos evento Click
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}