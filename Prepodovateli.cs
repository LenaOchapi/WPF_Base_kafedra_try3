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
    
    public partial class Prepodovateli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prepodovateli()
        {
            this.vedomosti = new HashSet<vedomosti>();
        }
    
        public long kod_prepodavatelya { get; set; }
        public long kod_kafedri { get; set; }
        public string FIO { get; set; }
        public string Doljnost { get; set; }
        public string Zvanie { get; set; }
        public Nullable<double> Stavka { get; set; }
        public Nullable<int> Staj { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Vozrast { get; set; }
    
        public virtual kafedra kafedra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vedomosti> vedomosti { get; set; }
    }
}
