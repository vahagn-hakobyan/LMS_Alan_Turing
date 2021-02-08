using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Stream
    {
        public Stream()
        {
            Groups = new HashSet<Group>();
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public int PathsId { get; set; }
        public int CoursesId { get; set; }
        public int StrearmsIdentity { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Course Courses { get; set; }
        public virtual Path Paths { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
