using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeviseAPI.Entity;

namespace DeviseAPI.Models
{
    public class TipDate
    {
        public TipDate(View_PodTip _PodTip)
        {
            ID_Tip = _PodTip.ID_Tip;
            ID_PodTip = _PodTip.ID_PodTip;
            Tip = _PodTip.Tip;
            PodTip = _PodTip.PodTip;
        }
        public int ID_Tip { get; set; }
        public int ID_PodTip { get; set; }
        public string Tip { get; set; }
        public string PodTip { get; set; }

    }
}