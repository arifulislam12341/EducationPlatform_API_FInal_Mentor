//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseModule
    {
        public int Id { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> MentorId { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
        public string Date { get; set; }
    
        public virtual Mentor Mentor { get; set; }
    }
}
