using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeviseAPI.Entity;

namespace DeviseAPI.Models
{

    public class Rootobject6
    {
        public Sost_Naklad_ProdagDellAdd[] Property6 { get; set; }
    }


    public class Sost_Naklad_ProdagDellAdd
    {
        public Sost_Naklad_ProdagDellAdd(Sost_Naklad_Prodag sost_Naklad_Prodag)
        {
            this.ID_Naklad_Prodag = sost_Naklad_Prodag.ID_Naklad_Prodag;
            this.ID_Tovar = sost_Naklad_Prodag.ID_Tovar;
            this.Koll = sost_Naklad_Prodag.Koll;
            this.Zena = sost_Naklad_Prodag.Zena;
            this.Summa = sost_Naklad_Prodag.Summa;
        }
        public int ID_Naklad_Prodag { get; set; }
        public int ID_Tovar { get; set; }
        public int Koll { get; set; }
        public decimal Zena { get; set; }
        public decimal Summa { get; set; }
    }
}