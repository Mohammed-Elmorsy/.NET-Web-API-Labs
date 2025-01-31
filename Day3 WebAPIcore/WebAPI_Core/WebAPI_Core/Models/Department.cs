﻿using System;
using System.Collections.Generic;

namespace WebAPI_Core.Models
{
    public partial class Department
    {
        public Department()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
