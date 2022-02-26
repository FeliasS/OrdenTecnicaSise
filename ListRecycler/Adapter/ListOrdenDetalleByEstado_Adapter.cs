using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using OrdenTecnica_App.ListRecycler.Holder;
using OrdenTecnica_App.ServicesClubTec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.ListRecycler.Adapter
{
    class ListOrdenDetalleByEstado_Adapter : RecyclerView.Adapter
    {
        //Definimos los elementos del item_detallebyestado
        List<DetalleOrdenWs> lstOrden;

        //Definimos un miembro controlador de evento click
        public event EventHandler<int> ItemClick;

        public ListOrdenDetalleByEstado_Adapter(List<DetalleOrdenWs> lstOD)
        {
            lstOrden = lstOD;
        }

        public override int ItemCount => lstOrden.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ListOrdenDetalleByEstado lstOD_holder = holder as ListOrdenDetalleByEstado;
            lstOD_holder.lblDispositivo.Text = lstOrden[position].FK_DISPOSITIVO;
            lstOD_holder.lblProblema.Text = lstOrden[position].DESCRIPCION;
            //lstOD_holder.lblODEstado.Text = lstOrdenD[position].ESTADO;

            switch (lstOrden[position].ESTADO)
            {
                case 1:
                    lstOD_holder.lblEstado.Text = "PENDIENTE";
                    
                    break;
                case 2:
                    lstOD_holder.lblEstado.Text = "ATENDIDO";
                    break;
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_listOrdenDetalleByEstado, parent, false);
            ListOrdenDetalleByEstado vH_OD = new ListOrdenDetalleByEstado(view, Onclick);
            return vH_OD;
        }

        void Onclick(int position)
        {
            if (ItemClick != null)
            {
                ItemClick(this, position);
            }
        }
    }
}