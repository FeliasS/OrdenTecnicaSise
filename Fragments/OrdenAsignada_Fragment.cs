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

        //cuadro de alerta
        AlertDialog.Builder alert;

        //Definimos la interface para abrir la siguiente ventana
        private ISolucionOrden iSolucionOrden;

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            iSolucionOrden = (ISolucionOrden)context;
        }

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
            //Orden est = new Orden();
            OrdenAEstado o = new OrdenAEstado();
            o.idEstado = 2;
            o.idEmpleado = UserLogin._fk_empleado;

            Console.WriteLine("dato: "+  o.idEstado + " empleado: "+ o.idEmpleado);
            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/buscarOrdenByEstadoAndEmpleado");

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
                    mAdapter.NotifyDataSetChanged();
                    rListORden.SmoothScrollToPosition(lstOrden.Count());

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
            est.estado = 2;

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
                    lstOrden = response.lista;

                    mAdapter = new ListOrden_Adapter(lstOrden);
                    rListORden.SetAdapter(mAdapter);
                    mAdapter.NotifyDataSetChanged();
                    rListORden.SmoothScrollToPosition(lstOrden.Count());

                    mAdapter.ItemClick += MAdapter_ItemClick;
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
            //var transaccion = this.Activity.SupportFragmentManager.BeginTransaction();
            //Asignar_DialogF dialogAsignar = new Asignar_DialogF();
            //dialogAsignar.Show(transaccion, "asignar Tecnico fragment");

            alert = new AlertDialog.Builder(Activity);
            alert.SetTitle("MENSAJE DE CONFIRMACION");
            alert.SetMessage("¿Desea realizar esta Orden Tecnica? \nUna vez aceptado, no se podra revertir la operacion");
            alert.SetPositiveButton("SI", (sender, args) => 
            {
                alert.Dispose();
                int id = int.Parse(lstOrden[e].ID_ORDEN);
                Console.WriteLine("id de la orden asignada en fragment ordenasignada; " + id);

                UpdateToStatus(id);

            });
            alert.SetNegativeButton("NO", (sender, args) => 
            {
                alert.Dispose();
            });
            
            Dialog dialog = alert.Create();
            dialog.Show();
        }

        async void UpdateToStatus(int e)
        {
            OrdenIDandEst uOrden = new OrdenIDandEst();
            uOrden.idOrden = e;
            uOrden.idEstado = 3;

            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/actualizarEstadoOrden");

            var json = JsonConvert.SerializeObject(uOrden);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var postJson = await client.PostAsync(url, content);
            Console.WriteLine(json);
            if (postJson.StatusCode==System.Net.HttpStatusCode.OK)
            {
                string readJson = await postJson.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<TramaOrden>(readJson);
                Console.WriteLine("status: "+ response.status+ " code: "+response.code);
                if (response.status==true && response.code==1)
                {

                    AlertDialog.Builder alert2 = new AlertDialog.Builder(Activity);
                    alert2.SetMessage("PROCESO REALIZADO CON EXITO");
                    alert2.SetPositiveButton("SI",(sender, args)=> 
                    {
                        //Aqui primero se valida que el estado acutlce
                        AlertDialog.Builder alert1 = new AlertDialog.Builder(Activity);
                        alert1.SetTitle("MENSAJE DE CONFIRMACION");
                        alert1.SetMessage("¿Desea Seguir en esta ventana?");
                        alert1.SetPositiveButton("SI", (sender, args) =>
                        {
                            alert1.Dispose();
                            List5();
                        });
                        alert1.SetNegativeButton("NO",(sender,args)=>
                        {
                            iSolucionOrden.AbrirOrdenProceso();
                        });

                        Dialog dialog1 = alert1.Create();
                        dialog1.Show();
                    });
                    Dialog dialog2 = alert2.Create();
                    dialog2.Show();

                }
                else if (response.status==true && response.code ==2)
                {
                    alert = new AlertDialog.Builder(Activity);
                    alert.SetTitle("MENSAJE DE ALERTA");
                    alert.SetMessage("No se pudo procesar la operacion");
                    alert.SetNeutralButton("ACEPTAR", (sender, args) => 
                    {
                        alert.Dispose();
                    });
                    Dialog dialog = alert.Create();
                    dialog.Show();
                }
            }
            else if (postJson.StatusCode==System.Net.HttpStatusCode.NotFound)
            {
                Toast.MakeText(Activity, "Proceso no encontrado", ToastLength.Short).Show();
            }

        }

    }
}