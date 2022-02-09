using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.Fragments
{
    public class OrdenSolucionar_Fragment :AndroidX.Fragment.App. Fragment
    {
        TextView lblFecha, lblHora, lblImgProblem, lblImgSolucion;
        EditText txtDiagnostico, txtFirmaClient, txtFirmaTenico;
        Button btnSubirImg1, btnSubirImg2, btnViImg1, btnViImg2, btnFinalizarOrden;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Activity.Title = "SOLUCIONAR ORDEN TECNICA";
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_OrdenProceso, container, false);
            lblFecha = view.FindViewById<TextView>(Resource.Id.lblFechaAtencion);
            lblHora = view.FindViewById<TextView>(Resource.Id.lblHoraAtencion);
            lblImgProblem = view.FindViewById<TextView>(Resource.Id.lblNomImageFirst);
            lblImgSolucion = view.FindViewById<TextView>(Resource.Id.lblNomImageLast);

            txtDiagnostico = view.FindViewById<EditText>(Resource.Id.txtDiagnostico);
            txtFirmaClient = view.FindViewById<EditText>(Resource.Id.txtFirmaCliente);
            txtFirmaTenico = view.FindViewById<EditText>(Resource.Id.txtFirmaTecnico);

            btnSubirImg1 = view.FindViewById<Button>(Resource.Id.btnSubirImg1);
            btnViImg1 = view.FindViewById<Button>(Resource.Id.btnTomarFoto1);

            btnSubirImg2 = view.FindViewById<Button>(Resource.Id.btnSubirImg2);
            btnViImg2 = view.FindViewById<Button>(Resource.Id.btnTomarFoto2);

            btnFinalizarOrden = view.FindViewById<Button>(Resource.Id.btnFinalizarOrden);

            return view;
        }
    }
}