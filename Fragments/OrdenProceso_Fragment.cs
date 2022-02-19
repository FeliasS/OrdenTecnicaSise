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
using OrdenTecnica_App.Models.Statics;
using OrdenTecnica_App.ServicesClubTec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace OrdenTecnica_App.Fragments
{
    public class OrdenProceso_Fragment : AndroidX.Fragment.App.Fragment, SearchView.IOnQueryTextListener
    {
        //Definimos los elementos del view
        SearchView sOrdenProceso;
        RecyclerView rvOrdenProceso;

        //Definimos el adaptador del recyclerViewAdapter
        RecyclerView.LayoutManager mLayoutManager;
        ListOrden_Adapter mAdapter;

        //Definimos el modelo de ordenWs
        List<OrdenWs> lstOrdenProceso;

        //Interface para Abrir la Solcionar de la orden tecnica
        private ISolucionOrden iSolucionOrden;

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            iSolucionOrden = (ISolucionOrden)context;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Activity.Title = "ORDENES EN PROCESO";
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
            ListOrdnProceso();
            searchOrdenProceso();
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

        private void searchOrdenProceso()
        {
            sOrdenProceso.SetOnQueryTextListener(this);
        }

        private void ListOrdnProceso()
        {
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

        private async void List1()
        {

            OrdenAEstado oa = new OrdenAEstado();
            oa.idEstado = 3;
            oa.idEmpleado = UserLogin._fk_empleado;

            Console.WriteLine("estado: " + oa.idEstado+ " Empleado: "+ oa.idEmpleado);
            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/buscarOrdenByEstadoAndEmpleado");

            var json = JsonConvert.SerializeObject(oa);
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

                    mAdapter.ItemClick += MAdapter_ItemClick;
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
            est.estado = 3;

            Console.WriteLine("dato: " + est.estado);
            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/buscarOrdenByEstado");

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
            //Capturamos los datos de item seleccionado y lo enviamos al siguiente fragmento
            OrdenWs ows = new OrdenWs();
            ows.ID_ORDEN = lstOrdenProceso[e].ID_ORDEN;
            ows.COD_ORDEN = lstOrdenProceso[e].COD_ORDEN;
            ows.FECHA_ORDEN = lstOrdenProceso[e].FECHA_ORDEN;
            ows.HORA_ORDEN = lstOrdenProceso[e].HORA_ORDEN;
            ows.REMITENTE = lstOrdenProceso[e].REMITENTE;
            ows.FK_SUCURSAL = lstOrdenProceso[e].FK_SUCURSAL;
            ows.ASUNTO = lstOrdenProceso[e].ASUNTO;
            ows.ESTADO = lstOrdenProceso[e].ESTADO;
            ows.FK_EMPLEADO = lstOrdenProceso[e].FK_EMPLEADO;
            
            iSolucionOrden.AbrirSolucionOrden0(ows);
        }
    }
}