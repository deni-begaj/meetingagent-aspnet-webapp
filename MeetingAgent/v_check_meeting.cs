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
    
    public partial class v_check_meeting
    {
        public int RElId { get; set; }
        public int meeting_id { get; set; }
        public string user_id { get; set; }
        public Nullable<int> status_id { get; set; }
        public string place { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string CreatedUsername { get; set; }
        public string Username { get; set; }
        public string created_user { get; set; }
    }
}