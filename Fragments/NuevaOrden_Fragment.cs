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
using OrdenTecnica_App.Models;
using OrdenTecnica_App.Interface;
using AndroidX.RecyclerView.Widget;
using OrdenTecnica_App.ListRecycler.Adapter;
using OrdenTecnica_App.Controller;
using System.Net.Http;
using Newtonsoft.Json;
using OrdenTecnica_App.ServicesClubTec;

namespace OrdenTecnica_App.Fragments
{
    public class NuevaOrden_Fragment : AndroidX.Fragment.App.Fragment
    {
        // Definimos los componentes del fragmento
        private TextView lblFecha, lblHora;
        private AutoCompleteTextView acCliente, acSucursal, acDispositivo;
        private EditText txtProblema, txtAsunto;
        private Button btnAgregarList, btnGenerarOrden;
        private RecyclerView rvOrden_Detalle;

        // Definimos el adaptador del recyclerView
        RecyclerView.LayoutManager mLayoutManager;
        ListOrdenDetalle_Adapter mAdapter;

        // Lista Detalle orden
        List<DetalleOrdenWs> lstDO;

        // Definimos el cuadro de alerta
        AlertDialog.Builder alert;

        // Definimos la interface
        private INuevaOrden iNuevaOrden;

        //hora ya fecha
        string horaAc, fechaAc;

        //DEFINIMOS UN ARRAY DE CADENA
        static string[] DISPOSITIVOS;
        static string[] SUCURSAL;
        static string[] CLIENTE;
        
        //declaracion global
        List<ListaD> listatemp;
        List<ListaS> listaSucursal;
        List<ListaC> listaClientes;

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            iNuevaOrden = (INuevaOrden)context;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Activity.Title = "NUEVA ORDEN";
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.fragment_nuevaOrden, container, false);

            lblFecha = view.FindViewById<TextView>(Resource.Id.lblFecha);
            lblHora = view.FindViewById<TextView>(Resource.Id.lblHora);
            
            acCliente = view.FindViewById<AutoCompleteTextView>(Resource.Id.autoComplCliente);
            // Llamamos los datos clients
            //string[] cliente = Resources.GetStringArray(Resource.Array.array_cliente);
            //var array_Cliente = new ArrayAdapter<string>(Activity, Resource.Layout.ac_ItemList, cliente);

            acSucursal = view.FindViewById<AutoCompleteTextView>(Resource.Id.autoComplSucursal);
            // Llamamos los datos Sucursales
            //string[] sucursal = Resources.GetStringArray(Resource.Array.array_sucursal);
            //var array_sucursal = new ArrayAdapter<string>(Activity, Resource.Layout.ac_ItemList, sucursal);

            acDispositivo = view.FindViewById<AutoCompleteTextView>(Resource.Id.autoComplDispositivo);
            // Llamamos los datos Sucursales
            //string[] dispositivo = Resources.GetStringArray(Resource.Array.array_dispositivo);
            //var array_dispositivo = new ArrayAdapter<string>(Activity, Resource.Layout.ac_ItemList, dispositivo);

            txtProblema = view.FindViewById<EditText>(Resource.Id.txtProblema);
            txtAsunto = view.FindViewById<EditText>(Resource.Id.txtAsunto);
            rvOrden_Detalle = view.FindViewById<RecyclerView>(Resource.Id.recyclerV_ODetalle);

            // intanciamos el RecyclerView
            mLayoutManager = new LinearLayoutManager(Activity);
            rvOrden_Detalle.SetLayoutManager(mLayoutManager);

            lstDO = new List<DetalleOrdenWs>();

            mAdapter = new ListOrdenDetalle_Adapter(lstDO);
            rvOrden_Detalle.SetAdapter(mAdapter);

            btnAgregarList = view.FindViewById<Button>(Resource.Id.btnLstDetalleOrden);
            btnAgregarList.Click += BtnAgregarList_Click;

            btnGenerarOrden = view.FindViewById<Button>(Resource.Id.btnGenerarOrden);
            btnGenerarOrden.Click += BtnGenerarOrden_Click;

            //Obteniendo la hora y fecha del sistema
            fechaAc = DateTime.Now.ToString("yyyy-MM-dd");
            horaAc = DateTime.Now.ToString("hh:mm");

            lblFecha.Text = fechaAc;
            lblHora.Text = horaAc;


            // Asignando el array al autocomplete
            AcDispositivo();
            AcSucursal();
            AcCliente();
            
            return view;
        }
        
        private void AcDispositivo()
        {
            try
            {
                HttpClient client = new HttpClient();
                Uri url = new Uri("http://servicios.micmaproyectos.com/dispositivo/listarTodos");

                var getJson = client.GetAsync(url).Result;
                if (getJson.StatusCode==System.Net.HttpStatusCode.OK)
                {
                    string readJson = getJson.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<TramaDispositivo>(readJson);
                    if (response.status==true && response.code==1)
                    {
                        if (response.lista != null)
                        {
                            DISPOSITIVOS = response.lista.Select(m=> m.NOMBRE).ToArray();
                            listatemp = response.lista;

                            
                        }
                        else
                        {
                            DISPOSITIVOS = new string[0];
                        }
                    }
                    else if (response.status==true && response.code==2)
                    {
                        Console.WriteLine("Se genero un problema al traer la lista dispositivos");
                    }

                    var adapter = new ArrayAdapter<String>(Activity, Resource.Layout.ac_ItemList, DISPOSITIVOS);
                    acDispositivo.Adapter= adapter;

                }
                else if (getJson.StatusCode==System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("servicio no encontrado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de error en AcDipositivo del Fragmento NUEVA ORDEN: "+ ex.Message);
            }
        }

        private void AcSucursal()
        {
            try
            {
                HttpClient client = new HttpClient();
                Uri url = new Uri("http://servicios.micmaproyectos.com/sucursal/listarTodos");

                var getJson = client.GetAsync(url).Result;
                if (getJson.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string readJson = getJson.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<TramaSucursal>(readJson);
                    if (response.status == true && response.code == 1)
                    {
                        if (response.lista != null)
                        {
                            SUCURSAL = response.lista.Select(m => m.DIRECCION).ToArray();
                            listaSucursal = response.lista;


                        }
                        else
                        {
                            SUCURSAL = new string[0];
                        }
                    }
                    else if (response.status == true && response.code == 2)
                    {
                        Console.WriteLine("Se genero un problema al traer la lista sucursal");
                    }

                    var adapter = new ArrayAdapter<String>(Activity, Resource.Layout.ac_ItemList, SUCURSAL);
                    acSucursal.Adapter = adapter;

                }
                else if (getJson.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("servicio no encontrado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de error en AcDipositivo del Fragmento NUEVA ORDEN: " + ex.Message);
            }
        }

        private void AcCliente()
        {
            try
            {
                HttpClient client = new HttpClient();
                Uri url = new Uri("http://servicios.micmaproyectos.com/cliente/listarTodos");

                var getJson = client.GetAsync(url).Result;
                if (getJson.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string readJson = getJson.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<TramaCliente>(readJson);
                    if (response.status == true && response.code == 1)
                    {
                        if (response.lista != null)
                        {
                            CLIENTE = response.lista.Select(m => m.RAZON_SOCIAL).ToArray();
                            listaClientes = response.lista;


                        }
                        else
                        {
                            CLIENTE = new string[0];
                        }
                    }
                    else if (response.status == true && response.code == 2)
                    {
                        Console.WriteLine("Se genero un problema al traer la lista clientes");
                    }

                    var adapter = new ArrayAdapter<String>(Activity, Resource.Layout.ac_ItemList, CLIENTE);
                    acCliente.Adapter = adapter;

                }
                else if (getJson.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("servicio no encontrado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de error en AcDipositivo del Fragmento NUEVA ORDEN: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            acCliente.Text = "";
            acSucursal.Text = "";
            
        }
        
        private void LimpiarDetalleOrd()
        {
            acDispositivo.Text = "";
            txtProblema.Text = "";
        }

        private bool CamposVaciosOrden(string client, string sucursal, string asunto)
        {
            if (client.Equals("") || sucursal.Equals("") || asunto.Equals("") || lstDO.Count.Equals(0))
            {
                return true;
            }
            return false;
        }

        private bool CamposVaciosDetalleOrd(string dispositivo, string problema)
        {
            if (dispositivo.Equals("") || problema.Equals(""))
            {
                return true;
            }
            return false;
        }

        private async void AgregarOrden(Orden o)
        {
            if (CamposVaciosOrden(acCliente.Text, acSucursal.Text, txtAsunto.Text))
            {
                Toast.MakeText(Activity, "Campos Vacios, Ingrese datos", ToastLength.Short).Show();
            }
            else if (lstDO.Count==0)
            {
                Toast.MakeText(Activity, "La lista debe tener como minimo un problema tecnico en la Orden", ToastLength.Short).Show();
            }
            else
            {
                try
                {
                    
                    Orden addOrden = new Orden
                    {
                        cod_orden = o.cod_orden,
                        asunto = o.asunto,
                        fecha_orden = o.fecha_orden,
                        hora_orden = o.hora_orden,
                        remitente = o.remitente,
                        estado = o.estado,
                        id_sucursal = o.id_sucursal,
                        id_empleado = o.id_empleado,
                        listaDetalleOrden = o.listaDetalleOrden
                    };

                    HttpClient client = new HttpClient();
                    Uri url = new Uri("http://servicios.micmaproyectos.com/orden/registrar ");
                    var json = JsonConvert.SerializeObject(addOrden);
                    var conten = new StringContent(json, Encoding.UTF8, "application/json");
                    var postJson = await client.PostAsync(url, conten);
                    
                    Console.WriteLine("json enviado: " + json);

                    if (postJson.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine("estado de solicitud: " + postJson.StatusCode);
                        string readJson = await postJson.Content.ReadAsStringAsync();
                        Console.WriteLine(readJson);
                        var response = JsonConvert.DeserializeObject<TramaOrdenObjeto>(readJson);

                        if (response.status == true && response.code == 1)
                        {
                            Console.WriteLine("estado de respuesta: " + response.message);
                            alert = new AlertDialog.Builder(Activity);
                            alert.SetTitle("Mensaje de confirmacion");
                            alert.SetMessage("Orden generado correctamente");
                            alert.SetPositiveButton("OK", (sender, args) =>
                            {
                                // Limpiamos los campos de texto despues de aceptar el mensaje
                                alert.Dispose();
                                postJson.Dispose(); //Cerramos el servicio
                                iNuevaOrden.AbrirListaPendiente();

                                LimpiarCampos();

                            });
                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                        else if (response.status = true && response.code == 2)
                        {
                            alert = new AlertDialog.Builder(Activity);
                            alert.SetTitle("Mensaje de confirmacion");
                            alert.SetMessage("No se pudo procesar la operacion");
                            alert.SetPositiveButton("OK", (sender, args) =>
                            {
                                // Limpiamos los campos de texto despues de aceptar el mensaje
                                alert.Dispose();
                                LimpiarCampos();

                            });
                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                    }
                    else if (postJson.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        Toast.MakeText(Activity, "servicio no encontrado", ToastLength.Short).Show();
                    }
                }
                catch (JsonReaderException e)
                {

                    Console.WriteLine("se encontró un error en crear nueva orden: " + e.Message);
                }
                catch (Java.IO.IOException e)
                {
                    Console.WriteLine("Se produjo una excepcion en : " + e.Message);
                }

            }
            
        }

        private void AgregarDetalleOrd(string disp, string probl)
        {
            if (CamposVaciosDetalleOrd(disp,probl).Equals(true) || acDispositivo.Text=="")
            {
                Toast.MakeText(Activity, "Campos Vacios, Ingrese datos", ToastLength.Short).Show();
            }
            else
            {
                String[] acDispo = listatemp.Where(x => x.NOMBRE.Equals(acDispositivo.Text)).Select(m => m.ID_DISPOSITIVO).ToArray();
                
                //Capturamos el index del valor insertado en el campo
                var index = Array.FindIndex(acDispo, x=>x == acDispositivo.Text);
                
                if (index > -1)
                {
                    alert = new AlertDialog.Builder(Activity);
                    alert.SetTitle("MENSAJE");
                    alert.SetMessage("Por favor, ingrese solo datos sugeridos por la aplicacion");
                    alert.SetPositiveButton("ACEPTAR", (sender, args) =>
                    {
                        alert.Dispose();
                    });
                    Dialog dialog = alert.Create();
                    dialog.Show();
                   
                }
                else
                {
                    //Instanciamos una lista
                    DetalleOrdenWs Op = new DetalleOrdenWs
                    {
                        DESCRIPCION = probl,
                        IMAGENES = "",
                        IMAGENES_EVIDENCIA = "",
                        FIRMA_CLIENTE = "",
                        FIRMA_TECNICO = "",
                        FK_DISPOSITIVO = acDispo[0],
                        
                    };

                    lstDO.Add(Op);

                    //indicamos al adapter que actualice la lista
                    mAdapter.NotifyDataSetChanged();
                    rvOrden_Detalle.SmoothScrollToPosition(lstDO.Count());

                    Console.WriteLine("problema; " + Op.DESCRIPCION);
                    Console.WriteLine("ID DE AUTOCOMPLETE SELECCIONADO: " + acDispo[0]);

                    LimpiarDetalleOrd();
                }

                
            }
        }

        private void BtnAgregarList_Click(object sender, EventArgs e)
        {
            if (acDispositivo.Text=="" || txtProblema.Text=="")
            {
                alert = new AlertDialog.Builder(Activity);
                alert.SetTitle("MENSAJE");
                alert.SetMessage("Campos para Agregar datos a las SubOrdenes tecnicas Vacios, \nIngrese dato por favor");
                alert.SetPositiveButton("ACEPTAR", (sender, args) =>
                {
                    alert.Dispose();
                });
                Dialog dialog = alert.Create();
                dialog.Show();
            }
            else
            {
                AgregarDetalleOrd(acDispositivo.Text, txtProblema.Text);
                Console.WriteLine(txtProblema.Text);
            }
            
        }

        private void BtnGenerarOrden_Click(object sender, EventArgs e)
        {
            if (acCliente.Text=="" || acSucursal.Text=="" || txtAsunto.Text=="" || lstDO.Count.Equals(0))
            {
                alert = new AlertDialog.Builder(Activity);
                alert.SetTitle("MENSAJE");
                alert.SetMessage("Los Campos estan Vacios, ingrese datos por favor");
                alert.SetPositiveButton("ACEPTAR",(sender, args)=>
                {
                    alert.Dispose();
                });
                Dialog dialog = alert.Create();
                dialog.Show();
            }
            else
            {
                String[] acClie = listaClientes.Where(x => x.RAZON_SOCIAL.Equals(acCliente.Text)).Select(m => m.ID_CLIENTE).ToArray();
                
                String[] acSucu = listaSucursal.Where(x => x.DIRECCION.Equals(acSucursal.Text)).Select(m => m.ID_SUCURSAL).ToArray();
                
                //Capturamos el index del valor insertado en el campo
                var indClie = Array.FindIndex(acClie, x => x == acCliente.Text);
                var indSucu = Array.FindIndex(acSucu, x=> x == acSucursal.Text);

                if (indClie > -1 || indSucu > -1)
                {
                    alert = new AlertDialog.Builder(Activity);
                    alert.SetTitle("MENSAJE");
                    alert.SetMessage("Por favor, ingrese solo datos sugeridos por la aplicacion");
                    alert.SetPositiveButton("ACEPTAR", (sender, args) =>
                    {
                        alert.Dispose();
                    });
                    Dialog dialog = alert.Create();
                    dialog.Show();
                    
                }
                else
                {
                    Orden nOrden = new Orden
                    {
                        cod_orden = "",
                        asunto = txtAsunto.Text,
                        fecha_orden = fechaAc,
                        hora_orden = horaAc,
                        remitente = acClie[0],
                        estado = 1,
                        id_sucursal = acSucu[0],
                        id_empleado = 0,
                        listaDetalleOrden = lstDO
                    };
                    Console.WriteLine("ID DE AUTOCOMPLETE ACSUCURSAL SELECCIONADO: " + acSucu[0]);
                    Console.WriteLine("ID DE AUTOCOMPLETE ACCLIENTE SELECCIONADO: " + acClie[0]);
                    AgregarOrden(nOrden);
                }

            }

        }

    }
}