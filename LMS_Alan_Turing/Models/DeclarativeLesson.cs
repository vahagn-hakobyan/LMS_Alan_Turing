using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class DeclarativeLesson
    {
        public DeclarativeLesson()
        {
            Assignments = new HashSet<Assignment>();
            Comments = new HashSet<Comment>();
            LearningMaterials = new HashSet<LearningMaterial>();
            Lessons = new HashSet<Lesson>();
            Submissions = new HashSet<Submission>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int CoursesId { get; set; }
        public int PathsId { get; set; }
        public int DeclarativeLessonsIdentity { get; set; }

        public virtual Course Courses { get; set; }
        public virtual Path Paths { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<LearningMaterial> LearningMaterials { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
