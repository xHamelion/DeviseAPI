using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeviseAPI.Entity;

namespace DeviseAPI.Models
{
    public class SkladDate
    {
        public SkladDate(View_Sklad sklad)
        {
            ID_Sklad = sklad.ID_Sklad;
            ID_Tovar = sklad.ID_Tovar;
            ID_Tip = sklad.ID_Tip;
            ID_PodTip = sklad.ID_PodTip;
            Koll = sklad.Koll;
            if(sklad.Sredn_Zena!=null)
                Zena = (int)sklad.Sredn_Zena;
            else
                Zena = 0;
            Tip = sklad.Tip;
            PodTip = sklad.PodTip;
            Tovar = sklad.Tovar;
            Opisanie = sklad.Opisanie;
            Image = sklad.Image;
        }

        public int ID_Sklad { get; set; }
        public int ID_Tovar { get; set; }
        public int ID_Tip { get; set; }
        public int ID_PodTip { get; set; }
        public int Koll { get; set; }
        public int Zena { get; set; }
        public string Tip { get; set; }
        public string PodTip { get; set; }
        public string Tovar { get; set; }
        public string Opisanie { get; set; }
        public byte[] Image { get; set; }


    }
}