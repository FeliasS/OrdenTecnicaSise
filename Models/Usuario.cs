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

namespace OrdenTecnica_App.Models
{
    class Usuario
    {
        public int _ID_USUARIO { get; set; }
        public string _COD_USUARIO { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string _FOTO { get; set; }
        public int _ESTADO { get; set; }
        public int _FK_PERFIL { get; set; } //En la BD no esta relacionado
        public int _FK_EMPLEADO { get; set; } //En la BD no esta relacionado
        public string _NOMBRES { get; set; }
        public int _APELLIDOS { get; set; }

        public Usuario(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }


        //Constructor para el Login

    }
}