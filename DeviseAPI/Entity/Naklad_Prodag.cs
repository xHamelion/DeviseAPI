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
    using Newtonsoft.Json;
    
    public partial class Naklad_Prodag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Naklad_Prodag()
        {
            this.Sost_Naklad_Prodag = new HashSet<Sost_Naklad_Prodag>();
        }
    
        public int ID_Naklad_Prodag { get; set; }
        public int ID_Pokup { get; set; }
        public int ID_Sotrudnic { get; set; }
        public System.DateTime Data_Pokup { get; set; }
        public string Nomer { get; set; }
        public decimal Summa { get; set; }
        public decimal Dostavka { get; set; }
        public decimal Summa_Obh { get; set; }
        public Nullable<int> ID_InternetUser { get; set; }
        [JsonIgnore]
        public virtual InternetUser InternetUser { get; set; }
        [JsonIgnore]
        public virtual Pokup Pokup { get; set; }
        [JsonIgnore]
        public virtual Sotrudnic Sotrudnic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Sost_Naklad_Prodag> Sost_Naklad_Prodag { get; set; }
    }
}
