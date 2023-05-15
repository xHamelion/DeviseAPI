using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeviseAPI.Entity;

namespace DeviseAPI.Models
{
    public class NakladProd
    {
        
        public NakladProd(Naklad_Prodag naklad_Prodag)
        {
            this.ID_Zakaz = naklad_Prodag.ID_Naklad_Prodag;
            this.Nomer = naklad_Prodag.Nomer;
        }
        public int ID_Zakaz { get; set; }
        public int ID_Naklad_Prodag { get; set; }
        public int ID_Pokup { get; set; }
        public int ID_Sotrudnic { get; set; }
        public DateTime Data_Pokup { get; set; }
        public string Nomer { get; set; }
        public double Summa { get; set; }
        public double Dostavka { get; set; }
        public double Summa_Obh { get; set; }
        public int ID_InternetUser { get; set; }
    }
}