using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using OrdenTecnica_App.ListRecycler.Holder;
using OrdenTecnica_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.ListRecycler.Adapter
{
    class ListOrdenDetalle_Adapter : RecyclerView.Adapter
    {
        // Definimos una lista de orden detalle
        List<Detalle_Orden> lstOrdenD;

        //Definimos un miembro controlador de evento click
        public event EventHandler<int> ItemClick;

        public ListOrdenDetalle_Adapter(List<Detalle_Orden> lstOD)
        {
            lstOrdenD = lstOD;
        }

        public override int ItemCount => lstOrdenD.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ListOrdenDetalle lstOD_holder = holder as ListOrdenDetalle;
            lstOD_holder.lblODCodigo.Text = lstOrdenD[position]._COD_DETALLE_ORD;
            lstOD_holder.lblODDispositivo.Text = lstOrdenD[position]._FK_DISPOSITIVO;
            lstOD_holder.lblODEstado.Text = lstOrdenD[position]._ESTADO;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_listOrdenDetalle, parent, false);
            ListOrdenDetalle vH_OD = new ListOrdenDetalle(view, Onclick);
            return vH_OD;
        }

        void Onclick(int position)
        {
            if (ItemClick!= null)
            {
                ItemClick(this, position);
            }
        }
    }
}