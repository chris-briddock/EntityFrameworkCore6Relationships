using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MyTemplate.Models.StudentAndStudentAddress
{
    public partial class StudentAddress
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentAddressId { get; set; } = Guid.NewGuid();
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Postcode { get; set; } = null!;
        public virtual Student Student { get; set; } = new Student();
    }
}

