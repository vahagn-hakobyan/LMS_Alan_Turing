using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public string Content { get; set; }
        public int? AssignmentsId { get; set; }
        public int? UsersId { get; set; }
        public int? SubmissionsId { get; set; }
        public int? PathsId { get; set; }
        public int? CoursesId { get; set; }
        public int? DeclarativeLessonsId { get; set; }
        public int? LessonsId { get; set; }

        public virtual Assignment Assignments { get; set; }
        public virtual Course Courses { get; set; }
        public virtual DeclarativeLesson DeclarativeLessons { get; set; }
        public virtual Lesson Lessons { get; set; }
        public virtual Path Paths { get; set; }
        public virtual Submission Submissions { get; set; }
        public virtual User Users { get; set; }
    }
}
