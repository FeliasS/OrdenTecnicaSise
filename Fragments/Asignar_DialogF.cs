using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using OrdenTecnica_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.Fragments
{
    class Asignar_DialogF: AndroidX.Fragment.App.DialogFragment,SearchView.IOnQueryTextListener
    {
        
        SearchView svAsigTecnico;

        public TextView lblcodigo, lblcliente, lblsucursal, lblasunto;

        //Definimos la orden que recibirá los datos del main
        Orden getOrden = new Orden();

        string cod;
        

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            
            View view = inflater.Inflate(Resource.Layout.fragment_AsignarTecnico, container, false);
            lblcodigo = view.FindViewById<TextView>(Resource.Id.lblAsigCodigo);
            lblcodigo.Text = cod;

            lblcliente = view.FindViewById<TextView>(Resource.Id.lblAsigCliente);
            lblsucursal = view.FindViewById<TextView>(Resource.Id.lblAsigSucursal);
            lblasunto = view.FindViewById<TextView>(Resource.Id.lblAsigAsunto);

            svAsigTecnico = view.FindViewById<SearchView>(Resource.Id.svAsignarView);
            RecyclerView rvAsigTecnico = view.FindViewById<RecyclerView>(Resource.Id.rvAsignarTecnico);
            Button btnAsignar = view.FindViewById<Button>(Resource.Id.btnAsignarTecnico);


            //Mostramos los dato en la actividad
            //lblcodigo.Text = miCodigo;
            //lblcliente.Text = miCliente;
            //lblsucursal.Text = miSucursal.ToString();
            //lblasunto.Text = miAsunto;
            
            Console.WriteLine("Codigo: " + lblcodigo.Text +
                "\n cliente: " + lblcliente.Text +
                "\n sucursal: " + lblsucursal.Text +
                "\n asunto: " + lblasunto.Text);
            return view;
        }

        public void SetInDialogOrden(Orden orden)
        {
            Console.WriteLine("orden ocdigo: " + orden.cod_orden);

            cod = orden.cod_orden;
            //lblcliente.Text = miCliente;
            //lblsucursal.Text = miSucursal.ToString();
            //lblasunto.Text = miAsunto;

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