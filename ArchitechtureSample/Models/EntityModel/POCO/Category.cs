//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FloraLimitedTest.Models.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public short CategoryID { get; set; }
        public string CategoryName { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
