using System;
using System.Collections.Generic;

namespace WebAPI_Core.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
    }
}
