//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostSharp.Samples.Transactions.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operation
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public System.DateTime Time { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
