//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FurnitureStoreApp.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public int Product { get; set; }
        public int Client { get; set; }
        public int Employee { get; set; }
        public string Description { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Products Products { get; set; }
    }
}
