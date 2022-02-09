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

namespace OrdenTecnica_App.Models.Statics
{
    public static class UserLogin
    {
        public static string _id_usuario { get; set; }
        public static string _cod_usuario { get; set; }
        public static string _usuario { get; set; }
        public static string _contraseña { get; set; }
        public static string _foto { get; set; }
        public static string _estado { get; set; }
        public static int _fk_perfil { get; set; }
        public static int _fk_empleado { get; set; }
        public static string _nombres { get; set; }
        public static string _apellidos { get; set; }
    }
}