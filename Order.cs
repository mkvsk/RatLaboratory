//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RAT_Lab
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.tbAnalyzers = new HashSet<Analyzer>();
        }
    
        public int PK_OrderId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<bool> OrderState { get; set; }
        public Nullable<int> FK_OrderServices { get; set; }
        public Nullable<int> FK_ClientPassport { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Analyzer> tbAnalyzers { get; set; }
        public virtual Client tbClient { get; set; }
        public virtual Service tbService { get; set; }
    }
}