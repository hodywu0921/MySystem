//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySystem_admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendor
    {
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> Establishment { get; set; }
        public string LawRepresentative { get; set; }
        public string BusinessLicense { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public Nullable<decimal> Tariff { get; set; }
        public Nullable<decimal> LY_Renvenue { get; set; }
        public Nullable<decimal> Area1_Renvenue { get; set; }
        public Nullable<decimal> Area2_Renvenue { get; set; }
        public Nullable<decimal> Area3_Renvenue { get; set; }
        public Nullable<decimal> SalesAmounts { get; set; }
        public string ManagementType { get; set; }
        public string ManagementCategory { get; set; }
        public string Subsidiary { get; set; }
        public Nullable<bool> IsFTA { get; set; }
        public string System { get; set; }
        public Nullable<int> EmpHeadcount { get; set; }
        public Nullable<bool> Flag { get; set; }
    }
}
