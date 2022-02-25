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

        // Definimos el Controller Detalle Orden
        CDetalle_Orden cD_Orden;

        //hora ya fecha
        string horaAc, fechaAc;

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
            
            // Instanciamos Lista del Detalle Orden
            cD_Orden = new CDetalle_Orden();

            acCliente = view.FindViewById<AutoCompleteTextView>(Resource.Id.autoComplCliente);
            // Llamamos los datos clients
            string[] cliente = Resources.GetStringArray(Resource.Array.array_cliente);
            var array_Cliente = new ArrayAdapter<string>(Activity, Resource.Layout.ac_ItemList, cliente);

            acSucursal = view.FindViewById<AutoCompleteTextView>(Resource.Id.autoComplSucursal);
            // Llamamos los datos Sucursales
            string[] sucursal = Resources.GetStringArray(Resource.Array.array_sucursal);
            var array_sucursal = new ArrayAdapter<string>(Activity, Resource.Layout.ac_ItemList, sucursal);

            acDispositivo = view.FindViewById<AutoCompleteTextView>(Resource.Id.autoComplDispositivo);
            // Llamamos los datos Sucursales
            string[] dispositivo = Resources.GetStringArray(Resource.Array.array_dispositivo);
            var array_dispositivo = new ArrayAdapter<string>(Activity, Resource.Layout.ac_ItemList, dispositivo);

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
            acCliente.Adapter = array_Cliente;
            acSucursal.Adapter = array_sucursal;
            acDispositivo.Adapter = array_dispositivo;

            return view;
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

        private bool CamposVaciosOrden(string client, int sucursal, string asunto, string dispositivo, string problema)
        {
            if (client.Equals("") || sucursal==0 || asunto.Equals("") || dispositivo.Equals("") || problema.Equals("") || lstDO.Count.Equals(0))
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
            if (CamposVaciosOrden(acCliente.Text, int.Parse(acSucursal.Text), txtAsunto.Text, txtProblema.Text, acDispositivo.Text).Equals(true))
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
                    //Orden addOrden = new Orden();
                    //addOrden.cod_orden = o.cod_orden;
                    //addOrden.asunto = o.asunto;
                    //addOrden.fecha_orden = o.fecha_orden;
                    //addOrden.hora_orden = o.hora_orden;
                    //addOrden.remitente = o.remitente;
                    //addOrden.estado = o.estado;
                    //addOrden.id_sucursal = o.id_sucursal;
                    //addOrden.id_empleado = o.id_empleado;
                    //addOrden.listaDetalleOrden = o.listaDetalleOrden; //Recibe la lista

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
            if (CamposVaciosDetalleOrd(disp,probl).Equals(true))
            {
                Toast.MakeText(Activity, "Campos Vacios, Ingrese datos", ToastLength.Short).Show();
            }
            else
            {
                //Instanciamos una lista
                DetalleOrdenWs Op = new DetalleOrdenWs
                {
                    DESCRIPCION = probl,
                    IMAGENES="",
                    IMAGENES_EVIDENCIA="",
                    FIRMA_CLIENTE="",
                    FIRMA_TECNICO="",
                    FK_DISPOSITIVO=disp
                };
                
                lstDO.Add(Op);

                //indicamos al adapter que actualice la lista
                mAdapter.NotifyDataSetChanged();
                rvOrden_Detalle.SmoothScrollToPosition(lstDO.Count());

                Console.WriteLine("problema; "+ Op.DESCRIPCION);
                LimpiarDetalleOrd();
            }
        }

        private void BtnAgregarList_Click(object sender, EventArgs e)
        {
            AgregarDetalleOrd(acDispositivo.Text,txtProblema.Text);
            Console.WriteLine(txtProblema.Text);
        }

        private void BtnGenerarOrden_Click(object sender, EventArgs e)
        {
            acSucursal.Text = "0"; //cambio temporar hasta implementar el autocomplete 
            Orden nOrden = new Orden
            {
                cod_orden = "",
                asunto = txtAsunto.Text,
                fecha_orden = fechaAc,
                hora_orden = horaAc,
                remitente = acCliente.Text,
                estado = 1,
                id_sucursal = int.Parse(acSucursal.Text),
                id_empleado = 0,
                listaDetalleOrden = lstDO
            };

            AgregarOrden(nOrden);

        }

    }
}