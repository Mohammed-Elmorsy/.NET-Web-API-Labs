namespace webAPI_lab2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int id { get; set; }

        [StringLength(50)]
        public string fullName { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        public int? dept_id { get; set; }

        public virtual Department Department { get; set; }
    }
}
