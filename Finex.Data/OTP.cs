//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finex.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OTP
    {
        public int Id { get; set; }
        public Nullable<int> CustId { get; set; }
        public string OTP1 { get; set; }
        public Nullable<System.DateTime> ExpireTime { get; set; }
        public Nullable<bool> IsUsed { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}