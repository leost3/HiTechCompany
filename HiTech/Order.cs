//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiTech
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int order_ID { get; set; }
        public int Customer_ID { get; set; }
        public string OrderedBy { get; set; }
        public Nullable<double> total { get; set; }
        public int ISBN { get; set; }
        public int Qte { get; set; }
    }
}