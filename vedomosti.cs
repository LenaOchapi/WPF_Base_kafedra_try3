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
    
    public partial class vedomosti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vedomosti()
        {
            this.podchin_tablica_vedomosti = new HashSet<podchin_tablica_vedomosti>();
        }
    
        public long kod_vedomosti { get; set; }
        public long kod_gruppi { get; set; }
        public long kod_disciplini { get; set; }
        public long kod_prepodovatelya { get; set; }
        public Nullable<int> God { get; set; }
        public Nullable<int> semestr { get; set; }
    
        public virtual disciplini disciplini { get; set; }
        public virtual disciplini disciplini1 { get; set; }
        public virtual gruppi gruppi { get; set; }
        public virtual Prepodovateli Prepodovateli { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<podchin_tablica_vedomosti> podchin_tablica_vedomosti { get; set; }
    }
}
