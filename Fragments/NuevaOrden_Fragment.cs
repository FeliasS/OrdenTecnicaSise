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
        private TextView lblCodigo, lblFecha, lblHora;
        private AutoCompleteTextView acCliente, acSucursal, acDispositivo;
        private EditText txtProblema;
        private Button btnAgregarList, btnGenerarOrden;
        private RecyclerView rvOrden_Detalle;

        // Definimos el adaptador del recyclerView
        RecyclerView.LayoutManager mLayoutManager;
        ListOrdenDetalle_Adapter mAdapter;

        // Lista Detalle orden
        List<Detalle_Orden> lstDO;

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

            lblCodigo = view.FindViewById<TextView>(Resource.Id.lblCodigo);
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
            rvOrden_Detalle = view.FindViewById<RecyclerView>(Resource.Id.recyclerV_ODetalle);

            // intanciamos el RecyclerView
            mLayoutManager = new LinearLayoutManager(Activity);
            rvOrden_Detalle.SetLayoutManager(mLayoutManager);

            lstDO = new List<Detalle_Orden>();

            Detalle_Orden detOr = new Detalle_Orden();
            detOr._COD_DETALLE_ORD = "...";
            detOr._DESCRIPCION = "...";
            detOr._ESTADO = "...";
            detOr._FK_DISPOSITIVO = "...";
            lstDO.Add(detOr);

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
            
            // Debemos limpiar el recyclerView tambien
        }
        
        private void LimpiarDetalleOrd()
        {
            acDispositivo.Text = "";
            txtProblema.Text = "";
        }

        private bool CamposVaciosOrden(string client, string sucursal)
        {
            if (client.Equals("") || sucursal.Equals(""))
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
            if (CamposVaciosOrden(acCliente.Text, acSucursal.Text).Equals(true))
            {
                Toast.MakeText(Activity, "Campos Vacios, Ingrese datos", ToastLength.Short).Show();
            }
            else
            {
                Orden addOrden = new Orden();
                addOrden.cod_orden = o.cod_orden;
                addOrden.asunto = o.asunto;
                addOrden.fecha_orden = o.fecha_orden;
                addOrden.hora_orden = o.hora_orden;
                addOrden.remitente = o.remitente;
                addOrden.estado = o.estado;
                addOrden.id_sucursal = o.id_sucursal;
                addOrden.id_empleado = o.id_empleado;


                HttpClient client = new HttpClient();
                Uri url = new Uri("http://servicios.micmaproyectos.com/orden/registrar ");
                var json = JsonConvert.SerializeObject(addOrden);
                var conten = new StringContent(json, Encoding.UTF8, "application/json");
                var postJson = await client.PostAsync(url, conten);

                Console.WriteLine("json enviado: " + json);
                    
                if (postJson.StatusCode== System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("estado de solicitud: " + postJson.StatusCode);
                    string readJson = await postJson.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<TramaOrdenObjeto>(readJson);

                    if (response.STATUS==true && response.CODE==1)
                    {
                        Console.WriteLine("estado de respuesta: " + response.MESSAGE);
                        alert = new AlertDialog.Builder(Activity);
                        alert.SetTitle("Mensaje de confirmacion");
                        alert.SetMessage("Orden generado correctamente");
                        alert.SetPositiveButton("OK", (sender, args) =>
                        {
                            // Limpiamos los campos de texto despues de aceptar el mensaje
                            alert.Dispose();
                            iNuevaOrden.AbrirListaPendiente();

                            LimpiarCampos();

                        });
                        Dialog dialog = alert.Create();
                        dialog.Show();
                    }
                    else if (response.STATUS=true && response.CODE==2)
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
                else if (postJson.StatusCode==System.Net.HttpStatusCode.NotFound)
                {
                    Toast.MakeText(Activity, "servicio no encontrado", ToastLength.Short).Show();
                }

                //Empleamos codigo para crear una nueva Orden
                // Mostrar mensaje de que el problema ha sido agregado correctamente
                
                
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
                
                Detalle_Orden detOr = new Detalle_Orden();
                detOr._COD_DETALLE_ORD = "DO001";
                detOr._DESCRIPCION = probl;
                detOr._ESTADO = "pendiente";
                detOr._FK_DISPOSITIVO = disp;

                lstDO.Add(detOr);

                //indicamos al adapter que actualice la lista
                mAdapter.NotifyDataSetChanged();
                rvOrden_Detalle.SmoothScrollToPosition(lstDO.Count());

                Console.WriteLine("problema; "+ detOr._DESCRIPCION);
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
            Orden nuevOrde = new Orden();
            nuevOrde.cod_orden = "";
            nuevOrde.asunto = "esto pertenece al detalle orden";
            nuevOrde.fecha_orden = fechaAc;
            nuevOrde.hora_orden = horaAc;
            nuevOrde.remitente = acCliente.Text;
            nuevOrde.estado = 1;
            nuevOrde.id_sucursal = int.Parse(acSucursal.Text);
            nuevOrde.id_empleado = 0;

            AgregarOrden(nuevOrde);

        }

    }
}