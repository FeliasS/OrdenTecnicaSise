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
    class TramaOrdenObjeto
    {
        internal bool STATUS { get; set; }
        internal int CODE { get; set; }
        internal string MESSAGE { get; set; }
        public OrdenTecnicaWS OBJETO { get; set; }

        public TramaOrdenObjeto(bool sTATUS, int cODE, string mESSAGE, OrdenTecnicaWS oBJETO)
        {
            STATUS = sTATUS;
            CODE = cODE;
            MESSAGE = mESSAGE;
            OBJETO = oBJETO;
        }
    }
}