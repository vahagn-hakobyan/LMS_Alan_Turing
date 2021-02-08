using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Student
    {
        public Student()
        {
            Submissions = new HashSet<Submission>();
        }

        public int Id { get; set; }
        public short? Discount { get; set; }
        public byte Rating { get; set; }

        public virtual User IdNavigation { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
