using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Submission
    {
        public Submission()
        {
            Comments = new HashSet<Comment>();
            Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public string Description { get; set; }
        public int DeclarativeLessonsId { get; set; }
        public int CoursesId { get; set; }
        public int PathsId { get; set; }
        public int LessonsId { get; set; }
        public int AssignmentsId { get; set; }
        public int? StudentsId { get; set; }
        public int Mark { get; set; }
        public int SubmissionsIdentity { get; set; }

        public virtual Assignment Assignments { get; set; }
        public virtual Course Courses { get; set; }
        public virtual DeclarativeLesson DeclarativeLessons { get; set; }
        public virtual Lesson Lessons { get; set; }
        public virtual Path Paths { get; set; }
        public virtual Student Students { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
