//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogsDataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [KnownTypeAttribute(typeof(Blog_Detail))]
    public partial class Blog_Detail
    {
        public int BID { get; set; }
        public string Title { get; set; }
        public string Blog_Content { get; set; }
        public System.DateTime DateOfUpdation { get; set; }
        public Nullable<int> UID { get; set; }

       [JsonIgnore]
        public virtual User_Details User_Details { get; set; }
    }
}
