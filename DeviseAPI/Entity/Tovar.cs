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
    
    public partial class Tovar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tovar()
        {
            this.Sklad = new HashSet<Sklad>();
            this.Sost_Naklad_Prodag = new HashSet<Sost_Naklad_Prodag>();
            this.Sost_Nakladna = new HashSet<Sost_Nakladna>();
            this.Sostav_Partii = new HashSet<Sostav_Partii>();
            this.Sostav_Postupl_Naklad = new HashSet<Sostav_Postupl_Naklad>();
            this.Sostav_Vibitie_Naklad = new HashSet<Sostav_Vibitie_Naklad>();
        }
    
        public int ID_Tovar { get; set; }
        public string Tovar1 { get; set; }
        public string Opisanie { get; set; }
        public int ID_PodTip { get; set; }
        public byte[] Image { get; set; }
    
        public virtual PodTip PodTip { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sklad> Sklad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sost_Naklad_Prodag> Sost_Naklad_Prodag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sost_Nakladna> Sost_Nakladna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sostav_Partii> Sostav_Partii { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sostav_Postupl_Naklad> Sostav_Postupl_Naklad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sostav_Vibitie_Naklad> Sostav_Vibitie_Naklad { get; set; }
    }
}