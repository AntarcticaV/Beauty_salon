//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beauty_salon.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServicePhoto
    {
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public string PhotoPath { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
