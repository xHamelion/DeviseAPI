//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeviseAPI.Entity
{
    using System;
    
    public partial class Hranim_Sost_J_Vibit_Result
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
    }
}
