﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Bumptech.Glide;
using Newtonsoft.Json;
using OrdenTecnica_App.ServicesClubTec;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Controls;
using Xamarin.Essentials;

namespace OrdenTecnica_App.Fragments
{
    public class OrdenSolucionar_Fragment : AndroidX.Fragment.App.Fragment
    {
        //Definiendo los componentes de la vista
        EditText txtDiagnostico;

        //Usar estos valores para   | guardar cambios(modificar orden) | finalizar orden (modificar orden + cmabiar estado de detalle de orden) * solo los usas ya que ya trae los valores
        //Values
        string nroOrden = "ORDEN14"; //aqui igualar al dato traido
        string PathImgInicio, PathImgFin;
        string PathFirmaTec, PathFirmaCli;
        //

        String PhotoPath = "";
        ImageView imgIni, imgFin;
        ImageView imgFirmTec, imgFirmCli, imgTemp;
        TextView lblFtec, lblFcli;
        LayoutInflater inflaterlocal;


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Activity.Title = "SOLUCIONAR ORDEN TECNICA";
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Xamarin.Essentials.Platform.Init(Activity, savedInstanceState);
            inflaterlocal = inflater;

            View view = inflater.Inflate(Resource.Layout.fragment_OrdenProceso0, container, false);
            txtDiagnostico = view.FindViewById<EditText>(Resource.Id.txtDiagnostico);

            //FOTOS
            Button btnTakephoto = view.FindViewById<Button>(Resource.Id.btnTakephoto);
            Button btnAddphotos = view.FindViewById<Button>(Resource.Id.btnAddphotos);
            Button btnTakephotoF = view.FindViewById<Button>(Resource.Id.btnTakephotoF);
            Button btnAddphotosF = view.FindViewById<Button>(Resource.Id.btnAddphotosF);

            imgIni = view.FindViewById<ImageView>(Resource.Id.imageViewI);
            imgFin = view.FindViewById<ImageView>(Resource.Id.imageViewF);
            imgFirmTec = view.FindViewById<ImageView>(Resource.Id.IVfirmatecnico);
            imgFirmCli = view.FindViewById<ImageView>(Resource.Id.IVfirmacliente);

            int idtimephoto = 0;

            btnTakephoto.Click += async (sender, e) => { idtimephoto = 1; await TakePhotoAsync(1); };
            btnAddphotos.Click += async (sender, e) => { idtimephoto = 1; await PickPhotoAsync(1); };
            btnTakephotoF.Click += async (sender, e) => { idtimephoto = 2; await TakePhotoAsync(2); };
            btnAddphotosF.Click += async (sender, e) => { idtimephoto = 2; await PickPhotoAsync(2); };

            //FIRMAS
            Button btnfirmaTec = view.FindViewById<Button>(Resource.Id.btnfirmaTec);
            Button btnfirmaCli = view.FindViewById<Button>(Resource.Id.btnfirmaCli);
            btnfirmaTec.Click += btnfirmaTec_Clicked;
            btnfirmaCli.Click += btnfirmaCli_Clicked;

            TextView lblFtec = view.FindViewById<TextView>(Resource.Id.lblFtec);
            TextView lblFcli = view.FindViewById<TextView>(Resource.Id.lblFcli);

            //BOTONES GUARDAR - FINALIZAR
            Button btnGuardarcambiosOrden = view.FindViewById<Button>(Resource.Id.btnGuardarcambiosOrden);
            btnGuardarcambiosOrden.Click += Generar;

            return view;
        }

        private async void btnfirmaTec_Clicked(object sender, EventArgs e) { /*await solicitarPermisos(); */ ProcesoFirm(1); }
        private async void btnfirmaCli_Clicked(object sender, EventArgs e) { /*await solicitarPermisos(); */ ProcesoFirm(2); }

        private void ProcesoFirm(int id)
        {
            View view;
            Android.App.AlertDialog.Builder dg = new Android.App.AlertDialog.Builder(Activity);
            //dg.SetTitle("");
            dg.SetMessage("FIRME EN EL ESPACIO EN BLANCO LO MAS PARECIDO A SU DNI");

            view = inflaterlocal.Inflate(Resource.Layout.Item_firmas, null, true);
            SignaturePadView signaturePadView = view.FindViewById<SignaturePadView>(Resource.Id.signaturePadView);
            Button btnSaveFirm = view.FindViewById<Button>(Resource.Id.btnSaveFirm);
            Button btnCancelFirm = view.FindViewById<Button>(Resource.Id.btnCancelFirm);

            dg.SetView(view);
            Dialog dialog = dg.Create();
            dialog.Show();


            btnSaveFirm.Click += async (sender, e) =>
            {

                if (signaturePadView.Points.Count() > 0)
                {
                    string Fname = "", Fdirectoryname = "", urlrestFirm = "";
                    switch (id)
                    {
                        case 1:
                            Fname = nroOrden + "_T" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ".Png";
                            Fdirectoryname = "http://photo.micmaproyectos.com/imagenes/firma";                                                            //aqui va el url del la carpeta de imagenes           **por si hay cambios
                            urlrestFirm = "";                                                                                                               //aqui poner el url del rest (REST FIRMA TECNICO)       **CAMBIAR
                            Console.WriteLine("mY CODE : " + Android.App.Application.Context.GetExternalFilesDir("").AbsolutePath);
                            break;
                        case 2:
                            Fname = nroOrden + "_C" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ".Png";
                            Fdirectoryname = "http://photo.micmaproyectos.com/imagenes/firma";                                                            // aqui va el url del la carpeta de imagenes          **por si hay cambios
                            urlrestFirm = "";                                                                                                                //aqui poner el url del rest (REST FIRMA CLIENTE)      **CAMBIAR
                            break;
                    }

                    Stream image = await signaturePadView.GetImageStreamAsync(SignatureImageFormat.Png);
                    //var stream = await photo.OpenReadAsync();
                    HttpClient httpClient = new HttpClient();
                    Uri urlmtf = new Uri(urlrestFirm);
                    MultipartFormDataContent form = new MultipartFormDataContent();
                    form.Add(new StreamContent(image), name: "file", fileName: Fname);
                    HttpResponseMessage response; string content;

                    response = await httpClient.PostAsync(urlmtf, form);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        content = await response.Content.ReadAsStringAsync();
                        var resultado = JsonConvert.DeserializeObject<UploadFirm>(content);

                        response.EnsureSuccessStatusCode();
                        httpClient.Dispose();

                        if (resultado.status == 1)
                        {
                            string rutaImg = Fdirectoryname + resultado.data;

                            PutImgFirms(id, rutaImg);
                            dialog.Dismiss();
                            Toast.MakeText(Activity, resultado.message, ToastLength.Short).Show();

                        }
                        else if (resultado.status == 0)
                        {
                            Toast.MakeText(Activity, resultado.message, ToastLength.Short).Show();
                        }

                    }
                    else { Toast.MakeText(Activity, "ERROR DE CONEXION", ToastLength.Short).Show(); }
                }
                else { return; }
            };

            btnCancelFirm.Click += (sender, e) => { dialog.Dismiss(); };
        }

        private void PutImgFirms(int id, string pathfirm)
        {

            if (File.Exists(pathfirm))
            {
                switch (id)
                {
                    case 1:
                        //Image tecimg = Image.FromFile(pathfirm);
                        Glide.With(Activity).AsBitmap().Load(pathfirm).Into(imgFirmTec);
                        imgFirmTec.Visibility = Android.Views.ViewStates.Visible;
                        lblFtec.Visibility = Android.Views.ViewStates.Visible;
                        PathFirmaTec = pathfirm;
                        break;
                    case 2:
                        Glide.With(Activity).AsBitmap().Load(pathfirm).Into(imgFirmCli);
                        imgFirmCli.Visibility = Android.Views.ViewStates.Visible;
                        lblFcli.Visibility = Android.Views.ViewStates.Visible;
                        PathFirmaCli = pathfirm;
                        break;
                }
            }
        }

        async Task TakePhotoAsync(int idtimephoto)
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(photo, idtimephoto);
                Console.WriteLine($" Captura: {PhotoPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }

        }

        async Task PickPhotoAsync(int idtimephoto)
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                await LoadPhotoAsync(photo, idtimephoto);
                Console.WriteLine($"Explorer COMPLETED: {PhotoPath}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        async Task LoadPhotoAsync(FileResult photo, int idtimephoto)
        {
            if (photo == null)
            {
                PhotoPath = null;

                return;
            }
            else
            {

                string urlrestImg = "";
                string urlDirectoryImg = "";
                switch (idtimephoto)
                {
                    case 1:
                        urlrestImg = "http://servicios.micmaproyectos.com/orden/uploadImagenBack";      //aqui va el url del rest (REST IMAGEN DE INICIO)      **por si hay cambios
                        urlDirectoryImg = "http://servicios.micmaproyectos.com/imagenes/orden/back/";  //aqui se debe poner el url  http://photo.micmaproyectos.com/imagenes/orden/back  **esta es temporal y funciona
                        //imgTemp = imgIni;

                        break;
                    case 2:
                        urlrestImg = "http://servicios.micmaproyectos.com/orden/uploadImagen...";     //aqui poner el url del rest (REST IMAGEN DE FIN)                   **CAMBIAR
                        urlDirectoryImg = "http://photo.micmaproyectos.com/imagenes/orden/later";    //aqui va la carpetas de imagen fin                           **por si hay cambios 
                        break;

                }

                //psdt: si van a usar el mismo rest con un identificador de envio, en arriba hacer los cambios ya que esta sectorizado y abajo esta como funcion

                var stream = await photo.OpenReadAsync();
                HttpClient httpClient = new HttpClient();
                Uri urlmtf = new Uri(urlrestImg);
                MultipartFormDataContent form = new MultipartFormDataContent();
                form.Add(new StreamContent(stream), name: "file", fileName: photo.FileName);
                HttpResponseMessage response; string content;
                try
                {
                    response = await httpClient.PostAsync(urlmtf, form);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK) // System.Net.HttpStatusCode.OK
                    {
                        content = await response.Content.ReadAsStringAsync();
                        var resultado = JsonConvert.DeserializeObject<UploadImage>(content);

                        response.EnsureSuccessStatusCode();
                        httpClient.Dispose();

                        if (resultado.status == 1)
                        {
                            PhotoPath = urlDirectoryImg + resultado.data;
                            switch (idtimephoto)
                            {
                                case 1:
                                    Glide.With(Activity).AsBitmap().Load(PhotoPath).Into(imgIni);
                                    PathImgInicio = PhotoPath;

                                    break;
                                case 2:
                                    Glide.With(Activity).AsBitmap().Load(PhotoPath).Into(imgFin);
                                    PathImgFin = PhotoPath;
                                    break;
                            }

                            Toast.MakeText(Activity, resultado.message, ToastLength.Short).Show();

                        }
                        else if (resultado.status == 0)
                        {
                            Toast.MakeText(Activity, resultado.message, ToastLength.Short).Show();
                        }

                    }
                    else { Toast.MakeText(Activity, "ERROR DE CONEXION", ToastLength.Short).Show(); }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            }

        }

        public void Generar(object sender, EventArgs e)
        {

            Toast.MakeText(Activity, PathImgInicio + "hi " + PathImgFin, ToastLength.Short).Show();
        }

    }

}