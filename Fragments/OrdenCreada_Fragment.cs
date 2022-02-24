using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Newtonsoft.Json;
using OrdenTecnica_App.Interface;
using OrdenTecnica_App.ListRecycler.Adapter;
using OrdenTecnica_App.Models;
using OrdenTecnica_App.ServicesClubTec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace OrdenTecnica_App.Fragments
{
    public class OrdenCreada_Fragment : AndroidX.Fragment.App.Fragment, SearchView.IOnQueryTextListener
    {
        //Definimos los elementos del view
        SearchView sOrdenProceso;
        RecyclerView rvOrdenProceso;

        //Definimos el adaptador del recyclerViewAdapter
        RecyclerView.LayoutManager mLayoutManager;
        ListOrden_Adapter mAdapter;

        public static string idOrden;

        //Definimos el modelo de ordenWs
        List<OrdenWs> lstOrdenProceso;

        //Definimos la interface
        private INuevaOrden iNuevaOrden;



        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            iNuevaOrden = (INuevaOrden)context;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Activity.Title = "ORDENES CREADAS";
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_listOrdenes, container, false);

            sOrdenProceso = view.FindViewById<SearchView>(Resource.Id.searchListOrdenes);
            rvOrdenProceso = view.FindViewById<RecyclerView>(Resource.Id.recyclerVListOrdenes);

            //instanciamos el recyclerView
            mLayoutManager = new LinearLayoutManager(Activity);
            rvOrdenProceso.SetLayoutManager(mLayoutManager);
            ListOrdnCreada();
            SearchOrdenCreada();
            return view;
        }

        public bool OnQueryTextChange(string newText)
        {
            mAdapter.filter(newText);
            return false;
        }

        public bool OnQueryTextSubmit(string query)
        {
            throw new NotImplementedException();
        }

        private void SearchOrdenCreada()
        {
            sOrdenProceso.SetOnQueryTextListener(this);
        }

        public async void ListOrdnCreada()
        {
            Orden est = new Orden();
            est.estado = 1;

            Console.WriteLine("dato: " + est.estado);
            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/buscarOrdenByEstado ");

            var json = JsonConvert.SerializeObject(est);
            Console.WriteLine("parametros enviados: " + json);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var postJson = await client.PostAsync(url, content);

            if (postJson.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string readJson = await postJson.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<TramaOrdenLista>(readJson);

                if (response.status == true && response.code == 1)
                {
                    Console.WriteLine("mensaje: " + response.message);
                    lstOrdenProceso = response.lista;

                    mAdapter = new ListOrden_Adapter(lstOrdenProceso);
                    rvOrdenProceso.SetAdapter(mAdapter);
                    postJson.Dispose();//Cerramos el servicio
                    mAdapter.ItemClick += MAdapter_ItemClick;
                }
            }
            else if (postJson.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Toast.MakeText(Activity, "no se pudo procesar la operacion", ToastLength.Short).Show();
            }
        }

        private void MAdapter_ItemClick(object sender, int e)
        {
            Orden ordenAsig = new Orden();
            ordenAsig.idOrden = lstOrdenProceso[e].ID_ORDEN;
            ordenAsig.cod_orden = lstOrdenProceso[e].COD_ORDEN;
            ordenAsig.asunto = lstOrdenProceso[e].ASUNTO;
            ordenAsig.remitente = lstOrdenProceso[e].REMITENTE;
            ordenAsig.id_sucursal = int.Parse(lstOrdenProceso[e].FK_SUCURSAL);
            
            var transaccion = this.Activity.SupportFragmentManager.BeginTransaction();
            Asignar_DialogF dialogAsignar = new Asignar_DialogF();
            
            //Primero enviamos los datos al main 
            iNuevaOrden.AsigarOrden(ordenAsig);
            dialogAsignar.Show(transaccion, "asignar Tecnico fragment");
        }
    }
}