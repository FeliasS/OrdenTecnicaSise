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

namespace OrdenTecnica_App.Fragments
{
    class Asignado_DialogF: AndroidX.Fragment.App.DialogFragment
    {
        TextView lblCodigo, lblCliente, lblSucursal, lblDispositivo, lblTecnico, lblAsunto, lblProblema;
        Button btnSolucion;

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            return base.OnCreateDialog(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_OrdenAsignada, container, false);

            lblCodigo = view.FindViewById<TextView>(Resource.Id.lblCodigoAsignado);
            lblCliente = view.FindViewById<TextView>(Resource.Id.lblNomCliente);
            lblSucursal = view.FindViewById<TextView>(Resource.Id.lblSucursalAsignado);
            lblDispositivo = view.FindViewById<TextView>(Resource.Id.lblDispositivoAsignado);
            lblTecnico = view.FindViewById<TextView>(Resource.Id.lblTecnicoAsignado);
            lblAsunto = view.FindViewById<TextView>(Resource.Id.lblAsuntoAsginado);
            lblProblema = view.FindViewById<TextView>(Resource.Id.lblProblema);
            btnSolucion = view.FindViewById<Button>(Resource.Id.btnSolucion);


            return view;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }

    }
}