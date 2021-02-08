using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Group
    {
        public Group()
        {
            Chats = new HashSet<Chat>();
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? StreamId { get; set; }
        public int? PathsId { get; set; }
        public int? CoursesId { get; set; }
        public int? LecturersId { get; set; }

        public virtual Course Courses { get; set; }
        public virtual Lecturer Lecturers { get; set; }
        public virtual Path Paths { get; set; }
        public virtual Stream Stream { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
