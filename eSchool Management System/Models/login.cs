//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace eSchool_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class login
    {
        public string loginId { get; set; }
        [Display(Name = "Username")]
        [Required]
        public string username { get; set; }

        [Display(Name = "Password")]
        [Required]
        public string password { get; set; }
        
    }
}
