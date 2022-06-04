using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MyTemplate.Models.StudentAndStudentAddress
{
    // one to one relationship between Student and StudentAddress

    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentId { get; set; } = Guid.NewGuid();
        public string StudentName { get; set; } = null!;

        public virtual StudentAddress Address { get; set; } = new StudentAddress();
    }
}

