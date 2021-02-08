using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Assignment
    {
        public Assignment()
        {
            Comments = new HashSet<Comment>();
            Notifications = new HashSet<Notification>();
            Submissions = new HashSet<Submission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Datetime { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int DeclarativeLessonsId { get; set; }
        public int CoursesId { get; set; }
        public int PathsId { get; set; }
        public int LessonsId { get; set; }
        public int AssignmentsIdentity { get; set; }

        public virtual Course Courses { get; set; }
        public virtual DeclarativeLesson DeclarativeLessons { get; set; }
        public virtual Lesson Lessons { get; set; }
        public virtual Path Paths { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
