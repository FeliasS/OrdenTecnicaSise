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

namespace OrdenTecnica_App.ServicesClubTec
{
    class TramaUsuario
    {
        public bool STATUS { get; set; }
        public int CODE { get; set; }
        public string MESSAGE { get; set; }
        public UsuarioWs OBJETO { get; set; }

        public TramaUsuario(bool sTATUS, int cODE, string mESSAGE, UsuarioWs oBJETO)
        {
            STATUS = sTATUS;
            CODE = cODE;
            MESSAGE = mESSAGE;
            OBJETO = oBJETO;
        }
    }

    public class UsuarioWs
    {
        public string _id_usuario { get; set; }
        public string _cod_usuario { get; set; }
        public string _usuario { get; set; }
        public string _contraseña { get; set; }
        public string _foto { get; set; }
        public string _estado { get; set; }
        public int _fk_perfil { get; set; }
        public int _fk_empleado { get; set; }
        public string _nombres { get; set; }
        public string _apellidos { get; set; }

        public UsuarioWs(string id_usuario, string cod_usuario, string usuario, string contraseña, string foto, string estado, int fk_perfil, int fk_empleado, string nombres, string apellidos)
        {
            _id_usuario = id_usuario;
            _cod_usuario = cod_usuario;
            _usuario = usuario;
            _contraseña = contraseña;
            _foto = foto;
            _estado = estado;
            _fk_perfil = fk_perfil;
            _fk_empleado = fk_empleado;
            _nombres = nombres;
            _apellidos = apellidos;
        }

    }
}