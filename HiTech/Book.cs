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
    
    public partial class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<int> YearPublished { get; set; }
        public Nullable<int> QOH { get; set; }
        public string Category { get; set; }
        public Nullable<int> Auhtor_Id { get; set; }
        public Nullable<int> Publisher_Id { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
