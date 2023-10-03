namespace QLSinhVienChuyenNghanh.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(10)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        public double AverageScore { get; set; }

        public int? FacultyID { get; set; }

        public int? MajorID { get; set; }

        [StringLength(200)]
        public string Avartar { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Major Major { get; set; }
    }
}
