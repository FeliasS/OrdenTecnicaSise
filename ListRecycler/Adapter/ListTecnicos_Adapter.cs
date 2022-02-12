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
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.ListRecycler.Adapter
{
    class ListTecnicos_Adapter : RecyclerView.Adapter
    {
        List<TecnicoWs> lstTecnico;
        List<TecnicoWs> originalItems;

        public event EventHandler<int> ItemClick;

        public ListTecnicos_Adapter(List<TecnicoWs> lstTecnicos)
        {
            lstTecnico = lstTecnicos;
            originalItems = new List<TecnicoWs>();
            originalItems.AddRange(lstTecnicos);
        }

        public void filter(string strSearch)
        {
            if (strSearch.Length == 0)
            {
                lstTecnico.Clear();
                lstTecnico.AddRange(originalItems);
            }
            else
            {
                lstTecnico.Clear();
                List<TecnicoWs> newList = originalItems.Where(x => x.NOMBRES.StartsWith(strSearch)).ToList();
                lstTecnico.AddRange(newList);
            }
            NotifyDataSetChanged();
        }

        public override int ItemCount => lstTecnico.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ListTecnicos lst = holder as ListTecnicos;

            lst.lblCodTecnico.Text = lstTecnico[position].COD_EMPLEADO;
            lst.lblNombTecnico.Text = lstTecnico[position].NOMBRES +" "+  lstTecnico[position].APELLIDOS;

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_listTecnico, parent, false);
            ListTecnicos vh = new ListTecnicos(view,OnClick);

            return vh;
        }

        // Creamos un controlador en el adaptador que genera el evento ItemClick
        void OnClick(int position)
        {
            if (ItemClick != null)
            {
                ItemClick(this, position);
            }
        }
    }
}