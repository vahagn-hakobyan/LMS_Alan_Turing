using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Lecturer
    {
        public Lecturer()
        {
            Groups = new HashSet<Group>();
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public decimal HourlyRate { get; set; }
        public string Speciality { get; set; }

        public virtual User IdNavigation { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
