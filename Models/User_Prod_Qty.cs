//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductDashboard.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Prod_Qty
    {
        public int user_prod_qty_id { get; set; }
        public int user_prod_id { get; set; }
        public int quantity { get; set; }
    
        public virtual User_Product User_Product { get; set; }
    }
}
