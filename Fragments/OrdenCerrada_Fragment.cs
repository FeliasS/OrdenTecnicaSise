using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrdenTecnica_App.ListRecycler.Adapter;
using OrdenTecnica_App.Models;
using OrdenTecnica_App.Controller;
using System.Net.Http;
using Newtonsoft.Json;
using OrdenTecnica_App.ServicesClubTec;
using OrdenTecnica_App.Models.Statics;

namespace OrdenTecnica_App.Fragments
{
    public class OrdenCerrada_Fragment : AndroidX.Fragment.App.Fragment
    {
        // Definimos los elementos del Fragment
        SearchView searchList;
        RecyclerView rvListORden;

        // Definimos el adaptador del RecyclerViewAdapter
        RecyclerView.LayoutManager mLayoutManager;
        ListOrden_Adapter mAdapter;

        // Definimos el modelo Orden
        List<OrdenWs> lstOrden;

        // Definimos el controller COrden
        COrden cOrden;

        // Definimos el cuadro de mensaje emergente
        AlertDialog.Builder alert;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Activity.Title = "ORDENES CERRADAS";
            // Create your fragment here


        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_listOrdenes, container, false);
            
            searchList = view.FindViewById<SearchView>(Resource.Id.searchListOrdenes);
            rvListORden = view.FindViewById<RecyclerView>(Resource.Id.recyclerVListOrdenes);


            // Instanciamos el recyclerView
            mLayoutManager = new LinearLayoutManager(Activity);
            rvListORden.SetLayoutManager(mLayoutManager);
            rvListORden.HasFixedSize = true;

            ListasEstadoCINCO();

            
            return view;
        }

        public void ListasEstadoCINCO()
        {

            int v = UserLogin._fk_empleado;

            Console.WriteLine("codigo empleado en fragment: " + v);

            switch (UserLogin._fk_perfil)
            {
                case 3:
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

        public async void List1()
        {
            
            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/buscarOrdenByEmpleado");

            var json = JsonConvert.SerializeObject(UserLogin._fk_empleado);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var postJson = await client.PostAsync(url, content);

            Console.WriteLine("json enviado: " + json);
            Console.WriteLine("estado postjson: " + postJson.StatusCode);
            if (postJson.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string readJson = await postJson.Content.ReadAsStringAsync();
                Console.WriteLine("readJson: " + readJson);
                var response = JsonConvert.DeserializeObject<TramaOrdenLista>(readJson);
                Console.WriteLine("response: " + response);
                Console.WriteLine("status: " + response.status + " code: " + response.code);
                if (response.status == true && response.code == 1)
                {
                    lstOrden = new List<OrdenWs>();

                    Console.WriteLine("mensaje: " + response.message);

                    lstOrden = response.lista;

                    mAdapter = new ListOrden_Adapter(lstOrden);
                    Console.WriteLine("datos llenados en el mAdapter");
                    rvListORden.SetAdapter(mAdapter);
                    Console.WriteLine("seteando en el recyclerView la nueva lista");

                    mAdapter.ItemClick += MAdapter_ItemClick1;
                }
                else if (response.status == true && response.code == 2)
                {
                    Toast.MakeText(Activity, response.message, ToastLength.Short).Show();
                }
            }
        }

        public async void List5()
        {
            Orden ordEstad = new Orden();
            ordEstad.estado = 5;
            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/buscarOrdenByEstado ");

            var json = JsonConvert.SerializeObject(ordEstad);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var postJson = await client.PostAsync(url, content);

            Console.WriteLine("json enviado: " + json);
            Console.WriteLine("estado postjson: " + postJson.StatusCode);
            if (postJson.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string readJson = await postJson.Content.ReadAsStringAsync();
                Console.WriteLine("readJson: " + readJson);
                var response = JsonConvert.DeserializeObject<TramaOrdenLista>(readJson);
                Console.WriteLine("response: " + response);
                Console.WriteLine("status: " + response.status + " code: " + response.code);
                if (response.status == true && response.code == 1)
                {
                    lstOrden = new List<OrdenWs>();

                    Console.WriteLine("mensaje: " + response.message);

                    lstOrden = response.lista;

                    mAdapter = new ListOrden_Adapter(lstOrden);
                    Console.WriteLine("datos llenados en el mAdapter");
                    rvListORden.SetAdapter(mAdapter);
                    Console.WriteLine("seteando en el recyclerView la nueva lista");

                    mAdapter.ItemClick += MAdapter_ItemClick1;
                }
                else if (response.status == true && response.code == 2)
                {
                    Toast.MakeText(Activity, response.message, ToastLength.Short).Show();
                }
            }
        }



        private void MAdapter_ItemClick1(object sender, int e)
        {
            var transaccion = this.Activity.SupportFragmentManager.BeginTransaction();
            Asignar_DialogF dialogAsignar = new Asignar_DialogF();
            dialogAsignar.Show(transaccion, "asignar Tecnico fragment");
        }

    }
}