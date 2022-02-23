using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
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
    class Asignar_DialogF: AndroidX.Fragment.App.DialogFragment,SearchView.IOnQueryTextListener
    {
        //Definimos los elementos de la vista
        public TextView lblcodigo, lblcliente, lblsucursal, lblasunto, lblTecnico;
        
        SearchView svAsigTecnico;
        RecyclerView rvAsigTecnico;

        //Definimos la orden que recibirá los datos del main
        static Orden getOrden = new Orden();
        static int idEmpleado;

        //Definimos el adaptador del recyclerViewAdapter
        RecyclerView.LayoutManager mLayoutManager;
        ListTecnicos_Adapter mAdapter;

        //Definimos una lista
        List<TecnicoWs> lstTecnico;

        //Interface para actualizar la lista 
        INuevaOrden iNuevaOrden;

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            iNuevaOrden= (INuevaOrden)context;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            
            View view = inflater.Inflate(Resource.Layout.fragment_AsignarTecnico, container, false);
            lblcodigo = view.FindViewById<TextView>(Resource.Id.lblAsigCodigo);

            lblcliente = view.FindViewById<TextView>(Resource.Id.lblAsigCliente);
            lblsucursal = view.FindViewById<TextView>(Resource.Id.lblAsigSucursal);
            lblasunto = view.FindViewById<TextView>(Resource.Id.lblAsigAsunto);
            lblTecnico = view.FindViewById<TextView>(Resource.Id.lblAsigTecnico);

            svAsigTecnico = view.FindViewById<SearchView>(Resource.Id.svAsignarView);
            rvAsigTecnico = view.FindViewById<RecyclerView>(Resource.Id.rvAsignarTecnico);

            Button btnAsignar = view.FindViewById<Button>(Resource.Id.btnAsignarTecnico);

            btnAsignar.Click += BtnAsignar_Click;

            mLayoutManager = new LinearLayoutManager(Activity);
            rvAsigTecnico.SetLayoutManager(mLayoutManager);
            ListTecnicos();
            SearchListTecnico();
 
            lblcodigo.Text = getOrden.cod_orden;
            lblcliente.Text = getOrden.remitente;
            lblsucursal.Text = getOrden.id_sucursal.ToString();
            lblasunto.Text = getOrden.asunto;
           
            return view;
        }

        private async void BtnAsignar_Click(object sender, EventArgs e)
        {
            // 1) Asignamos a la orden el Tecnico
            OrdenEmpleado ATec = new OrdenEmpleado();
            ATec.idOrden = int.Parse(getOrden.idOrden);//actualizar este punto
            ATec.idEmpleado = idEmpleado;

            Console.WriteLine("empleado: " + lblTecnico.Text + " id Empleado: " + ATec.idEmpleado);
            if (lblTecnico.Text=="" || ATec.idEmpleado == 0)
            {
                Toast.MakeText(Activity, "Campos vacios, Seleccione un Tecnico",ToastLength.Short).Show();
            }
            else
            {
                Console.WriteLine("id obtenido de la lista: " + ATec.idOrden);
                HttpClient client = new HttpClient();
                Uri url = new Uri("http://servicios.micmaproyectos.com/orden/asignarTecnico");

                var json = JsonConvert.SerializeObject(ATec);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var postJson = await client.PostAsync(url, content);

                Console.WriteLine(json);
                if (postJson.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string readJson = await postJson.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<TramaOrden>(readJson);

                    Console.WriteLine("status: " + response.status + " code: " + response.code);
                    if (response.status == true && response.code == 1)
                    {
                        Console.WriteLine(response.message);
                        // 2) actualizamos el estado de la orden
                        UpdateOrden(ATec.idOrden);
                        
                    }
                    else if (response.status==true && response.code==2)
                    {
                        Console.WriteLine(response.message);
                    }
                }
                else if (postJson.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("Error al momento de realizar la operacion");
                }
            }

            
        }

        public void SetInDialogOrden(Orden orden)
        {
            getOrden.idOrden = orden.idOrden;
            getOrden.cod_orden = orden.cod_orden;
            getOrden.remitente = orden.remitente;
            getOrden.id_sucursal = orden.id_sucursal;
            getOrden.asunto = orden.asunto;

        } 

        private async void ListTecnicos()
        {
            Tecnicos lstT = new Tecnicos();

            HttpClient client = new HttpClient();
            Uri uri = new Uri("http://servicios.micmaproyectos.com/tecnico/listarTodos");

            var JsonGet = await client.GetAsync(uri);

            if (JsonGet.StatusCode==System.Net.HttpStatusCode.OK)
            {
                string readJSON = await JsonGet.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<TramaTecnicoLista>(readJSON);
                Console.WriteLine("status: " + response.status + " code: " + response.code);
                if (response.status==true && response.code==1)
                {
                    Console.WriteLine(response.message);
                    lstTecnico = response.lista;
                    mAdapter = new ListTecnicos_Adapter(lstTecnico);
                    rvAsigTecnico.SetAdapter(mAdapter);

                    mAdapter.ItemClick += MAdapter_ItemClick;
                }
                else if (response.status==true && response.code==2)
                {
                    Console.WriteLine(response.message + " en lista de tecnicos.");
                }

            }
            else if (JsonGet.StatusCode==System.Net.HttpStatusCode.NotFound)
            {
                Console.WriteLine("No se encontro la URL");
            }


        }

        private void MAdapter_ItemClick(object sender, int e)
        {
            lblTecnico.Text = lstTecnico[e].NOMBRES +" "+ lstTecnico[e].APELLIDOS;
            idEmpleado = lstTecnico[e].ID_EMPLEADO;
            Console.WriteLine("id del empleado seleccionado: " + idEmpleado);
            //Toast.MakeText(Activity, "mensaje asignado, falta implementacon", ToastLength.Short).Show();

           

        }

        async void UpdateOrden(int idOrden)
        {
            OrdenIDandEst oe = new OrdenIDandEst();
            oe.idOrden = idOrden;
            oe.idEstado =2;

            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/actualizarEstadoOrden");

            var json = JsonConvert.SerializeObject(oe);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var postJson = await client.PostAsync(url, content);

            if (postJson.StatusCode==System.Net.HttpStatusCode.OK)
            {
                string readJson = await postJson.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<TramaOrden>(readJson);

                if (response.status==true && response.code==1)
                {
                    Console.WriteLine(response.message);
                    AlertDialog.Builder alert1 = new AlertDialog.Builder(Activity);
                    alert1.SetTitle("MENSAJE DE CONFIRMACION");
                    alert1.SetMessage("Tecnico asignado exitosamente");
                    alert1.SetPositiveButton("ACEPTAR", (sender, args) => 
                    {
                        //Actualizamos la lista creada
                        iNuevaOrden.ListarOrdenCreado();
                        alert1.Dispose();
                        this.Dismiss();
                        lblTecnico.Text = "";
                        idEmpleado = 0;
                    });
                    Dialog dialog = alert1.Create();
                    dialog.Show();

                }
                else if (response.status==true && response.code==2)
                {
                    Console.WriteLine(response.message);
                }
            }
            else if (postJson.StatusCode==System.Net.HttpStatusCode.NotFound)
            {
                Console.WriteLine("error al enviar el json");
            }
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {

            base.OnActivityCreated(savedInstanceState);
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

        private void SearchListTecnico()
        {
            svAsigTecnico.SetOnQueryTextListener(this);
        }

    }
}