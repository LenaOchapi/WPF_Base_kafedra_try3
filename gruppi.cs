//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_Base_kafedra_try3
{
    using System;
    using System.Collections.Generic;
    
    public partial class gruppi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gruppi()
        {
            this.Studenti = new HashSet<Studenti>();
            this.vedomosti = new HashSet<vedomosti>();
        }
    
        public long kod_gruppi { get; set; }
        public long kod_kafedri { get; set; }
        public string nom_gruppi { get; set; }
        public Nullable<int> god_postuplenia { get; set; }
        public Nullable<int> kurs { get; set; }
    
        public virtual kafedra kafedra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Studenti> Studenti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vedomosti> vedomosti { get; set; }
    }
}
