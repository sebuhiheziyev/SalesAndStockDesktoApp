//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stock_App.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int Id { get; set; }
        public Nullable<decimal> Count { get; set; }
        public Nullable<System.DateTime> StockTime { get; set; }
        public Nullable<int> ProductId { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
