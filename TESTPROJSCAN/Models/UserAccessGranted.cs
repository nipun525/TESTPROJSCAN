//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TESTPROJSCAN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccessGranted
    {
        public int Id { get; set; }
        public Nullable<int> UserRoleId { get; set; }
        public Nullable<int> MainMenuId { get; set; }
        public Nullable<int> InterMenuId { get; set; }
        public string Status { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
