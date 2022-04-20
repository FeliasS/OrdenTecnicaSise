using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrdenTecnica_App.Controller;
using OrdenTecnica_App.Models;
using Xamarin.Essentials;
using System.Net.Http;
using Newtonsoft.Json;
using OrdenTecnica_App.ServicesClubTec;
using OrdenTecnica_App.Models.Statics;

namespace OrdenTecnica_App
{
    [Activity(Label = "LoginActivity", MainLauncher =false)]
    public class LoginActivity : Activity
    {
        // Definiendo los controles del login
        EditText txtUsuario, txtContraseña;
        Button btnIngresar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);

            // Create your application here
            txtUsuario = FindViewById<EditText>(Resource.Id.txtUsuario);
            txtContraseña = FindViewById<EditText>(Resource.Id.txtContraseña);
            btnIngresar = FindViewById<Button>(Resource.Id.btnIngresar);

            // Click ingresar
            btnIngresar.Click += BtnIngresar_Click;

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (Connectivity.NetworkAccess==NetworkAccess.None)
            {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
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
                Toast.MakeText(this, "Conexion a internet establecida", ToastLength.Short).Show();
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar(txtUsuario.Text, txtContraseña.Text);
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private bool CamposVacios(string u, string c)
        {
            if (u.Equals("") || c.Equals(""))
            {
                return true;
            }
            return false;
        }

        private async void Ingresar(string u, string c)
        {

            if (CamposVacios(u,c).Equals(true))
            {
                Toast.MakeText(this, "Campos vacíos, Ingrese datos", ToastLength.Short).Show();
                txtUsuario.Selected = true;
            }
            else
            {
                try
                {
                    Usuario login = new Usuario(u, c);

                    HttpClient client = new HttpClient();
                    Uri url = new Uri("http://servicios.micmaproyectos.com/usuario/login");

                    var json = JsonConvert.SerializeObject(login);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var postJson = await client.PostAsync(url, content);

                    Console.WriteLine(json);
                    if (postJson.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine("estado de enviso json: " + postJson.StatusCode);

                        string readJson = await postJson.Content.ReadAsStringAsync();


                        var response = JsonConvert.DeserializeObject<TramaUsuario>(readJson);

                        if (response.STATUS == true && response.CODE == 1)
                        {
                            Console.WriteLine("mensaje: " + response.MESSAGE);
                            Console.WriteLine("\n id usuario: " + response.OBJETO._id_usuario +
                                "\n cod_usuario: " + response.OBJETO._cod_usuario +
                                "\n usuario: " + response.OBJETO._contraseña +
                                "\n foto: " + response.OBJETO._foto +
                                "\n estado: " + response.OBJETO._estado +
                                "\n perfil: " + response.OBJETO._fk_perfil +
                                "\n empleado: " + response.OBJETO._fk_empleado +
                                "\n nombres: " + response.OBJETO._nombres +
                                "\n apellidos: " + response.OBJETO._apellidos);

                            ISharedPreferences pref = GetSharedPreferences("MisPreferencias", FileCreationMode.Private);
                            ISharedPreferencesEditor editor = pref.Edit();
                            editor.PutString("idUser", response.OBJETO._id_usuario); //¿porque en string?
                            editor.PutString("nombreUser", response.OBJETO._nombres + ' ' + response.OBJETO._apellidos);
                            editor.PutInt("cargo", response.OBJETO._fk_perfil);
                            editor.PutString("fotoUser", response.OBJETO._foto);
                            editor.PutInt("idEmpleado", response.OBJETO._fk_empleado);
                            editor.Apply();


                            var intent = new Intent(this, typeof(MainActivity));
                            intent.PutExtra(MainActivity.LLAVE_COD_EMPLEADO, response.OBJETO._fk_empleado);
                            StartActivity(intent);
                            postJson.Dispose(); //cerramos el servicio
                            LimpiarCampos();

                            UserLogin._fk_empleado = response.OBJETO._fk_empleado;
                            UserLogin._fk_perfil = response.OBJETO._fk_perfil;
                            Console.WriteLine("codigo de empleado en static: " + UserLogin._fk_empleado);

                        }
                        else if (response.STATUS == true && response.CODE == 2)
                        {
                            Toast.MakeText(this, response.MESSAGE, ToastLength.Short).Show();
                        }


                    }
                    else if (postJson.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        Toast.MakeText(this, "no se pudo procesar la operacion", ToastLength.Short).Show();
                    }
                }
                catch (Java.IO.IOException e)
                {
                    Console.WriteLine("mensaje: " + e.Message);
                }

                
                
            }
        }
    }
}