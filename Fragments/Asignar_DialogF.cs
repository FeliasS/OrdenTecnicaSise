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

namespace OrdenTecnica_App.Fragments
{
    class Asignar_DialogF: AndroidX.Fragment.App.DialogFragment,SearchView.IOnQueryTextListener
    {
        private int _clickCount;

        SearchView svAsigTecnico;

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Bundle args = this.Arguments;

            return base.OnCreateDialog(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.fragment_AsignarTecnico, container, false);
            var lblNombre = view.FindViewById<TextView>(Resource.Id.lblNomCliente);
            var lblSucursal = view.FindViewById<TextView>(Resource.Id.lblNomSucursal);
            var lblDispositivo = view.FindViewById<TextView>(Resource.Id.lblNomDispositivo);
            var lblProblema = view.FindViewById<TextView>(Resource.Id.lblProblema);

            svAsigTecnico = view.FindViewById<SearchView>(Resource.Id.svAsignarView);
            RecyclerView rvAsigTecnico = view.FindViewById<RecyclerView>(Resource.Id.rvAsignarTecnico);
            Button btnAsignar = view.FindViewById<Button>(Resource.Id.btnAsignarTecnico);


            return view;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {

            base.OnActivityCreated(savedInstanceState);
        }

        public bool OnQueryTextChange(string newText)
        {
            throw new NotImplementedException();
        }

        public bool OnQueryTextSubmit(string query)
        {
            throw new NotImplementedException();
        }
    }
}