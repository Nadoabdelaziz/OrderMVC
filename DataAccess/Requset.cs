//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requset
    {
        public int CompanyID { get; set; }
        public string Company_Name { get; set; }
        public Nullable<int> ItemID { get; set; }
        public string Item_Name { get; set; }
        public Nullable<double> Item_Quantity { get; set; }
        public string Pick_Up_Date { get; set; }
        public Nullable<double> Purchase_Price { get; set; }
        public string Shipping_instructions { get; set; }
        public string Recurring_Order { get; set; }
    }
}