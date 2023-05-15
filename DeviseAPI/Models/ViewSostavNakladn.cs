using System;
using System.Collections.Generic;
using System.Linq;
using DeviseAPI.Entity;
using System.Web;

namespace DeviseAPI.Models
{
    public class ViewSostavNakladn
    {
        public int ID_Naklad_Prodag { get; set; }
        public int ID_Tovar { get; set; }
        public int ID_PodTip { get; set; }
        public int ID_Tip { get; set; }
        public string Tip { get; set; }
        public string PodTip { get; set; }
        public string Tovar { get; set; }
        public string Opisanie { get; set; }
        public int Koll { get; set; }
        public decimal Zena { get; set; }
        public decimal Summa { get; set; }
        public byte[] Image { get; set; }

        public ViewSostavNakladn(View_Sost_Naklad_Prodag view_Sost_Naklad_Prodag)
        {
            this.ID_Naklad_Prodag = view_Sost_Naklad_Prodag.ID_Naklad_Prodag;
            this.ID_Tovar = view_Sost_Naklad_Prodag.ID_Tovar;
            this.ID_PodTip = view_Sost_Naklad_Prodag.ID_PodTip;
            this.ID_Tip = view_Sost_Naklad_Prodag.ID_Tip;
            this.Tip = view_Sost_Naklad_Prodag.Tip;
            this.PodTip = view_Sost_Naklad_Prodag.PodTip;
            this.Tovar = view_Sost_Naklad_Prodag.Tovar;
            this.Opisanie = view_Sost_Naklad_Prodag.Opisanie;
            this.Koll = view_Sost_Naklad_Prodag.Koll;
            this.Zena = view_Sost_Naklad_Prodag.Zena;
            this.Summa = view_Sost_Naklad_Prodag.Summa;
            this.Image = view_Sost_Naklad_Prodag.Image;
        }
    }
}