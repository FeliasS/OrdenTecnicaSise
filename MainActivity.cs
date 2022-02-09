using System;
using System.Drawing;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;
using OrdenTecnica_App.Fragments;
using OrdenTecnica_App.Interface;
using Xamarin.Essentials;

namespace OrdenTecnica_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = false)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener, INuevaOrden,ISolucionOrden
    {
        //Definimos los fragmentos
        OrdenCerrada_Fragment ordenCerrada;
        OrdenAsignada_Fragment OrdenPendiente;

        int empleado;
        int cargo;


        //llaves estaticas
        public static readonly string LLAVE_COD_EMPLEADO="nombre";

        // Funcion para llamar a los fragmentos
        void callFragmentInConteiner()
        {
            Title = "ORDENES CERRADAS";
            ordenCerrada = new OrdenCerrada_Fragment();
            
            var transaccion = SupportFragmentManager.BeginTransaction();
            transaccion.Add(Resource.Id.conteinerView, ordenCerrada);
            transaccion.Commit();
        }

        void FragmentNuevaOrden()
        {
            NuevaOrden_Fragment nOrden = new NuevaOrden_Fragment();

            var transaccion = SupportFragmentManager.BeginTransaction();
            transaccion.Replace(Resource.Id.conteinerView, nOrden);
            transaccion.Commit();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            //Get SharedPreferences
            ISharedPreferences pref = GetSharedPreferences("MisPreferencias", FileCreationMode.Private);
            pref.GetString(("idUser"), null);
            cargo = pref.GetInt(("cargo"), 0);
            
            empleado = pref.GetInt(("idEmpleado"), 0);
            string nomUser = pref.GetString(("nombreUser"), null);
            
            string fotoUser = "";
            fotoUser = pref.GetString(("fotoUser"), null);

            Console.WriteLine("id cargo: " + cargo);
            Console.WriteLine("id empleado: " + empleado);

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

            

            View headerView = navigationView.GetHeaderView(0);
            navigationView.SetNavigationItemSelectedListener(this);

            // Validamos los cargos
            switch (cargo)
            {
                case 5: //JEFE DE OPERACIONES
                    headerView.FindViewById<TextView>(Resource.Id.textViewNomUser).Text = nomUser;
                    headerView.FindViewById<TextView>(Resource.Id.textViewCargoUser).Text = "JEFE DE OPERACIONES";

                    if (fotoUser == "sin_imagen.jpg")
                    {
                        headerView.FindViewById<ImageView>(Resource.Id.imageViewUser).SetImageResource(Resource.Drawable.sin_imagen);
                    }
                    else
                    {
                        System.Net.WebRequest request = System.Net.WebRequest.Create("https://i.ibb.co/5T5n6nj/kitten.jpg");
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream responseStream = response.GetResponseStream();
                        Android.Graphics.Bitmap bitmap = BitmapFactory.DecodeStream(responseStream);
                        headerView.FindViewById<ImageView>(Resource.Id.imageViewUser).SetImageBitmap(bitmap);
                    }

                    //Mostramos los items menu del menu lateral
                    navigationView.Menu.FindItem(Resource.Id.nuev_orden).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_creada).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_asignada).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_proceso).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_atendido).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_cerrado).SetVisible(true);

                    // Instanciamos el objeto
                    // Al ser el cargo mas alto, este debe mostrar de primera todas las ordenes pendientes
                    // Llamamos a la lista de ordenes cerradas
                    callFragmentInConteiner();
                    break;

                case 2: //SUPERVISOR: TECNICO
                    headerView.FindViewById<TextView>(Resource.Id.textViewNomUser).Text = nomUser;// app:headerLayout
                    headerView.FindViewById<TextView>(Resource.Id.textViewCargoUser).Text = "SUPERVISOR";

                    if (fotoUser == "sin_imagen.jpg")
                    {
                        headerView.FindViewById<ImageView>(Resource.Id.imageViewUser).SetImageResource(Resource.Drawable.sin_imagen);
                    }
                    else
                    {
                        System.Net.WebRequest request = System.Net.WebRequest.Create("https://i.ibb.co/5T5n6nj/kitten.jpg"); //url = obj = string
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream resposeStream = response.GetResponseStream();

                        Android.Graphics.Bitmap bitmap = BitmapFactory.DecodeStream(resposeStream);
                        headerView.FindViewById<ImageView>(Resource.Id.imageViewUser).SetImageBitmap(bitmap);

                    }

                    navigationView.Menu.FindItem(Resource.Id.nuev_orden).SetVisible(false);
                    navigationView.Menu.FindItem(Resource.Id.orden_creada).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_asignada).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_proceso).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_atendido).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_cerrado).SetVisible(true);

                    callFragmentInConteiner();

                    break;

                case 1: //Tecnico
                    headerView.FindViewById<TextView>(Resource.Id.textViewNomUser).Text = nomUser;// app:headerLayout
                    headerView.FindViewById<TextView>(Resource.Id.textViewCargoUser).Text = "Técnico";

                    if (fotoUser == "sin_imagen.jpg")  //|| fotouser == ""
                    {
                        headerView.FindViewById<ImageView>(Resource.Id.imageViewUser).SetImageResource(Resource.Drawable.sin_imagen); //setImageResource 
                    }
                    else
                    {
                        System.Net.WebRequest request = System.Net.WebRequest.Create("https://i.ibb.co/5T5n6nj/kitten.jpg"); //url = obj = string
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream responseStream = response.GetResponseStream();
                        Android.Graphics.Bitmap bitmap = BitmapFactory.DecodeStream(responseStream);
                        headerView.FindViewById<ImageView>(Resource.Id.imageViewUser).SetImageBitmap(bitmap);
                    }

                    navigationView.Menu.FindItem(Resource.Id.nuev_orden).SetVisible(false);
                    navigationView.Menu.FindItem(Resource.Id.orden_creada).SetVisible(false);
                    navigationView.Menu.FindItem(Resource.Id.orden_asignada).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_proceso).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_atendido).SetVisible(true);
                    navigationView.Menu.FindItem(Resource.Id.orden_cerrado).SetVisible(false);

                    OrdenAtendida_Fragment ordenAtendido = new OrdenAtendida_Fragment();
                    var transaccion = SupportFragmentManager.BeginTransaction();

                    transaccion.Replace(Resource.Id.conteinerView, ordenAtendido);
                    transaccion.Commit();

                    break;
            }

        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (Connectivity.NetworkAccess== NetworkAccess.None)
            {
                Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this);
                builder.SetTitle("MENSAJE");
                builder.SetMessage("Se ha perdido la conexion a internet");
                builder.SetNeutralButton("ACEPTAR", (sender, args) =>
                {
                    //type congiguration
                });
                Dialog dialog = builder.Create();
                dialog.Show();
                return;
            }
            else
            {
                Android.Widget.Toast.MakeText(this, "Conexion a internet establecida", Android.Widget.ToastLength.Short).Show();
            }
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            
            int id = item.ItemId;
            
            if (id == Resource.Id.nuev_orden)
            {
                FragmentNuevaOrden();
            }
            if (id == Resource.Id.orden_creada)
            {
                OrdenCreada_Fragment ordenCreada = new OrdenCreada_Fragment();
                var transaccion = SupportFragmentManager.BeginTransaction();

                transaccion.Replace(Resource.Id.conteinerView, ordenCreada);
                transaccion.Commit();
            }
            else if (id == Resource.Id.orden_asignada)
            {

                OrdenPendiente = new OrdenAsignada_Fragment();
                var transaccion = SupportFragmentManager.BeginTransaction();

                transaccion.Replace(Resource.Id.conteinerView, OrdenPendiente);
                transaccion.Commit();

            }
            else if (id == Resource.Id.orden_proceso)
            {
                int estadoOrden = 2; // aqui el tecnico ya esta actualizando la orden
                OrdenProceso_Fragment ordenProceso = new OrdenProceso_Fragment();
                var transaccion = SupportFragmentManager.BeginTransaction();

                transaccion.Replace(Resource.Id.conteinerView, ordenProceso);
                transaccion.Commit();
            }
            else if (id == Resource.Id.orden_atendido)
            {
                int estadoOrden = 3; // Aqui indica que ya dio solucion a la orden
                OrdenAtendida_Fragment ordenAtendido = new OrdenAtendida_Fragment();
                var transaccion = SupportFragmentManager.BeginTransaction();

                transaccion.Replace(Resource.Id.conteinerView, ordenAtendido);
                transaccion.Commit();
            }
            else if (id == Resource.Id.orden_cerrado)
            {
                ordenCerrada = new OrdenCerrada_Fragment();
                int estadoOrden = 4; // aqui la orden ya tiene el visto bueno por el supervisor general
                int v = Intent.GetIntExtra(LLAVE_COD_EMPLEADO, 0);

                Bundle bundle = new Bundle();
                bundle.PutInt("miCodigoFragment", v);

                Console.WriteLine("dato de login: " + v);
                ordenCerrada.Arguments=bundle;

                var transaccion = SupportFragmentManager.BeginTransaction();

                transaccion.Replace(Resource.Id.conteinerView, ordenCerrada);
                transaccion.Commit();
            }
            else if (id == Resource.Id.cerrar_sesion)
            {
                this.FinishAffinity();
            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void AbrirListaPendiente()
        {
            OrdenCreada_Fragment ordenCreada = new OrdenCreada_Fragment();

            var transaccion = SupportFragmentManager.BeginTransaction();
            transaccion.Replace(Resource.Id.conteinerView, ordenCreada);
            transaccion.Commit();
        }

        public void AbrirSolucionOrden()
        {
            OrdenSolucionar_Fragment ordenSolucionar = new OrdenSolucionar_Fragment();

            var transaccion = SupportFragmentManager.BeginTransaction();
            transaccion.Replace(Resource.Id.conteinerView, ordenSolucionar);
            transaccion.Commit();
        }

        public void AbrirSolucionOrden0()
        {
            OrdenSolucionar0_Fragment ordenSol0 = new OrdenSolucionar0_Fragment();

            var transaccion = SupportFragmentManager.BeginTransaction();
            transaccion.Replace(Resource.Id.conteinerView, ordenSol0);
            transaccion.Commit();
        }
    }
}

