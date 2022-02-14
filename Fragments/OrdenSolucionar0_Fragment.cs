using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using OrdenTecnica_App.Interface;
using OrdenTecnica_App.ListRecycler.Adapter;
using OrdenTecnica_App.Models;
using OrdenTecnica_App.ServicesClubTec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenTecnica_App.Fragments
{
    public class OrdenSolucionar0_Fragment : AndroidX.Fragment.App.Fragment
    {
        TextView lblFecha, lblHora, lblClient, lblSucursal, lblAsunto, lblCodigo;
        RecyclerView rvODetalle;

        //Definimos el adaptador para el recyclerView
        RecyclerView.LayoutManager mLayoutManager;
        ListOrdenDetalle_Adapter mAdapter;

        // Lista Detalle Orden
        List<Detalle_Orden> lstDo;

        //Definimos una orden estatica
        static OrdenWs o;

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

            SetData();

            //ingresamos unos datos estaticos
            lstDo = new List<Detalle_Orden>();
            Detalle_Orden dtor = new Detalle_Orden();
            dtor._COD_DETALLE_ORD = "...";
            dtor._DESCRIPCION = "...";
            dtor._ESTADO = "...";
            dtor._FK_DISPOSITIVO = "...";
            lstDo.Add(dtor);

            mAdapter = new ListOrdenDetalle_Adapter(lstDo);
            rvODetalle.SetAdapter(mAdapter);

            //INSTACIAMOS EL ADAPTADOR DEL LIST
            mLayoutManager = new LinearLayoutManager(Activity);
            rvODetalle.SetLayoutManager(mLayoutManager);

            mAdapter.ItemClick += MAdapter_ItemClick;

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
                o.COD_ORDEN = orden.COD_ORDEN;
                o.FECHA_ORDEN = orden.FECHA_ORDEN;
                o.HORA_ORDEN = orden.HORA_ORDEN;
                o.REMITENTE = orden.REMITENTE;
                o.FK_SUCURSAL = orden.FK_SUCURSAL;
                o.ASUNTO = orden.ASUNTO;
                o.ESTADO = orden.ESTADO;

                Console.WriteLine("datos LLenos");
            }

        }

        private void MAdapter_ItemClick(object sender, int e)
        {
            iSolucionOrden.AbrirSolucionOrden();
        }
    }
}