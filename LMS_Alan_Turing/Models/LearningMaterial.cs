using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class LearningMaterial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public int? PathsId { get; set; }
        public int? CoursesId { get; set; }
        public int? DeclarativeLessonsId { get; set; }
        public int? LessonsId { get; set; }

        public virtual Course Courses { get; set; }
        public virtual DeclarativeLesson DeclarativeLessons { get; set; }
        public virtual Lesson Lessons { get; set; }
        public virtual Path Paths { get; set; }
    }
}
