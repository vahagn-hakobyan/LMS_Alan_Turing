using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Course
    {
        public Course()
        {
            Assignments = new HashSet<Assignment>();
            Comments = new HashSet<Comment>();
            DeclarativeLessons = new HashSet<DeclarativeLesson>();
            Groups = new HashSet<Group>();
            LearningMaterials = new HashSet<LearningMaterial>();
            Lessons = new HashSet<Lesson>();
            Streams = new HashSet<Stream>();
            Submissions = new HashSet<Submission>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Subject { get; set; }
        public int PathsId { get; set; }
        public int CoursesIdentity { get; set; }

        public virtual Path Paths { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<DeclarativeLesson> DeclarativeLessons { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<LearningMaterial> LearningMaterials { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Stream> Streams { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
