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
    using System.Collections.Generic;
    
    public partial class Sost_Naklad_Prodag
    {
        public int ID_Naklad_Prodag { get; set; }
        public int ID_Tovar { get; set; }
        public int Koll { get; set; }
        public decimal Zena { get; set; }
        public decimal Summa { get; set; }
    
        public virtual Naklad_Prodag Naklad_Prodag { get; set; }
        public virtual Tovar Tovar { get; set; }
    }
}