//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSchool_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class classroom
    {
        public int classroom_id { get; set; }
        public short year { get; set; }
        public int grade_id { get; set; }
        public string section { get; set; }
        public sbyte status { get; set; }
        public string remarks { get; set; }
        public int teacher_id { get; set; }
    
        public virtual grade grade { get; set; }
        public virtual teacher teacher { get; set; }
    }
}
