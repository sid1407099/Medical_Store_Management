//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medical_Store_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesMst
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public string IName { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> TPrice { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
    }
}
