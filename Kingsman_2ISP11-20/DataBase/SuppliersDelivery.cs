//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kingsman_2ISP11_20.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuppliersDelivery
    {
        public int Id { get; set; }
        public int IdSupplier { get; set; }
        public int IdMaterial { get; set; }
        public int Quantity { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
