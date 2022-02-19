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
    public class OrdenSolucionar0_Fragment : AndroidX.Fragment.App.Fragment
    {
        TextView lblFecha, lblHora, lblClient, lblSucursal, lblAsunto, lblCodigo;
        RecyclerView rvODetalle;
        Button btnFinalizarOrden;

        //Definimos el adaptador para el recyclerView
        RecyclerView.LayoutManager mLayoutManager;
        ListOrdenDetalle_Adapter mAdapter;

        // Lista Detalle Orden
        List<DetalleOrdenWs> lstDo;

        //Definimos una orden estatica
        static OrdenWs o;

        //Mensaje de alerta
        AlertDialog.Builder alert;

        //Interfce para abrir la siguiente ventana de procesor para la finalizacion de orden tecnica
        private ISolucionOrden iSolucionOrden;

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            iSolucionOrden = (ISolucionOrden)context;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Activity.Title = "DETALLE DE ORDEN";
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_OrdDetalleProceso, container, false);

            lblFecha = view.FindViewById<TextView>(Resource.Id.lblFechaAtencion);
            lblHora = view.FindViewById<TextView>(Resource.Id.lblHoraAtencion);
            lblClient = view.FindViewById<TextView>(Resource.Id.lblSetCliente);
            lblSucursal = view.FindViewById<TextView>(Resource.Id.lblSetSucursal);
            lblCodigo = view.FindViewById<TextView>(Resource.Id.lblSetCodigo);
            lblAsunto = view.FindViewById<TextView>(Resource.Id.lblSetAsunto);

            rvODetalle = view.FindViewById<RecyclerView>(Resource.Id.rvSetListadoProblemas);
            btnFinalizarOrden = view.FindViewById<Button>(Resource.Id.btnFinOrdTecnica);
            btnFinalizarOrden.Click += BtnFinalizarOrden_Click;

            SetData();

            //ingresamos unos datos estaticos
            lstDo = new List<DetalleOrdenWs>();
            //DetalleOrdenWs dtor = new DetalleOrdenWs();
            //dtor.COD_ORDEN_DETALLE = "...";
            //dtor.DESCRIPCION = "...";
            //dtor.ESTADO = "...";
            //dtor.FK_DISPOSITIVO = "...";
            //lstDo.Add(dtor);

            LstOrdenDetallebyOrden();

            //INSTACIAMOS EL ADAPTADOR DEL LIST
            mLayoutManager = new LinearLayoutManager(Activity);
            rvODetalle.SetLayoutManager(mLayoutManager);

            

            return view;
        }


        void SetData()
        {
            lblFecha.Text = o.FECHA_ORDEN;
            lblHora.Text = o.HORA_ORDEN;
            lblCodigo.Text = o.COD_ORDEN;
            lblClient.Text = o.REMITENTE;
            lblSucursal.Text = o.FK_SUCURSAL;
            lblAsunto.Text = o.ASUNTO;
        }

        public void SetOrdenDetalle(OrdenWs orden)
        {
            
            if (orden.Equals(null))
            {
                Console.WriteLine("datos vacios");
            }
            else
            {
                o = new OrdenWs();
                o.ID_ORDEN = orden.ID_ORDEN;
                o.COD_ORDEN = orden.COD_ORDEN;
                o.FECHA_ORDEN = orden.FECHA_ORDEN;
                o.HORA_ORDEN = orden.HORA_ORDEN;
                o.REMITENTE = orden.REMITENTE;
                o.FK_SUCURSAL = orden.FK_SUCURSAL;
                o.FK_EMPLEADO = orden.FK_EMPLEADO;
                o.ASUNTO = orden.ASUNTO;
                o.ESTADO = orden.ESTADO;

                Console.WriteLine("datos LLenos");
            }

        }

        private async void LstOrdenDetallebyOrden()
        {
            
            Orden ord = new Orden();
            ord.idOrden = int.Parse(o.ID_ORDEN); //obtiene el ID del item seleccionado en la lista

            HttpClient client = new HttpClient();
            Uri url = new Uri("http://servicios.micmaproyectos.com/orden/buscarDetalleOrdenByIdOrden");

            var json = JsonConvert.SerializeObject(ord);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var postJson = await client.PostAsync(url, content);

            if (postJson.StatusCode==System.Net.HttpStatusCode.OK)
            {
                string readJson = await postJson.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<TramaDetalleOrden>(readJson);

                if (response.status==true && response.code==1)
                {
                    Console.WriteLine(response.message);
                    lstDo = response.lista;


                    mAdapter = new ListOrdenDetalle_Adapter(lstDo);
                    rvODetalle.SetAdapter(mAdapter);

                    mAdapter.ItemClick += MAdapter_ItemClick;
                }
                else if (response.status==true && response.code==2)
                {
                    Toast.MakeText(Activity, response.message, ToastLength.Short).Show();
                }

            }
            else if (postJson.StatusCode==System.Net.HttpStatusCode.NotFound)
            {
                Toast.MakeText(Activity, "Sugrio un problema con el procedimiento", ToastLength.Short).Show();
            }


        }


        private void MAdapter_ItemClick(object sender, int e)
        {
            DetalleOrdenWs d = new DetalleOrdenWs();
            d.ID_ORDEN_DETALLE = lstDo[e].ID_ORDEN_DETALLE;
            d.COD_ORDEN_DETALLE = lstDo[e].COD_ORDEN_DETALLE;
            d.FK_DISPOSITIVO = lstDo[e].FK_DISPOSITIVO;
            
            iSolucionOrden.AbrirSolucionOrden(d);
        }
        private async void BtnFinalizarOrden_Click(object sender, EventArgs e)
        {
            if (lstDo.Count>0)
            {
                int contador=0;
                for (int i = 0; i < lstDo.Count; i++)
                {
                    if (lstDo[i].ESTADO=="0")
                    {
                        contador++;
                        if (contador>=1)
                        {
                            alert = new AlertDialog.Builder(Activity);
                            alert.SetTitle("MENSAJE DE CONFIRMACION");
                            alert.SetMessage("Para finalizar la Orden Tecnica, primero debe atender todos los problemas");
                            alert.SetPositiveButton("ACEPTAR", (sender, args) =>
                            {
                                //NOS MANTIENE EN EL MISMO FRAGMENTO
                                alert.Dispose();
                            });
                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                    }
                    else
                    {
                        break;
                    }
                    break;
                }

                Orden ord = new Orden();
                ord.idOrden = int.Parse(o.ID_ORDEN);
                ord.asunto =lblAsunto.Text;
                ord.fecha_atencion = DateTime.Now.ToString("yyyy-MM-dd");
                ord.hora_atencion = DateTime.Now.ToString("hh:mm");
                ord.remitente =lblClient.Text;
                ord.estado =4;
                ord.id_sucursal =int.Parse(lblSucursal.Text);
                ord.id_empleado =int.Parse(o.FK_EMPLEADO);

                HttpClient client = new HttpClient();
                Uri uri = new Uri("http://servicios.micmaproyectos.com/orden/actualizarOrden");

                var json = JsonConvert.SerializeObject(ord);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var postJson = await client.PostAsync(uri, content);

                if (postJson.StatusCode==System.Net.HttpStatusCode.OK)
                {
                    string readJson = await postJson.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<TramaOrden>(readJson);

                    if (response.status==true && response.code==1)
                    {
                        Console.WriteLine(response.message);
                        alert = new AlertDialog.Builder(Activity);
                        alert.SetTitle("MENSAJE DE CONFIRMACION");
                        alert.SetMessage("Orden Tecnica Finalizada Correctamente");
                        alert.SetPositiveButton("ACEPTAR",(sender, args)=> 
                        {
                            //AQUI NOS DEBE ENVIAR DE NUEVO A LA LISTA QUE ESTAN EN PROCESO
                            alert.Dispose();
                            iSolucionOrden.AbrirOrdenProceso();
                        });
                        Dialog dialog = alert.Create();
                        dialog.Show();

                    }
                    else if (response.status==true && response.code==2)
                    {
                        Console.WriteLine(response.message);
                        alert = new AlertDialog.Builder(Activity);
                        alert.SetTitle("MENSAJE DE CONFIRMACION");
                        alert.SetMessage("No se pudo procesar la solicitud");
                        alert.SetPositiveButton("ACEPTAR", (sender, args) =>
                        {
                            //NOS MANTIENE EN EL MISMO FRAGMENTO
                            alert.Dispose();
                        });
                        Dialog dialog = alert.Create();
                        dialog.Show();
                    }
                }
                else if (postJson.StatusCode==System.Net.HttpStatusCode.NotFound)
                {
                    Toast.MakeText(Activity, "servicio no encontrado", ToastLength.Short).Show();
                }

            }
            else
            {
                Toast.MakeText(Activity, "Esta Orden Tecnica no contiende detalles de problemas", ToastLength.Short).Show();
            }
        }
    }
}