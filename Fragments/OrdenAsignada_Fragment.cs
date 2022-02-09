using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Newtonsoft.Json;
using OrdenTecnica_App.ListRecycler.Adapter;
using OrdenTecnica_App.Models;
using OrdenTecnica_App.Models.Statics;
using OrdenTecnica_App.ServicesClubTec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace OrdenTecnica_App.Fragments
{
    public class OrdenAsignada_Fragment : AndroidX.Fragment.App.Fragment, SearchView.IOnQueryTextListener
    {
        //Definimos los componentes
        SearchView searchList;
        RecyclerView rListORden;

        // Definimos el adaptador del RecyclerViewAdapter
        RecyclerView.LayoutManager mLayoutManager;
        ListOrden_Adapter mAdapter;

        // Definimos el modelo Orden
        List<OrdenWs> lstOrden;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Activity.Title = "ORDENES ASIGNADAS";
            
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_listOrdenes, container, false);

            searchList = view.FindViewById<SearchView>(Resource.Id.searchListOrdenes);
            rListORden = view.FindViewById<RecyclerView>(Resource.Id.recyclerVListOrdenes);

            // Instanciamos el recyclerView
            mLayoutManager = new LinearLayoutManager(Activity);
            ListOrdPendientes();
            rListORden.SetLayoutManager(mLayoutManager);

            searchListener();
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

        private void ListOrdPendientes()
        {
            switch (UserLogin._fk_perfil)
            {
                case 5:
                    List5();
                    break;
                case 2:
                    List5();
                    break;
                case 1:
                    List1();
                    break;

            }
        }

        private async void List1()
        {
            //Orden est = new Orden();
            OrdenAEstado o = new OrdenAEstado();
            o.idEstado = 2;
            o.idEmpleado = UserLogin._fk_empleado;

            Console.WriteLine("dato: "+  o.idEstado + " empleado: "+ o.idEmpleado);
            HttpClient client = new HttpClient();
            Uri url = new Uri("http://micmaproyectos.com/orden/buscarOrdenByEstadoAndEmpleado");

            var json = JsonConvert.SerializeObject(o);
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
                    lstOrden = response.lista;

                    mAdapter = new ListOrden_Adapter(lstOrden);
                    rListORden.SetAdapter(mAdapter);

                    //mAdapter.ItemClick += MAdapter_ItemClick;
                }
            }
            else if (postJson.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Toast.MakeText(Activity, "no se pudo procesar la operacion", ToastLength.Short).Show();
            }
        }

        private async void List5()
        {
            Orden est = new Orden();
            est.estado = 2;

            Console.WriteLine("dato: " + est.estado);
            HttpClient client = new HttpClient();
            Uri url = new Uri("http://micmaproyectos.com/orden/buscarOrdenByEstado");

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
                    lstOrden = response.lista;

                    mAdapter = new ListOrden_Adapter(lstOrden);
                    rListORden.SetAdapter(mAdapter);

                    //mAdapter.ItemClick += MAdapter_ItemClick;
                }
            }
            else if (postJson.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Toast.MakeText(Activity, "no se pudo procesar la operacion", ToastLength.Short).Show();
            }
        }

        private void searchListener()
        {
            searchList.SetOnQueryTextListener(this);
        }

        private void MAdapter_ItemClick(object sender, int e)
        {
            var transaccion = this.Activity.SupportFragmentManager.BeginTransaction();
            Asignar_DialogF dialogAsignar = new Asignar_DialogF();
            dialogAsignar.Show(transaccion, "asignar Tecnico fragment");
        }

    }
}