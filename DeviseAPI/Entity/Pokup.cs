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
    
    public partial class Pokup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pokup()
        {
            this.Naklad_Prodag = new HashSet<Naklad_Prodag>();
            this.J_Vibit = new HashSet<J_Vibit>();
        }
    
        public int ID_Pokup { get; set; }
        public string Familia { get; set; }
        public string Imia { get; set; }
        public string Otzhestvo { get; set; }
        public string Telefon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Naklad_Prodag> Naklad_Prodag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<J_Vibit> J_Vibit { get; set; }
    }
}
