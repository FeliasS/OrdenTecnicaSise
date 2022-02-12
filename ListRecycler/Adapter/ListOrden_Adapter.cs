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
using OrdenTecnica_App.ListRecycler.Holder;
using OrdenTecnica_App.Models;
using OrdenTecnica_App.ServicesClubTec;

namespace OrdenTecnica_App.ListRecycler.Adapter
{
    class ListOrden_Adapter : RecyclerView.Adapter
    {
        // Definimos una lista de Ordenes
        List<OrdenWs> lstOrden;

        //lista original
        List<OrdenWs> originalItems;

        // Definimos un miembro controlador de evento click
        public event EventHandler<int> ItemClick;

        public ListOrden_Adapter(List<OrdenWs> ordens)
        {
            lstOrden = ordens;

            originalItems = new List<OrdenWs>();
            originalItems.AddRange(ordens);
        }

        public void filter(string strSearch)
        {
            if (strSearch.Length==0)
            {
                lstOrden.Clear();
                lstOrden.AddRange(originalItems);
            }
            else
            {
                lstOrden.Clear();
                List<OrdenWs> newList = originalItems.Where(x => x.ASUNTO.StartsWith(strSearch)).ToList();
                lstOrden.AddRange(newList);
            }
            NotifyDataSetChanged();
        }


        public override int ItemCount => lstOrden.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ListOrden_Item itemHolder = holder as ListOrden_Item;

            itemHolder.lblCodigo.Text = lstOrden[position].COD_ORDEN;
            itemHolder.lblAsunto.Text = lstOrden[position].ASUNTO;
            itemHolder.lblFecha.Text = lstOrden[position].FECHA_ORDEN;
            itemHolder.lblHora.Text = lstOrden[position].HORA_ORDEN;
            //itemHolder.lblEstado.Text = lstOrden[position].ESTADO;

            switch (lstOrden[position].ESTADO)
            {
                case "1":
                    itemHolder.lblEstado.Text = "POR ASIGNAR";
                    break;

                case "2":
                    itemHolder.lblEstado.Text = "ASIGNADOS";
                    break;

                case "3":
                    itemHolder.lblEstado.Text = "EN PROCESO";
                    break;

                case "4":
                    itemHolder.lblEstado.Text = "ATENDIDO";
                    break;

                case "5":
                    itemHolder.lblEstado.Text = "CERRADO";
                    break;
            }

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_listOrdenTecnica, parent, false);
            ListOrden_Item vh = new ListOrden_Item(view, OnClick);
            return vh;
        }

        // Creamos un controlador en el adaptador que genera el evento ItemClick
        void OnClick(int position)
        {
            if (ItemClick != null)
            {
                ItemClick(this,position);
            }
        }

    }
}