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
    
    public partial class Studenti
    {
        public long kod_studenta { get; set; }
        public long kod_gruppi { get; set; }
        public string FIO { get; set; }
        public Nullable<int> god_rojdenia { get; set; }
        public string Adress { get; set; }
    
        public virtual gruppi gruppi { get; set; }
    }
}
