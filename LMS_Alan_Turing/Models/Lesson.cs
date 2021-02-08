using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            Assignments = new HashSet<Assignment>();
            Comments = new HashSet<Comment>();
            LearningMaterials = new HashSet<LearningMaterial>();
            Submissions = new HashSet<Submission>();
        }

        public int Id { get; set; }
        public string MeetingId { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public int DeclarativeLessonsId { get; set; }
        public int CoursesId { get; set; }
        public int PathsId { get; set; }
        public int? LecturersId { get; set; }
        public int? GroupsId { get; set; }
        public int? StreamsId { get; set; }

        public virtual Course Courses { get; set; }
        public virtual DeclarativeLesson DeclarativeLessons { get; set; }
        public virtual Group Groups { get; set; }
        public virtual Lecturer Lecturers { get; set; }
        public virtual Path Paths { get; set; }
        public virtual Stream Streams { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<LearningMaterial> LearningMaterials { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
