//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetingAgent
{
    using System;
    using System.Collections.Generic;
    
    public partial class rst_restrain
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public bool all_day { get; set; }
        public Nullable<System.TimeSpan> starting_hour { get; set; }
        public Nullable<System.TimeSpan> ending_hour { get; set; }
        public string user_id { get; set; }
        public string reason { get; set; }
    }
}
