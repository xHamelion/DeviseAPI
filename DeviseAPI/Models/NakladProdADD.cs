using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeviseAPI.Controllers
{
    public class NakladProdADD
    {
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