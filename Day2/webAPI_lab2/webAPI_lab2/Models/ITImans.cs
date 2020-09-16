namespace webAPI_lab2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ITImans : DbContext
    {
        public ITImans()
            : base("name=ITImans")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.dept_id);

            modelBuilder.Entity<Student>()
                .Property(e => e.fullName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.address)
                .IsUnicode(false);
        }
    }
}
